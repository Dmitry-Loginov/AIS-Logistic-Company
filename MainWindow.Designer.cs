namespace АИС
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.копияБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копияБДToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.car = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statistic = new System.Windows.Forms.Button();
            this.provider = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.changeUser = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.Button();
            this.typeCargo = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.Button();
            this.driver = new System.Windows.Forms.Button();
            this.tarif = new System.Windows.Forms.Button();
            this.contract = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копияБДToolStripMenuItem,
            this.новыйToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(396, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // копияБДToolStripMenuItem
            // 
            this.копияБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копияБДToolStripMenuItem1,
            this.пользовательToolStripMenuItem});
            this.копияБДToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.копияБДToolStripMenuItem.Name = "копияБДToolStripMenuItem";
            this.копияБДToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.копияБДToolStripMenuItem.Text = "Меню";
            // 
            // копияБДToolStripMenuItem1
            // 
            this.копияБДToolStripMenuItem1.Name = "копияБДToolStripMenuItem1";
            this.копияБДToolStripMenuItem1.Size = new System.Drawing.Size(176, 24);
            this.копияБДToolStripMenuItem1.Text = "Копия БД";
            this.копияБДToolStripMenuItem1.Click += new System.EventHandler(this.копияБДToolStripMenuItem1_Click);
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            this.пользовательToolStripMenuItem.Click += new System.EventHandler(this.пользовательToolStripMenuItem_Click);
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.новыйToolStripMenuItem.Text = "Новый пользователь";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.SystemColors.Window;
            this.car.Cursor = System.Windows.Forms.Cursors.Default;
            this.car.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.car.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.car.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.car.Font = new System.Drawing.Font("Rage Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car.Image = global::АИС.Properties.Resources.icons8_car_50;
            this.car.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.car.Location = new System.Drawing.Point(201, 450);
            this.car.Margin = new System.Windows.Forms.Padding(4);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(180, 57);
            this.car.TabIndex = 9;
            this.car.Text = "Машины";
            this.car.UseVisualStyleBackColor = true;
            this.car.Click += new System.EventHandler(this.button12_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::АИС.Properties.Resources.logistic_truck_logo_design_vector_18099_1641;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(13, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 198);
            this.panel1.TabIndex = 2;
            // 
            // statistic
            // 
            this.statistic.BackColor = System.Drawing.SystemColors.Window;
            this.statistic.Cursor = System.Windows.Forms.Cursors.Default;
            this.statistic.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.statistic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.statistic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.statistic.Font = new System.Drawing.Font("Rage Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statistic.Image = global::АИС.Properties.Resources.icons8_laptop_metrics_50;
            this.statistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statistic.Location = new System.Drawing.Point(201, 385);
            this.statistic.Margin = new System.Windows.Forms.Padding(4);
            this.statistic.Name = "statistic";
            this.statistic.Size = new System.Drawing.Size(180, 57);
            this.statistic.TabIndex = 5;
            this.statistic.Text = "Статистика";
            this.statistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.statistic.UseVisualStyleBackColor = true;
            this.statistic.Click += new System.EventHandler(this.statistic_Click);
            // 
            // provider
            // 
            this.provider.BackColor = System.Drawing.SystemColors.Window;
            this.provider.Cursor = System.Windows.Forms.Cursors.Default;
            this.provider.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.provider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.provider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.provider.Font = new System.Drawing.Font("Rage Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.provider.Image = global::АИС.Properties.Resources.icons8_supplier_50;
            this.provider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.provider.Location = new System.Drawing.Point(201, 317);
            this.provider.Margin = new System.Windows.Forms.Padding(4);
            this.provider.Name = "provider";
            this.provider.Size = new System.Drawing.Size(180, 60);
            this.provider.TabIndex = 3;
            this.provider.Text = "Поставщики";
            this.provider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.provider.UseVisualStyleBackColor = true;
            this.provider.Click += new System.EventHandler(this.provider_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.Window;
            this.exit.Cursor = System.Windows.Forms.Cursors.Default;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.exit.Font = new System.Drawing.Font("Rage Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Image = global::АИС.Properties.Resources.power;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(13, 580);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(180, 57);
            this.exit.TabIndex = 11;
            this.exit.Text = "Выход";
            this.exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // changeUser
            // 
            this.changeUser.BackColor = System.Drawing.SystemColors.Window;
            this.changeUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.changeUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.changeUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.changeUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.changeUser.Font = new System.Drawing.Font("Rage Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeUser.Image = global::АИС.Properties.Resources.icons8_change_user_50;
            this.changeUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeUser.Location = new System.Drawing.Point(13, 512);
            this.changeUser.Margin = new System.Windows.Forms.Padding(4);
            this.changeUser.Name = "changeUser";
            this.changeUser.Size = new System.Drawing.Size(180, 57);
            this.changeUser.TabIndex = 11;
            this.changeUser.Text = "Сменить пользователя";
            this.changeUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeUser.UseVisualStyleBackColor = true;
            this.changeUser.Click += new System.EventHandler(this.changeUser_Click);
            // 
            // client
            // 
            this.client.BackColor = System.Drawing.SystemColors.Window;
            this.client.Cursor = System.Windows.Forms.Cursors.Default;
            this.client.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.client.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.client.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.client.Font = new System.Drawing.Font("Rage Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.client.Image = ((System.Drawing.Image)(resources.GetObject("client.Image")));
            this.client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.client.Location = new System.Drawing.Point(13, 382);
            this.client.Margin = new System.Windows.Forms.Padding(4);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(180, 57);
            this.client.TabIndex = 8;
            this.client.Text = "Заказчики";
            this.client.UseVisualStyleBackColor = true;
            this.client.Click += new System.EventHandler(this.button6_Click);
            // 
            // typeCargo
            // 
            this.typeCargo.BackColor = System.Drawing.SystemColors.Window;
            this.typeCargo.Cursor = System.Windows.Forms.Cursors.Default;
            this.typeCargo.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.typeCargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.typeCargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.typeCargo.Font = new System.Drawing.Font("Rage Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeCargo.Image = global::АИС.Properties.Resources.icons8_handle_with_care_50;
            this.typeCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.typeCargo.Location = new System.Drawing.Point(201, 249);
            this.typeCargo.Margin = new System.Windows.Forms.Padding(4);
            this.typeCargo.Name = "typeCargo";
            this.typeCargo.Size = new System.Drawing.Size(180, 60);
            this.typeCargo.TabIndex = 1;
            this.typeCargo.Text = "Типы грузов";
            this.typeCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.typeCargo.UseVisualStyleBackColor = true;
            this.typeCargo.Click += new System.EventHandler(this.typeCargo_Click);
            // 
            // users
            // 
            this.users.BackColor = System.Drawing.SystemColors.Window;
            this.users.Cursor = System.Windows.Forms.Cursors.Default;
            this.users.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.users.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.users.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.users.Font = new System.Drawing.Font("Rage Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.users.Image = ((System.Drawing.Image)(resources.GetObject("users.Image")));
            this.users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.users.Location = new System.Drawing.Point(201, 515);
            this.users.Margin = new System.Windows.Forms.Padding(4);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(180, 57);
            this.users.TabIndex = 10;
            this.users.Text = "         Пользователи";
            this.users.UseVisualStyleBackColor = true;
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // driver
            // 
            this.driver.BackColor = System.Drawing.SystemColors.Window;
            this.driver.Cursor = System.Windows.Forms.Cursors.Default;
            this.driver.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.driver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.driver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.driver.Font = new System.Drawing.Font("Rage Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driver.Image = ((System.Drawing.Image)(resources.GetObject("driver.Image")));
            this.driver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.driver.Location = new System.Drawing.Point(13, 447);
            this.driver.Margin = new System.Windows.Forms.Padding(4);
            this.driver.Name = "driver";
            this.driver.Size = new System.Drawing.Size(180, 57);
            this.driver.TabIndex = 10;
            this.driver.Text = "Водители";
            this.driver.UseVisualStyleBackColor = true;
            this.driver.Click += new System.EventHandler(this.driver_Click);
            // 
            // tarif
            // 
            this.tarif.BackColor = System.Drawing.SystemColors.Window;
            this.tarif.Cursor = System.Windows.Forms.Cursors.Default;
            this.tarif.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.tarif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.tarif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.tarif.Font = new System.Drawing.Font("Rage Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tarif.Image = global::АИС.Properties.Resources.icons8_cost_50;
            this.tarif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tarif.Location = new System.Drawing.Point(13, 317);
            this.tarif.Margin = new System.Windows.Forms.Padding(4);
            this.tarif.Name = "tarif";
            this.tarif.Size = new System.Drawing.Size(180, 57);
            this.tarif.TabIndex = 4;
            this.tarif.Text = "Тарифы";
            this.tarif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tarif.UseVisualStyleBackColor = true;
            this.tarif.Click += new System.EventHandler(this.tarif_Click);
            // 
            // contract
            // 
            this.contract.BackColor = System.Drawing.SystemColors.Window;
            this.contract.Cursor = System.Windows.Forms.Cursors.Default;
            this.contract.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.contract.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.contract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.contract.Font = new System.Drawing.Font("Rage Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contract.Image = global::АИС.Properties.Resources.icons8_contract_50;
            this.contract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contract.Location = new System.Drawing.Point(13, 249);
            this.contract.Margin = new System.Windows.Forms.Padding(4);
            this.contract.Name = "contract";
            this.contract.Size = new System.Drawing.Size(180, 60);
            this.contract.TabIndex = 0;
            this.contract.Text = "Договор";
            this.contract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contract.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.contract.UseVisualStyleBackColor = true;
            this.contract.Click += new System.EventHandler(this.contract_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 58);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(396, 639);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statistic);
            this.Controls.Add(this.provider);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.changeUser);
            this.Controls.Add(this.client);
            this.Controls.Add(this.typeCargo);
            this.Controls.Add(this.users);
            this.Controls.Add(this.driver);
            this.Controls.Add(this.tarif);
            this.Controls.Add(this.contract);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копияБДToolStripMenuItem;
        private System.Windows.Forms.Button contract;
        private System.Windows.Forms.Button driver;
        private System.Windows.Forms.Button client;
        private System.Windows.Forms.Button tarif;
        private System.Windows.Forms.Button typeCargo;
        private System.Windows.Forms.Button provider;
        private System.Windows.Forms.Button statistic;
        private System.Windows.Forms.Button changeUser;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button car;
        private System.Windows.Forms.ToolStripMenuItem копияБДToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.Button users;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button1;
    }
}

