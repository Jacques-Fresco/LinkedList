using System;

namespace LinkedList
{
    class Program
    {
        static void Main()
        {
            Model.LinkedList<int> list = new Model.LinkedList<int>();
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
            }

            Console.ReadLine();
        }
    }
}
