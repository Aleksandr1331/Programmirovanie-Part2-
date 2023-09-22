using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MyLibrary;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;
using System.Windows.Forms;

namespace Laborotornay1
{
    public partial class Form1 : Form
    {
        readonly List<Car> CarCatalog = new List<Car>();
        private int IndexBox = 0;

        public Form1()
        {
            InitializeComponent();
            dataGridView.Rows.Add("Марка");
            dataGridView.Rows.Add("Модель");
            dataGridView.Rows.Add("Владелец");
            dataGridView.Rows.Add("Год выпуска");
            dataGridView.Rows.Add("Год ТехОсмотра");
            CatalogComboBox.Text = "Выбирите автомобиль";

            CarCatalog.Add(new Car("BMV", "x5", "2012", "2016", "Геннадий Коробейников Евгеньевич"));
            CatalogComboBox.Items.Add(CarCatalog.Last().GetOutTextBox());

            CarCatalog.Add(new Car("Tesla", "S", "2020", "2023", "Кирилл Варпач Ильич"));
            CatalogComboBox.Items.Add(CarCatalog.Last().GetOutTextBox());
        }

        private DialogResult ShowInputDialog(string InputBoxText, string TextBox, string ButtonOkText, string ButtonCanselText, bool ItsTO)
        {
            Size size = new Size(200, 90);
            Form inputBox = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ClientSize = size,
                Text = InputBoxText
            };
            
            Label label = new Label
            {
                Size = new Size(size.Width, 23),
                Location = new Point(5, 10),
                Text = TextBox
            };
            inputBox.Controls.Add(label);

            TextBox textBox = new TextBox
            {
                Size = new Size(size.Width - 10, 30),
                Location = new Point(5, 35),
                Text = ""
            };
            inputBox.Controls.Add(textBox);
            textBox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

            Button okButton = new Button
            {
                DialogResult = DialogResult.OK,
                Name = "okButton",
                Size = new Size(75, 23),
                Text = ButtonOkText,
                Location = new Point(size.Width - 80 - 80, 62)
            };
            inputBox.Controls.Add(okButton);
            okButton.Click += new EventHandler(okButton_Click);

            Button cancelButton = new Button
            {
                DialogResult = DialogResult.Cancel,
                Name = "cancelButton",
                Size = new Size(75, 23),
                Text = ButtonCanselText,
                Location = new Point(size.Width - 80, 62)
            };
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            if (ItsTO) textBox.MaxLength = 4;
            else textBox.MaxLength = 40;

            void textBox_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (ItsTO) InputDigit(e);
                if (!ItsTO) ForbitSpace(e, textBox.Text);
            }

            void okButton_Click(object sender, EventArgs e)
            {
                if (textBox.Text == "") MessageBox.Show("Пустое поле ввода", "Ошибка ввода");
                else
                {
                    if (ItsTO)
                    {
                        if (int.Parse(textBox.Text) <= CarCatalog[IndexBox].GetYearofTO())
                        {
                            textBox.Text = "";
                            MessageBox.Show("Год технического осмотра должен быть больше года получения автомобиля", "Ошибка ввода");
                        }
                        else
                        {
                            CarCatalog[IndexBox].SetYearofTO(int.Parse(textBox.Text));
                        }
                    }
                    else
                    {
                        CarCatalog[IndexBox].SetOwner(textBox.Text);
                    }
                }
                
            }
            DialogResult result = inputBox.ShowDialog();
            return result;
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            try
            {
                bool TryCatch = true;
                if (Int32.Parse(YearsOfSTOText.Text) < Int32.Parse(YearsOfOutText.Text)) { MessageBox.Show("Год ТехОсмотра не может быть меньше даты выпуска машины"); TryCatch = false; }
                if (Int32.Parse(YearsOfOutText.Text) > 2023) { MessageBox.Show("Год выпуска машины не может быть больше текущего года"); TryCatch = false; }

                if (TryCatch)
                {
                    CarCatalog.Add(new Car(MarkaText.Text, ModelText.Text, YearsOfOutText.Text, YearsOfSTOText.Text, OwnerText.Text));

                    CatalogComboBox.Items.Add(CarCatalog.Last().GetOutTextBox());

                    MarkaText.Text = null; ModelText.Text = null; YearsOfOutText.Text = null; YearsOfSTOText.Text = null; OwnerText.Text = null;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Заполнены не все окна ввода", "Неверный формат");
            }
        }

        private void CatalogComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexBox = CarCatalog.FindIndex(x => x.GetOutTextBox() == Convert.ToString(CatalogComboBox.SelectedItem));
            for (int i = 0; i < 5; i++)
            {
                dataGridView.Rows[i].Cells[1].Value = CarCatalog[IndexBox].GetData()[i];
            }

            SelectFineComboBox.Items.Clear();
            SelectFineComboBox.Text = "Выбирите штраф";

            foreach (var a in CarCatalog[IndexBox].GetFines())
            {
                SelectFineComboBox.Items.Add(a.ToString());
            }
        }

        private void FineTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputDigit(e);
        }

        private void YearsOfOutText_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputDigit(e);
        }

        private void YearsOfSTOText_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputDigit(e);
        }

        private void MarkaText_KeyPress(object sender, KeyPressEventArgs e)
        {
            ForbitDigit(e);
            ForbitSpace(e, MarkaText.Text);
        }

        private void OwnerText_KeyPress(object sender, KeyPressEventArgs e)
        {
            ForbitDigit(e);
            ForbitSpace(e, OwnerText.Text);
        }

        private void ModelText_KeyPress(object sender, KeyPressEventArgs e)
        {
            ForbitSpace(e, ModelText.Text);
        }

        private void InputDigit(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void ForbitSpace(KeyPressEventArgs e, string b)
        {
            if (b.Length == 0)
                if (e.KeyChar == (int)Keys.Space) e.Handled = true;
        }

        private void ForbitDigit(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void GetFine_Click(object sender, EventArgs e)
        {
            if (CatalogComboBox.SelectedIndex == -1) MessageBox.Show("Не выбрана машина", "^&!$&@!!");
            else
            {
                if (FineTextBox.Text == "") MessageBox.Show("Вы не ввели размер штрафа", "Ошибка!!!Больше так не делай");
                else
                {
                    CarCatalog[IndexBox].SetFines(Int32.Parse(FineTextBox.Text));
                    SelectFineComboBox.Items.Add(FineTextBox.Text);
                    FineTextBox.Text = "";
                }
            }

        }

        private void ToPayFine_Click(object sender, EventArgs e)
        {
            if (SelectFineComboBox.SelectedIndex == -1) { MessageBox.Show("Вы не выбрали штраффф", "Ошибка!!"); }
            else
            {
                MessageBox.Show($"Штраф успешно заплачен\r\n-{SelectFineComboBox.SelectedItem} рублей у тебя с карточки", "Успех");
                SelectFineComboBox.Items.Remove(SelectFineComboBox.SelectedItem);
                SelectFineComboBox.Text = "Выбирите штраф";
            }
        }

        private void GoTechInspection_Click(object sender, EventArgs e)
        {
            if (CatalogComboBox.SelectedIndex == -1) MessageBox.Show("Не выбрана машина", "^&!$&@!!");
            else
            {
                DialogResult result = MessageBox.Show("Прошёл ТехОсмотр?", "ТехОсмотр", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DialogResult result2 = ShowInputDialog("ТО", "Напишите год следующего ТО", "OK", "Cancel", true);

                    if (result2 == DialogResult.OK)
                    {
                        CarCatalog[IndexBox].SetYearofTO(CarCatalog[IndexBox].GetYearofTO());
                        dataGridView.Rows[4].Cells[1].Value = CarCatalog[IndexBox].GetYearofTO();
                    }
                }
                else if (result == DialogResult.No)
                {
                    CarCatalog[IndexBox].SetYearofTO(-1);
                    dataGridView.Rows[4].Cells[1].Value = -1;
                }
            }
        }

        private void SellCar_Click(object sender, EventArgs e)
        {
            if (CatalogComboBox.SelectedIndex == -1) MessageBox.Show("Не выбрана машина", "^&!$&@!!");
            else
            {
                DialogResult result2 = ShowInputDialog("", "Введите ФИО нового владельца", "Продать", "Утиль", false);
                if (result2 == DialogResult.OK)
                { 
                    dataGridView.Rows[2].Cells[1].Value = CarCatalog[IndexBox].GetData()[2];
                    CatalogComboBox.Items[CatalogComboBox.SelectedIndex] = CarCatalog[IndexBox].GetOutTextBox();
                }

                else if (result2 == DialogResult.Cancel)
                {
                    CatalogComboBox.Items.Remove(CarCatalog[IndexBox].GetOutTextBox());
                    CatalogComboBox.Text = "Выбирите автомобиль";
                    SelectFineComboBox.Items.Clear();
                    SelectFineComboBox.Text = "Выбирите штраф";
                    for (int i = 0; i < 5; i++)
                    {
                        dataGridView.Rows[i].Cells[1].Value = "";
                    }

                    CarCatalog.RemoveAt(IndexBox);
                }
            }
        }
    }
}