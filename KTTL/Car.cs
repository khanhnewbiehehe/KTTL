using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTTL
{
    class Car : Vehicle
    {
        private int numberOfSeats;

        public Car()
        {
        }
        public Car(int numberOfSeats)
        {
            this.numberOfSeats = numberOfSeats;
        }
        public Car(String flatTable , String brand, string modal, double price, int yearOfManufacture, int numberOfSeats) : base(flatTable ,brand, modal, price, yearOfManufacture)
        {
            this.numberOfSeats = numberOfSeats;
        }

        public int NumberOfSeats { get => numberOfSeats; set => numberOfSeats = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("So cho ngoi: ");
            numberOfSeats = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So cho ngoi: " + numberOfSeats);
        }
    }
}
