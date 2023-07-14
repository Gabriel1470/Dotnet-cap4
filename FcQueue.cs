using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_cap4
{
        public class FcQueue<T> : MyQueue<T>
    {
        public void Queue(T value)
        {
            if (firstElement == array.Length - 1)
            {
                throw new StackOverflowException();
            }
            array[++firstElement] = value;
        }
    }
}