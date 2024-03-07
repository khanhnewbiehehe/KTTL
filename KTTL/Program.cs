using System;

namespace KTTL
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("=====BAI TAP LINQ=====");
                Console.WriteLine("1. Car");
                Console.WriteLine("2. Truck");
                Console.WriteLine("0. Thoat");
                choice = int.Parse(Console.ReadLine());
                List<Vehicle> list = new List<Vehicle>();
                Vehicle vehicle;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("=====NHAP DU LIEU=====");
                        Console.WriteLine("Nhap so luong xe: ");
                        n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {   
                            Console.WriteLine((i+1)+".");
                            vehicle = new Car();
                            vehicle.Nhap();
                            list.Add(vehicle);
                        }
                        Console.WriteLine("=====DANH SACH XE======");
                        foreach (Vehicle v in list)
                        {
                            Console.WriteLine(list.IndexOf(v) + 1);
                            v.Xuat();
                        }
                        while (choice != 4)
                        {
                            Console.WriteLine("=====TRUY VAN DU LIEU=====");
                            Console.WriteLine("1. Hien thi cac xe co gia trong khoang 100.000 den 250.000");
                            Console.WriteLine("2. Cac xe co nam san xuat > 1990");
                            Console.WriteLine("3. Gom cac xe theo hang san xuat, tinh tong gia tri theo nhom");
                            Console.WriteLine("4. Thoat");
                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    var list1 = from car in list where car.Price >= 100000 && car.Price <= 250000 select car;
                                    Console.WriteLine("Ket qua: ");
                                    foreach (var car in list1)
                                    {
                                        Console.WriteLine(car.Brand + " " + car.Modal + " - " + car.Price);
                                    }
                                    break;
                                case 2:
                                    var list2 = from car in list where car.YearOfManufacture > 1990 select car;
                                    Console.WriteLine("Ket qua: ");
                                    foreach (var car in list2)
                                    {
                                        Console.WriteLine($"{car.Brand} {car.Modal} - {car.YearOfManufacture}");  
                                    }
                                    break;
                                case 3:
                                    var groupedByBrand = list.GroupBy(v => v.Brand);
                                    Console.WriteLine("Ket qua: ");
                                    foreach (var group in groupedByBrand)
                                    {
                                        Console.WriteLine("Hang xe: " + group.Key);
                                        double totalValue = 0;
                                        foreach (var car in group)
                                        {
                                            Console.WriteLine($"{car.Brand} {car.Modal} - {car.YearOfManufacture}");
                                            totalValue += car.Price;
                                        }
                                        Console.WriteLine("Tong gia tri: " + totalValue);
                                    }
                                    break;

                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("=====NHAP DU LIEU=====");
                        Console.WriteLine("Nhap so luong xe: ");
                        n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine((i + 1) + ".");
                            vehicle = new Truck();
                            vehicle.Nhap();
                            list.Add(vehicle);
                        }
                        Console.WriteLine("=====DANH SACH XE======");
                        foreach (Vehicle v in list)
                        {
                            Console.WriteLine(list.IndexOf(v) + 1);
                            v.Xuat();
                        }
                        while(choice != 3)
                        {
                            Console.WriteLine("=====TRUY VAN DU LIEU=====");
                            Console.WriteLine("1. Hien thi danh sach Truck theo thu tu nam san xuat moi nhat");
                            Console.WriteLine("2. Hien thi ten cong ty chu quan cua Truck");
                            Console.WriteLine("3. Thoat");
                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    var sortedTrucksByYear = from truck in list
                                                             orderby truck.YearOfManufacture descending
                                                             select truck;

                                    Console.WriteLine("Ket qua:");
                                    foreach (var truck in sortedTrucksByYear)
                                    {
                                        Console.WriteLine($"{truck.Brand} {truck.Modal} - {truck.YearOfManufacture}");
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Nhap bien so xe cua xe tai: ");
                                    string truckFlatTable = Console.ReadLine();

                                    var truckft = (from truck in list.OfType<Truck>()
                                                            where truck.FlatTable == truckFlatTable
                                                            select truck).FirstOrDefault();

                                    Console.WriteLine("Ket qua:");
                                    if (truckft != null)
                                    {
                                        Console.WriteLine($"Cong ty chu quan : {truckft.Company}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Khong co du lieu!");
                                    }
                                    break;
                            }
                        }
                        break;
                }
            }
            
        }
    }
}