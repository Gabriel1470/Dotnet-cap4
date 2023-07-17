using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  Dotnet_cap4;
namespace Dotnet_cap4
{
    public class ArrayStorage<T>
    {
         private T[] array;
        private int firstElement;

        public ArrayStorage(int size)
        {
            array = new T[size];
        }

        public void Queue(T value)
        {
            if (firstElement == array.Length - 1)
            {
                throw new StackOverflowException();
            }
            array[++firstElement] = value;
        }

        public T Dequeue()
        {
            if (firstElement == -1)
            {
                throw new InvalidOperationException();
            }
            return array[firstElement--];
        }

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