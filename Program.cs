using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList list = new ArrayList();
                list.Add(4.5);
                list.Add(18);
                list.AddRange(new string[] { "Студент", "Петров" });

                ArrayList nList = new ArrayList();
                nList.Add(5);
                nList.Add(15);
                nList.Add(25);
                nList.Add(35);
                nList.Add(45);
                nList.Add(55);

                Console.Write("Введите индекс, для вставки новой коллекции: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                list.InsertRange(n1, nList);
                int n = n1 / 2;
                Console.Write("Введите кол-во элементов, для удаления из новой коллекции: ");
                int k = Convert.ToInt32(Console.ReadLine());
                nList.RemoveRange(n1, k);
                Console.WriteLine("Новая колелкция: ");
                foreach (var item in nList)
                {
                    Console.WriteLine(item);
                }
                Console.Read();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            

        }
    }
}
