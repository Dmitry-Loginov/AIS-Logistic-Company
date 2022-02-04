namespace АИС
{
    partial class ContractWindow
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
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.place = new System.Windows.Forms.TextBox();
            this.km = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.carBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.driver = new System.Windows.Forms.Label();
            this.changeCar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.clientBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tarifBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.litr = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.placeTakeCargo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(148, 11);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата выезда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Место доставки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Километраж";
            // 
            // place
            // 
            this.place.Location = new System.Drawing.Point(148, 63);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(200, 20);
            this.place.TabIndex = 3;
            // 
            // km
            // 
            this.km.Location = new System.Drawing.Point(148, 88);
            this.km.Name = "km";
            this.km.Size = new System.Drawing.Size(200, 20);
            this.km.TabIndex = 3;
            this.km.Text = "0";
            this.km.TextChanged += new System.EventHandler(this.km_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Автомобиль";
            // 
            // carBox
            // 
            this.carBox.FormattingEnabled = true;
            this.carBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.carBox.Location = new System.Drawing.Point(148, 120);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(200, 21);
            this.carBox.TabIndex = 4;
            this.carBox.SelectedIndexChanged += new System.EventHandler(this.carBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Водитель";
            // 
            // driver
            // 
            this.driver.AutoSize = true;
            this.driver.Location = new System.Drawing.Point(282, 147);
            this.driver.Name = "driver";
            this.driver.Size = new System.Drawing.Size(33, 13);
            this.driver.TabIndex = 5;
            this.driver.Text = "driver";
            // 
            // changeCar
            // 
            this.changeCar.Location = new System.Drawing.Point(351, 120);
            this.changeCar.Name = "changeCar";
            this.changeCar.Size = new System.Drawing.Size(159, 23);
            this.changeCar.TabIndex = 6;
            this.changeCar.Text = "Изменить";
            this.changeCar.UseVisualStyleBackColor = true;
            this.changeCar.Click += new System.EventHandler(this.changeCar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Заказчик";
            // 
            // clientBox
            // 
            this.clientBox.FormattingEnabled = true;
            this.clientBox.Location = new System.Drawing.Point(148, 195);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(200, 21);
            this.clientBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Тариф";
            // 
            // tarifBox
            // 
            this.tarifBox.FormattingEnabled = true;
            this.tarifBox.Location = new System.Drawing.Point(148, 222);
            this.tarifBox.Name = "tarifBox";
            this.tarifBox.Size = new System.Drawing.Size(200, 21);
            this.tarifBox.TabIndex = 4;
            this.tarifBox.SelectedIndexChanged += new System.EventHandler(this.tarifBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Модель";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(280, 170);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(35, 13);
            this.model.TabIndex = 5;
            this.model.Text = "model";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Общий вес";
            // 
            // weight
            // 
            this.weight.Enabled = false;
            this.weight.Location = new System.Drawing.Point(148, 259);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(200, 20);
            this.weight.TabIndex = 8;
            this.weight.Text = "0";
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Цена";
            // 
            // price
            // 
            this.price.Enabled = false;
            this.price.Location = new System.Drawing.Point(148, 285);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(200, 20);
            this.price.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.currentUser,
            this.toolStripStatusLabel2,
            this.currentDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(137, 17);
            this.toolStripStatusLabel1.Text = "Текущий пользователь:";
            // 
            // currentUser
            // 
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(68, 17);
            this.currentUser.Text = "currentUser";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel2.Text = "Дата:";
            // 
            // currentDate
            // 
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(69, 17);
            this.currentDate.Text = "currentDate";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(354, 285);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Скидка";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(355, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "За литр:";
            // 
            // litr
            // 
            this.litr.Location = new System.Drawing.Point(410, 88);
            this.litr.Name = "litr";
            this.litr.Size = new System.Drawing.Size(100, 20);
            this.litr.TabIndex = 12;
            this.litr.Text = "0";
            this.litr.TextChanged += new System.EventHandler(this.litr_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Место погрузки";
            // 
            // placeTakeCargo
            // 
            this.placeTakeCargo.Location = new System.Drawing.Point(148, 37);
            this.placeTakeCargo.Name = "placeTakeCargo";
            this.placeTakeCargo.Size = new System.Drawing.Size(200, 20);
            this.placeTakeCargo.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(532, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(438, 351);
            this.dataGridView1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(622, 375);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 16;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.Image = global::АИС.Properties.Resources.icons8_clear_formatting_40;
            this.clear.Location = new System.Drawing.Point(282, 309);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(60, 60);
            this.clear.TabIndex = 17;
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // save
            // 
            this.save.Image = global::АИС.Properties.Resources.icons8_save_50;
            this.save.Location = new System.Drawing.Point(217, 309);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(60, 60);
            this.save.TabIndex = 13;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // create
            // 
            this.create.Image = global::АИС.Properties.Resources.icons8_create_50__1_;
            this.create.Location = new System.Drawing.Point(152, 309);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(60, 60);
            this.create.TabIndex = 7;
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // ContractWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 442);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.litr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.create);
            this.Controls.Add(this.changeCar);
            this.Controls.Add(this.model);
            this.Controls.Add(this.driver);
            this.Controls.Add(this.tarifBox);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.carBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.km);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.placeTakeCargo);
            this.Controls.Add(this.place);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateStart);
            this.Name = "ContractWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый договор";
            this.Activated += new System.EventHandler(this.ContractWindow_Activated);
            this.Load += new System.EventHandler(this.ContractWindow_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox place;
        private System.Windows.Forms.TextBox km;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox carBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label driver;
        private System.Windows.Forms.Button changeCar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox clientBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox tarifBox;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel currentUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel currentDate;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox litr;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox placeTakeCargo;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
    }
}