using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Converter
    {
        private decimal _usdToUah;
        private decimal _euroToUah;

        public Converter(decimal usdToUah, decimal euroToUah)
        {
            _usdToUah = usdToUah;
            _euroToUah = euroToUah;
        }

        public decimal ConvertUsdToUah(decimal uah)
        {
            return uah * _usdToUah;
        }

        public decimal ConvertEuroToUah(decimal uah)
        {
            return uah * _euroToUah;
        }

        public decimal ConvertUahToEuro(decimal euro)
        {
            if (euro == 0)
            {
                return 0;
            }
            else
            {
                return euro / _euroToUah;
            }
        }

        public decimal ConvertUahToUsd(decimal usd)
        {
            if (usd == 0)
            {
                return 0;
            }
            else
            {
                return usd / _usdToUah;
            }
        }
    }
}
