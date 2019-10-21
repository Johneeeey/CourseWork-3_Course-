using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void TablesDataGridViewInitialize()
        {
            TablesDataGridView.DataSource = FileClass.TableGrid();
            TablesDataGridView.Columns["TableNumber"].HeaderText = "Номер столика";
            TablesDataGridView.Columns["PlaceCount"].HeaderText = "Количество мест";
            TablesDataGridView.Columns["Color"].HeaderText = "Цвет";
            TablesDataGridView.Columns["FormFactor"].HeaderText = "Форма";
            TablesDataGridView.Columns["Material"].HeaderText = "Материал";
            TablesDataGridView.Columns["Status"].HeaderText = "Статус";
            TablesDataGridView.Columns["Owner"].HeaderText = "Клиент";
            TablesDataGridView.Columns["Image"].Visible = false;
        }

        private void TablesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetailsForm detailsForm = new DetailsForm(TablesDataGridView.CurrentRow.Cells[0].Value.ToString());
            detailsForm.ShowDialog();
            TablesDataGridViewInitialize();
        }

        private void buttonNewTable_Click(object sender, EventArgs e)
        {
            if (TablesDataGridView.Rows.Count > 0)
            {
                DetailsForm detailsForm = new DetailsForm(false);
                detailsForm.ShowDialog();
                TablesDataGridViewInitialize();
            }
            else
            {
                DetailsForm detailsForm = new DetailsForm(true);
                detailsForm.ShowDialog();
                TablesDataGridViewInitialize();
            }
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxAdr.Text = openFileDialog.FileName;
            }
        }

        private void buttonOpenFIle_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBoxAdr.Text.Trim()))
            {
                FileClass.FileAddress = textBoxAdr.Text.Trim();
                TablesDataGridViewInitialize();
            }
            else
            {
                textBoxAdr.Text = "Файл не найден";
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (TablesDataGridView.Rows.Count > 0)
                (TablesDataGridView.DataSource as DataView).RowFilter = String.Format("[TableNumber] LIKE '%{0}%'", textBoxSearch.Text.Trim());
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char temp = e.KeyChar;
            if (!Char.IsDigit(temp) && temp != 8)
                e.Handled = true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            TablesDataGridViewInitialize();
        }
    }
}
