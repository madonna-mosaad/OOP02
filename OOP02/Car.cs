using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Car
    {
        #region attributes
        private int id;
        private string model;
        private double speed;

        #endregion
        #region properties
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"{id} : {model} : {speed}";
        }
        #endregion
        #region constructors
        public Car(int _id,string _model ,double _speed)
        {
            id = _id ;
            model = _model ;
            speed = _speed ;
        }
        //constructor chain
        public Car(int _id,string _model) : this(_id, _model, 122)
        {
        }
        #endregion
    }
}
