using System;
using System.Collections.Generic;
using System.Text;

namespace HW_002_1
{
    public class Converter
    {
        public Converter(double usd, double eur, double rub)
        {
            this.Usd = usd;
            this.Eur = eur;
            this.Rub = rub;
        }
        public double Usd { get; set; }
        public double Eur { get; set; }
        public double Rub { get; set; }

        public double ConvertToUsd(double grn)
        {
            return grn / Usd;
        }
        public double ConvertToEur(double grn)
        {
            return grn / Eur;
        }
        public double ConvertToRub(double grn)
        {
            return grn / Rub;
        }
        public double UsdToGrivna(double usd)
        {
            return usd * Usd;
        }
        public double EurToGrivna(double eur)
        {
            return eur * Eur;
        }
        public double RubToGrivna(double rub)
        {
            return rub * Rub;
        }
    }
}
