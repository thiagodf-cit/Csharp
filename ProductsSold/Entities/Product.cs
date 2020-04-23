using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsSold.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Quant { get; set; }

        public Product()
        {
        }

        public Product(string name, double value, int quant)
        {
            Name = name;
            Value = value;
            Quant = quant;
        }

        public double Total(double value, int quant)
        {
            return value * quant;
        }
    }
}
