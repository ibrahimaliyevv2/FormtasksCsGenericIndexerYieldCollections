using System;
using System.Collections.Generic;
using System.Text;

namespace MyListTask
{
    class MyList<T>
    {
        private T[] arr = new T[100];

        public T this[int  index] { 
            get=>arr[index];
            set{
                arr[index] = value; 
            }
        }
    }
}
