using System;
namespace SalesWeb.Models
{
    public class Department
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Department(int id, String name)
        {
            Id = id;
            Name = name;
        }

        //public void addSeller(Seller seller) {}

        //public double totalSales(DateTime initial, DateTime final) {}
    }
}
