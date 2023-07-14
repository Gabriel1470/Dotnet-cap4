using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_cap4
{
    public class FcDequeue<T> : MyQueue<T>
    {
        public T Dequeue()
        {
            if (firstElement == -1)
            {
                throw new InvalidOperationException();
            }
            return array[firstElement--];
        }
    }
}