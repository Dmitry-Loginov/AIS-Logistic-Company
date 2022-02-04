using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace АИС
{
    public partial class DiagramWIndow : Form
    {
        public DiagramWIndow()
        {
            InitializeComponent();
        }

        public DiagramWIndow(List<Shipment> shipments)
        {
            InitializeComponent();
            Shipments = shipments;
        }

        public List<Shipment> Shipments { get; set; }

        private void DiagramWIndow_Load(object sender, EventArgs e)
        {
            var shipments = from shipment in Shipments
                            group shipment by shipment.TarifName into g
                            select new { TarifName = g.Key, Count = g.Count() };
            tarifChart.DataSource = shipments;
            
            tarifChart.Series["countTarif"].XValueMember = "TarifName";
            tarifChart.Series["countTarif"].XValueType = ChartValueType.String;
            tarifChart.Series["countTarif"].YValueMembers = "Count";
            tarifChart.Series["countTarif"].XValueType = ChartValueType.Int32;
            //SELECT COUNT(CustomerID), Country
            //FROM Customers
            //GROUP BY Country
            var shipmentsDriver = from shipment in Shipments
                            group shipment by shipment.CarNumber into g
                            select new { CarNumber = g.Key, Count = g.Count() };
            carChart.DataSource = shipmentsDriver;
    
            carChart.Series["carSeries"].XValueMember = "CarNumber";
            carChart.Series["carSeries"].XValueType = ChartValueType.String;
            carChart.Series["carSeries"].YValueMembers = "Count";
            carChart.Series["carSeries"].XValueType = ChartValueType.Int32;
            //for(int i = 0; i<shipmentsDriver.Count(); i++)
            //{
            //    carChart.Legends[0].CustomItems[i].Name = shipmentsDriver.ElementAt(i).CarNumber;

            //}
        }
    }
}
