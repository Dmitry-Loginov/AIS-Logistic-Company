using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class NewDriver : Form
    {
        public NewDriver()
        {
            InitializeComponent();
        }

        public NewDriver(DriverWindow driverWindow)
        {
            InitializeComponent();
            DriverWindow = driverWindow;
        }

        public NewDriver(bool isEdit, Driver changingDriver, DriverWindow driverWindow)
        {
            InitializeComponent();
            IsEdit = isEdit;
            ChangingDriver = changingDriver;
            DriverWindow = driverWindow;
            Text = "Изменение данных водителя";
            button1.Text = "Изменить данные";

        }

        public DriverWindow DriverWindow { get; set; }
        public bool IsEdit { get; set; }
        public Driver ChangingDriver { get; set; }
        DialogResult Confirm()
        {
            return MessageBox.Show($"Имя: {name.Text}\n" +
                 $"Телефон: {telephone.Text}\n" +
                 $"Номер паспорта: {passportId.Text}", $"{button1.Text} водителя?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        public void Clear()
        {
            name.Clear();
            telephone.Clear();
            passportId.Clear();
        }

        private void NewDriver_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                name.Text = ChangingDriver.Name;
                telephone.Text = ChangingDriver.Telephone;
                passportId.Text = ChangingDriver.PassportId;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || telephone.Text == "" || passportId.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Driver driverFormDataBase = CP.Context.Drivers.FromSqlRaw($"SELECT Driver.DriverId, Driver.Name, Driver.Telephone, Driver.PassportId from Driver where PassportId = \'{passportId.Text}\'").FirstOrDefault();

                if (driverFormDataBase != default && ChangingDriver?.PassportId != passportId.Text)
                {
                    MessageBox.Show("Водитель с такими данными уже существует!");
                    return;
                }
                if (!IsEdit)
                    switch (Confirm())
                    {
                        case DialogResult.Yes:
                            CP.Context.Database.ExecuteSqlRaw("insert into Driver (Name, Telephone, PassportId) values ({0}, {1}, {2})", name.Text, telephone.Text, passportId.Text);
                            CP.Context.Dispose();
                            CP.GetContext();
                            break;
                  
                    }
                else
                    switch (Confirm())
                    {
                        case DialogResult.Yes:
                            CP.Context.Database.ExecuteSqlRaw("update Driver set Name = {0}, Telephone = {1}, PassportId = {2} where DriverId = {3}", name.Text, telephone.Text, passportId.Text, ChangingDriver.DriverId);
                            CP.Context.Dispose();
                            CP.GetContext();
                            Close();
                            break;
                    }
            }
            DriverWindow.RefreshWindow();
            CP.MainWindow.Activate();
            DriverWindow.Activate();
            this?.Activate();
        }
    }
}
