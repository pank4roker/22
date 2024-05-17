using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_3
{
    public struct Book
    {
        public string name;
        public string fio;
        public int yearofpublication;
        public int countpages;
        public Book(string name, string fio, int yearofpublication, int countpages)
        {
            this.name = name;
            this.fio = fio;
            this.yearofpublication = yearofpublication;
            this.countpages = countpages;
        }
        public void OutPut()
        {
            Console.WriteLine($"{name};{fio};{yearofpublication};{countpages}");
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> list = new List<Book>();
            Console.Write("Введите какое колиество книг вы хотите ввести: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                list.Add(InPut());
                Console.WriteLine();
            }
            Console.WriteLine("\tСписок книг:");
            foreach(Book book in list)
            {
                book.OutPut();
            }
            Console.ReadLine();
          
        }
        static Book InPut()
        {
            Console.Write("Введите название книги: ");
            string name = Console.ReadLine();
            Console.Write("Введите ФИО автора (Фамилия И.О.): ");
            string fio = Console.ReadLine();
            Console.Write("Введите год издания: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество страниц книги: ");
            int countpages = Convert.ToInt32(Console.ReadLine());
            return new Book(name,fio,year,countpages);
        }
    }
}
