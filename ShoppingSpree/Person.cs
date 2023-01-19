using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public List<Product> Bag
        {
            get
            {
                return this.bag;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Trim() == "")
                {
                    throw new Exception("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.bag.Add(product);
                Console.WriteLine($"{this.Name} bought {product.Name}");
                this.Money -= product.Cost;
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
            
        }
        public override string ToString()
        {
            if (this.bag.Count == 0)
            {
                return this.Name + " - Nothing bought";
            }
            else
            {
                return this.Name + " - " + string.Join(", ", this.Bag);
            }
        }
    }
}
