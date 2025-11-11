using System;

namespace Pract13
{
    class Task1
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Антон", "менеджер", 1000, "11.11.2025", 3);
            manager.HoldMeeting();
            Developer developer = new Developer("Вергилий", "разработчик", 2000, "16.06.2024", "C#");
            developer.WriteCode();
            Director director = new Director("Аркадий", "директор", 3000, "01.01.2015", "IT");
            director.ApproveBudget();
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Post { get; set; }
        public decimal Salary { get; set; }
        public string DateOfEmployment { get; set; }

        public Employee(string name, string post, decimal salary, string dateOfEmployment)
        {
            Name = name;
            Post = post;
            Salary = salary;
            DateOfEmployment = dateOfEmployment;
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, string post, decimal salary, string dateOfEmployment, int teamSize) : base(name, post, salary, dateOfEmployment)
        {
            Name = name;
            Post = post;
            Salary = salary;
            DateOfEmployment = dateOfEmployment;
            TeamSize = teamSize;
        }

        public void HoldMeeting()
        {
            Console.WriteLine($"{Name} провёл собрание с командой из {TeamSize} человек.");
        }
    }
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, string post, decimal salary, string dateOfEmployment, string programmingLanguage) : base(name, post, salary, dateOfEmployment)
        {
            Name = name;
            Post = post;
            Salary = salary;
            DateOfEmployment = dateOfEmployment;
            ProgrammingLanguage = programmingLanguage;
        }

        public void WriteCode()
        {
            Console.WriteLine($"{Name} написал код на {ProgrammingLanguage}.");
        }
    }
    public class Director : Employee
    {
        public string Department { get; set; }

        public Director(string name, string post, decimal salary, string dateOfEmployment, string department) : base(name, post, salary, dateOfEmployment)
        {
            Name = name;
            Post = post;
            Salary = salary;
            DateOfEmployment = dateOfEmployment;
            Department = department;
        }

        public void ApproveBudget()
        {
            Console.WriteLine($"{Name} утвердил бюджет для {Department}");
        }
    }
}
