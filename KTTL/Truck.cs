using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTTL
{
    class Truck:Vehicle 
    {
        private Double loadCapacity;
        private String company;
        public Truck()
        {
        }

        public Truck(double loadCapacity, String company)
        {
            this.loadCapacity = loadCapacity;
            this.Company = company;
        }

        public Truck(String flatTable, String brand, string modal, double price, int yearOfManufacture, double loadCapacity, String company) : base(flatTable ,brand, modal, price, yearOfManufacture)
        {
            this.loadCapacity = loadCapacity;
            this.Company = company;
        }

        public double LoadCapacity { get => loadCapacity; set => loadCapacity = value; }
        public string Company { get => company; set => company = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Trong tai (tan): ");
            loadCapacity = Double.Parse(Console.ReadLine());
            Console.WriteLine("Cong ty chu quan: ");
            company = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Trong tai (tan): " +  loadCapacity);
            Console.WriteLine("Cong ty chu quan: " + company);
        }
    }
}
