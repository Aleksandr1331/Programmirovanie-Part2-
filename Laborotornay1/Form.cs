using System;
using System.Collections.Generic;
using System.Linq;
using MyLibrary;
using System.Windows.Forms;
using static Lab1.Validator;
using System.IO;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public static List<Car> carCatalog = new List<Car>();
        public static int indexBox = -1;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Add("Марка");
            dataGridView.Rows.Add("Модель");
            dataGridView.Rows.Add("Владелец");
            dataGridView.Rows.Add("Год выпуска");
            dataGridView.Rows.Add("Год ТехОсмотра");
            CatalogComboBox.Text = "Выбирите автомобиль";

            carCatalog.Add(new Car("BMV", "x5", 2012, 2016, "Коробейников Геннадий Евгеньевич"));
            CatalogComboBox.Items.Add(carCatalog.Last().OutTextBox);

            carCatalog.Add(new Car("Tesla", "S", 2020, 2023, "Варпач Кирилл Ильич"));
            CatalogComboBox.Items.Add(carCatalog.Last().OutTextBox);
        }
                
        private void AddCar_Click(object sender, EventArgs e)
        {
            if (IsDataValid(YearsOfOutText.Text, YearsOfTOText.Text, ModelText.Text, 
                MarkaText.Text, OwnerText.Text, out string result))
            {
                carCatalog.Add(new Car(MarkaText.Text, ModelText.Text, int.Parse(YearsOfOutText.Text), 
                    int.Parse(YearsOfTOText.Text), OwnerText.Text));
                CatalogComboBox.Items.Add(carCatalog.Last().OutTextBox);

                MarkaText.Text = ModelText.Text = YearsOfOutText.Text = YearsOfTOText.Text = OwnerText.Text = string.Empty;
            }
            else MessageBox.Show(result);
        }
        
        private void CatalogComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBox = carCatalog.FindIndex(x => x.OutTextBox == Convert.ToString(CatalogComboBox.SelectedItem));

            for (int i = 0; i < 5; i++)
            {
                dataGridView.Rows[i].Cells[1].Value = carCatalog[indexBox].Data[i];
            }

            SelectFineComboBox.Items.Clear();
            SelectFineComboBox.Text = "Выбирите штраф";

            foreach (var a in carCatalog[indexBox].Fines)
            {
                SelectFineComboBox.Items.Add(a.ToString());
            }
        }

        private void GetFine_Click(object sender, EventArgs e)
        {
            if (IsCarSelected(CatalogComboBox.SelectedIndex, out string result))
            {
                if (FineTextBox.Text == "") MessageBox.Show("Вы не ввели размер штрафа", "Ошибка");
                else
                {
                    carCatalog[indexBox].Fines.Add(int.Parse(FineTextBox.Text));
                    SelectFineComboBox.Items.Add(FineTextBox.Text);
                    FineTextBox.Text = "";
                }
            }
            else MessageBox.Show(result);
        }


        private void ToPayFine_Click(object sender, EventArgs e)
        {
            if (SelectFineComboBox.SelectedIndex == -1) { MessageBox.Show("Вы не выбрали штраф", "Ошибка"); }
            else
            {
                MessageBox.Show("Штраф успешно заплачен", "Успех");
                SelectFineComboBox.Items.Remove(SelectFineComboBox.SelectedItem);
                SelectFineComboBox.Text = "Выбирите штраф";
            }
        }

        private void GoTechInspection_Click(object sender, EventArgs e)
        {
            if (IsCarSelected(CatalogComboBox.SelectedIndex, out string result2))
            {
                DialogResult result = MessageBox.Show("Прошёл ТехОсмотр?", "ТехОсмотр", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CarMessegeFunc settingsForm = new CarMessegeFunc("Введите год следующего ТО", "Год ТО", this);
                    settingsForm.Show();
                }
            }
            else MessageBox.Show(result2);
        }
        
        private void SellCar_Click(object sender, EventArgs e)
        {
            if (IsCarSelected(CatalogComboBox.SelectedIndex, out string result))
            {
                CarMessegeFunc settingsForm = new CarMessegeFunc("Введите ФИО нового владельца", "Смена владельца", this);
                settingsForm.Show();
            }
            else MessageBox.Show(result);
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
            ForbbidDigit(e);
            ForbbidSpace(e, MarkaText.Text);
        }

        private void OwnerText_KeyPress(object sender, KeyPressEventArgs e)
        {
            ForbbidDigit(e);
            ForbbidSpace(e, OwnerText.Text);
        }

        private void ModelText_KeyPress(object sender, KeyPressEventArgs e)
        {
            ForbbidSpace(e, ModelText.Text);
        }
    }
}