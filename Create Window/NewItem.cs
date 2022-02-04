using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    
    public partial class NewItem : Form
    {
        public NewItem()
        {
            InitializeComponent();

        }

        public NewItem(ContractWindow form)
        {
            InitializeComponent();
            ContractWindow = form;
            TypeCargos = CP.Context.TypeCargos.FromSqlRaw("select * from TypeCargo")?.ToList();
            typeBox.DataSource = TypeCargos;
            typeBox.DisplayMember = "Name";
            typeBox.ValueMember = "TypeCargoId";
            typeBox.SelectedIndex = 0;
            Providers = CP.Context.Providers.FromSqlRaw("select * from Provider")?.ToList();
            providerBox.DataSource = Providers;
            providerBox.DisplayMember = "Name";
            providerBox.ValueMember = "ProviderId";

        }
        List<TypeCargo> TypeCargos { get; set; }
        List<Provider> Providers { get; set; }
        

        public ContractWindow ContractWindow { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            Item item1 = CP.Items.Where(item => item.Name == name.Text).FirstOrDefault();
            if(item1 != default)
            {
                MessageBox.Show("Груз с таким названием уже существует!");
                return;
            }

            if (name.Text == "" || count.Text == "" || weight.Text == "")
            {
                MessageBox.Show("Проверьте правильность введенной информации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (!(Convert.ToDouble(weight.Text) > 0 && Convert.ToInt32(count.Text) > 0))
                        throw new Exception();
                    Item item = new Item();
                    item.Name = name.Text;
                    item.Count = Convert.ToInt32(count.Text);
                    item.Weight = Convert.ToDouble(weight.Text);

                    item.TypeCargoId = (int)typeBox.SelectedValue;
                    item.TypeCargo = typeBox.Text;

                    item.ProviderId = (int)providerBox.SelectedValue;
                    item.ProviderName = providerBox.Text;

                    item.ItemId = ++CP.ItemId;
                    item.ShipmentId = 0;
                    CP.CoomonWeight += Convert.ToDouble(weight.Text);
                    CP.Items.Add(item);
                }
                catch
                {
                    MessageBox.Show("Проверьте правильность введенных данных!");
                }
                

                

            }
            CP.MainWindow.Activate();
            ContractWindow.RefreshWindow();
            ContractWindow.Activate();
            this?.Activate();

        }

        private void NewItem_Load(object sender, EventArgs e)
        {

        }
    }
}