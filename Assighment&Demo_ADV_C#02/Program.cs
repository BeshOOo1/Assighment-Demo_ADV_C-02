using System.Collections;

namespace Assighment_Demo_ADV_C_02
{
    internal class Program
    {
        //public static int SumArrayList(ArrayList array)
        //{
        //    int sum = 0;
        //    if(array?.Count > 0)
        //    {
        //        for (int i = 0; i < array.Count; i++)
        //            sum = sum +(int?) array[i] ?? 0;
        //    }
        //    return sum;
        //}
        static void Main(string[] args)
        {
            #region Non - Generic Collections - ArrayList

            //ArrayList arrayList = new ArrayList();

            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}");


            #region Add Elements
            //arrayList.Add(1);//Boxing
            //Add new Element using Add() , Adding At End Of The Araylist

            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}");

            //arrayList.AddRange(new int[] { 2, 3, 4 });
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}");// 4 ,4

            //arrayList.Add(5);
            //arrayList.Add(6);
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}");// 8 , 5

            //foreach(int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Insert Elements
            //arrayList.Insert(1,10); // Boxing
            //Console.WriteLine("//////////////////");
            //foreach(int i in arrayList) // Unboxing
            //{
            //    Console.WriteLine(i);
            //}

            //arrayList.Insert(7, 200); // ArgumentOutOfRangeException

            //arrayList.InsertRange(2, new int[] { 20, 30});

            //Console.WriteLine("//////////////////");
            //foreach (int i in arrayList) // Unboxing
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 8 ,5

            #endregion

            #region Trim
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 8 , 6

            //arrayList.TrimToSize();
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 6 , 6

            //arrayList.Add(100);

            #endregion

            #region Remove()
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 12 , 7

            //foreach (int i in arrayList) // 1 , 2 , 3 , 4 , 5 , 6 , 100
            //    Console.WriteLine(i);
            ////arrayList.Remove(1);
            ////arrayList.RemoveAt(5);
            //arrayList.RemoveRange(0, 2);
            ////arrayList[0] = 100;
            ////Console.WriteLine(arrayList[0]);
            //Console.WriteLine("////////////////");
            //foreach (int i in arrayList) // 1 , 2 , 3 , 4 , 5 , 6 , 100
            //    Console.WriteLine(i);
            #endregion

            #region Contains
            //int FirstElement = (int?)arrayList[0] ?? 0 ;

            //bool flag = arrayList.Contains(1000);
            //Console.WriteLine(flag);
            #endregion

            #region 3 Constructors
            //arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}");// 8 ,5

            //arrayList = new ArrayList(10) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}");// 10 ,5

            //arrayList = new ArrayList(new int[] { 1, 2, 3 });
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 3 , 3

            #endregion

            //arrayList = new ArrayList(5);
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);

            //Console.WriteLine(SumArrayList(arrayList));
            #endregion

            #region Generic Collections - LinkedList

            //LinkedList<int> linkedList = new LinkedList<int>();
            //LinkedListNode<int> FirstNode =  linkedList.AddFirst(10);

            //LinkedListNode<int> SecoundNode = linkedList.AddFirst(20);

            //LinkedListNode<int> Node = new LinkedListNode<int>(30);
            //linkedList.AddFirst(Node);

            //linkedList.AddBefore(Node, 100);
            //foreach(int i in linkedList) // 30 , 20 , 10
            //    Console.WriteLine(i);

            //Console.WriteLine(linkedList.Count());
            //LinkedListNode<int> FNode =  linkedList.First;
            //LinkedListNode<int> LNode =  linkedList.Last;

            //Console.WriteLine(FNode.Value);
            //Console.WriteLine(LNode.ValueRef);
            #endregion

            #region Stack

            //Stack<int> stack = new Stack<int>();
            //Console.WriteLine($"{stack.Capacity} , {stack.Count}");
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //Console.WriteLine($"{stack.Capacity} , {stack.Count}");
            //stack.Push(5);
            //Console.WriteLine($"{stack.Capacity} , {stack.Count}");

            //foreach(int i in stack)
            //    Console.WriteLine(i);

            //Console.WriteLine("/////////////////");
            //int Top = stack.Peek();
            //Console.WriteLine(Top);
            //Console.WriteLine("/////////////////");

            //foreach (int i in stack)
            //    Console.WriteLine(i);

            #endregion

            #region Queue
            //Queue<int> queue = new Queue<int>();
            //Console.WriteLine($"{queue.Capacity} , {queue.Count}");

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //Console.WriteLine($"{queue.Capacity} , {queue.Count}");


            //foreach(int i in queue)
            //    Console.WriteLine(i);
            #endregion

        }
    }
}
