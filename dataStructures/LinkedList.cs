using System;
using System.Collections.Generic;
using System.Text;

namespace dataStructures
{
    public class LinkedList : IDataStructures
    {
        public Node Root { get; private set; }
        public int Length { get; private set; }

        public int this[int index] 
        { 
            get 
            {
                if (Length != 0)
                {
                    Node tmp = Root;
                    for (int i = 0; i < index; i++)
                    {
                        tmp = tmp.Next;
                    }
                    return tmp.Value;
                }
                return -1;
            }
            set
            {
                if (Length != 0)
                {
                    Node tmp = Root;
                    for (int i = 0; i < index; i++)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Value = value;
                }
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
            if (elements.Length != 0)
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

                    for (int i = 1; i < elements.Length; i++)
                    {
                        tmp.Next = new Node(elements[i]);
                        tmp = tmp.Next;
                    }
                }

                Length += elements.Length;
            }
        }

        public void Add(int index, int element)
        {
            if (Length != 0)
            {
                Node tmp = Root;

                if (Length > 1)
                {
                    for (int i = 0; i < index - 1; i++)
                    {
                        tmp = tmp.Next;
                    }
                    Node tmp2 = tmp.Next;
                    tmp.Next = new Node(element);
                    tmp = tmp.Next;
                    tmp.Next = tmp2;
                }
                else
                {
                    Node tmp2;
                    tmp2 = new Node(element);
                    tmp2.Next = tmp;
                    Root = tmp2;
                }
                Length++;
            }
            else
            {
                Add(element);
            }
        }

        public void Add(int index, int[] elements)
        {
            if (elements.Length != 0)
            {
                Node tmp = Root;

                if (Length > 1)
                {
                    for (int i = 0; i < index - 1; i++)
                    {
                        tmp = tmp.Next;
                    }
                    Node tmp2 = tmp.Next;

                    for (int i = 0; i < elements.Length; i++)
                    {
                        tmp.Next = new Node(elements[i]);
                        tmp = tmp.Next;
                    }

                    tmp.Next = tmp2;
                }
                else
                {
                    Node tmp2 = new Node(elements[0]);
                    Root = tmp2;

                    for (int i = 1; i < elements.Length; i++)
                    {
                        tmp2.Next = new Node(elements[i]);
                        tmp2 = tmp2.Next;
                    }
                    tmp2.Next = tmp;
                }

                Length += elements.Length;
            }
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
                tmp = tmp.Next;
            }

            return -1;
        }

        public int Max()
        {
            if (Length != 0)
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

            return 0;
        }

        public int Min()
        {
            if (Length != 0)
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

            return 0;
        }

        public void Remove()
        {
            if (Length != 0)
            {
                Node tmp = Root;

                for (int i = 0; i < Length - 2; i++)
                    tmp = tmp.Next;

                tmp.Next = null;
                Length--;
            }
        }

        public void Remove(int index)
        {
            if (Length != 0)
            {
                Node tmp = Root;

                if (Length > 1)
                {
                    for (int i = 0; i < index - 1; i++)
                        tmp = tmp.Next;

                    tmp.Next = tmp.Next.Next;
                }
                else
                {
                    Root = null;
                }

                Length--;
            }
        }

        public void Remove(int index, int quantity)
        {
            Node tmp = Root;

            if (Length != 0)
            {
                if (Length > 1)
                {
                    for (int i = 0; i < index - 1; i++)
                        tmp = tmp.Next;

                    for (int i = 0; i < quantity; i++)
                        tmp.Next = tmp.Next.Next;

                    Length -= quantity;
                }
                else
                {
                    Root = null;
                    Length = 0;
                }
            }
        }

        public void RemoveElement(int element)
        {
            Node tmp = Root, prev = null;
            int i = 0;

            while(tmp != null)
            {
                if (tmp.Value == element)
                {
                    if (i == 0)
                        Root = tmp.Next;
                    else if(tmp.Next == null)
                        prev.Next = null;
                    else
                    {
                        prev.Next = prev.Next.Next;
                    }

                    Length--;
                }
              
                i++;

                prev = tmp;
                tmp = tmp.Next;
            }
        }

        public void RemoveFirstElement()
        {
            if (Length != 0)
            {
                Root = Root.Next;
                Length--;
            }
        }

        public void RemoveFirstElement(int quantity)
        {
            if (Length != 0)
            {
                for (int i = 0; i < quantity; i++)
                {
                    Root = Root.Next;
                    Length--;
                }
            }
        }

        public void RemoveLastElement(int quantity)
        {
            if (Length != 0)
            {
                Node tmp = Root;
                for (int i = 0; i < Length - quantity - 1; i++)
                    tmp = tmp.Next;
                tmp.Next = null;
                Length -= quantity;
            }
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
            Node sorted = null;

            Node current = Root;
            while (current != null)
            {
                Node next = current.Next;

                current.Next = null;

                sorted = insertSortedDec(sorted, current);

                current = next;
            }

            Root = sorted;
        }

        public void SortArrayInc()
        {
            Node sorted = null;

            Node current = Root;

            while(current != null)
            {
                Node next = current.Next;

                current.Next = null;

                sorted = insertSortedInc(sorted, current);

                current = next;
            }

            Root = sorted;
        }

        private Node insertSortedDec(Node root, Node newNode)
        {
            Node current;

            if (root == null)
                root = newNode;
            else if(root.Value <= newNode.Value)
            {
                newNode.Next = root;
                root = newNode;
            }
            else
            {
                current = root;

                while (current.Next != null && current.Next.Value > newNode.Value)
                    current = current.Next;

                newNode.Next = current.Next;

                current.Next = newNode;
            }

            return root;
        }

        private Node insertSortedInc(Node root, Node newNode)
        {
            Node current;

            if (root == null)
                root = newNode;
            else if(root.Value >= newNode.Value)
            {
                newNode.Next = root;
                root = newNode;
            }
            else
            {
                current = root;

                while (current.Next != null && current.Next.Value < newNode.Value)
                    current = current.Next;

                newNode.Next = current.Next;
                current.Next = newNode;
            }

            return root;
        }
    }
}
