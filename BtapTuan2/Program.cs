using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtapTuan2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> StudentsList = new List<Student>
            {
                
                new Student(1, "Huynh Tuan Vu", 19),
                new Student(2, "Chung Quoc An", 17),
                new Student(3, "Nguyen An Khang", 15),
                new Student(4, "Le Duy Vu", 18),
                new Student(5, "Tran Trong Tan", 16)
            };
            
            bool exit =false;
            while (!exit) {
                Console.WriteLine("======================Menu=====================");
                Console.WriteLine("1. In danh sach hoc sinh.");
                Console.WriteLine("2. In danh sach hoc sinh co tuoi tu 15 den 18.");
                Console.WriteLine("3. In hoc sinh co ten bat dau bang chu 'A'.");
                Console.WriteLine("4. Tong tuoi cua tat ca hoc sinh trong danh sach.");
                Console.WriteLine("5. Hoc sinh lon tuoi nhat trong danh sach.");
                Console.WriteLine("6. In danh sach hoc sinh co tuoi tang dan.");
                Console.WriteLine("0. Thoat.");
                Console.WriteLine("================================================");
                Console.WriteLine();
                Console.Write("Vui long chon so: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Danh sach hoc sinh: ");
                        StudentsList.ForEach(Student => Console.WriteLine(Student));
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("Danh sach hoc sinh co tuoi tu 15 den 18: ");
                        var tuoi = StudentsList.Where( s => s.Age >= 15 && s.Age <= 18);
                        foreach (var student in tuoi) 
                        { 
                            Console.WriteLine(student); 
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        var tenA = StudentsList.Where(s => s.Name.Split(' ')
                        .Last().StartsWith("A",StringComparison.OrdinalIgnoreCase));
                        Console.WriteLine("Hoc sinh co ten bat dau bang chu 'A':");
                        foreach (var student in tenA)
                        {
                            Console.WriteLine(student);
                        }
                        Console.WriteLine();
                        break;
                        case "4":
                            var SumAge= StudentsList.Sum(s => s.Age);
                            Console.WriteLine($"Tong tuoi cua tat ca hoc sinh trong danh sach: {SumAge}");
                        Console.WriteLine();
                        break;
                        case "5":
                            var OldAge = StudentsList.OrderByDescending(s => s.Age).FirstOrDefault();
                            Console.WriteLine("Hoc sinh co tuoi lon nhat: ");
                        Console.WriteLine($"{OldAge}");
                        Console.WriteLine();
                        break;
                        case "6":
                        var SortAge = StudentsList.OrderBy(s => s.Age).ToList();
                            Console.WriteLine("Danh sach hoc sinh co tuoi tang dan:");
                            SortAge.ForEach(s => Console.WriteLine(s));
                        Console.WriteLine();
                        break;

                    case "0": 
                        exit = true;
                        Console.WriteLine("Ket thuc chuong trinh.");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Khong hop le");
                        break;

                }
            }

        }
    }
}
