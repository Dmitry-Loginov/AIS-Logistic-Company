using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class NewTarif : Form
    {
        public NewTarif()
        {
            InitializeComponent();
        }

        public NewTarif(TarifWindow tarifWindow)
        {
            InitializeComponent();
            TarifWindow = tarifWindow;
        }

        public NewTarif(bool IsEdit, Tarif changingTarif, TarifWindow tarifWindow)
        {
            InitializeComponent();
            this.IsEdit = IsEdit;
            ChangingTarif = changingTarif;
            TarifWindow = tarifWindow;
            Text = "Изменить тариф";
            button1.Text = "Изменить данные";
        }

        public TarifWindow TarifWindow { get; set; }
        public bool IsEdit { get; set; }
        public Tarif ChangingTarif { get; set; }
        DialogResult Confirm()
        {
            return MessageBox.Show($"Название: {name.Text}\n" +
                 $"За кг: {perKg.Text}\n" +
                 $"За км: {perKm.Text}\n",
                  $"{button1.Text} тариф?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }



        private void NewTarif_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                name.Text = ChangingTarif.Name;
                perKg.Text = ChangingTarif.PerKg.ToString();
                perKm.Text = ChangingTarif.PerKm.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || perKg.Text == "" || perKm.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tarif tariftFormDataBase = CP.Context.Tarifs.FromSqlRaw($"SELECT Tarif.TarifId, Tarif.Name, Tarif.PerKg, Tarif.PerKm from Tarif where Name = \'{name.Text}\'").FirstOrDefault();

                if (tariftFormDataBase != default && ChangingTarif?.Name != name.Text)
                {
                    MessageBox.Show("Тариф с такими данными уже существует!");
                    return;
                }
                if (!IsEdit)
                    switch (Confirm())
                    {
                        case DialogResult.Yes:
                            try
                            {
                                CP.Context.Database.ExecuteSqlRaw("insert into Tarif (Name, PerKg, PerKm) values ({0}, {1}, {2})", name.Text, Convert.ToInt32(perKg.Text), Convert.ToInt32(perKm.Text));
                                CP.Context.Dispose();
                                CP.GetContext();
                            }
                            catch
                            {
                                MessageBox.Show("Проверьте правильность ввода данных!");
                            }
                            break;
                    }
                else
                    switch (Confirm())
                    {
                        case DialogResult.Yes:
                            try
                            {
                                CP.Context.Database.ExecuteSqlRaw("update Tarif set Name = {0}, PerKg = {1}, PerKm = {2} where TarifId = {3}", name.Text, Convert.ToInt32(perKg.Text), Convert.ToInt32(perKm.Text), ChangingTarif.TarifId);
                                CP.Context.Dispose();
                                CP.GetContext();
                                Close();
                            }
                            catch
                            {
                                MessageBox.Show("Проверьте правильность ввода данных!");
                            }
                            break;
                    }
            }
            TarifWindow.RefreshWindow();
            CP.MainWindow.Activate();
            TarifWindow.Activate();
            this?.Activate();
        }
    }
}
