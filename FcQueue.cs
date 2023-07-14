using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_cap4
{
      public interface FcQueue<T>
    {
        void Queue(T value);
    }
}
