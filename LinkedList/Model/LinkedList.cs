using System;
using System.Collections;

namespace LinkedList.Model
{
    /// <summary>
    /// Односвязный список.
    /// </summary>
    public class LinkedList<T> : IEnumerable // связный список
    {
        /// <summary>
        /// Первый элемент списка.
        /// </summary>
        public Item<T> Head { get; private set; }
        /// <summary>
        /// Последний элемент списка.
        /// </summary>
        public Item<T> Tail { get; private set; }
        /// <summary>
        /// Кол.во элементов в списке.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Создать пустой список.
        /// </summary>
        public LinkedList()
        {
            Clear();
        }

        /// <summary>
        /// Создать список с начальным элементом.
        /// </summary>
        /// <param name="data"></param>
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        /// <summary>
        /// Добавить данные в конец списка.
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if(Tail != null)
            {
                Item<T> item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Удалить первое вхождение данных в список.
        /// </summary>
        /// <param name="data"></param>
        public void Delet(T data)
        {
            if(Head != null)
            {

                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                Item<T> current = Head.Next;
                Item<T> previous = Head;

                while (current != null)
                {
                    if(current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        if (current.Next == null) Tail = previous;
                         Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
        }
        private void SetHeadAndTail(T data)
        {
            Item<T> item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Добавить данные в начало списка.
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            Item<T> item = new Item<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }
        /// <summary>
        /// Вставить данные после искомого значения
        /// </summary>
        /// <param name="target"></param>
        /// <param name="data"></param>
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                Item<T> current = Head;

                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        Item<T> item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {
                // нужно для себя решить => либо не добавлять ничего, либо вставить данные
            }
        }

        /// <summary>
        /// Очистить список.
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        /// <summary>
        /// Получить перечисление всех элементов списка.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            Item<T> current = Head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public override string ToString()
        {
            return "Linked List" + Count + " элементов";
        }
    }
}
