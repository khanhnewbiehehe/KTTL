using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTTL
{
    abstract class Vehicle
    {
        protected String flatTable;
        protected String brand;
        protected String modal;
        protected Double price;
        protected int yearOfManufacture;

        protected Vehicle()
        {
        }
        protected Vehicle( String flatTable,String brand, String modal, double price, int yearOfManufacture)
        {
            this.flatTable = flatTable;
            this.brand = brand;
            this.Modal = modal;
            this.price = price;
            this.yearOfManufacture = yearOfManufacture;
        }

        public string Brand { get => brand; set => brand = value; }
        public double Price { get => price; set => price = value; }
        public int YearOfManufacture { get => yearOfManufacture; set => yearOfManufacture = value; }
        public string Modal { get => modal; set => modal = value; }
        public string FlatTable { get => flatTable; set => flatTable = value; }

        public virtual void Nhap()
        {
            Console.WriteLine("Bien so: ");
            flatTable = Console.ReadLine();
            Console.WriteLine("Hang xe: ");
            brand = Console.ReadLine();
            Console.WriteLine("Mau xe: ");
            modal = Console.ReadLine();
            Console.WriteLine("Gia xe: ");
            price = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nam san xuat: ");
            yearOfManufacture = int.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Bien so: " + flatTable);
            Console.WriteLine("Hang xe: " + brand);
            Console.WriteLine("Mau xe: " + modal);
            Console.WriteLine("Gia xe: " + price);
            Console.WriteLine("Nam san xuat: " +  yearOfManufacture);
        }
        
    }
}
