using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
            List<Role> roles = CP.Context.Roles.FromSqlRaw("SELECT * FROM Role").ToList();
            roleBox.DataSource = roles;
            roleBox.DisplayMember = "Type";
            roleBox.ValueMember = "RoleId";
        }

        public NewUser(UserWindow form)
        {
            InitializeComponent();
            List<Role> roles = CP.Context.Roles.FromSqlRaw("SELECT * FROM Role").ToList();
            roleBox.DataSource = roles;
            roleBox.DisplayMember = "Type";
            roleBox.ValueMember = "RoleId";
            UserWindow = form;
        }

        public NewUser(bool isEdit, User user, UserWindow form)
        {
            InitializeComponent();
            List<Role> roles = CP.Context.Roles.FromSqlRaw("SELECT * FROM Role").ToList();
            roleBox.DataSource = roles;
            roleBox.DisplayMember = "Type";
            roleBox.ValueMember = "RoleId";
            UserWindow = form;
            this.isEdit = isEdit;
            changingUser = user;
            button1.Text = "Изменить данные";
            Text = "Изменение пользователя";
        }

        bool isEdit;
        UserWindow UserWindow;
        User changingUser;

        void Clear()
        {
            login.Clear();
            password.Clear();
            name.Clear();
            roleBox.SelectedIndex = 0;
        }
        DialogResult Confirm()
        {
           return MessageBox.Show($"Логин: {login.Text}\n" +
                $"Пароль: {password.Text}\n" +
                $"Имя: {name.Text}\n" +
                $"Роль: {roleBox.Text}", $"{button1.Text} пользвателя?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (login.Text == "" || password.Text == "" || name.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User userFormDataBase = CP.Context.Users.FromSqlRaw($"SELECT User.UserId, User.Name, User.Login, User.Password, User.RoleId, 'RoleType' as RoleType FROM User WHERE Login = '{login.Text}'").FirstOrDefault();
               
                if (userFormDataBase != default && changingUser?.Login != login.Text)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                    return;
                }
                   
                if(!isEdit)
                switch (Confirm())
                {
                    case DialogResult.Yes:
                        CP.Context.Database.ExecuteSqlRaw("insert into User (Login, Name, Password, RoleId) values ({0}, {1}, {2}, {3})", login.Text, name.Text, password.Text, roleBox.SelectedValue);
                        CP.Context.Dispose();
                        CP.GetContext();
                        break;
                }
                else
                    switch (Confirm())
                    {
                        case DialogResult.Yes:
                            CP.Context.Database.ExecuteSqlRaw("update User set Login = {0}, Password = {1}, Name = {2}, RoleId = {3} where UserId = {4}", login.Text, password.Text, name.Text, (int)roleBox.SelectedValue, changingUser.UserId);
                            CP.Context.Dispose();
                            CP.GetContext();
                            if (changingUser.UserId == CP.CurrentUser.UserId)
                            {
                                MessageBox.Show("Изменения вступят в силу после перезагрузки программы.");
                            }
                            Close();
                            break;
                    }
            }
            UserWindow.RefreshWindow();
            CP.MainWindow.Activate();
            UserWindow.Activate();
            this?.Activate();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                login.Text = changingUser.Login;
                password.Text = changingUser.Password;
                name.Text = changingUser.Name;
                roleBox.SelectedItem = changingUser.Role;
            }
        }
    }
}