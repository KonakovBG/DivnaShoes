using DivnaShoes.Models.ProductModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DivnaShoes.Models.CartModel
{
    public class Cart
    {
        public List<Product> products;
        public decimal sum = 0;

        public Cart()
        {
            products = new List<Product>();
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Remove(Product product)
        {
            IfExists(product);
            products.Remove(product);
        }

        public decimal FinalPrice()
        {
            sum = 0;
            foreach (var item in products)
            {
                sum += item.Price;
            }
            return sum;

        }

        public bool IfExists(Product product)
        {
            bool flag = false;

            if (products.Contains(product))
            {
                flag = true;
            }
            else
            {
                throw new ArgumentException("The product does not exist");
            }

            return flag;
        }

        public void Print()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Your cart is empty!");
                Console.WriteLine("---------------------------------");

            }
            foreach (var item in products)
            {
                Console.WriteLine(item.Name + " - " + item.Price);
            }
            Console.WriteLine("---------------------------------");
        }




    }
}
