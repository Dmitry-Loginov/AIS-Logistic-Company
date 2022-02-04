namespace АИС
{
    partial class StatisticWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.info = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.carText = new System.Windows.Forms.Label();
            this.uText = new System.Windows.Forms.Label();
            this.adresLoadText = new System.Windows.Forms.Label();
            this.adresUnloadText = new System.Windows.Forms.Label();
            this.kmText = new System.Windows.Forms.Label();
            this.weightText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dCTo = new System.Windows.Forms.DateTimePicker();
            this.dSTo = new System.Windows.Forms.DateTimePicker();
            this.dCFrom = new System.Windows.Forms.DateTimePicker();
            this.dSFrom = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(323, 542);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(819, 377);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(151, 542);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(83, 23);
            this.info.TabIndex = 17;
            this.info.Text = "Информация";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 542);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(133, 23);
            this.output.TabIndex = 16;
            this.output.Text = "Вывести в файл";
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Статистика";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Автомобиль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Сотрудник:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 640);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Адрес погрузки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 667);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Адрес доставки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 698);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Км";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 721);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Вес";
            // 
            // carText
            // 
            this.carText.Location = new System.Drawing.Point(148, 589);
            this.carText.Name = "carText";
            this.carText.Size = new System.Drawing.Size(80, 13);
            this.carText.TabIndex = 20;
            // 
            // uText
            // 
            this.uText.Location = new System.Drawing.Point(148, 613);
            this.uText.Name = "uText";
            this.uText.Size = new System.Drawing.Size(80, 13);
            this.uText.TabIndex = 20;
            // 
            // adresLoadText
            // 
            this.adresLoadText.Location = new System.Drawing.Point(148, 640);
            this.adresLoadText.Name = "adresLoadText";
            this.adresLoadText.Size = new System.Drawing.Size(80, 13);
            this.adresLoadText.TabIndex = 20;
            // 
            // adresUnloadText
            // 
            this.adresUnloadText.Location = new System.Drawing.Point(148, 667);
            this.adresUnloadText.Name = "adresUnloadText";
            this.adresUnloadText.Size = new System.Drawing.Size(80, 13);
            this.adresUnloadText.TabIndex = 20;
            // 
            // kmText
            // 
            this.kmText.Location = new System.Drawing.Point(148, 698);
            this.kmText.Name = "kmText";
            this.kmText.Size = new System.Drawing.Size(80, 13);
            this.kmText.TabIndex = 20;
            // 
            // weightText
            // 
            this.weightText.Location = new System.Drawing.Point(148, 721);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(80, 13);
            this.weightText.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dCTo);
            this.groupBox1.Controls.Add(this.dSTo);
            this.groupBox1.Controls.Add(this.dCFrom);
            this.groupBox1.Controls.Add(this.dSFrom);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 141);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(284, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Сброс";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(132, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "До";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "До";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(130, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "От";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "От";
            // 
            // dCTo
            // 
            this.dCTo.Location = new System.Drawing.Point(133, 90);
            this.dCTo.Name = "dCTo";
            this.dCTo.Size = new System.Drawing.Size(119, 20);
            this.dCTo.TabIndex = 4;
            // 
            // dSTo
            // 
            this.dSTo.Location = new System.Drawing.Point(9, 90);
            this.dSTo.Name = "dSTo";
            this.dSTo.Size = new System.Drawing.Size(118, 20);
            this.dSTo.TabIndex = 4;
            // 
            // dCFrom
            // 
            this.dCFrom.Location = new System.Drawing.Point(133, 50);
            this.dCFrom.Name = "dCFrom";
            this.dCFrom.Size = new System.Drawing.Size(119, 20);
            this.dCFrom.TabIndex = 4;
            // 
            // dSFrom
            // 
            this.dSFrom.Location = new System.Drawing.Point(9, 50);
            this.dSFrom.Name = "dSFrom";
            this.dSFrom.Size = new System.Drawing.Size(118, 20);
            this.dSFrom.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Дата создания";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Дата выезда";
            // 
            // StatisticWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 735);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.kmText);
            this.Controls.Add(this.adresUnloadText);
            this.Controls.Add(this.adresLoadText);
            this.Controls.Add(this.uText);
            this.Controls.Add(this.carText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.output);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete);
            this.Name = "StatisticWindow";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.StatisticWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label carText;
        private System.Windows.Forms.Label uText;
        private System.Windows.Forms.Label adresLoadText;
        private System.Windows.Forms.Label adresUnloadText;
        private System.Windows.Forms.Label kmText;
        private System.Windows.Forms.Label weightText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dCTo;
        private System.Windows.Forms.DateTimePicker dSTo;
        private System.Windows.Forms.DateTimePicker dCFrom;
        private System.Windows.Forms.DateTimePicker dSFrom;
    }
}