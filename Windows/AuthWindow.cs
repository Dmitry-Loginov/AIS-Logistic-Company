using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class AuthWindow : Form
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = CP.Context.Users.FromSqlRaw($"select User.UserId, User.Login, User.Password, User.Name, User.RoleId, 'RoleType' as RoleType from User where Login = \'{login.Text}\' and Password = \'{password.Text}\'").FirstOrDefault();
            if (user == default)
            {
                MessageBox.Show("Неправильный логин или пароль!");
            }
            else
            {
                Role role_ = CP.Context.Roles.FromSqlRaw("select Role.RoleId, Role.Type from Role where Role.RoleId = {0}", user.RoleId).FirstOrDefault();
                CP.CurrentUser = user;
                CP.CurrentUser.Role = role_;
                int count = CP.context.Items.FromSqlRaw("select * from Item").ToList().Count;
                ItemMaxId item = null;
                if (count != 0)
                {
                    item = CP.context.ItemMaxIds.FromSqlRaw("select ItemId, max(ItemId) as MaxIndex from Item").FirstOrDefault();
                }
                CP.StartItem = count == 0 ? 0 : item.MaxIndex;
                CP.ItemId = CP.StartItem;
                MainWindow mainWindow = new MainWindow();
                CP.MainWindow = mainWindow;
                CP.MainWindow.Show();
                login.Text = "";
                password.Text = "";
                Hide();

            }
        }
    }
}
