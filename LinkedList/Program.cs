using System;

namespace LinkedList
{
    class Program
    {
        static void Main()
        {
            //CircularLinkedList (Кольцевой список)
            Model3.CircularLinkedList<int> circularList = new Model3.CircularLinkedList<int>();
            circularList.Add(10);
            circularList.Add(20);
            circularList.Add(30);
            circularList.Add(40);
            circularList.Add(50);

            foreach(Object item in circularList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            circularList.Delete(10);

            foreach (Object item in circularList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            circularList.Delete(50);

            foreach (Object item in circularList)
            {
                Console.WriteLine(item);
            }

            //DuplexLinkedList (Двусвязный список)

            /*Model2.DuplexLinkedList<int> duplexList = new Model2.DuplexLinkedList<int>();
            duplexList.Add(10);
            duplexList.Add(20);
            duplexList.Add(30);
            duplexList.Add(40);

            foreach(Object item in duplexList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            duplexList.Delete(40);

            foreach (Object item in duplexList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var revers = duplexList.Reverse();

            foreach (Object item in revers)
            {
                Console.WriteLine(item);
            }*/

            //LinkedList (Связный список)

            /*Model.LinkedList<int> list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            foreach(var item in list)
            {
                Console.WriteLine(item + " ");
            }

            list.Delet(1);
            list.Delet(6);

            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }*/

            Console.ReadLine();
        }
    }
}
