using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_cap4
{
    public class IntQueue<T> : MyQueue<T>
    {
        public override void Queue(T value)
        {
            if (firstElement == array.Length - 1)
            {
                throw new StackOverflowException();
            }
            array[++firstElement] = value;
        }

        public override T Dequeue()
        {
            if (firstElement == -1)
            {
                throw new InvalidOperationException();
            }
            return array[firstElement--];
        }

        public override T Peek()
        {
            if (firstElement == -1)
            {
                throw new InvalidOperationException();
            }
            return array[firstElement];
        }
    }
}