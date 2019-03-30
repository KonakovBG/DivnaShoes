using System;
using System.Collections.Generic;
using System.Text;

namespace DivnaShoes.Models.ProductModel.Women_s_shoes
{
    public class Mules : Product
    {
        static string name = "Mules";
        const decimal price = 425;
        static string brand = "Tory Burch";
        static string category = "Women";

        public Mules(int Size) : base(name, Size, price, brand,category)
        {
            list.Add(name);
        }
    }
}
