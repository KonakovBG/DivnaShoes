using System;
using System.Collections.Generic;
using System.Text;

namespace DivnaShoes.Models.ProductModel.Women_s_shoes
{
    public class Pumps : Product
    {
        static string name = "Pumps";
        const decimal price = 990;
        static string brand = "Valentino GARAVANI";

        public Pumps(int Size) : base(name, Size, price, brand)
        {
        }
    }
}
