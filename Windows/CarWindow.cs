using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace АИС
{
    public partial class CarWindow : Form
    {
        public CarWindow()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
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
            List<Car> carListShow = CP.Context.Cars.FromSqlRaw("select Car.CarId, Car.Number, Car.Model, Car.Consumption, Driver.Name as DriverName, Car.DriverId " +
                "from Car left join Driver on Car.DriverId = Driver.DriverId").ToList();

            BindingSource binding = new BindingSource();
            binding.DataSource = carListShow;

            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].HeaderText = "Водитель";
            dataGridView1.Columns[3].HeaderText = "Расход";

            dataGridView1.Columns[1].HeaderText = "Номер";
            dataGridView1.Columns[2].HeaderText = "Модель";
            dataGridView1.Columns[4].Visible = false;
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
        }

        private void add_Click(object sender, EventArgs e)
        {
            NewCar newCar = new NewCar(this);
            newCar.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show("Удалить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
                if (dialogResult == DialogResult.Yes)
            {     CP.Context.Database.ExecuteSqlInterpolated($"delete from Car where CarId = {id}");
                RefreshWindow();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {

            Car car = CP.Context.Cars.FromSqlRaw($"select Car.CarId, Car.Number, Car.Model, Car.Consumption,  'DriverName' as DriverName, Car.DriverId from Car where CarId = {dataGridView1.SelectedRows[0].Cells[0].Value}").First();
            NewCar newCar = new NewCar(true, car, this);
            newCar.Show();
        }

        private void CarWindow_Activated(object sender, EventArgs e)
        {
            RefreshWindow();
        }
    }
}