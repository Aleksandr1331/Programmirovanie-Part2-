using MyLibrary;
using System.IO;
using Lab1;
using Xunit.Sdk;

namespace Lab1.Tests
{
    public class UnitTest
    {
        [Fact]
        public void AddCar()
        {
            string expectedResult = "������ 1980";

            string actualResult = new Car("������", "S", 1980, 1982, "�������� ������ ����������").OutTextBox;

            Assert.Contains(expectedResult, actualResult);
        }

        [Fact]
        public void IsDataRight()
        {
            bool actualResult = Validator.IsDataValid("2023", "2024", "sub2", "sub", "�������� ������ ����������", out _);

            Assert.True(actualResult);
        }

        [Fact]
        public void IsCarNotSelect()
        {
            int a = 2;
            bool actualResult = Validator.IsCarSelected(a, out _);

            Assert.False(!actualResult);
        }

        [Fact]
        public void Lists()
        {
            List<int> expectedResult = new() { 123, 46449, -89, 5480 };

            Car a = new("������", "S", 1982, 1982, "�������� ������ ����������");
            Validator.AddFineForTest(123, a); Validator.AddFineForTest(46449, a);
            Validator.AddFineForTest(-89, a); Validator.AddFineForTest(5480, a);
            List<int> actualResult = a.Fines;


            Assert.Equal(actualResult, expectedResult);
        }

        [Fact]
        public void Gek8()
            {
            List<Car> a = new()
            {
                new("������", "S", 1982, 1982, "�������� ������ ����������")
            };

            Assert.NotEmpty(a);
            }
        //not ������ �����
    }
}
