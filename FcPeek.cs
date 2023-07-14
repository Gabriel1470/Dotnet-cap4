using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_cap4
{
      public class FcPeek<T> : MyQueue<T>
    {
        public T Peek()
        {
            if (firstElement == -1)
            {
                throw new InvalidOperationException();
            }
            return array[firstElement];
        }
    }
}