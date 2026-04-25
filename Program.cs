using System;
using System.Reflection.PortableExecutable;
namespace Training1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            // Создаем объект класса Person и заполняем его данными
            // Person person = new Person();
            // person.name = Console.ReadLine();
            // person.age = int.Parse(Console.ReadLine());
            // person.Print();


            // Создаем объект класса Car и заполняем его данными
            // Car car1 = new Car();
            // car1.brand = Console.ReadLine(); 
            // car1.model = Console.ReadLine();
            // car1.year = int.Parse(Console.ReadLine());
            // car1.PrintInfo();

            // Car car2 = new Car();
            // car2.brand = Console.ReadLine(); 
            // car2.model = Console.ReadLine();
            // car2.year = int.Parse(Console.ReadLine());
            // car2.PrintInfo();


            // Внедренние массива объектов класса Book
            // Book[] books = new Book[3];
            // books[0]=new Book();
            // books[0].title = "Война и мир";
            // books[0].author = "Лев Толстой";
            // books[1]=new Book();
            // books[1].title = "Преступление и наказание";
            // books[1].author = "Федор Достоевский";
            // books[2]=new Book();
            // books[2].title = "Мастер и Маргарита";
            // books[2].author = "Михаил Булгаков";
            // for (int i = 0; i < books.Length; i++)
            // {
            //     books[i].Show();
            // }


            // Создаем объекты класса Student и выводим информацию
            // Student Ann = new Student("Alice", 85);
            // Ann.PrintInfo();
            // Student Bob = new Student("Bob", 90);
            // Bob.PrintInfo();
            // Student Charlie = new Student("Charlie", 78);
            // Charlie.PrintInfo();
            // Student.PrintTotal();

            // Car создание авто и подсчет авто
            // Car ford = new Car("mustang", 2019);
            // ford.Print();
            // Car cadilac = new Car("escolate", 2019);
            // cadilac.Print();
            // Car shevrole = new Car("camaro", 2019);
            // shevrole.Print();
            // Car.PrintTotal();

            // Product создание и подсчет продуктов 
            // Product mango = new Product("манго", 192);
            // mango.Print();
            // Product banana = new Product("банан", 52);
            // banana.Print();
            // Product.Printtotal();

            // Employee для закрепления тоже самое
            // Employee work1 = new Employee("Jonh", 2.3);
            // work1.Print();
            // Employee work2 = new Employee("Bob", 5.2);
            // work2.Print();
            // Employee.PrintTotal();

            // Smartphone для закрепления
            // Smartphone phone1 = new Smartphone("Iphone 15","iOS 17",128);
            // phone1.Print();
            // Smartphone phone2 = new Smartphone("Samsung S24","Android 14", 256);
            // phone2.Print();
            // Smartphone phone3 = new Smartphone("Xiaomi 14","HyperOS", 512);
            // phone3.Print();
            // Smartphone.printTotal();

            // Book опять повторение
            // Book book1 = new Book("Война и мир", "Толстой", 1869);
            // book1.Print();
            // Book book2 = new Book("Мастер и Маргарита","Булгаков");
            // book2.Print();
            // Book book3 = new Book();
            // book3.Print();
            // Book book4 = new Book("Азы програмированния","Столяров",2019);
            // book4.Print();
            // Book.TotalPrint();

            // Item использование this в полной мере
            // Item item1 = new Item("back", 323.43);
            // item1.Print();
            // Item item2 = new Item("table");
            // item2.Print();
            // Item item3 = new Item();
            // item3.Print();
            // Item.PrintInfo();

            // Product использование get and set
            // Product pr1 = new Product("Мышь", -12);
            // pr1.Print();

            // Person тренировка с get and set
            // Person pr1 = new Person("Иван",10);
            // pr1.Print();
            // System.Console.WriteLine($"Совершеннолетний: {pr1.IsAdult()}");

            // Book повторние тренировка
            // Book book1 = new Book("Война и мир", "Толстой");
            // book1.Print();
            // Book book2 = new Book("Мастер и Маргарита", "Булгаков");
            // book2.Print();
            // Book book3 = new Book();
            // book3.Print();

            // Animal с использованием наследования
            // Animal[] animals = new Animal[3];
            // Dog bud = new Dog("bud");
            // Cat whi = new Cat("whi");
            // Animal an = new Animal("Create");
            // animals[0] = bud;
            // animals[1] = whi;
            // animals[2] = an;
            // foreach (Animal el in animals)
            // el.Makesound();

            // Shape математическое вычесление площади круга или радиуса
            // System.Console.WriteLine("Вычисление площади");
            // Shape[] sh = new Shape[2];
            // System.Console.Write("Ввведите радиус для вычисления площади круга: ");
            // double n = double.Parse(Console.ReadLine());
            // sh[0] = new Circle(n);
            // System.Console.Write("Введи ширину для вычесления площади прямоугольника: ");
            // double a = double.Parse(Console.ReadLine());
            // System.Console.Write("Введи высоту для вычесления площади прямоугольника: ");
            // double b = double.Parse(Console.ReadLine());
            // sh[1] = new Rectangle(a,b);
            // foreach(Shape el in sh)
            // {
            //     System.Console.WriteLine($"Площадь: {el.GetArea():F2}");
            // }



            // Employee программа на добавление рабочих
            // List<Employee> employees = new List<Employee>();
            // int choice;
            // do
            // {
            // Console.WriteLine("1 - Добавить рабочего");
            // Console.WriteLine("2 - Добавить менеджера");
            // Console.WriteLine("0 - Выход");
            // Console.Write("Выбор действия: ");
            // choice = int.Parse(Console.ReadLine());
            // if (choice == 1)
            // {
            //     Console.Write("Введите имя рабочего: ");
            //     string name = Console.ReadLine();
            //     Console.Write("Введите ставку за час: ");
            //     double rate = double.Parse(Console.ReadLine());
            //     Console.Write("Введите отработанные часы: ");
            //     int hours = int.Parse(Console.ReadLine());
            //     employees.Add(new Worker(name, rate, hours));
            // }
            // else if (choice == 2)
            // {
            //     Console.Write("Введите имя менеджера: ");
            //     string name = Console.ReadLine();
            //     Console.Write("Введите базовую зарплату: ");
            //     double baseSalary = double.Parse(Console.ReadLine());
            //     Console.Write("Введите бонус: ");
            //     double bonus = double.Parse(Console.ReadLine());
            //     employees.Add(new Manager(name, baseSalary, bonus));
            // }
            // } while (choice != 0);
            // Console.WriteLine($"Всего сотрудников: {employees.Count}");
            // foreach (var emp in employees)
            // {
            // Console.WriteLine($"{emp.name}: {emp.GetSalary()} руб.");}


            // Instrument легая практика наследования
            // Instrument[] inst1 =new Instrument[1];
            // inst1[0] = new Piano();
            // foreach (Instrument el in inst1)
            // {
            //     el.Play();
            // }


            // Vehicle выбор машины с опр характеристикой
            // Vehicle[] auto = new Vehicle[2];
            // auto[0] = new Car("Ford",1999,4);
            // auto[1] = new Truck("Cuber",2021,33);
            // foreach(Vehicle el in auto)
            // {
            //     el.Info();
            // }

            // Transport наследование задание
            // Transport[] tr = new Transport[1];
            // tr[0] = new Bike("model", 21,42);
            // foreach(Transport el in tr)
            // {
            //     el.Show();
            // }



            // Динамический массив list<int> 
            // List<int> num = new List<int>();
            // int n;
            // do
            // {
            //     System.Console.WriteLine("Введите любое число, 0 завершит цикл");
            //     n=int.Parse(Console.ReadLine());
            //     if (n !=0){num.Add(n);}
            // } while(n != 0);
            // Console.Write("Числа: ");
            // foreach (int el in num)
            // Console.Write(el + " ");
            // Console.WriteLine();
            // int sum = 0;
            // foreach (int el in num)
            // sum += el;
            // Console.WriteLine($"Сумма: {sum}");
            // Console.WriteLine($"Количество: {num.Count}");



            // Задание 2 с динамическим массивом ввод, добавление и вывод
            // List<int> number = new List<int>();
            // int n;
            // do
            // {
            //     System.Console.Write("Enter number, 0 - stop: ");
            //     n=int.Parse(Console.ReadLine());
            //     if (n != 0)
            //     {
            //         number.Add(n);
            //     }
            // } while (n != 0);
            // int res = 0;
            // foreach(var el in number)
            // {
            //     System.Console.Write(el + " ");
            // }
            // foreach(var el in number)
            // {
            //     res += el;          
            // }
            // System.Console.WriteLine();
            // System.Console.WriteLine($"Number in array: {number.Count}");
            // System.Console.WriteLine($"Summa={res}");


            // Задание 3 с динамическим массивом удаление и вставка
            // List<string> fruct = new List<string>();
            // fruct.Add("яблоко");
            // fruct.Add("банан");
            // fruct.Add("вишня");
            // fruct.Add("дыня");
            // fruct.Remove("банан");
            // fruct.Insert(1,"апельсин");
            // fruct[fruct.Count - 1] = "арбуз";
            // Console.WriteLine(string.Join(", ", fruct));


            // Сложное задание с динамическим массивом
            // List<int> number = new List<int>();
            // int n;
            // do
            // {
            //     System.Console.Write("Введите числа (0 для окончания): ");
            //     n =int.Parse(Console.ReadLine());
            //     if (n !=0)
            //     {
            //         number.Add(n);
            //     }
            // } while(n!=0);
            // int a;
            // int res;
            // do
            // {
            //     System.Console.WriteLine();
            //     System.Console.WriteLine("1 - Вывести список");
            //     System.Console.WriteLine("2 - Удалить все чётные числа");
            //     System.Console.WriteLine("3 - Найти максимальное и минимальное");
            //     System.Console.WriteLine("4 - Отсортировать по возрастанию");
            //     System.Console.WriteLine("0 - Выход");
            //     a = int.Parse(Console.ReadLine());
            //     if (a == 1)
            //     {
            //         System.Console.Write("Список: ");
            //         foreach(int el in number)
            //         {
            //             System.Console.Write(el + " ");
            //         }
            //     }
            //     if (a == 2)
            //     {
            //         List<int> oddNumbers = new List<int>();
            //         foreach (int el in number)
            //         {
            //             if (el % 2 != 0) 
            //             {
            //                 oddNumbers.Add(el);
            //             }
            //         } 
            //         Console.Write("Чётные числа удалены. Список: ");
            //         foreach (int el in oddNumbers)
            //         {
            //             Console.Write(el + " ");
            //         }
            //     }
            //     if (a == 3)
            //     {
            //         int max = number[0];
            //         int min = number[0];
            //         foreach (int el in number)
            //         {
            //             if (el > max)
            //             {
            //                 max=el;
            //             }
            //             if (el < min)
            //             {
            //                 min=el;
            //             }
            //         }
            //         System.Console.WriteLine($"Максимальное значение: {max}");
            //         System.Console.WriteLine($"Минимальное значение: {min}");
            //     }
            //     if (a== 4)
            //     {
            //         number.Sort();
            //         System.Console.Write("Список: ");
            //         foreach(int el in number)
            //             {
            //                 System.Console.Write(el + " ");
            //             }
            //     }
            // } while(a!=0);


            // Is as задание на проверку знаний и закрепление 
            // List<Animal> an= new List<Animal>();
            // an.Add(new Dog("Bob"));
            // an.Add(new Cat("Meika"));
            // an.Add(new Animal("хз"));
            // foreach(Animal obj in an)
            // {
            //     Dog dog = obj as Dog;
            //     if(dog != null)
            //     {
            //         Console.WriteLine("Это собака");
            //         obj.Makesound();
            //     }
            //     else if(obj is Cat)
            //     {
            //         obj.Makesound();
            //     } else
            //     {
            //         obj.Makesound();
            //     }
            // }


            // Задание на повторение List<>
            // List<Device> d1 = new List<Device>();
            // d1.Add(new Laptop("apple",16));
            // d1.Add(new Smartphone("sunsung",6.1));
            // foreach(var el in d1)
            // {
            //     el.Show();
            // }


            // Задание от claude
            // List<Animal> an = new List<Animal>();
            // an.Add(new Dog("Бобик", 4));
            // an.Add(new Cat("Барсик",3));
            // foreach(Animal el in an)
            // {
            //     el.Makesound();
            // }


            // Абстракция 
            // List<Vehicle> tr = new List<Vehicle>();
            // tr.Add(new Car("Ford",120));
            // tr.Add(new Boat("Medusa",60));
            // tr.Add(new Plane("Arflout",320));
            // foreach(Vehicle el in tr)
            // {
            //     el.GetInfo();
            //     el.Move();
            // }


            // Интерфейс
            // List<ISwithcable> gad = new List<ISwithcable>();
            // gad.Add(new Laptop("Ipad"));
            // gad.Add(new Phone("Apple"));
            // gad.Add(new Lamp("Lamp"));
            // foreach(ISwithcable el in gad)
            // {
            //     el.TurnOn();
            //     if (el is IChargeable chargeable)
            //     {
            //         chargeable.Charge();
            //     }
            // }


            // калькулятор мини
            int n;
            int a;
            int b;
            int c;
            double d;
            double g;
            string str1;
            string str2;
            Calculator calc = new Calculator();
            do
            {
                System.Console.WriteLine("Выберите действие");
                System.Console.WriteLine("1=Два int — возвращает сумму");
                System.Console.WriteLine("2=Два double — возвращает сумму");
                System.Console.WriteLine("3=Три int — возвращает сумму всех трёх");
                System.Console.WriteLine("4=Два string — возвращает склеенную строку");
                System.Console.Write("0=Выход");
                n= int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    System.Console.WriteLine("Введите два int числа");
                    System.Console.Write("Первое: ");
                    a = int.Parse(Console.ReadLine());
                    System.Console.Write("Второе: ");
                    b = int.Parse(Console.ReadLine());
                    calc.Calculate(a,b);
                } else if (n == 2)
                {
                    System.Console.WriteLine("Введите два double числа");
                    System.Console.Write("Первое: ");
                    d = double.Parse(Console.ReadLine());
                    System.Console.Write("Второе: ");
                    g = double.Parse(Console.ReadLine());
                    calc.Calculate(d,g);
                } else if (n == 3)
                {
                     System.Console.WriteLine("Введите три int числа");
                    System.Console.Write("Первое: ");
                    a = int.Parse(Console.ReadLine());
                    System.Console.Write("Второе: ");
                    b = int.Parse(Console.ReadLine());
                    System.Console.Write("третье: ");
                    c = int.Parse(Console.ReadLine());
                    calc.Calculate(a,b,c);
                } else if (n == 4)
                {
                    System.Console.WriteLine("Введите два string");
                    System.Console.Write("Первое: ");
                    str1 = Console.ReadLine();
                    System.Console.Write("Второе: ");
                    str2 = Console.ReadLine();
                    calc.Calculate(str1,str2);
                }
                
            } while(n!=0);
            System.Console.WriteLine("Программа закончена, спасибо!");
        }

    }
}
