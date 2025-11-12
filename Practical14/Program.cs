using System;

namespace Pract14
{
    class Program
    {
        static void Main(string[] args)
        {
            Instrument[] band = { new Guitar(), new Drum(), new Instrument() };
            foreach (var i in band) i.Play();
            Message[] messages = { new Email(), new SMS(), new Message() };
            foreach (var m in messages) m.Send();
            Food[] lunch = { new Pizza(), new Burger(), new Food() };
            foreach (var f in lunch) f.Eat(); 
            Shape[] shapes = { new Circle(), new Triangle() };
            foreach (var s in shapes) Console.WriteLine(s.Draw());
            Player[] team = { new Warrior(), new Archer(), new Player() };
            foreach (var p in team) p.Attack();
            Console.ReadKey();
        }
    }

    // Задание 1

    class Instrument
    {
        public virtual void Play() => Console.WriteLine("Играет музыка...");
    }
    class Guitar : Instrument
    {
        public override void Play() => Console.WriteLine("Брень-брень!"); 
    }
    class Drum : Instrument
    {
        public override void Play() => Console.WriteLine("Бум-бум!");
    }

    // Задание 2

    class Message
    {
        public virtual void Send() => Console.WriteLine("Сообщение отправлено.");
    }
    class Email : Message
    {
        public override void Send() => Console.WriteLine("Email отправлен!");
    }
    class SMS : Message
    {
        public override void Send() => Console.WriteLine("SMS отправлено!");
    }

    // Задание 3

    class Food
    {
        public virtual void Eat() => Console.WriteLine("Едим...");
    }
    class Pizza : Food
    {
        public override void Eat() => Console.WriteLine("Едим пиццу!");
    }
    class Burger : Food
    {
        public override void Eat() => Console.WriteLine("Едим бургер!");
    }

    // Задание 4

    abstract class Shape
    {
        public abstract string Draw();
    }
    class Circle : Shape
    {
        public override string Draw() { return "Рисую круг"; }
    }
    class Triangle : Shape
    {
        public override string Draw() { return "Рисую треугольник"; }
    }

    // Задание 5

    class Player
    {
        public virtual void Attack() => Console.WriteLine("Атакую!");
    }
    class Warrior : Player
    {
        public override void Attack() => Console.WriteLine("Рублю мечом!");
    }
    class Archer : Player
    {
        public override void Attack() => Console.WriteLine("Стреляю из лука!");
    }
}
