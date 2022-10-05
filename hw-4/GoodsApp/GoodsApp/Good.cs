using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GoodsApp
{
    class Good
    {
        protected double _price;
        protected string _country;
        protected string _name;
        protected string _dateOfProd;
        protected string _describtion;

        public Good(double price, string country, string name, string dateOfProd, string describtion)
        {
            _price = price;
            _country = country;
            _name = name;
            _dateOfProd = dateOfProd;
            _describtion = describtion;
        }
    } 

    class Products: Good
    {
        private int _expireDays;
        private int _amount;
        private string _unitOfMeature;
        public Products(double price, string country, string name, string dateOfProd, string describtion, int expireDays, int amount, string unitOfMeature):
            base(price, country, name, dateOfProd, describtion)
        {
            _expireDays = expireDays;
            _amount = amount;
            _unitOfMeature = unitOfMeature;
        }


    }

    class Book : Good
    {
        private int _pagesCount;
        private string _publisher;
        private string _authers;

        public Book (double price, string country, string name, string dateOfProd, string describtion, int pages, string publisher, string authers) :
            base(price, country, name, dateOfProd, describtion)
        {
            _pagesCount = pages;
            _publisher = publisher;
            _authers = _authers;
        }
    }
}
