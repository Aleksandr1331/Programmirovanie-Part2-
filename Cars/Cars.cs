using System.Collections.Generic;

namespace MyLibrary
{
    public class Car
    {
        readonly string Marka, Model;
        readonly int YearsOfOut;
        private int YearsOfTO;
        private string Owner, OutTextBox;
        readonly List<int> Fines = new List<int>();

        public Car(string a, string b, string c, string d, string e)
        {
            Marka = a; Model = b; Owner = e;
            YearsOfOut = int.Parse(c); YearsOfTO = int.Parse(d);
            OutTextBox = a + " " + YearsOfOut + " (" + e + ")";
        }
        
        public void SetOwner(string a)
        {
            Owner = a;
            SetOutTextBox();
        }

        public string GetOutTextBox()
        {
            return OutTextBox;
        }

        private void SetOutTextBox() 
        {
            OutTextBox = Marka + " " + YearsOfOut + " (" + Owner + ")";
        }

        public List<int> GetFines()
        {
            return Fines;
        }

        public void SetFines(int a)
        {
            Fines.Add(a);
        }

        public void SetYearofTO(int a)
        {
            YearsOfTO = a;
        }

        public int GetYearofTO()
        {
            return YearsOfTO;
        }

        public string[] GetData()
        {
            return new string[5] { Marka, Model, Owner, YearsOfOut.ToString(), YearsOfTO.ToString() };
        }

    }
}
