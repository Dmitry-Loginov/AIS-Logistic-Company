namespace АИС
{
    partial class DiagramWIndow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tarifChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.carChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.tarifChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tarifChart
            // 
            chartArea1.Name = "ChartArea1";
            this.tarifChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.tarifChart.Legends.Add(legend1);
            this.tarifChart.Location = new System.Drawing.Point(12, 12);
            this.tarifChart.Name = "tarifChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Количество перевозок";
            series1.Name = "countTarif";
            this.tarifChart.Series.Add(series1);
            this.tarifChart.Size = new System.Drawing.Size(543, 426);
            this.tarifChart.TabIndex = 0;
            this.tarifChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Диграмма тарифов";
            this.tarifChart.Titles.Add(title1);
            // 
            // carChart
            // 
            chartArea2.Name = "ChartArea1";
            this.carChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.carChart.Legends.Add(legend2);
            this.carChart.Location = new System.Drawing.Point(573, 12);
            this.carChart.Name = "carChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "carSeries";
            this.carChart.Series.Add(series2);
            this.carChart.Size = new System.Drawing.Size(543, 426);
            this.carChart.TabIndex = 1;
            this.carChart.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Диаграмма автомобилей";
            this.carChart.Titles.Add(title2);
            // 
            // DiagramWIndow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 569);
            this.Controls.Add(this.carChart);
            this.Controls.Add(this.tarifChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DiagramWIndow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagramWIndow";
            this.Load += new System.EventHandler(this.DiagramWIndow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarifChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart tarifChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart carChart;
    }
}