using System;
using System.Collections.Generic;
using System.Text;

namespace DivnaShoes.Models.ProductModel.Men_s_Shoes
{
    public class Trainers : Product
    {
        static string name = "Trainers";
        const decimal price = 140;
        static string brand = "Nike";
        static string category = "Men";

        public Trainers(int Size) : base(name, Size, price, brand,category)
        {
            list.Add(name);
        }
    }
}
