using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class UserWindow : Form
    {
        public UserWindow()
        {
            InitializeComponent();
        }
        
        private void UserWindow_Load(object sender, EventArgs e)
        {
            if (CP.CurrentUser.RoleId != 3)
            {
                delete.Visible = false;
                edit.Visible = false;
                add.Visible = false;
            }
            RefreshWindow();
        }
        public void RefreshWindow()
        {
            Refresh();
            List<User> userListShow = CP.Context.Users.FromSqlRaw("select User.UserId, User.Login, User.Password, " +
                "User.Name, User.RoleId, Role.Type as RoleType from User left join Role on User.RoleId = Role.RoleId").ToList();

            BindingSource binding = new BindingSource();
            binding.DataSource = userListShow;

            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;
            dataGridView1.Columns[0].Visible = false;
            if (CP.CurrentUser.RoleId != 3)
                dataGridView1.Columns[2].Visible = false;  //пароль
            dataGridView1.Columns[1].HeaderText = "Логин";
            dataGridView1.Columns[2].HeaderText = "Пароль";
            dataGridView1.Columns[3].HeaderText = "Имя";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].HeaderText = "Роль";
            dataGridView1.Columns[6].Visible = false;
            if (dataGridView1.RowCount == 0)
            {
                delete.Enabled = false;
                edit.Enabled = false;
            }
            else
            {
                delete.Enabled = true;
                edit.Enabled = true;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((int)dataGridView1.Rows[i].Cells[0].Value == CP.CurrentUser.UserId)
                {
                    dataGridView1.Rows[i].Cells[5].Value = CP.CurrentUser.Role.Type;
                }
            }
            if (dataGridView1.Rows.Count == 1)
                delete.Enabled = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser(this);
            newUser.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            User user;
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //List<User> users = CP.Context.Users.FromSqlRaw("select User.UserId, 'RoleType' as RoleType, User.Login, User.Password, " +
            //    "User.Name, User.RoleId from User where RoleId = 3").ToList();
            user = CP.Context.Users.FromSqlRaw("select User.UserId, 'RoleType' as RoleType, User.Login, User.Password, " +
                "User.Name, User.RoleId from User where UserId = {0}", dataGridView1.SelectedRows[0].Cells[0].Value).First();
            if (user.UserId != CP.CurrentUser.UserId)
            {
                DialogResult dialogResult = MessageBox.Show("Удалить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                    CP.Context.Database.ExecuteSqlInterpolated($"delete from User where UserId = {id}");
                RefreshWindow();
            }
            else
            {
                MessageBox.Show("Нельзя удалять текущего пользователя!");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            User user = CP.Context.Users.FromSqlRaw($"select User.UserId, User.Login, User.Password, User.Name, User.RoleId, 'RoleType' as RoleType from User where UserId = {dataGridView1.SelectedRows[0].Cells[0].Value}").First();
            NewUser newUser = new NewUser(true, user, this);
            newUser.Show();
        
        }

        private void UserWindow_Activated(object sender, EventArgs e)
        {
            RefreshWindow();
        }
    }
}