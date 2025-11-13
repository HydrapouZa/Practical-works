using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Color(255, 128, 0);
            var c2 = c1;
            c2.R = 100;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine();

            var order1 = new Order(1001, 1500.50m);
            var order2 = order1;
            order2.Total = 2000.00m;
            Console.WriteLine(order1.Total);

            var f = new File{Permissions = FileAccess.Read | FileAccess.Write};
            Console.WriteLine(f.CanRead());
            Console.WriteLine(f.CanWrite());

            var w1 = new Weather { City = "Moscow", Temperature = 22.5 };
            var w2 = new Weather { City = "Sochi", Temperature = null };
            Console.WriteLine(w1);
            Console.WriteLine(w2);
            Console.WriteLine(w2.Temperature ??  -999);
        }

    }

    //Задание 1

    struct Color
    {
        private int r;
        private int g;
        private int b;
        public int R
        { 
            set 
            {  
                r = value; 
                if(value < 0) r = 0; 
                else if(value > 255) r = 255; 
            } 
            get {return r;} 
        }
        public int G { set {  g = value; if(value < 0) g = 0; else if(value > 255) g = 255; } get {return g;} }
        public int B { set {  b = value; if(value < 0) b = 0; else if(value > 255) b = 255; } get {return b;} }
        

        public Color(int _r, int _g, int _b)
        {
            r = 0; g = 0; b = 0; R = _r; G = _g; B = _b; 
        }
        public override string ToString() { return $"RGB({R}, {G}, {B})"; }
    }

    //Задание 2

    class Order
    {
        public int ID;
        public decimal Total;
        public Order(int _ID, decimal _Total)
        {
            ID = _ID;
            Total = _Total;
        }
    }

    //Задание 3

    [Flags] enum FileAccess {None, Read, Write, Execute}

    struct File
    {
        public FileAccess Permissions;

        public bool CanRead()
        {
            if(Permissions == FileAccess.Read) return true;
            else return false;
        }
        public bool CanWrite()
        {
            if (Permissions == FileAccess.Write) return true;
            else return false;
        }
    }

    // Задание 4

    struct Weather
    {
        public string City;
        public double? Temperature;

        public override string ToString()
        {
            var t = Temperature ?? "";
            return $"{City} {Temperature ?? 0}"; 
        }
    }

    // Задание 5

    enum EmployeeStatus { Active, OnLieave, Terminated}
    class Employee
    {
        public string Name;
        public DateTime? HireDate;
        public EmployeeStatus Status;

        public int GetYearsWorked()
        {

            return DateTime.Now.Year - HireDate.Year;
        }
    }
}
