using MyLibrary;
using System;
using System.Security;
using System.Windows.Forms;

namespace Lab1
{
    public static class Validator
    {
        

        public static void InputDigit(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public static void ForbbidSpace(KeyPressEventArgs e, string b)
        {
            if (b.Length == 0)
                if (e.KeyChar == (int)Keys.Space) e.Handled = true;
        }

        public static void ForbbidDigit(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) return;
            e.Handled = true;
        }

        public static bool IsCarSelected(int indexComboBox, out string result)
        {
            result = string.Empty;
            if (indexComboBox == -1)
            {
                result = "Ошибка, не выбрана машинаОшибка";
                return false;
            }
            return true;
        }

        public static bool IsDataValid(string yearOut, string yearTO, string model,
            string marka, string owner, out string result)
        {
            result = string.Empty;

            if (yearOut == string.Empty || yearTO == string.Empty || model == string.Empty || 
                marka == string.Empty || owner == string.Empty)
            {
                result = "Неверно введёнs данные";
                return false;
            }

            int YearOut = int.Parse(yearOut);
            int YearTO = int.Parse(yearTO);

            if (YearOut > 2023)
            {
                result = "Год выпуска машины не может быть больше текущего года";
                return false;
            }
            if (YearTO < YearOut)
            {
                result = "Год ТехОсмотра не может быть меньше даты выпуска машины";
                return false;
            }
            return true;
        }

        //Специально для ЮнитТеста. Работает также, как и функция штрафов, но может вызываться в коде
        //Для проверки записи штрафов
        public static void AddFineForTest(int fineAmount, Car automobile)
        {
            automobile.Fines.Add(fineAmount);
        }
    }
}