using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace АИС
{
    public partial class StatisticWindow : Form
    {
        public StatisticWindow()
        {
            InitializeComponent();
            if (CP.CurrentUser.RoleId != 3)
            {
                output.Visible = false;
                delete.Visible = false;
            }
        }

        private void StatisticWindow_Load(object sender, EventArgs e)
        {
            RefreshWindow();
            dSFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
            dCFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
        }
        List<Shipment> Shipments { get; set; }
        List<Shipment> FullShipment { get; set; }
        public void RefreshWindow(List<Shipment> shipmentsIn = null)
        {
            FullShipment = CP.Context.Shipments.FromSqlRaw(
                "select Shipment.ShipmentId, Shipment.CarId, Shipment.ClientId, Shipment.TarifId, Shipment.UserId, AddressLoad, AddressUnload, Km, Weight, Price, DateStart, DateCreate, IsConstantCustomer, " +
                  "Car.Number as CarNumber, Client.Name as ClientName, Tarif.Name as TarifName, User.Name as UserName " +
                  "from Shipment " +
                  "left join Car ON Shipment.CarId = Car.CarId " +
                  "left join Client ON Shipment.ClientId = Client.ClientId " +
                  "left join Tarif ON Shipment.TarifId = Tarif.TarifId " +
                  "left join User ON Shipment.UserId = User.UserId ")?.ToList();
            if (shipmentsIn == null)
            {
                Shipments = FullShipment;
            }
            else
                Shipments = shipmentsIn;
            //price
            //datestart
            //datecreate
            //tarif
            //client name
            //постоянный
            //id
            if (Shipments != default)
            {
                dataGridView1.DataSource = Shipments;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;


                dataGridView1.Columns[0].HeaderText = "Номер\nдоговора";
                dataGridView1.Columns[2].HeaderText = "Автомобиль";//
                dataGridView1.Columns[4].HeaderText = "Заказчик";
                dataGridView1.Columns[6].HeaderText = "Тариф";
                dataGridView1.Columns[8].HeaderText = "Пользователь";//


                dataGridView1.Columns[9].HeaderText = "Адрес\nпогрузки";//
                dataGridView1.Columns[10].HeaderText = "Адрес\nдоставки";///

                dataGridView1.Columns[11].HeaderText = "Км";//
                dataGridView1.Columns[12].HeaderText = "Вес";//
                dataGridView1.Columns[13].HeaderText = "Цена";
                dataGridView1.Columns[14].HeaderText = "Дата\nвыезда";
                dataGridView1.Columns[15].HeaderText = "Дата\nсоздания";
                dataGridView1.Columns[16].HeaderText = "Скидка";
                if (dataGridView1.Rows.Count == 0)
                {
                    delete.Enabled = false;
                    info.Enabled = false;
                    output.Enabled = false;
                }
                else
                {
                    delete.Enabled = true;
                    info.Enabled = true;
                    output.Enabled = true;
                }


            }
            dataGridView1.AutoResizeColumns();
            if(dataGridView1.Rows.Count != 0)
            dataGridView1.SelectedRows[0].Selected = true;
            

        }

        private void add_Click(object sender, EventArgs e)
        {
            ContractWindow contracts = new ContractWindow(this);
            contracts.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show("Удалить?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CP.Context.Database.ExecuteSqlRaw("delete from Shipment where ShipmentId = {0}", id);
                RefreshWindow();
            }
        }

        public ItemWindow ItemWindow;
        private void info_Click(object sender, EventArgs e)
        {
            int Id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            if (ItemWindow == null)
                ItemWindow = new ItemWindow(Id);
            if (ItemWindow.IsDisposed)
                ItemWindow = new ItemWindow(Id);
            ItemWindow.Show();
            ItemWindow.Activate();
        }

        private void output_Click(object sender, EventArgs e)
        {
            Shipment shipment = CP.Context.Shipments.FromSqlRaw("select * from Shipment where ShipmentId = {0}", dataGridView1.SelectedRows[0].Cells[0].Value).FirstOrDefault();
            ContractWindow.CreateDocument(shipment);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1?.SelectedRows[0]?.Cells[0].Value);

                Shipment shipment = Shipments.Where(t => t.ShipmentId == id).FirstOrDefault();
                carText.Text = shipment.CarNumber.ToString();
                uText.Text = shipment.UserName;
                adresLoadText.Text = shipment.AddressLoad;
                adresUnloadText.Text = shipment.AddressUnload;
                kmText.Text = shipment.Km.ToString();
                weightText.Text = shipment.Weight.ToString();
            }
            catch 
            {
                carText.Text = "";
                uText.Text = "";
                adresLoadText.Text = "";
                adresUnloadText.Text = "";
                kmText.Text = "";
                weightText.Text = "";
            }
        }

        private void idFiltr_TextChanged(object sender, EventArgs e)
        {

        }



        private void button2_Click_1(object sender, EventArgs e)
        {

            
            
                string query =
              "select Shipment.ShipmentId, Shipment.CarId, Shipment.ClientId, Shipment.TarifId, Shipment.UserId, AddressLoad, AddressUnload, Km, Weight, Price, DateStart, DateCreate, IsConstantCustomer, " +
                "Car.Number as CarNumber, Client.Name as ClientName, Tarif.Name as TarifName, User.Name as UserName " +
                "from Shipment " +
                "left join Car ON Shipment.CarId = Car.CarId " +
                "left join Client ON Shipment.ClientId = Client.ClientId " +
                "left join Tarif ON Shipment.TarifId = Tarif.TarifId " +
                "left join User ON Shipment.UserId = User.UserId ";
                query = DSQuery(query);
                query = DCQuery(query);
 
                Shipments = CP.Context.Shipments.FromSqlRaw(query).ToList();
                RefreshWindow(Shipments);
            
            
            


        }
        public string DSQuery(string query)
        {
            query += "Where DateStart >= ";
            if(dSFrom.Value.Date.Day >= 10)
                query += "'" + dSFrom.Value.Date.Year +"-" + dSFrom.Value.Date.Month + "-" + dSFrom.Value.Date.Day + " 00:00:00" + "'";
            else
            {
                query += "'" + dSFrom.Value.Date.Year + "-" + dSFrom.Value.Date.Month + "-" + "0" + dSFrom.Value.Date.Day + " 00:00:00" + "'";
            }
            query += " AND DateStart <= ";
            if (dSTo.Value.Date.Day >= 10)
                query += "'" + dSTo.Value.Date.Year + "-" + dSTo.Value.Date.Month + "-" + dSTo.Value.Date.Day + " 00:00:00" + "'";
            else
            {
                query += "'" + dSTo.Value.Date.Year + "-" + dSTo.Value.Date.Month + "-" + "0" + dSTo.Value.Date.Day + " 00:00:00" + "'";
            }
            return query;

        }
        public string DCQuery(string query)
        {
            query += " AND DateCreate >= ";
            if (dCFrom.Value.Date.Day >= 10)
                query += "'" + dCFrom.Value.Date.Year + "-" + dCFrom.Value.Date.Month + "-" + dCFrom.Value.Date.Day + " 00:00:00" + "'";
            else
            {
                query += "'" + dCFrom.Value.Date.Year + "-" + dCFrom.Value.Date.Month + "-" + "0" + dCFrom.Value.Date.Day + " 00:00:00" + "'";
            }
            query += " AND DateCreate <= ";
            if (dCTo.Value.Date.Day >= 10)
                query += "'" + dCTo.Value.Date.Year + "-" + dCTo.Value.Date.Month + "-" + dCTo.Value.Date.Day + " 00:00:00" + "'";
            else
            {
                query += "'" + dCTo.Value.Date.Year + "-" + dCTo.Value.Date.Month + "-" + "0" + dCTo.Value.Date.Day + " 00:00:00" + "'";
            }
            return query;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dSFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
            dCFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
            RefreshWindow();
        }

        DiagramWIndow DiagramWIndow { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            DiagramWIndow = new DiagramWIndow(Shipments);
            DiagramWIndow.Show();
            DiagramWIndow.Activate();
        }
    }
}
