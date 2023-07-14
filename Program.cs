using Dotnet_cap4;
var myQueueInt= new MyQueue<int>();

myQueueInt.Queue(1);
myQueueInt.Queue(2);
myQueueInt.Queue(3);
myQueueInt.Queue(4);

myQueueInt.Dequeue();
myQueueInt.Peek();



var myQueueStr = new MyQueue<string>();

myQueueStr.Queue("Red");
myQueueStr.Queue("Gio");
myQueueStr.Queue("Manu");
myQueueStr.Queue("Albe");

myQueueString.Dequeue();
myQueueString.Peek();