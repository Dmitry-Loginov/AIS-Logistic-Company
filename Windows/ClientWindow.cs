using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class ClientWindow : Form
    {
        public ClientWindow()
        {
            InitializeComponent();
        }

        private void ClientWindow_Load(object sender, EventArgs e)
        {

            RefreshWindow();
            if (CP.CurrentUser.RoleId == 1)
            {
                add.Visible = false;
                delete.Visible = false;
            }
        }
        public void RefreshWindow()
        {
            Refresh();
            List<Client> userListShow = CP.Context.Clients.FromSqlRaw("select Client.ClientId, Client.Name, Client.Address, " +
                "Client.Telephone, Client.PassportId from Client").ToList();

            BindingSource binding = new BindingSource();
            binding.DataSource = userListShow;

            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;
            dataGridView1.Columns[0].Visible = false;  
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Адрес";
            dataGridView1.Columns[3].HeaderText = "Телефон";
            dataGridView1.Columns[4].HeaderText = "Номер паспорта";
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
        }

        private void add_Click(object sender, EventArgs e)
        {
            NewClient newClient = new NewClient(this);
            newClient.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show("Удалить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
                if (dialogResult == DialogResult.Yes)
            {   CP.Context.Database.ExecuteSqlInterpolated($"delete from Client where ClientId = {id}");
                RefreshWindow();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Client user = CP.Context.Clients.FromSqlRaw($"select Client.ClientId, Client.Name, Client.Address, Client.Telephone, Client.PassportId from Client where ClientId = {dataGridView1.SelectedRows[0].Cells[0].Value}").First();
            NewClient newClient = new NewClient(true, user, this);
            newClient.Show();
        }

        private void ClientWindow_Activated(object sender, EventArgs e)
        {
            RefreshWindow();
        }
    }
}