using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Dotnet_cap4;

namespace Dotnet_cap4.Test
{
    public class Tested : IDisposable
    {
      var myQueueInt = new MyQueue<int>();
        var myQueueStr = new MyQueue<string>();

        public UnitTest()
        {
            this.myQueueInt= new MyQueue<int>();
            this.myQueueStr = new MyQueue<string>();
        }

        MyQueue<int> myQueueInt = new MyQueue<int>();
        MyQueue<string> myQueueStr = new MyQueue<string>();

        [Fact]
        public void TestTheTailEmptyInteger()
        {
            myQueueInt.Queue(1);
            myQueueInt.Queue(2);
            myQueueInt.Queue(3);
            Assert.Empty(myQueueInt.array);
        }

        [Fact]
        public void QueueTestInteger()
        {
            myQueueInt.Queue(1);
            myQueueInt.Queue(2);
            Assert.Equal(2, myQueueInt.firstElement);
        }

        [Fact]
        public void DequeueTestInteger()
        {
            myQueueInt.Queue(1);
            myQueueInt.Queue(2);
            myQueueInt.Dequeue();
            Assert.True(myQueueInt.firstElement.Equals(1));
        }

        [Fact]
        public void PeekTestInteger()
        {
            myQueueInt.Queue(1);
            myQueueInt.Queue(2);
            var getValue= myQueueInt.Peek();
            Assert.Equivalent(1, getValue);
        }




        [Fact]
        public void TestTheTailEmptyString()
        {
            myQueueStr.Queue("Leo");
            myQueueStr.Queue("Luca");
            myQueueStr.Queue("Marco");
            Assert.Empty(myQueueStr.array);
        }

        [Fact]
        public void QueueTestString()       
        {
            myQueueStr.Queue("Mario");
            myQueueStr.Queue("Luigi");
            var result = myQueueStr.firstElement;
            Assert.Equivalent(2, result);
        }

        [Fact]
        public void DequeueTestString()
        {
            myQueueStr.Queue("Luca");
            myQueueStr.Queue("Emanuele");
            myQueueStr.Dequeue();
            Assert.Equivalent(1, myQueueStr.firstElement);
        }

        [Fact]
        public void PeekTestString()
        {
            myQueueStr.Queue("Francesco");
            myQueueStr.Queue("Anna");
            string getPeekElement= myQueueStr.Peek();
            Assert.Equivalent("Francesco", getPeekElement);
        }
    }
}