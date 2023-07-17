using Dotnet_cap4;
var arrayStorageInteger = new ArrayStorage<int>(10);

arrayStorageInteger.Queue(1);
arrayStorageInteger.Queue(2);
arrayStorageInteger.Queue(3);

arrayStorageInteger.Dequeue();
arrayStorageInteger.Peek();

//-------------------------------------------

var arrayStorageString = new ArrayStorage<string>(10);

arrayStorageString.Queue("Red");
arrayStorageString.Queue("Gio");
arrayStorageString.Queue("Manu");

arrayStorageString.Dequeue();
arrayStorageString.Peek();