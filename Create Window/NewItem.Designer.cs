namespace АИС
{
    partial class NewItem
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.providerBox = new System.Windows.Forms.ComboBox();
            this.provider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(97, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип груза";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название";
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weight.Location = new System.Drawing.Point(97, 140);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(147, 23);
            this.weight.TabIndex = 4;
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(97, 48);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(147, 23);
            this.count.TabIndex = 10;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(97, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(147, 23);
            this.name.TabIndex = 5;
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(97, 87);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(147, 21);
            this.typeBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество";
            // 
            // providerBox
            // 
            this.providerBox.FormattingEnabled = true;
            this.providerBox.Location = new System.Drawing.Point(97, 113);
            this.providerBox.Name = "providerBox";
            this.providerBox.Size = new System.Drawing.Size(147, 21);
            this.providerBox.TabIndex = 14;
            // 
            // provider
            // 
            this.provider.AutoSize = true;
            this.provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.provider.Location = new System.Drawing.Point(7, 117);
            this.provider.Name = "provider";
            this.provider.Size = new System.Drawing.Size(81, 17);
            this.provider.TabIndex = 7;
            this.provider.Text = "Поставщик";
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 210);
            this.Controls.Add(this.providerBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.provider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.count);
            this.Controls.Add(this.name);
            this.Name = "NewItem";
            this.Text = "Добавить груз";
            this.Load += new System.EventHandler(this.NewItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox providerBox;
        private System.Windows.Forms.Label provider;
    }
}