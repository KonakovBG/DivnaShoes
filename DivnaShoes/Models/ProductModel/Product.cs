﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DivnaShoes.Models.ProductModel
{
    public class Product
    {
        public string name;
        public int size;
        public decimal price;
        public string brand { get; set; }
        public string category;
        public List<string> list = new List<string>();

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (name == null)
                {
                    throw new InvalidOperationException("The Product name cannnot be null");
                }
                this.name = value;
            }

        }

        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (size <= 0)
                {
                    throw new InvalidOperationException("The Product size cannot be 0 or below");
                }
                this.size = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (price < 0)
                {
                    throw new InvalidOperationException("The Price cannot be negative number");
                }
                this.price = value;
            }

        }

        public string Category
        {
            get
            {
                return this.category;
            }
            set
            {
                this.category = value;
            }
        }
      

        public Product(string Name, int Size, decimal Price,string Brand,string Category)
        {
            this.name = Name;
            this.size = Size;
            this.price = Price;
            this.brand = Brand;
            this.category = Category;

        }
    }
}
