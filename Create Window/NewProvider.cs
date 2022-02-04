using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class NewProvider : Form
    {
        public NewProvider(ProviderWindow providerWindow)
        {
            InitializeComponent();
            ProviderWindow = providerWindow;
        }

        public NewProvider(bool isEdit, Provider changingProvider, ProviderWindow providerWindow)
        {
            InitializeComponent();
            IsEdit = isEdit;
            ChangingProvider = changingProvider;
            ProviderWindow = providerWindow;
            button1.Text = "Изменить данные";
            Text = "Изменение данных поставщика";
        }

        public bool IsEdit { get; }
        public Provider ChangingProvider { get; }
        public ProviderWindow ProviderWindow { get; }
        DialogResult Confirm()
        {
            return MessageBox.Show($"Имя: {name.Text}\n" +
                 $"Адрес: {addres.Text}\n" +
                 $"Телефон: {telephone.Text}\n" +
                 $"Номер паспорта : {passportId.Text}", $"{button1.Text} поставщика?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        public void Clear()
        {
            name.Clear();
            addres.Clear();
            telephone.Clear();
            passportId.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || addres.Text == "" || telephone.Text == "" || passportId.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var query = $"SELECT Provider.ProviderId, Provider.Name, Provider.Address, Provider.Telephone, Provider.PassportId from Provider where PassportId = \'{passportId.Text}\'";
                Provider providerFormDataBase = CP.Context.Providers.FromSqlRaw(query).FirstOrDefault();

                if (providerFormDataBase != default && ChangingProvider?.PassportId != passportId.Text)
                {
                    MessageBox.Show("Поставщик с такими данными уже существует!");
                    return;
                }
                if (!IsEdit)
                    switch (Confirm())
                    {
                        case DialogResult.Yes:
                            CP.Context.Database.ExecuteSqlRaw("insert into Provider (Name, Address, Telephone, PassportId) values ({0}, {1}, {2}, {3})", name.Text, addres.Text, telephone.Text, passportId.Text);
                            CP.Context.Dispose();
                            CP.GetContext();
                            break;
                    }
                else
                    switch (Confirm())
                    {
                        case DialogResult.Yes:
                            CP.Context.Database.ExecuteSqlRaw("update Provider set Name = {0}, Address = {1}, Telephone = {2}, PassportId = {3} where ProviderId = {4}", name.Text, addres.Text, telephone.Text, passportId.Text, ChangingProvider.ProviderId);
                            CP.Context.Dispose();
                            CP.GetContext();
                            break;
                    }
            }
            ProviderWindow.RefreshWindow();
            CP.MainWindow.Activate();
            ProviderWindow.Activate();
            this?.Activate();
        }

        private void NewProvider_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                name.Text = ChangingProvider.Name;
                addres.Text = ChangingProvider.Address;
                telephone.Text = ChangingProvider.Telephone;
                passportId.Text = ChangingProvider.PassportId;
            }
        }
    }
}
