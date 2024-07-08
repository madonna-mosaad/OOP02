using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.inheretance
{
    internal class Parent
    {
        #region attributes
        protected private int x; //private in this class 
                                 //private in Parent's child (in same project)
                                 //not inhereted in Parent's child (in different project)
        protected int y;//private in this class 
                        //private in Parent's child (in same project)
                        //private in Parent's child (in different project)
        protected internal int z;//internal in this class 
                                 //internal in Parent's child (in same project)
                                 //private inhereted in Parent's child (in different project)
        #endregion
        #region constructors
        public Parent(int x, int y, int z)
        {
            this.x = x; this.y = y; this.z = z;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Parent :{x} {y} {z}";
        }
        #endregion
    }
}
