using System.Windows.Forms;
using static Lab1.Validator;

namespace Lab1
{
    public partial class CarMessegeFunc : Form
    {
        readonly bool ItsTO;
        readonly Form1 form1 = new Form1();

        public CarMessegeFunc(string label, string formText, Form1 form1)
        {
            InitializeComponent();
            MessageLabel.Text = label;
            Text = formText;
            this.form1 = form1;
            

            if (formText == "Год ТО")
            {
                ItsTO = true;
                MessageTextBox.MaxLength = 4;
                LeftButton.Text = "OK";
                RightButton.Text = "Отменить";
            }
            else
            {
                ItsTO = false;
                LeftButton.Text = "Продать";
                RightButton.Text = "Утиль";
            }
        }

        private void MessageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ItsTO) InputDigit(e);
            if (!ItsTO)
            {
                ForbbidDigit(e);
                ForbbidSpace(e, MessageTextBox.Text);
            }
        }

        private void LeftButton_Click(object sender, System.EventArgs e)
        {
            if (MessageTextBox.Text == "") MessageBox.Show("Пустое поле ввода", "Ошибка ввода");
            else
            {
                if (ItsTO)
                {
                    if (int.Parse(MessageTextBox.Text) <= Form1.carCatalog[Form1.indexBox].YearOfTO)
                    {
                        MessageTextBox.Text = "";
                        MessageBox.Show("Год технического осмотра должен быть больше года получения автомобиля", "Ошибка ввода");
                    }
                    else
                    {
                        Form1.carCatalog[Form1.indexBox].YearOfTO = int.Parse(MessageTextBox.Text);
                        form1.dataGridView.Rows[2].Cells[1].Value = Form1.carCatalog[Form1.indexBox].Data[2];
                    }
                }
                else
                {
                    Form1.carCatalog[Form1.indexBox].Owner = MessageTextBox.Text;
                    form1.dataGridView.Rows[4].Cells[1].Value = Form1.carCatalog[Form1.indexBox].Data[4];
                    form1.CatalogComboBox.Items[form1.CatalogComboBox.SelectedIndex] = Form1.carCatalog[Form1.indexBox].OutTextBox;

                }
            }
            Close();
        }

        private void RightButton_Click(object sender, System.EventArgs e)
        {
            if (!ItsTO)
            {
                form1.CatalogComboBox.Items.Remove(Form1.carCatalog[Form1.indexBox].OutTextBox);
                form1.CatalogComboBox.Text = "Выбирите автомобиль";
                form1.SelectFineComboBox.Items.Clear();
                form1.SelectFineComboBox.Text = "Выбирите штраф";
                
                for (int i = 0; i < 5; i++)
                {
                    form1.dataGridView.Rows[i].Cells[1].Value = "";
                }

                Form1.carCatalog.RemoveAt(Form1.indexBox);
            }
            Close();
        }
    }
}