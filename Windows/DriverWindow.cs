using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class DriverWindow : Form
    {
        public DriverWindow()
        {
            InitializeComponent();
        }

        private void DriverWindow_Load(object sender, EventArgs e)
        {
            RefreshWindow();
            if (CP.CurrentUser.RoleId == 1)
            {
                delete.Visible = false;
                add.Visible = false;
            }
        }
        public void RefreshWindow()
        {
            Refresh();
            List<Driver> driverListShow = CP.Context.Drivers.FromSqlRaw("select Driver.DriverId, Driver.Name, Driver.Telephone, Driver.PassportId " +
                "from Driver").ToList();

            BindingSource binding = new BindingSource();
            binding.DataSource = driverListShow;

            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Телефон";
            dataGridView1.Columns[3].HeaderText = "Номер паспорта";
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
            NewDriver newDriver = new NewDriver(this);
            newDriver.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show("Удалить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                try
                {
                    CP.Context.Database.ExecuteSqlInterpolated($"delete from Driver where DriverId = {id}");
                    RefreshWindow();
                }
                catch
                {
                    MessageBox.Show("Имеются связанные записи. Сначала удалите записи из таблицы 'Автомобили' или назначте другого водителя");
                }
        }

        private void edit_Click(object sender, EventArgs e)
        {

            Driver driver = CP.Context.Drivers.FromSqlRaw($"select Driver.DriverId, Driver.Name, Driver.Telephone, Driver.PassportId from Driver where DriverId = {dataGridView1.SelectedRows[0].Cells[0].Value}").First();
            NewDriver newDriver = new NewDriver(true, driver, this);
            newDriver.Show();

        }

        private void DriverWindow_Activated(object sender, EventArgs e)
        {
            RefreshWindow();
        }
    }
}