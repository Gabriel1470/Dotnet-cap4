using Dotnet_cap4;

var myIntQueue = new IntQueue<int>();

myIntQueue.Queue(1);
myIntQueue.Queue(2);
myIntQueue.Queue(3);
myIntQueue.Queue(4);

myIntQueue.Dequeue();
myIntQueue.Peek();

//-------------------------------------------

var myStringQueue = new StringQueue<string>();

myStringQueue.Queue("Marco");
myStringQueue.Queue("Luca");
myStringQueue.Queue("Emanuele");
myStringQueue.Queue("Alberto");

myStringQueue.Dequeue();
myStringQueue.Peek();