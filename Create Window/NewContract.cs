using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace АИС
{
    public partial class ContractWindow : Form
    {
        public static Car carFormDataBase;
        public static List<Car> cars;
        public static List<Client> clients;
        public static List<Tarif> tarifs;
        public static List<Item> items;
        public static int Index { get; set; }
        public static double Price { get; set; }
        public static StatisticWindow StatisticWindow { get; set; }

        public ContractWindow()
        {
            InitializeComponent();
            CP.Items = new List<Item>();
            RefreshWindow();


        }

        public ContractWindow(StatisticWindow statisticWindow)
        {
            InitializeComponent();
            StatisticWindow = statisticWindow;
            CP.Items = new List<Item>();
            RefreshWindow();

        }

        public void CountPrice()
        {

            try
            {
                double litrs = Convert.ToDouble(km.Text) * cars[carBox.SelectedIndex].Consumption / 100;
                Price = Convert.ToDouble(km.Text) * tarifs[tarifBox.SelectedIndex].PerKm
                    + Convert.ToDouble(weight.Text) * tarifs[tarifBox.SelectedIndex].PerKg
                    + litrs * Convert.ToDouble(litr.Text);
                if (checkBox1.Checked)
                    Price = 0.8 * Price;
                price.Text = String.Format("{0:F2}", Price.ToString());
            }
            catch
            {
                price.Text = "Ошибка";
            }
        }
        public void RefreshWindow()
        {
            cars = CP.Context.Cars.FromSqlRaw("select Car.CarId, Car.Number, Car.Model, Driver.Name as DriverName, Car.DriverId,  " +
                "Car.Consumption from Car left join Driver on Car.DriverId = Driver.DriverId").ToList();
            clients = CP.Context.Clients.FromSqlRaw("select Client.ClientId, Client.Name, Client.Address, " +
                "Client.Telephone, Client.PassportId from Client").ToList();
            tarifs = CP.Context.Tarifs.FromSqlRaw("select Tarif.TarifId, Tarif.Name, Tarif.PerKm, " +
                "Tarif.PerKg from Tarif").ToList();


            carBox.DataSource = cars;
            carBox.DisplayMember = "Number";
            carBox.ValueMember = "CarId";
            carFormDataBase = cars[carBox.SelectedIndex];
            driver.Text = carFormDataBase.DriverName;
            model.Text = carFormDataBase.Model;

            clientBox.DataSource = clients;
            clientBox.DisplayMember = "Name";
            clientBox.ValueMember = "ClientId";

            tarifBox.DataSource = tarifs;
            tarifBox.DisplayMember = "Name";
            tarifBox.ValueMember = "TarifId";





            dataGridView1.DataSource = null;
            dataGridView1.DataSource = CP.Items.Count > 0 ? CP.Items : null;
            if (CP.Items.Count > 0)
            {
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Название";
                dataGridView1.Columns[2].HeaderText = "Количество";
                dataGridView1.Columns[3].HeaderText = "Вес";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].HeaderText = "Тип  груза";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].HeaderText = "Поставщик";
                dataGridView1.Columns[8].Visible = false;
            }
            if (dataGridView1.Rows.Count == 0)
            {
                delete.Enabled = false;
            }
            else
            {
                delete.Enabled = true;
            }
            weight.Text = CP.CoomonWeight.ToString();
            CountPrice();

        }

        private void changeCar_Click(object sender, EventArgs e)
        {
            NewCar newCar = new NewCar(true, carFormDataBase, this);
            newCar.Show();
        }

        private void carBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            carFormDataBase = cars[carBox.SelectedIndex];
            driver.Text = carFormDataBase.DriverName;
            model.Text = carFormDataBase.Model;

        }

        private void ContractWindow_Activated(object sender, EventArgs e)
        {
            RefreshWindow();
        }

        public static void CreateDocument(Shipment shipment)
        {


            string saveFolder = @"C:\Users\Student\OneDrive\learn\ТРПО\AIS\АИС\bin\Contracts\";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = saveFolder;
            saveFileDialog.Filter = "Договор(*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Оформлнеие договора";
            saveFileDialog.FileName = shipment.ShipmentId.ToString();
            string copyPath = null;
            Workbook workbook = null;
            Excel.Application xlApp = null;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                WaitForm = new WaitForm();
                WaitForm.Show();
                copyPath = Path.GetFullPath(saveFileDialog.FileName);
                FileInfo fileInf = new FileInfo(@"C:\Users\Student\OneDrive\learn\ТРПО\AIS\АИС\bin\Debug\Contract.xlsx");
            
                    if (fileInf.Exists)
                    {
                        workbook = CreateAndGetWorkSheet(copyPath, out xlApp);
                    }
                    else
                    {
                        MessageBox.Show("Файл существует");
                    }
                List<Car> cars = CP.Context.Cars.FromSqlRaw("select Car.CarId, Car.Number, Car.Model, Driver.Name as DriverName, Car.DriverId,  " +
               "Car.Consumption from Car left join Driver on Car.DriverId = Driver.DriverId").ToList();
                List<Client> clients = CP.Context.Clients.FromSqlRaw("select Client.ClientId, Client.Name, Client.Address, " +
                    "Client.Telephone, Client.PassportId from Client").ToList();
                List<Tarif> tarifs = CP.Context.Tarifs.FromSqlRaw("select Tarif.TarifId, Tarif.Name, Tarif.PerKm, " +
                    "Tarif.PerKg from Tarif").ToList();

                XlReferenceStyle RefStyle = xlApp.ReferenceStyle;
                Excel.Worksheet worksheet = (Excel.Worksheet)xlApp.Worksheets.get_Item(2);
                //Worksheet worksheet = workbook.ActiveSheet;
                //Contract
                worksheet.Cells[4, "F"] = shipment.ShipmentId.ToString();
                //По тарифу
                Tarif tarif = tarifs.Where(t => t.TarifId == shipment.TarifId).FirstOrDefault();
                worksheet.Cells[7, "D"] = tarif.Name;
                worksheet.Cells[11, "D"] = tarif.PerKm.ToString();
                worksheet.Cells[12, "D"] = tarif.PerKg.ToString();

                //Auto
                Car car = cars.Where(c => c.CarId == shipment.CarId).FirstOrDefault();
                worksheet.Cells[10, "H"] = car.Number;
                worksheet.Cells[11, "H"] = car.DriverName;

                //Items
                items = CP.Context.Items?.FromSqlRaw("select Item.ItemId, Item.Name, Item.Count, Item.Weight, Item.TypeCargoId, " +
                    "TypeCargo.Name as TypeCargo, Item.ProviderId, Provider.Name as ProviderName, Item.ShipmentId " +
                    "from Item " +
                    "left join TypeCargo on Item.TypeCargoId = TypeCargo.TypeCargoId " +
                    "left join Provider on Provider.ProviderId = Item.ProviderId " +
                    "where ShipmentId = {0}", shipment.ShipmentId).ToList();
                int countItem = 1;
                int countRow = 21;
                if (items.Count > 0)
                    for (int i = 0; i < items.Count; i++)
                    {
                        worksheet.Cells[countRow, "C"] = countItem.ToString();
                        worksheet.Cells[countRow, "D"] = items[i].Name.ToString();
                        worksheet.Cells[countRow, "E"] = items[i].TypeCargo.ToString();
                        worksheet.Cells[countRow, "F"] = items[i].Count.ToString();
                        worksheet.Cells[countRow, "G"] = items[i].Weight.ToString();
                        worksheet.Cells[countRow, "H"] = items[i].ProviderName.ToString();
                        countItem++;
                        countRow++;
                    }


                //Price
                worksheet.Cells[countRow, "I"] = "Цена";
                worksheet.Cells[countRow, "J"] = shipment.Price.ToString();

                //Place load
                countRow += 4;
                worksheet.Cells[countRow, "C"] = "Место погрузки";
                worksheet.Cells[countRow, "D"] = shipment.AddressLoad;
                countRow += 1;
                worksheet.Cells[countRow, "C"] = "Место доставки";
                worksheet.Cells[countRow, "D"] = shipment.AddressUnload;

                //Contacts
                countRow += 3;
                Client client = clients.Where(c => c.ClientId == shipment.ClientId).FirstOrDefault();
                worksheet.Cells[countRow, "C"] = "Заказчик";
                worksheet.Cells[countRow, "D"] = client.Name;

                worksheet.Cells[countRow, "F"] = "Сотрудник";
                worksheet.Cells[countRow, "G"] = CP.CurrentUser.Name;

                //Sign
                countRow += 2;
                worksheet.Cells[countRow, "C"] = "Подпись";
                worksheet.Cells[countRow, "D"] = "_________";

                worksheet.Cells[countRow, "F"] = "Подпись";
                worksheet.Cells[countRow, "G"] = "_________";
                xlApp.Visible = true;
                Excel.Range range;
                Excel.Range c1 = worksheet.Cells[2, 2];
                Excel.Range c2 = worksheet.Cells[countRow, 11];
                range = worksheet.get_Range(c1, c2);
                // Excel.Range range = worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[countRow, 11]);

                range.Borders.get_Item(XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Borders.get_Item(XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Borders.get_Item(XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
                WaitForm.Close();
                
                workbook.Close(true);
                
                xlApp.Quit();
               
                Process.Start(copyPath);
            }

        }
        private void create_Click(object sender, EventArgs e)
        {
            Shipment shipment = SaveShipment();
            if (shipment == null)
                return;
            CreateDocument(shipment);

        }
        public static WaitForm WaitForm;

        public static Workbook CreateAndGetWorkSheet(string path, out Microsoft.Office.Interop.Excel.Application xlApp)
        {
            xlApp = new Microsoft.Office.Interop.Excel.Application(); //Excel
            Workbook xlWB; //рабочая книга откуда будем копировать лист  
            Workbook xlWB2; //рабочая книга куда будем копировать лист
            Worksheet xlSht; //лист Excel            

            xlWB = xlApp.Workbooks.Open($@"{System.Windows.Forms.Application.StartupPath}/Contract.xlsx"); //название файла Excel откуда будем копировать лист
            xlWB2 = xlApp.Workbooks.Add(System.Reflection.Missing.Value); //название файла Excel куда будем копировать лист

            xlSht = xlWB.Worksheets["Лист1"]; //название листа или 1-й лист в книге xlSht = xlWB.Worksheets[1];

            xlSht.Copy(After: xlWB2.Worksheets[xlWB2.Worksheets.Count]);  //сам процесс копирования листа из одного файла в другой           

            xlWB2.SaveAs(path);
            xlWB.Close();


            return xlWB2;
        }
        private void km_TextChanged(object sender, EventArgs e)
        {
            CountPrice();
        }

        private void weight_TextChanged(object sender, EventArgs e)
        {
            CountPrice();
        }

        private void tarifBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            CountPrice();
        }

        private void litr_TextChanged(object sender, EventArgs e)
        {
            CountPrice();
        }

        private void providerBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            CountPrice();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CountPrice();
        }

        private void ContractWindow_Load(object sender, EventArgs e)
        {
            currentUser.Text = CP.CurrentUser.Name + ".";
            currentDate.Text = DateTime.Now.ToShortDateString();
            if (dataGridView1.Rows.Count == 0)
            {
                delete.Enabled = false;
            }
            else
            {
                delete.Enabled = true;
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            SaveShipment();
            CP.Context.Dispose();
            CP.GetContext();
        }

        public Shipment SaveShipment()
        {
            Shipment shipment = null;
            if (place.Text != "" && placeTakeCargo.Text != "")
                try
                {
                    CP.Context.Database.ExecuteSqlRaw("insert into Shipment (CarId, ClientId, TarifId, UserId, AddressLoad, AddressUnload, Km, Weight, Price, DateStart, DateCreate, IsConstantCustomer) " +
                       "values ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11})", cars[carBox.SelectedIndex].CarId, clients[clientBox.SelectedIndex].ClientId, tarifs[tarifBox.SelectedIndex].TarifId,
                      CP.CurrentUser.UserId, placeTakeCargo.Text, place.Text, Convert.ToDouble(km.Text), Convert.ToDouble(weight.Text), Price, dateStart.Value.Date, DateTime.Today, checkBox1.Checked);
                    CP.Context.Dispose();
                    CP.GetContext();
                    Index = CP.Context.ShipmentMaxItems.FromSqlRaw("select ShipmentId, max(ShipmentId) as MaxItem from Shipment").FirstOrDefault().MaxItem;
                    MessageBox.Show("Договор сохранен!");
                    StatisticWindow?.RefreshWindow();
                    StatisticWindow?.Activate();
                    Activate();
                }
                catch
                {
                    MessageBox.Show("Проверьте правильность ввода!");
                    return null;

                }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                return null;
            }
            CP.Items?.ForEach(item => item.ShipmentId = Index);
            CP.Items?.ForEach(item => item.TypeCargo = null);
            CP.Items?.ForEach(item => item.ProviderName = null);
            CP.Context.Items?.AddRange(CP.Items);
            CP.Context.SaveChanges();
            CP.Context.Dispose();
            CP.GetContext();
            int count = CP.context.Items.FromSqlRaw("select * from Item").ToList().Count;
            ItemMaxId item_ = null;
            if (count != 0)
            {
                item_ = CP.context.ItemMaxIds.FromSqlRaw("select ItemId, max(ItemId) as MaxIndex from Item").FirstOrDefault();
            }
            CP.StartItem = count == 0 ? 0 : item_.MaxIndex;
            CP.ItemId = CP.StartItem;
            //shipment = CP.Context.Shipments.FromSqlRaw("select ShipmentId, CarId, ClientId, TarifId, UserId, " +
            //     "AddressLoad, AddressUnload, Km, Weight, Price, DateStart, DateCreate, IsConstantCustomer from Shipment where ShipmentId = {0}", Index).FirstOrDefault();
            shipment = CP.Context.Shipments.FromSqlRaw("select * from Shipment where ShipmentId = {0}", Index).FirstOrDefault();
            Clear();
            CP.Context.Dispose();
            CP.GetContext();
            return shipment;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            NewItem newItem = new NewItem(this);
            newItem.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            CP.Items.Remove(CP.Items.Where(item => item.ItemId == id).First());
            CP.ItemId--;
            RefreshWindow();

        }

        public void Clear()
        {
            place.Clear();
            placeTakeCargo.Clear();
            dataGridView1.DataSource = null;
            CP.Items.Clear();
            CP.ItemId = CP.StartItem;
            km.Clear();
            litr.Clear();
            dateStart.Value = DateTime.Today;
            Index = 0;
            RefreshWindow();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
