using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtis_Exchange
{
    public static class Exchanger
    {

        // US Dollar Exchange Methods
        public static double UsdtoGbp(double value)
        {
            return Math.Round(value / .72523, 2);
        }
        public static double UsdtoCan(double value)
        {
            return Math.Round(value / 1.25427, 2);
        }
        public static double UsdtoEur(double value)
        {
            return Math.Round(value / .83572, 2);
        }

        // British Pound Exchange Methods
        public static double GbptoUsd(double value)
        {
            return Math.Round(value / 1.37887, 2);
        }
        public static double GbptoCan(double value)
        {
            return Math.Round(value / 1.72947, 2);
        }
        public static double GbptoEur(double value)
        {
            return Math.Round(value / 1.15195, 2);
        }

        // Canadian Dollar Exchange Methods
        public static double CantoUsd(double value)
        {
            return Math.Round(value / .79728, 2);
        }
        public static double CantoGbp(double value)
        {
            return Math.Round(value / .57848, 2);
        }
        public static double CantoEur(double value)
        {
            return Math.Round(value / 1.15195, 2);
        }

        // Euro Exchange Methods
        public static double EurtoUsd(double value)
        {
            return Math.Round(value / 1.19648, 2);
        }
        public static double EurtoGbp(double value)
        {
            return Math.Round(value / .86826, 2);
        }
        public static double EurtoCan(double value)
        {
            return Math.Round(value / 1.50040, 2);
        }
    }
}
