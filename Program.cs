using DSA_VSCode._01_Basics;
using DSA_VSCode._02_Arrays;
using DSA_VSCode._10_Hasshing;
using DSA_VSCode._05_Stacks_Queues;

#region 01_Basics- Loops and Patterns

//Loops.SquarePattern();
//Console.WriteLine();
//Loops.SquareRowPattern();
//Loops.RightTriangleStarPattern();
//Loops.InvertedRightTriangleStarPattern();
//Loops.PyramidShapePattern();
//Loops.DiamondStarPattern();
//Loops.LeftTriStarPattern();
//Loops.InvertedLeftTriStarPattern();
//Loops.HollowSquarePattern();
//Loops.HollowRightTriPattern();
#endregion
#region Arrays
//Arrays.PrintArray();
//Arrays.ArrSum();
//Arrays.FindMax();
//Arrays.FindMin();
//Arrays.AvgArray();
//Arrays.SearchNum(1);
//Arrays.CountOccurrence();
#endregion
#region Hashing
/* HashSetClass H = new HashSetClass();
H.AddHashSet();
H.CheckValue(10);
H.CheckValue(100);
H.RemoveValue(30); */
// Find Duplicate
//HashSetClass.FindDuplicate();

//HashMapClass HMap = new HashMapClass();
/* HMap.AddValue();
//HMap.ShowKey();
//HMap.ShowValue();
HMap.ContainKey(104);
HMap.RemovePair(103);
HMap.ShowMap(); */
// Check Frequency
//HMap.CheckFrequency();
//HMap.SumNum();
#endregion
#region Stack
// MyStack stack = new MyStack(4);
// stack.Push(5);
// stack.Push(10);
// stack.Push(15);
// stack.Push(20);
// Console.WriteLine(stack.Peek());
// Console.WriteLine(stack.Pop());
// Console.WriteLine(stack.Pop());
// Console.WriteLine(stack.Pop());
// Console.WriteLine(stack.Peek());
// stack.DisplayStack();
#endregion
#region Queue

//Myqueue myqueue = new Myqueue(4);
//myqueue.Enque(3);
// myqueue.Enque(5);
// myqueue.Enque(7);
// myqueue.Enque(9);

//Console.WriteLine(myqueue.Peek());
// Console.WriteLine(myqueue.DeQue());
// Console.WriteLine(myqueue.DeQue());
// Console.WriteLine(myqueue.DeQue());
//Console.WriteLine(myqueue.DeQue());

//myqueue.DisplayQueue();
#endregion
#region Circular Queue
MyCircularQueue myCircularQueue = new MyCircularQueue(3);
myCircularQueue.CirEnque(11);
myCircularQueue.CirEnque(13);
myCircularQueue.CirEnque(15);

Console.WriteLine(myCircularQueue.CirDeque());
Console.WriteLine(myCircularQueue.CirDeque());
myCircularQueue.CirEnque(17);
myCircularQueue.CirEnque(19);
myCircularQueue.DisplayCirQueue();
Console.WriteLine(myCircularQueue.CirPeek());
#endregion