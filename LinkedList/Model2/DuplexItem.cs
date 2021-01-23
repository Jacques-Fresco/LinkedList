using System;

namespace LinkedList.Model2
{
    public class DuplexItem<T>
    {
        public T Data { get; set; }
        public DuplexItem<T> Previous { get; set; } // Предыдущий
        public DuplexItem<T> Next { get; set; } // Следующий 
        public DuplexItem(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
