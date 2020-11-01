using System;

namespace Задание13
{
    public abstract class Goods
    {
        protected string _name;
        protected string _manufacturers;//производитель/издательство
        protected double _price;
        protected int _age;
        protected int _Id;
        protected Goods(string name, string manufacture, double price, int age)
        {
            _name = name;
            _manufacturers = manufacture;
            _price = price;
            _age = age;
        }
        public abstract void info();
        public bool valid(int num)
        {
            if (num == _Id) return true;
            else return false;
        }
    }
    public class Toy : Goods
    {
        public Toy(string name, string manufacture, double price, int age) : base(name, manufacture, price, age)
        {
            _Id = 1;
        }
        public override void info()
        {
            Console.WriteLine($"ИГРУШКА\nНазвание: {_name}\nЦена: {_price}\nПроизводитель:{_manufacturers}\nВозраст, на который рассчитана:{_age}\n");
        }
    }
    public class Book : Goods
    {
        private string _autor;
        public Book(string name, string manufacture, string autor, double price, int age) : base(name, manufacture, price, age)
        {
            _Id = 2;
            _autor = autor;
        }
        public override void info()
        {
            Console.WriteLine($"КНИГА\nНазвание: {_name}\nЦена: {_price}\nАвтор: {_autor}\nИздатель:{_manufacturers}\nВозраст, на который рассчитана:{_age}\n");
        }
    }
    public class Sport : Goods
    {
        public Sport(string name, string manufacture, double price, int age) : base(name, manufacture, price, age)
        {
            _Id = 3;
        }
        public override void info()
        {
            Console.WriteLine($"СПОРТ-ТОВАР\nНазвание: {_name}\nЦена: {_price}\nПроизводитель:{_manufacturers}\nВозраст, на который рассчитана:{_age}\n");
        }
    }
}
