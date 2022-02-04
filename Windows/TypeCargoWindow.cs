using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace АИС
{
    public partial class TypeCargoWindow : Form
    {
        public TypeCargoWindow()
        {
            InitializeComponent();
        }

        private void TypeCargoWindow_Load(object sender, EventArgs e)
        {

            RefreshWindow();
            if (CP.CurrentUser.RoleId == 1)
            {
                add.Visible = false;
                delete.Visible = false;
            }
        }
        public void RefreshWindow()
        {
            Refresh();
            List<TypeCargo> typeListShow = CP.Context.TypeCargos.FromSqlRaw("select TypeCargo.TypeCargoId, TypeCargo.Name from TypeCargo").ToList();

            BindingSource binding = new BindingSource();
            binding.DataSource = typeListShow;

            dataGridView1.DataSource = binding;
            bindingNavigator1.BindingSource = binding;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Тип груза";
            if (dataGridView1.RowCount == 0)
            {
                delete.Enabled = false;
                edit.Enabled = false;
            }
            else
            {
                delete.Enabled = true;
                edit.Enabled = true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            NewType newType = new NewType(this);
            newType.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show("Удалить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                CP.Context.Database.ExecuteSqlInterpolated($"delete from TypeCargo where TypeCargoId = {id}");
                RefreshWindow();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            TypeCargo type = CP.Context.TypeCargos.FromSqlRaw($"select TypeCargo.TypeCargoId, TypeCargo.Name from TypeCargo where TypeCargoId = {dataGridView1.SelectedRows[0].Cells[0].Value}").First();
            NewType newtype = new NewType(true, type, this);
            newtype.Show();
        }
    }
}