using System;
using System.Collections.Generic;
using System.Text;

namespace RList
{
    public class LinkedList
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Next  { set; get; } = null;

            public Node(int n)
            {
                Value = n;
            }

            public bool GreaterThan(Node n)
            {
                return Value > n.Value;
            }
        }

        public Node Root { private set; get; } = null;
        private int Length { set; get; } = 0;

        public LinkedList()
        {
        }

        /// (3) конструктор копіювання
        public LinkedList(LinkedList originalList)
        {
            if (originalList.IsEmpty())
                return;

            Root = new Node(originalList.Root.Value);
            Length++;

            Node current = Root;
            Node originalCurrent = originalList.Root;

            while (originalCurrent.Next != null)
            {
                current.Next = new Node(originalCurrent.Next.Value);
                originalCurrent = originalCurrent.Next;
                current = current.Next;
                Length++;
            }
        }


        /// (1) Конструктор з одним параметром (число); 
        public LinkedList(int n)
        {
            Root = new Node(n);
            Length++;
        }

        /// (4) Метод додавання нового елементу першим у список;
        public void AddFirst(int n)
        {
            if (Root == null)
            {
                this.Push(n);
            }
            else
            {
                Node oldRoot = Root;
                Root = new Node(n)
                {
                    Next = oldRoot
                };
                Length++;
            }
        }

        /// (6) Рекурсивний метод додавання нового елемента останнім у список;
        public void Push(int n)
        {
            if (Root == null)
            {
                Root = new Node(n);
                Length++;
                return;
            }

            Node current = Root;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(n);
            Length++;
        }



        /// (19) Не рекурсивний метод видалення всіх елементів із заданим значенням;
        public void DeleteByValue(int n)
        {
            if (Root == null)
                return;

            Node current = Root;
            Node nextItem = Root.Next;

            if (current.Value == n)
            {
                Root = current.Next;
                Length--;
            }
            while (nextItem != null)
            {
                if (nextItem.Value == n)
                {
                    current.Next = nextItem.Next;
                    Length--;
                }
                current = nextItem;
                nextItem = current.Next;
                
            }
        }

        /// (23) Метод видалення всіх парних по порядку елементів;
        public void DeleteEvens()
        {
            Node current = Root;
            if (current == null)
                return;
            Node nextItem = current.Next;

            while (nextItem != null)
            {
                current.Next = nextItem.Next;
                nextItem = current.Next;
                Length--;
                if (nextItem == null)
                    continue;
                current = current.Next;
                nextItem = current.Next;
            }
        }

        /// (27) Не рекурсивний метод друку елементів списку у прямому порядку у стовпець;
        public string PrintColumn()
        {
            if (Root == null)
                return "";

            Node nextItem = Root.Next;
            string result = $"{Root.Value}";

            while (nextItem != null)
            {
                result += $"\n{nextItem.Value}";
                nextItem = nextItem.Next;
            }

            return result;
        }

        /// (39) Метод сортування елементів списку за зростанням числових значень;
        public void SortByAsc()
        {
            if (IsEmpty() || Root.Next == null)
                return;

            
            for (int i = Length; i > 0; i--)
            {
                if (Root.GreaterThan(Root.Next))
                {
                    Node tempRoot = Root;
                    Root = Root.Next;
                    tempRoot.Next = Root.Next;
                    Root.Next = tempRoot;
                }
                if (Length == 2)
                    return;

                Node prev = Root;
                Node current = prev.Next;
                Node next = current.Next;

                while (next != null)
                {
                    if (current.GreaterThan(next))
                    {
                        current.Next = next.Next;
                        prev.Next = next;
                        next.Next = current;
                    }
                    prev = prev.Next;
                    current = prev.Next;
                    next = current.Next;
                } 
            }
        }

        public void InsertAfter(int position, Node node)
        {
            if (IsEmpty() && position != 0 || position < 0)
                return; /// TODO: throw exception


            if (IsEmpty() && position == 0)
            {
                Root = node;
                Length++;
                return;
            }


            int counter = 0;
            Node current = Root;
            Node nextItem = Root.Next;

            while (counter != Length)
            {
                if (counter == position)
                {
                    current.Next = node;
                    node.Next = nextItem;
                    return;
                }
                current = nextItem;
                nextItem = current.Next;
                counter++;
            }
        }

        public string Print()
        {
            string result = "";
            Node current = Root;

            if (current == null)
                return result;

            while (current.Next != null)
            {
                result += $"{current.Value} -> ";
                current = current.Next;
            }

            if (current.Next == null)
                result += current.Value.ToString();

            return result;
        }

        public bool IsEmpty()
        {
           return Root == null;
        }

        /// (54) Індексатор з двома параметрами, що дозволяє знайти суму значень елементів, розташованих між елементами із заданими номерами;
        public Int32 Sum(int firstIndex, int lastIndex)
        {
            Int32 sum = 0;

            if (IsEmpty())
                return sum;
            int counter = 0;
            Node current = Root;

            while (current != null)
            {
                if (counter > firstIndex && counter < lastIndex)
                    sum += current.Value;
                current = current.Next;
                counter++;
            }
            return sum;
        }

        public void Clear()
        {
            Root = null;
        }
    }
}
