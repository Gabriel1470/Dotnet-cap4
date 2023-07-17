using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_cap4
{
    public interface IQueue<T>
    {
         public void Queue(T value);
        public T Dequeue();
        public T Peek();
    }
}