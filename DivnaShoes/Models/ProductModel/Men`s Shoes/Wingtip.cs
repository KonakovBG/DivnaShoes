﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DivnaShoes.Models.ProductModel.Men_s_Shoes
{
    public class Wingtip : Product
    {
        static string name = "Wingtip";
        const decimal price = 150;
        static string brand = "";
        static string category = "Men";

        public Wingtip(int Size ) : base(name, Size, price, brand,category)
        {
            list.Add(name);
        }
    }
}
