using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityDemo
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override bool Equals(object obj)

        {
            Customer c = obj as Customer; // (Customer)obj return this.Id == c.Id;
            return this.Id == c.Id;
        }
    }
}