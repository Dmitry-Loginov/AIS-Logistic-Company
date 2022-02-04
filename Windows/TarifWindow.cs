using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class TarifWindow : Form
    {
        public TarifWindow()
        {
            InitializeComponent();
        }

        private void TarifWindow_Load(object sender, EventArgs e)
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
            List<Tarif> userListShow = CP.Context.Tarifs.FromSqlRaw("select Tarif.TarifId, Tarif.Name, Tarif.PerKm, " +
                "Tarif.PerKg from Tarif").ToList();

            BindingSource binding = new BindingSource();
            binding.DataSource = userListShow;

            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "За км";
            dataGridView1.Columns[3].HeaderText = "За кг";
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
            NewTarif newTarif = new NewTarif(this);
            newTarif.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show("Удалить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                CP.Context.Database.ExecuteSqlRaw("delete from Tarif where TarifId = {0}", id);
                RefreshWindow();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Tarif tarif = CP.Context.Tarifs.FromSqlRaw($"select Tarif.TarifId, Tarif.Name, Tarif.PerKm, Tarif.PerKg from Tarif where TarifId = {dataGridView1.SelectedRows[0].Cells[0].Value}").First();
            NewTarif newTarif = new NewTarif(true, tarif, this);
            newTarif.Show();
        }

        private void TarifWindow_Activated(object sender, EventArgs e)
        {
            RefreshWindow();
        }
    }
}