using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Stuff
    {
        public int Price { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string ProductionDate { get; set; }
        public string Description { get; set; }

        public Stuff(int price, string country, string name, string productionDate, string description)
        {
            Price = price;
            Country = country;
            Name = name;
            ProductionDate = productionDate;
            Description = description;
        }
    }

    public class Goods : Stuff
    {
        private readonly string _expiryDate;
        private readonly double _quantity;
        private readonly string _unit;

        public Goods(int price, string country, string name, string productionDate,
            string description, string expiryDate, double quantity, string unit) : base(price, country, name, productionDate, description)
        {
            _expiryDate = expiryDate;
            _quantity = quantity;
            _unit = unit;
        }
    }

    public class Book : Stuff
    {
        private readonly int _pageNumber;
        private readonly string _publisher;
        private readonly string _author;

        public Book(int price, string country, string name, string productionDate, string description,
            int pageNumber, string publisher, string author) : base(price, country, name, productionDate, description)
        {
            _pageNumber = pageNumber;
            _publisher = publisher;
            _author = author;
        }


    }
}
