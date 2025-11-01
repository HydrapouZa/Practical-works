using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac12
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.Write("1) Calculator\n2) ProgramConfig\n3) ObjectCounter\n4) Book\n5) Settings\nВыберите задание для проверки (1-5): ");
            int.TryParse(Console.ReadLine(), out int task);
            switch (task)
            {
                case 1:
                    Console.WriteLine("Введите число а: ");
                    int.TryParse(Console.ReadLine(), out int a);
                    Console.WriteLine("Введите число б: ");
                    int.TryParse(Console.ReadLine(), out int b);
                    Console.Write("Выберите операцию (1.сложение 2.вычитание 3.деление 4.умножение): ");
                    int.TryParse(Console.ReadLine(), out int op);
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine(Calculator.Addition(a, b));
                            break;
                        case 2:
                            Console.WriteLine(Calculator.Substraction(a, b));
                            break;
                        case 3:
                            Console.WriteLine(Calculator.Division(a, b));
                            break;
                        case 4:
                            Console.WriteLine(Calculator.Multiplication(a, b));
                            break;
                    }
                    break;
                case 2:
                    ProgramConfig.ShowProgramInfo();
                    break;
                case 3:
                    ObjectCounter counter1 = new ObjectCounter();
                    ObjectCounter counter2 = new ObjectCounter();
                    ObjectCounter counter3 = new ObjectCounter();
                    ObjectCounter.COutObjectsCount();
                    break;
                case 4:
                    Book book = new Book(581035, "Война и мир", "Николай Васильевич Гоголь");
                    book.AutorName = "Лев Николаевич Толсой";
                    book.COutInfo();
                    break;
                case 5:
                    Settings.COutPath();
                    break;
            }
            Console.ReadKey();

        }
    }
}
