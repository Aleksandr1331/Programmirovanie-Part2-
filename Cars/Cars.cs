using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Car
    {
        readonly string Marka, Model, Name, LastName, SecondName, OutTextBox;
        readonly int YearsOfOut, YearsOfSTO;
        readonly List<int> Fines = new List<int>();
        readonly bool HasSecondName;

        public Car(string a, string b, string c, string d, string e, string f)
        {
            Marka = a; Model = b; Name = e; LastName = f;
            YearsOfOut = int.Parse(c); YearsOfSTO = int.Parse(d);
            OutTextBox = a + " " + YearsOfOut + " (" + f + " " + char.ToUpper(e[0]) + "." + ".)";
            HasSecondName = true;
        }

        public Car(string a, string b, string c, string d, string e, string f, string g) 
        {
            Marka = a; Model = b; Name = e; LastName = f; SecondName = g;
            YearsOfOut = int.Parse(c); YearsOfSTO = int.Parse(d);
            OutTextBox = a + " " + YearsOfOut + " (" + f + " " + char.ToUpper(e[0]) + "." + char.ToUpper(g[0]) + ".)";
            HasSecondName = false;
        }
        
        public string GetOutTextBox()
        {
            return OutTextBox;
        }

        public List<int> GetFines()
        {
            return Fines;
        }

        public void SetFines(int a)
        {
            Fines.Add(a);
        }

        public void TechInspection()
        {
            
        }

        public void IssueAFine()
        {

        }

        public void Sell()
        {

        }

        public string[] GetData()
        {
            return new string[5] { Marka, Model, Name + " " + LastName + " " + SecondName, YearsOfOut.ToString(), YearsOfSTO.ToString() };
        }

        public void PayFine()
        {

        }

    }
}
