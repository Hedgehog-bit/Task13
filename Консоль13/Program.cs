using System;
using System.IO;
using System.Collections.Generic;

namespace Задание13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\\egora\Desktop\tovar.txt"; ;
                List<Goods> collection = new List<Goods>();
                string[] all_lines = File.ReadAllLines(path);
                for (int i = 0; i < all_lines.Length; i++)
                {
                    string[] current_position = all_lines[i].Split(';');
                    if (Convert.ToInt32(current_position[0]) == 1)
                    {
                        Toy toy = new Toy(current_position[1], current_position[2], Convert.ToDouble(current_position[3]), Convert.ToInt32(current_position[4]));
                        collection.Add(toy);
                    }
                    if (Convert.ToInt32(current_position[0]) == 2)
                    {
                        Book book = new Book(current_position[1], current_position[2], current_position[3], Convert.ToDouble(current_position[4]), Convert.ToInt32(current_position[5]));
                        collection.Add(book);
                    }
                    if (Convert.ToInt32(current_position[0]) == 3)
                    {
                        Sport sport = new Sport(current_position[1], current_position[2], Convert.ToDouble(current_position[3]), Convert.ToInt32(current_position[4]));
                        collection.Add(sport);
                    }
                }
                foreach (Goods var in collection)
                    var.info();
                Console.Write("Введите номер категории (1 - игрушка, 2 - книга, 3 - спорт-товар): "); int des = Convert.ToInt32(Console.ReadLine());
                if (des > 3 && des < 1) throw new Exception("Некорректный ввод");
                List<Goods> search = new List<Goods>();
                foreach (Goods var in collection)
                {
                    if (var.valid(des)) search.Add(var);
                }
                Console.WriteLine("Результат поиска по категории: ");
                foreach (Goods var in search)
                    var.info();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
