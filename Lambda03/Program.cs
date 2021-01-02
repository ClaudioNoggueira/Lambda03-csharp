using Lambda03.Entities;
using System;
using System.Collections.Generic;

namespace Lambda03 {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Action<Product> action = p => { p.Price += p.Price * 0.1; };

            list.ForEach(action);
            foreach (Product item in list) {
                Console.WriteLine(item);
            }
        }
    }
}
