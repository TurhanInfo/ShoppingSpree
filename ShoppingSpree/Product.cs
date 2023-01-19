using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Trim()=="")
                {
                    throw new Exception("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                if (value<0)
                {
                    throw new Exception("Money cannot be negative");
                }
                this.cost = value;
            }
        }
        public Product(string name,decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
