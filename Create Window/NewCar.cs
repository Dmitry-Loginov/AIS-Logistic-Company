using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class NewCar : Form
    {
        public NewCar()
        {
            InitializeComponent();
        }
        public NewCar(bool isEdit, Car car, CarWindow form)
        {
            InitializeComponent();

            carWindowForm = form;

            List<Driver> drivers = CP.Context.Drivers.FromSqlRaw("select * from Driver").ToList();

            driverBox.DataSource = drivers;

            driverBox.DisplayMember = "Name";
            driverBox.ValueMember = "DriverId";

            button1.Text = "Изменить";

            this.isEdit = isEdit;
            changingCar = car;
            Text = "Изменение данных автомобиля";
        }
        bool isEdit;
        Car changingCar;
        CarWindow carWindowForm;


        public NewCar(CarWindow form)
        {
            InitializeComponent();
            carWindowForm = form;
            Drivers = CP.Context.Drivers.FromSqlRaw("select * from Driver").ToList();
            driverBox.DataSource = Drivers;
            driverBox.DisplayMember = "Name";
            driverBox.ValueMember = "DriverId";
        }

        public NewCar(bool isEdit, Car car, ContractWindow contractWindow)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            changingCar = car;
            ContractWindow = contractWindow;
            Drivers = CP.Context.Drivers.FromSqlRaw("select * from Driver").ToList();
            driverBox.DataSource = Drivers;
            driverBox.DisplayMember = "Name";
            driverBox.ValueMember = "DriverId";
            button1.Text = "Изменить";
        }

        public List<Driver> Drivers { get; set; }
        public ContractWindow ContractWindow { get; }

        DialogResult Confirm()
        {
            return MessageBox.Show($"Номер: {number.Text}\n" +
                 $"Модель: {model.Text}\n" +
                 $"Водитель: {driverBox.Text}\n" +
                 $"Расход: {сonsumption.Text}", $"{button1.Text} автомобиль?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }  
        private void button1_Click(object sender, EventArgs e)
        {             
            if (number.Text == "" || model.Text == "")
            {                                     
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                 Car carFormDataBase = CP.Context.Cars.FromSqlRaw($"SELECT Car.CarId, Car.Number, Car.DriverId, 'DriverName' as DriverName, Car.Model, Car.Consumption FROM Car WHERE Number = \'{number.Text}\'").FirstOrDefault();

                if (carFormDataBase != default && changingCar?.Number != number.Text)
                {
                    MessageBox.Show("Автомобиль с таким номером уже существует!");
                    return;
                }
                try
                {
                    Convert.ToDouble(сonsumption.Text);
                }
                catch 
                {
                    MessageBox.Show("Значение поля Расход должно быть числовым, в качестве разделителя используйте точку!");
                }
                if(!isEdit)
                switch (Confirm())                
                {
                    case DialogResult.Yes:
                        CP.Context.Database.ExecuteSqlInterpolated($"insert into Car (Number, Model, DriverId, Consumption) values ({number.Text}, {model.Text}, {(int)driverBox.SelectedValue}, {Convert.ToDouble(сonsumption.Text)})");
                        CP.Context.Dispose();
                        CP.GetContext();
                        break;                    
                
                }
                else
                    switch (Confirm())
                    {
                        case DialogResult.Yes:
                            CP.Context.Database.ExecuteSqlRaw("update Car set Number = {0}, Model = {1}, Consumption = {2}, DriverId = {3} where CarId = {4}", number.Text, model.Text, Convert.ToDouble(сonsumption.Text), (int)driverBox.SelectedValue, changingCar.CarId);
                            CP.Context.Dispose();
                            CP.GetContext();
                            Close();
                            break;
                       
                    }
            }
            carWindowForm?.RefreshWindow();
            CP.MainWindow.Activate();
            carWindowForm?.Activate();
            ContractWindow?.Invalidate();
            ContractWindow?.Activate();
            this?.Activate();
        }

        private void NewCar_Load(object sender, EventArgs e)
        {
            if (changingCar != null)
            {
                number.Text = changingCar.Number;
                model.Text = changingCar.Model;
                сonsumption.Text = changingCar.Consumption.ToString();


                driverBox.SelectedItem = changingCar.Driver;
            }
        }
    }
}