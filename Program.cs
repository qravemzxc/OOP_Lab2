using Lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Lifetime;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static Bus obj1 = new Bus();
        static Bus obj2 = new Bus("Иванов Иван Иванович", "2005TE-7", 1523123, "bmw", 1990, "200000км");
        static Bus obj3 = new Bus("Иванов Иван Иванович");
        static Bus obj4 = new Bus();
        static Bus obj5 = new Bus("Сидоров Иван Иванович", "21034", numberOfObject);

        public readonly int id1 = obj1.GetHashCode();
        public readonly int id2 = obj2.GetHashCode();
        public readonly int id3 = obj3.GetHashCode();
        public readonly int id4 = obj4.GetHashCode();
        public readonly int id5 = obj5.GetHashCode();

        static int numberOfObject = 5;
        static void infAboutObj()
        {
            Console.WriteLine(obj1);
        }

        static void Main()
        {
         
            Console.WriteLine($"Вызов закрытого конструктора:{obj5}");

            void Sum(ref int f, ref int s, out int result)
            {
                result = f + s;
            }
            int numb;
            int firstNumber = 10;
            int secondNumber = 20;
            Sum(ref firstNumber, ref secondNumber, out numb);
            Console.WriteLine($"Вывод результата ref- и out- параметров:{numb}");

            void AgeOfBus(int year,out int res)
            {
                res = 2022 - year;
               
            }
            int num;
            AgeOfBus(obj1.yearOfExploitation,out num);
            Console.WriteLine($"Возраст автобуса:{num}");
        

            Bus[] array = { obj1, obj2, obj3 };
            Console.Write("Список автобусов:");
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i].yearOfExploitation == 1990)
                    Console.Write($"{array[i].brand} ");

            }
            Console.WriteLine();
            Console.Write("Список автобусов:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].yearOfExploitation<1990)
                    Console.Write($"{array[i].brand} ");

            }
            Console.WriteLine();

            var user = new { Name = "Tom", Age = 30 };
            Console.WriteLine($"Анонимный тип:{user.Name}");
        }
        
    }
    class Bus
    {
        public string fio;                                                                                                                                                       
        public string numberOfBus;
        public int numberOfRoute;
        public string brand;
        public int yearOfExploitation;
        public string mileage;
        const double PI = 3.14;

        public Bus()
        {
            fio = "Иванов Иван Иванович";
            numberOfBus = "2005TE-7";
            numberOfRoute = 1523123;
            brand = "audi";
            yearOfExploitation = 1980;
            mileage = "200000км";
        }

        public Bus(string fio, string numberOfBus, int numberOfRoute, string brand, int yearOfExploitation, string mileage)
        {
            this.fio = fio;
            this.numberOfBus = numberOfBus;
            this.numberOfRoute = numberOfRoute;
            this.brand = brand;
            this.yearOfExploitation = yearOfExploitation;
            this.mileage = mileage;
        }

        public Bus(string fio, string numberOfBus = "2005TE-7", int numberOfRoute = 1523123, string brand = "toyota", int yearOfExploitation = 1990)
        {
            this.fio = fio;
            this.numberOfBus = numberOfBus;
            this.numberOfRoute = numberOfRoute;
            this.brand = brand;
            this.yearOfExploitation = yearOfExploitation;
    
        }

        static Bus()
        {
            string fio = "Иванов Иван Иванович";
            string numberOfBus = "2005TE-7";
            int numberOfRoute = 1523123;
        }

        private Bus(string f, string nob, int noo)
        {
            fio = f;
            numberOfBus = nob;
            noo++;
        }

        public string Fio
        {
            get
            {   
                return fio;

            }
            set
            {
                fio = value;
            }
        }

        public string NumberOfBus
        {
            get
            {
                return numberOfBus;

            }
            set
            {
                numberOfBus = value;
            }
        }

        public int NumberOfRoute
        {
            get
            {
                return numberOfRoute;

            }
            set
            {
                numberOfRoute= value;
            }
        }

        public string Brand
        {
            get
            {
                return brand;

            }
            set
            {
                brand = value;
            }
        }

        public int YearOfExploitation
        {
            get
            {
                return yearOfExploitation;

            }
            set
            {
                yearOfExploitation = value;
            }
        }

        public string Mileage
        {
            get
            {
                return mileage;

            }
            private set
            {
                mileage = value;
            }
        }

        partial class BUS
        {
            public void Drive()
            {
                Console.WriteLine("I'm driving");
            }
        }

        
    }
 }
