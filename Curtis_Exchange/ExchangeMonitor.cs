using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtis_Exchange
{
    public class ExchangeMonitor
    {
        private int _count = 0;
        private double _total;
       public int TransactionCount(int value)
        {
            _count = _count + value;
            return _count;
        } 
        public double TransactionTotal(double value)
        {
            _total = _total + value;
            return _total;
        }
    }
}
