using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class NewClient : Form
    {
        public NewClient(ClientWindow clientWindow)
        {
            InitializeComponent();
            ClientWindow = clientWindow;
        }

        public NewClient(bool isEdit, Client changingClient, ClientWindow clientWindow)
        {
            InitializeComponent();
            IsEdit = isEdit;
            ChangingClient = changingClient;
            ClientWindow = clientWindow;
            button1.Text = "Изменить данные";
            Text = "Изменение данных заказчика";
        }

        public bool IsEdit { get; }
        public Client ChangingClient { get; }
        public ClientWindow ClientWindow { get; }
        DialogResult Confirm()
        {
            return MessageBox.Show($"Имя: {name.Text}\n" +
                 $"Адрес: {addres.Text}\n" +
                 $"Телефон: {telephone.Text}\n" +
                 $"Номер паспорта: {passportId.Text}", $"{button1.Text} заказчика?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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
                Client clientFormDataBase = CP.Context.Clients.FromSqlRaw($"SELECT Client.ClientId, Client.Name, Client.Address, Client.Telephone, Client.PassportId from Client where PassportId = \'{passportId.Text}\'").FirstOrDefault();

                if (clientFormDataBase != default && ChangingClient?.PassportId != passportId.Text)
                {
                    MessageBox.Show("Заказчик с такими данными уже существует!");
                    return;
                }
                if (!IsEdit)
                    switch (Confirm())
                    {
                        case DialogResult.Yes:
                            CP.Context.Database.ExecuteSqlRaw("insert into Client (Name, Address, Telephone, PassportId) values ({0}, {1}, {2}, {3})", name.Text, addres.Text, telephone.Text, passportId.Text);
                            CP.Context.Dispose();
                            CP.GetContext();
                            break;
                    }
                else
                    switch (Confirm())
                    {
                        case DialogResult.Yes:
                            CP.Context.Database.ExecuteSqlRaw("update Client set Name = {0}, Address = {1}, Telephone = {2}, PassportId = {3} where ClientId = {4}", name.Text, addres.Text, telephone.Text, passportId.Text, ChangingClient.ClientId);
                            CP.Context.Dispose();
                            CP.GetContext();
                            Close();
                            break;
                    }
            }
            ClientWindow.RefreshWindow();
            CP.MainWindow.Activate();
            ClientWindow.Activate();
            this?.Activate();
        }

        private void NewClient_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                name.Text = ChangingClient.Name;
                addres.Text = ChangingClient.Address;
                telephone.Text = ChangingClient.Telephone;
                passportId.Text = ChangingClient.PassportId;
            }
        }
    }
}
