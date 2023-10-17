using System.Collections.Generic;

namespace MyLibrary
{
    public class Car
    {
        readonly string marka, model;
        readonly int yearsOfOut;
        private int yearsOfTO;
        private string owner, outTextBox;
        readonly List<int> fines = new List<int>();

        public Car(string marka, string model, int yearsOfOut, int yearsOfTO, string owner)
        {
            this.marka = marka; this.model = model; this.owner = owner;
            this.yearsOfOut = yearsOfOut; this.yearsOfTO = yearsOfTO;
            outTextBox = marka + " " + yearsOfOut + " (" + owner + ")";
        }

        public int YearsofOut
        {
            get { return yearsOfOut; }
        }

        public string Owner
        {
            set { owner = value; SetOutTextBox(); }
        }

        public string OutTextBox
        {
            get { return outTextBox; }
        }

        public List<int> Fines
        {
            get { return fines; }
        }

        public int YearOfTO
        {
            set { yearsOfTO = value; SetOutTextBox(); }
            get { return yearsOfTO; }
        }

        public string[] Data
        {
            get { return new string[5] { marka, model, owner, yearsOfOut.ToString(), yearsOfTO.ToString() }; }
        }

        private void SetOutTextBox()
        {
            outTextBox = marka + " " + yearsOfOut + " (" + owner + ")";
        }
    }
}
