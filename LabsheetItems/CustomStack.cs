using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsheetItems
{
    public class CustomStack <T> : ICustomStack<T> where T : IIntern
    {
        //Changing the type from string to object will allow you to input different types
        public T[] arr = new T[10];
        private int index = 0;

        public void Push(T value)
        {
            arr[index++] = value;
        }

        public T Pop()
        {
            return arr[--index];
        }

        public int Count()
        {
            return index;
        }
    }
}
