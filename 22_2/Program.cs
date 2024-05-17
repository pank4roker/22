using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_2
{
    class Program
    {
        public struct NateBook
        {
            public string model;
            public string manufacturer;
            public double price;
            public NateBook(string model, string manufacturer, double price)
            {
                this.model = model;
                this.manufacturer = manufacturer;
                this.price = price;
            }
            public void OutPut()
            {
                Console.WriteLine($"Модель: {model};Производитель: {manufacturer};Цена: {price}$");
            }
           
        }
        static void Main(string[] args)
        {
            NateBook book = new NateBook("Iphone SE", "Apple", 450);
            book.OutPut();
            Console.ReadKey();
        }
    }
}
