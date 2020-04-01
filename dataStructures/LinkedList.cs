using System;
using System.Collections.Generic;
using System.Text;

namespace dataStructures
{
    public class LinkedList : IdataStructures
    {
        public Node Root { get; private set; }
        public int Length { get; private set; }

        public int this[int index] 
        { 
            get 
            {
                Node tmp = Root;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                return tmp.Value;
            }
            set
            {
                Node tmp = Root;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Value = value;
            } 
        }

        public int MaxElementIndex { get { return GetIndex(Max()); } }
        public int MinElementIndex { get { return GetIndex(Min()); } }

        public LinkedList()
        {
            Root = null;
            Length = 0;
        }

        public LinkedList(int element)
        {
            Root = new Node(element);
            Length = 1;
        }

        public void Add(int element)
        {
            if (Length == 0)
            {
                Root = new Node(element);
                Length = 1;
            }
            else if (Length == 1)
            {
                Root.Next = new Node(element);
                Length++;
            }
            else
            {
                Node tmp = Root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = new Node(element);
                Length++;
            }
        }

        public void Add(int[] elements)
        {
            if (Length != 0)
            {
                Node tmp = Root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }

                for (int i = 0; i < elements.Length; i++)
                {
                    tmp.Next = new Node(elements[i]);
                    tmp = tmp.Next;
                }
            }
            else
            {
                Root = new Node(elements[0]);

                Node tmp = Root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }

                for (int i = 1; i < elements.Length; i++)
                {
                    tmp.Next = new Node(elements[i]);
                    tmp = tmp.Next;
                }
            }

            Length += elements.Length;
        }

        public void Add(int index, int element)
        {
            Node tmp = Root;

            for (int i = 0; i < index-1; i++)
            {
                tmp = tmp.Next;
            }
            Node tmp2 = tmp.Next;
            tmp.Next = new Node(element);
            tmp = tmp.Next;
            tmp.Next = tmp2;

            Length++;
        }

        public void Add(int index, int[] elements)
        {
            Node tmp = Root;

            for (int i = 0; i < index - 1; i++)
            {
                tmp = tmp.Next;
            }
            Node tmp2 = tmp.Next;
        
            for(int i = 0; i < elements.Length; i++)
            {
                tmp.Next = new Node(elements[i]);
                tmp = tmp.Next;
            }

            tmp.Next = tmp2;

            Length+=elements.Length;
        }

        public void AddToBeggining(int element)
        {
            Node tmp = new Node(element);
            tmp.Next = Root;
            Root = tmp;
            Length++;
        }

        public void AddToBeggining(int[] elements)
        {
            for (int i = elements.Length-1; i >= 0; i--)
                AddToBeggining(elements[i]);
        }

        public int GetIndex(int element)
        {
            Node tmp = Root;
            for (int i = 0; i < Length; i++)
            {
                if (tmp.Value == element)
                    return i;
            }

            return -1;
        }

        public int Max()
        {
            Node tmp = Root;
            int max = tmp.Value;

            while (tmp.Next != null)
            {
                tmp = tmp.Next;

                if (max < tmp.Value)
                    max = tmp.Value;
            }

            return max;
        }

        public int Min()
        {
            Node tmp = Root;
            int min = tmp.Value;

            while (tmp.Next != null)
            {
                tmp = tmp.Next;

                if (min > tmp.Value)
                    min = tmp.Value;
            }

            return min;
        }

        public void Remove()
        {
            Node tmp = Root;

            for (int i = 0; i < Length - 2; i++)
                tmp = tmp.Next;

            tmp.Next = null;
            Length--;
        }

        public void Remove(int index)
        {
            Node tmp = Root;

            for (int i = 0; i < index-1; i++)
                tmp = tmp.Next;

            tmp.Next = tmp.Next.Next;
            Length--;
        }

        public void Remove(int index, int quantity)
        {
            Node tmp = Root;

            for (int i = 0; i < index - 1; i++)
                tmp = tmp.Next;

            for(int i = 0; i < quantity; i++)
                tmp.Next = tmp.Next.Next;

            Length -= quantity;
        }

        public void RemoveElement(int element)
        {
            Node tmp = Root;

            for (int i = 0; i < Length; i++)
            {
                if (tmp.Value == element)
                {
                    Root = tmp.Next;
                    Length--;
                }
                else if (tmp.Next.Value == element)
                {
                    tmp.Next = tmp.Next.Next;
                    Length--;
                }

                tmp = tmp.Next;
            }
        }

        public void RemoveFirstElement()
        {
            Root = Root.Next;
            Length--;
        }

        public void RemoveFirstElement(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Root = Root.Next;
                Length--;
            }
        }

        public void RemoveLastElement(int quantity)
        {
            Node tmp = Root;
            for (int i = 0; i < Length - quantity - 1; i++)
                tmp = tmp.Next;
            tmp.Next = null;
            Length -= quantity;
        }

        public int[] Return()
        {
            int[] array = new int[Length];
            if (Length != 0)
            {
                Node tmp = Root;
                int i = 0;
                do
                {
                    array[i] = tmp.Value;
                    i++;
                    tmp = tmp.Next;

                } while (tmp != null);
            }

            return array;
        }

        public void Reverse()
        {
            Node prev = null, current = Root, next;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            Root = prev;
        }

        public void SortArrayDec()
        {
           
        }

        public void SortArrayInc()
        {
           
        }
    }
}
