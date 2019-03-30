using System;
using System.Collections.Generic;
using System.Text;

namespace DivnaShoes.Models.ProductModel.Men_s_Shoes
{
    public class Sneakers : Product
    {
        static string name = "Sneakers";
        const decimal price = 200;
        static string brand = "New Balance";
        static string category = "Men";

        public Sneakers(int Size) : base(name, Size, price, brand,category)
        {
            list.Add(name);
        }
    }
}
