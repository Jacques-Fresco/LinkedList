using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList.Model2;

namespace LinkedList.Model3
{
    // Кольцевой список
    class CircularLinkedList<T> : IEnumerable
    {
        public DuplexItem<T> Head { get; set; }
        public int Count { get; set; }
        public CircularLinkedList() { }
        public CircularLinkedList(T data)
        {
            SetHeadItem(data);
        }
        public void Add(T data)
        {
            if(Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            DuplexItem<T> item = new DuplexItem<T>(data);
            item.Next = Head;
            item.Previous = Head.Previous;
            Head.Previous.Next = item;
            Head.Previous = item;
            Count++;
        }
        public void Delete(T data)
        {
            if (Head.Data.Equals(data))
            {
                Head.Next.Previous = Head.Previous;
                Head.Previous.Next = Head.Next;
                Count--;
                Head = Head.Next; 
            }

            DuplexItem<T> current = Head.Next;
            for (int i = Count; i > 0; i--)
            {
                if (current != null && current.Data.Equals(data))
                {
                    current.Next.Previous = current.Previous;
                    current.Previous.Next = current.Next;
                    Count--;
                    return;
                }
                current = current.Next;
            }
        }
        private void SetHeadItem(T data)
        {
            Head = new DuplexItem<T>(data);
            Head.Next = Head;
            Head.Previous = Head;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            DuplexItem<T> current = Head;
            for (int i = 0; i < Count; i++)
            {
                yield return current;
                current = current.Next;
            }
        }
    }
}
