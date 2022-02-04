using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class ProviderWindow : Form
    {
        public ProviderWindow()
        {
            InitializeComponent();
        }

        private void ProviderWindow_Load(object sender, EventArgs e)
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
            List<Provider> providerListShow = CP.Context.Providers.FromSqlRaw("select Provider.ProviderId, Provider.Name, Provider.Address, " +
                "Provider.Telephone, Provider.PassportId from Provider").ToList();

            BindingSource binding = new BindingSource();
            binding.DataSource = providerListShow;

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
        }

        private void add_Click(object sender, EventArgs e)
        {
            NewProvider newProvider = new NewProvider(this);
            newProvider.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            
                DialogResult dialogResult = MessageBox.Show("Удалить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (dialogResult == DialogResult.Yes)
            {      CP.Context.Database.ExecuteSqlInterpolated($"delete from Provider where ProviderId = {dataGridView1.SelectedRows[0].Cells[0].Value}");
                RefreshWindow();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Provider tarif = CP.Context.Providers.FromSqlRaw($"select Provider.ProviderId, Provider.Name, Provider.Address, Provider.Telephone, Provider.PassportId from Provider where ProviderId = {dataGridView1.SelectedRows[0].Cells[0].Value}").First();
            NewProvider newProvider = new NewProvider(true, tarif, this);
            newProvider.Show();
        }
    }
}