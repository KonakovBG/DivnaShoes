using System;
using System.Collections.Generic;
using System.Text;

namespace DivnaShoes.Models.ProductModel.Women_s_shoes
{
    public class Platform : Product
    {
        static string name = "Platform";
        const decimal price = 520;
        static string brand = "Marc Fischer";

        public Platform(int Size) : base(name, Size, price, brand)
        {
        }
    }
}
