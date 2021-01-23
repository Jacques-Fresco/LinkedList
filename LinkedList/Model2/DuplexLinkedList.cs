using System;
using System.Collections; 
using System.Collections.Generic;

namespace LinkedList.Model2
{
    // Двусвязный список
    public class DuplexLinkedList<T> : IEnumerable<T>
    {
        public DuplexItem<T> Head { get; set; } // Первый
        public DuplexItem<T> Tail { get; set; } // Последний
        public int Count { get; set; } // Кол.во
        public DuplexLinkedList() { }
        public DuplexLinkedList(T data)
        {
            DuplexItem<T> item = new DuplexItem<T>(data);

            Head = item;
            Tail = item;
            Count = 1;
        }
        public void Add(T data)
        {
            DuplexItem<T> item = new DuplexItem<T>(data);

            if(Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }

            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }

        public void Delete(T data)
        {
            if(Head != null)
            {
                if(Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Head.Previous = null;
                    Count--;
                    return;
                }

                //DuplexItem<T> current = Head; // текущий элемент

                DuplexItem<T> current = Head.Next; // текущий элемент

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        if(current.Next == null)
                        {
                            current.Previous.Next = null;
                            Count--;
                            Tail = current.Previous;
                            return;
                        }
                        current.Previous.Next = current.Next; // у предыдущего current делаем Next current-a
                        current.Next.Previous = current.Previous; // 
                        Count--;
                        return;
                    }
                    current = current.Next;
                }
            }
        }

        public DuplexLinkedList<T> Reverse()
        {
            DuplexLinkedList<T> result = new DuplexLinkedList<T>();

            DuplexItem<T> current = Tail;
            while(current != null)
            {
                result.Add(current.Data);
                current = current.Previous;
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }
}
