using System;
using System.IO;
using System.Windows.Forms;

namespace АИС
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            switch(CP.CurrentUser.RoleId)
            {
                case 1:
                    {
                        новыйToolStripMenuItem.Visible = false;
                        break;
                    }
                case 2:
                    {
                        новыйToolStripMenuItem.Visible = false;
                        break;
                    }
                case 3:
                    {
                        новыйToolStripMenuItem.Visible = true;
                        break;
                    }
            }
            if (CP.CurrentUser.RoleId == 2)
            {
                contract.Enabled = false;
            }
        }

        public CarWindow CarWindow;
        private void button12_Click(object sender, EventArgs e)
        {
            if (CarWindow == null)
                CarWindow = new CarWindow();
            if(CarWindow.IsDisposed)
                CarWindow = new CarWindow();
            CarWindow.Show();
            CarWindow.Activate();
        }

        ClientWindow ClientWindow;
        private void button6_Click(object sender, EventArgs e)
        {
            if(ClientWindow == null)
                ClientWindow = new ClientWindow();
            if (ClientWindow.IsDisposed)
                ClientWindow = new ClientWindow();
            ClientWindow.Show();
            ClientWindow.Activate();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.Show();
        }

        private void пользовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Имя: {CP.CurrentUser.Name}\n" +
                $"Логин: {CP.CurrentUser.Login}\n" +
                $"Роль: {CP.CurrentUser.Role?.Type}");
        }

        private void changeUser_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void копияБДToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.Filter = "Файл базы данных(*.db)|*.db";
            saveFileDialog1.Title = "Создание копии БД";
            string copyPath;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                copyPath = Path.GetFullPath(saveFileDialog1.FileName);
                FileInfo fileInf = new FileInfo(@"C:\Users\Student\OneDrive\learn\ТРПО\AIS\АИС\bin\Debug\DB.db");
                if (!fileInf.Exists)
                {
                    fileInf.CopyTo(copyPath, true);
                }
                else
                {
                    MessageBox.Show("Файл существует");
                }
            }
    }

        public UserWindow UserWindow;
        private void users_Click(object sender, EventArgs e)
        {
            if (UserWindow == null)
                UserWindow = new UserWindow();
            if(UserWindow.IsDisposed)
                UserWindow = new UserWindow();
            UserWindow.Show();
            UserWindow.Activate();

        }

        DriverWindow DriverWindow;
        private void driver_Click(object sender, EventArgs e)
        {
            if (DriverWindow == null)
                DriverWindow = new DriverWindow();
            if (DriverWindow.IsDisposed)
                DriverWindow = new DriverWindow();
            DriverWindow.Show();
            DriverWindow.Activate();
        }

        TarifWindow TarifWindow;
        private void tarif_Click(object sender, EventArgs e)
        {
            if (TarifWindow == null)
                TarifWindow = new TarifWindow();
            if(TarifWindow.IsDisposed)
                TarifWindow = new TarifWindow();
            TarifWindow.Show();
            TarifWindow.Activate();
        }

        private void contract_Click(object sender, EventArgs e)
        {
            ContractWindow contract = new ContractWindow();
            contract.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ProviderWindow ProviderWindow;
        private void provider_Click(object sender, EventArgs e)
        {
            if (ProviderWindow == null)
                ProviderWindow = new ProviderWindow();
            if (ProviderWindow.IsDisposed)
                ProviderWindow = new ProviderWindow();
            ProviderWindow.Show();
            ProviderWindow.Activate();
        }

        TypeCargoWindow TypeCargoWindow;
        private void typeCargo_Click(object sender, EventArgs e)
        {
            if (TypeCargoWindow == null)
                TypeCargoWindow = new TypeCargoWindow();
            if (TypeCargoWindow.IsDisposed)
                TypeCargoWindow = new TypeCargoWindow();
            TypeCargoWindow.Show();
            TypeCargoWindow.Activate();
        }

        StatisticWindow StatisticWindow;
        private void statistic_Click(object sender, EventArgs e)
        {
            if (StatisticWindow == null)
                StatisticWindow = new StatisticWindow();
            if (StatisticWindow.IsDisposed)
                StatisticWindow = new StatisticWindow();
            StatisticWindow.Show();
            StatisticWindow.Activate();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
