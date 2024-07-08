using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal struct PhoneBook
    {
        #region attributes
        string[] names;
        long[] numbers;
        int size;
        #endregion
        #region Constructors
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        #endregion
        #region properties
        public int Size { get { return size; } }
        #endregion
        #region Methods
        public void AddPerson(int pos , string name , long num)
        {
            if (names != null && numbers !=null) 
            {
                if (pos >= 0 && pos < numbers.Length)
                {
                    names[pos] = name;
                    numbers[pos] = num;
                }
            }

        }
        #endregion
        #region indexer
        public long this[string name]
        {
            get 
            {
                if (names != null)
                {
                    for (int i = 0; i < names.Length; i++) 
                    {
                        if (name == names[i])
                        {
                            return numbers[i];
                        }
                    }
                    
                }
                return -1;
            }
            set
            {
                if(names != null)
                {
                    for (int i = 0; i < names.Length; i++) 
                    {
                        if (name == names[i]) 
                        { 
                            numbers[i] = value;
                            return;
                        }
                    }
                }
            }
        }
        #endregion

    }
}
