using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class ItemWindow : Form
    {
        public ItemWindow()
        {
            InitializeComponent();
        }

        public ItemWindow(int shipmentId)
        {
            InitializeComponent();
            ShipmentId = shipmentId;
            RefreshWindow();
        }

        List<Item> items;
        public void RefreshWindow()
        {
            items = CP.Context.Items.FromSqlRaw("select Item.ItemId, Item.Name, Item.Count, Item.Weight, Item.TypeCargoId, Item.ProviderId, TypeCargo.Name as TypeCargo, Provider.Name as ProviderName, Item.ShipmentId from Item " +
                "left join TypeCargo ON TypeCargo.TypeCargoId = Item.TypeCargoId " +
                "left join Provider ON Provider.ProviderId = Item.ProviderId " +
                "where ShipmentId = {0}", ShipmentId)?.ToList();
            if (items != default)
            {
                dataGridView1.DataSource = items;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Название";
                dataGridView1.Columns[2].HeaderText = "Количество";
                dataGridView1.Columns[3].HeaderText = "Вес";
                dataGridView1.Columns[5].HeaderText = "Тип груза";
                dataGridView1.Columns[7].HeaderText = "Поставщик";
            }
        }
        public int ShipmentId { get; set; }

        private void ItemWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
