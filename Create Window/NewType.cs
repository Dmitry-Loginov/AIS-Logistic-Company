using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class NewType : Form
    {
        public NewType()
        {
            InitializeComponent();
        }

        public NewType(TypeCargoWindow typeCargoWindow)
        {
            InitializeComponent();
            TypeCargoWindow = typeCargoWindow;
        }

        public NewType(bool IsEdit, TypeCargo changingType, TypeCargoWindow typeCargoWindow)
        {
            InitializeComponent();
            this.IsEdit = IsEdit;
            ChangingType = changingType;
            TypeCargoWindow = typeCargoWindow;
            Text = "Изменить тип";
            button1.Text = "Изменить данные";
        }

        public TypeCargoWindow TypeCargoWindow { get; set; }
        public bool IsEdit { get; set; }
        public TypeCargo ChangingType { get; set; }
        DialogResult Confirm()
        {
            return MessageBox.Show($"Название: {name.Text}", 
                 $"{button1.Text} тип?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        public void Clear()
        {
            name.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TypeCargo typetFormDataBase = CP.Context.TypeCargos.FromSqlRaw($"SELECT TypeCargo.TypeCargoId, TypeCargo.Name from TypeCargo where Name = \'{name.Text}\'").FirstOrDefault();

                if (typetFormDataBase != default && ChangingType?.Name != name.Text)
                {
                    MessageBox.Show("Тип груза с таким названием уже существует!");
                    return;
                }
                if (!IsEdit)
                    switch (Confirm())
                    {
                        case DialogResult.Yes:
                            CP.Context.Database.ExecuteSqlRaw("insert into TypeCargo (Name) values ({0})", name.Text);
                            CP.Context.Dispose();
                            CP.GetContext();
                            break;
                    }
                else
                    switch (Confirm())
                    {
                        case DialogResult.Yes:
                            CP.Context.Database.ExecuteSqlRaw("update TypeCargo set Name = {0} where TypeCargoId = {1}", name.Text, ChangingType.TypeCargoId);
                            CP.GetContext();
                            TypeCargoWindow.RefreshWindow();
                            break;
                    }
            }
            TypeCargoWindow.RefreshWindow();
            CP.MainWindow.Activate();
            TypeCargoWindow.Activate();
            this?.Activate();
        }

        private void NewType_Load(object sender, EventArgs e)
        {
            if (IsEdit)
                name.Text = ChangingType.Name;
        }
    }
}
