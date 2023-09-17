using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laborotornay1
{
    public partial class Form : System.Windows.Forms.Form
    {
        readonly List<Car> CarCatalog = new List<Car>();
        int IndexBox = 0;

        public Form() 
        {
            InitializeComponent();
            dataGridView.Rows.Add("Марка");
            dataGridView.Rows.Add("Модель");
            dataGridView.Rows.Add("Владелец");
            dataGridView.Rows.Add("Год выпуска");
            dataGridView.Rows.Add("Год СТО");




            CarCatalog.Add(new Car("BMV", "x5", "2012", "2016", "Геннадий", "Коробейников", "Евгеньевич"));
            CatalogComboBox.Items.Add(CarCatalog.Last().GetOutTextBox());

            CarCatalog.Add(new Car("Tesla", "S", "2020", "2023", "Кирилл", "Варпач", "Ильич"));
            CatalogComboBox.Items.Add(CarCatalog.Last().GetOutTextBox());
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            try
            {
                bool TryCatch = true;
                if (Int32.Parse(YearsOfSTOText.Text) > 2023) { MessageBox.Show("Год СТО не может быть больше текущего года"); TryCatch = false; }
                if (Int32.Parse(YearsOfOutText.Text) > 2023) { MessageBox.Show("Год выпуска машины не может быть больше текущего года"); TryCatch = false; }

                if (TryCatch)
                {
                    CarCatalog.Add(new Car(MarkaText.Text, ModelText.Text, YearsOfOutText.Text, YearsOfSTOText.Text, NameText.Text, LastNameText.Text, SecondNameText.Text));
                    CatalogComboBox.Items.Add(CarCatalog.Last().GetOutTextBox());

                    MarkaText.Text = null; ModelText.Text = null; YearsOfOutText.Text = null; YearsOfSTOText.Text = null;
                    NameText.Text = null; LastNameText.Text = null; SecondNameText.Text = null;
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

            foreach (var a in CarCatalog[IndexBox].GetFines())
            {
                SelectFineComboBox.Items.Add(a.ToString());
            }
        }

        private void FineTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            InputDigit(e, number);
        }

        private void YearsOfOutText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            InputDigit(e, number);
        }

        private void YearsOfSTOText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            InputDigit(e, number);
        }

        private void InputDigit(KeyPressEventArgs e, char number)
        {
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
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
    }
}
// var item in CatalogComboBox.Items