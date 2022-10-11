using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WinFormsApp1
{
    internal abstract class Good
    {
        private double price;
        private string country;
        private string name;
        private string dateOfProd;
        private string describtion;

        public double Price { get => price; set => price = value; }
        public string Country { get => country; set => country = value; }
        public string Name { get => name; set => name = value; }
        public string DateOfProd { get => dateOfProd; set => dateOfProd = value; }
        public string Describtion { get => describtion; set => describtion = value; }

        public Good(double price, string country, string name, string dateOfProd, string describtion)
        {
            if (name == null) throw new ArgumentException("Name can not be empty");
            Price = price;
            Country = country;
            Name = name;
            DateOfProd = dateOfProd;
            Describtion = describtion;
        }
    }

    class Food : Good
    {
        private int expireDays;
        private int amount;
        private string unitOfMeature;

        public int ExpireDays { get => expireDays; set => expireDays = value; }
        public int Amount { get => amount; set => amount = value; }
        public string UnitOfMeature { get => unitOfMeature; set => unitOfMeature = value; }

        public Food(double price, string country, string name, string dateOfProd, string describtion, int expireDays, int amount, string unitOfMeature) :
            base(price, country, name, dateOfProd, describtion)
        {
            if (amount < 0) throw new ArgumentException("Amount should be positive");
            if (expireDays < 0) throw new ArgumentException("Expire days should be positive");
            this.expireDays = expireDays;
            this.amount = amount;
            this.unitOfMeature = unitOfMeature;
        }
    }

    class Book : Good
    {
        private int pagesCount;
        private string publisher;
        private string authers;

        public int PagesCount { get => pagesCount; set => pagesCount = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Authers { get => authers; set => authers = value; }

        public Book(double price, string country, string name, string dateOfProd, string describtion, int pages, string publisher, string authers) :
            base(price, country, name, dateOfProd, describtion)
        {
            if (pages < 0) throw new ArgumentException("Pages should be positive");
            this.pagesCount = pages;
            this.publisher = publisher;
            this.authers = authers;
        }
    }
}
