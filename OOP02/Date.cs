using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Date
    {
        #region attributes
        public int year;
        public int month;
        public int day;
        #endregion
        #region constructors
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
        #endregion
    }
}
