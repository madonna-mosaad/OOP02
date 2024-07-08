using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.inheretance
{
    internal class Child : Parent
    {
        #region constructors
        public Child(int _x,int _y,int _z):base(_x,_y,_z) { }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Child: {x} {y} {z}";
        }
        #endregion
    }
}
