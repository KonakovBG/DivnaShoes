using System;
using System.Collections.Generic;
using System.Text;

namespace DivnaShoes.Models.ProductModel.Men_s_Shoes
{
    public class Hiking : Product
    {
        static string name = "Hiking";
        const decimal price = 300;
        static string brand = "Timberland";
        static string category = "Men";

        public Hiking(int Size) : base(name, Size, price, brand,category)
        {
            list.Add(name);
        }
    }
}
