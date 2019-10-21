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
    public partial class DetailsForm : Form
    {
        private Table _table;
        public DetailsForm(string TableNum)
        {
            InitializeComponent();
            CenterToScreen();
            this._table = new Table(Int16.Parse(TableNum));
            FieldsFilling(this._table);
            ButtonSave.Click += SaveButton_ClickForSave;
            buttonRemove.Visible = true;
        }
        public DetailsForm(bool IsNewList)
        {
            InitializeComponent();
            CenterToScreen();
            buttonRemove.Visible = false;
            this._table = new Table();
            if (IsNewList) { TableNumTextBox.Text = "1"; }
            else
            {
                TableNumTextBox.Text = Convert.ToString(FileClass.GetNewElementNum() + 1);
            }
            comboBoxStatus.SelectedItem = "Свободен";
            textBoxOwnerName.Text = "NaN";
            ButtonSave.Click += SaveButton_ClickForAdd;
        }

        private void SaveButton_ClickForSave(object sender, EventArgs e)
        {
            if (!CheckFields())
            {
                string[] value = {TableNumTextBox.Text.Trim(),
                            PlaceCountTextBox.Text.Trim(),
                            comboBoxColor.SelectedItem.ToString(),
                            comboBoxForm.SelectedItem.ToString(),
                            comboBoxMaterial.SelectedItem.ToString(),
                            comboBoxStatus.SelectedItem.ToString(),
                            textBoxOwnerName.Text,
                            pictureBox.ImageLocation};
                Int16 _tableNum = Int16.Parse(TableNumTextBox.Text);
                FileClass.ChangeFile(_tableNum, value);
                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте корректность введеных данных", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private void SaveButton_ClickForAdd(object sender, EventArgs e)
        {
            if (!CheckFields())
            {
                /*Если создается абсолютно новый файл, то нужно его заранее создать*/
                if (FileClass.FileAddress == null)
                {
                    DialogResult result = saveFileDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        FileClass.FileAddress = saveFileDialog.FileName;
                        List<string> tempMas = new List<string>();
                        File.WriteAllLines(FileClass.FileAddress, tempMas);
                    }
                    else { return; }
                }
                this._table.TableNumber = Int16.Parse(TableNumTextBox.Text);
                this._table.NumberOfSeats = Int16.Parse(PlaceCountTextBox.Text.Trim());
                this._table.Color = comboBoxColor.SelectedItem.ToString();
                this._table.FormFactor = comboBoxForm.SelectedItem.ToString();
                this._table.Material = comboBoxMaterial.SelectedItem.ToString();
                this._table.Status = comboBoxStatus.SelectedItem.ToString();
                this._table.Owner = textBoxOwnerName.Text;
                FileClass.AddToFile(this._table);
                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте корректность введенных данных", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            FileClass.RemoveFromFile(this._table.TableNumber);
            this.Close();
        }

        private bool CheckFields()
        {
            if (PlaceCountTextBox.Text.Trim() == "")
            {
                 return true;
            }
            /*Если столик занят, то нужно знать кем*/
            if ((comboBoxStatus.SelectedItem.ToString() == "Занят") &&
                (textBoxOwnerName.Text.Trim() == "" || textBoxOwnerName.Text.Trim() == "NaN"))
                return true;
            /*Если столик свободен, полю всегда будет присаиваться значение NaN*/
            else if (comboBoxStatus.SelectedItem.ToString() == "Свободен")
                textBoxOwnerName.Text = "NaN";
            return false;
        }
        private void FieldsFilling(Table Table)
        {
            TableNumTextBox.Text = Table.TableNumber.ToString();
            PlaceCountTextBox.Text = Table.NumberOfSeats.ToString();
            comboBoxColor.SelectedItem = Table.Color;
            comboBoxForm.SelectedItem = Table.FormFactor;
            comboBoxMaterial.SelectedItem = Table.Material;
            comboBoxStatus.SelectedItem = Table.Status;
            textBoxOwnerName.Text = Table.Owner;
            pictureBox.ImageLocation = Table.ImagePath;
        }
        private void PlaceCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char placeCount = e.KeyChar;
            if (!Char.IsDigit(placeCount) && placeCount != 8)
                e.Handled = true;
        }
    }
}
