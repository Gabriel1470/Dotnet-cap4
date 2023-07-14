using Dotnet_cap4;
FcQueue<int> fcQueueInt = new FcQueue<int>();
FcDequeue<int> fcDequeueInt = new FcDequeue<int>();
FcPeek<int> fcPeekInt = new FcPeek<int>();


fcQueueInt.Queue(1);
fcQueueInt.Queue(2);
fcQueueInt.Queue(3);
fcQueueInt.Queue(4);


fcDequeueInt.Dequeue();
fcPeekInt.Peek();

//-------------------------------------------

FcQueue<string> fcQueueStr = new FcQueue<string>();
FcDequeue<string> fcDequeueStr = new FcDequeue<string>();
FcPeek<string> fcPeekStr = new FcPeek<string>();

fcQueueStr.Queue("Marco");
fcQueueStr.Queue("Luca");
fcQueueStr.Queue("Emanuele");
fcQueueStr.Queue("Alberto");

fcDequeueStr.Dequeue();
fcPeekStr.Peek();