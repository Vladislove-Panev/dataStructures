using System;
using System.Collections.Generic;
using System.Text;

namespace dataStructures
{
    public class L2List : IDataStructures
    {
        private L2Node root;
        private L2Node end;
        public int Length { get; private set; }
        public int this[int index]
        {
            get
            {
                if (Length != 0)
                {
                    L2Node tmp = root;
                    for (int i = 0; i < index; i++)
                        tmp = tmp.Next;
                    return tmp.Value;
                }
                else
                    return -1;
            }

            set
            {
                if (Length != 0)
                {
                    L2Node tmp = root;
                    for (int i = 0; i < index; i++)
                        tmp = tmp.Next;
                    tmp.Value = value;
                }
            }
        }

        public int MaxElementIndex { get { return GetIndex(Max()); } private set { } }

        public int MinElementIndex { get { return GetIndex(Min()); } private set { } }

        public L2List()
        {
            root = null;
            end = null;
            Length = 0;
        }

        public L2List(int a)
        {
            root = new L2Node(a);
            end = new L2Node(a);
            Length = 1;
        }

        public L2List(int[] array)
        {
            Add(array);
        }

        public void Add(int element)
        {
            if (Length == 0)
            {
                root = new L2Node(element);
                end = new L2Node(element);
                Length++;
            }
            else if (Length == 1)
            {
                end.Next = new L2Node(element);
                end.Next.Previous = end;
                end = end.Next;
                root.Next = end;
                Length++;
            }
            else
            {
                end.Next = new L2Node(element);
                end.Next.Previous = end;
                end = end.Next;
                Length++;
            }
        }

        public void Add(int[] elements)
        {
            if (elements.Length != 0)
            {
                if (end != null)
                {
                    for (int i = 0; i < elements.Length; i++)
                    {
                        end.Next = new L2Node(elements[i]);
                        end.Next.Previous = end;
                        end = end.Next;

                        if (Length == 1)
                        {
                            root.Next = end;
                        }
                        Length++;
                    }
                }
                else
                {
                    Add(elements[0]);
                    for (int i = 1; i < elements.Length; i++)
                    {
                        end.Next = new L2Node(elements[i]);
                        end.Next.Previous = end;
                        end = end.Next;

                        if (Length == 1)
                        {
                            root.Next = end;
                        }
                        Length++;
                    }
                }
            }
        }

        public void Add(int index, int element)
        {
            if (Length != 0)
            {
                L2Node tmp = root;

                for (int i = 0; i < index - 1; i++)
                {
                    tmp = tmp.Next;
                }
                if (index == 0)
                {
                    tmp.Previous = new L2Node(element);
                    tmp.Previous.Next = tmp;
                    root = tmp.Previous;
                    Length++;
                }
                else if (index < Length)
                {
                    L2Node tmp2 = tmp.Next;
                    tmp.Next = new L2Node(element);
                    tmp.Next.Previous = tmp;

                    tmp.Next.Next = tmp2;
                    tmp.Next.Next.Previous = tmp.Next;
                    Length++;
                }
            }
            else
                Add(element);
        }

        public void Add(int index, int[] elements)
        {
            if (Length != 0)
            {
                L2Node tmp = root;

                for (int i = 0; i < index - 1; i++)
                {
                    tmp = tmp.Next;
                }
                if (index == 0)
                {
                    for (int i = elements.Length - 1; i >= 0; i--)
                    {
                        tmp.Previous = new L2Node(elements[i]);
                        tmp.Previous.Next = tmp;
                        tmp = tmp.Previous;
                    }
                    root = tmp;

                    Length += elements.Length;
                }
                else if (index < Length)
                {
                    L2Node tmp2 = tmp.Next;
                    for (int i = 0; i < elements.Length; i++)
                    {
                        tmp.Next = new L2Node(elements[i]);
                        tmp.Next.Previous = tmp;
                        tmp = tmp.Next;
                    }

                    tmp.Next = tmp2;
                    tmp.Next.Previous = tmp.Next;

                    Length += elements.Length;
                }
            }
            else
                Add(elements);
        }

        public void AddToBeggining(int element)
        {
            Add(0, element);
        }

        public void AddToBeggining(int[] elements)
        {
            Add(0, elements);
        }

        public int GetIndex(int element)
        {
            L2Node tmp = root;
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
                L2Node tmp = root;
                int max = tmp.Value;

                while (tmp.Next != null)
                {
                    tmp = tmp.Next;

                    if (max < tmp.Value)
                        max = tmp.Value;
                }

                return max;
            }
            else
                return 0;
        }

        public int Min()
        {
            if (Length != 0)
            {
                L2Node tmp = root;
                int min = tmp.Value;

                while (tmp.Next != null)
                {
                    tmp = tmp.Next;

                    if (min > tmp.Value)
                        min = tmp.Value;
                }

                return min;
            }
            else
                return 0;
        }

        public void Remove()
        {
            if (Length != 0)
            {
                if (Length > 1)
                {
                    end = end.Previous;
                    end.Next.Previous = null;
                    end.Next = null;
                    Length--;
                }
                else
                {
                    root = null;
                    end = null;
                    Length = 0;
                }
            }
        }

        public void Remove(int index)
        {
            if (Length != 0)
            {
                L2Node tmp = root;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                if (Length > 1)
                {
                    if (index != 0)
                    {
                        tmp.Previous.Next = tmp.Next;
                        tmp.Next.Previous = tmp.Previous;
                        Length--;
                    }
                    else
                    {
                        root = tmp.Next;
                        tmp.Next.Previous = null;
                        Length--;
                    }
                }
                else
                {
                    root = null;
                    end = null;
                    Length = 0;
                }
            }
        }

        public void Remove(int index, int quantity)
        {
            if (Length != 0)
            {
                if (Length > 1)
                {
                    L2Node tmp = root;

                    for (int i = 0; i < index - 1; i++)
                        tmp = tmp.Next;

                    if (index != 0)
                    {
                        if (Length - (index + quantity) == 0)
                        {
                            tmp.Next.Previous = null;
                            tmp.Next = null;

                            end = tmp;
                        }
                        else
                        {
                            for (int i = 0; i < quantity; i++)
                            {
                                tmp.Next = tmp.Next.Next;
                                tmp.Next.Previous = tmp;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < quantity; i++)
                        {
                            root = root.Next;
                            root.Previous = null;
                        }
                    }

                    Length -= quantity;
                }
                else
                {
                    root = null;
                    end = null;
                    Length = 0;
                }
            }
        }

        public void RemoveElement(int element)
        {
            L2Node tmp = root;
            while (tmp != null)
            {
                if (tmp.Value == element)
                {
                    if (tmp.Previous == null)
                    {
                        root = tmp.Next;
                    }
                    else if (tmp.Next == null)
                    {
                        end = tmp.Previous;
                        end.Next = null;
                    }
                    else
                    {
                        tmp.Previous.Next = tmp.Next;
                        tmp.Next.Previous = tmp.Previous;
                    }
                    Length--;
                }

                tmp = tmp.Next;
            }
        }

        public void RemoveFirstElement()
        {
            Remove(0);
        }

        public void RemoveFirstElement(int quantity)
        {
            Remove(0, quantity);
        }

        public void RemoveLastElement(int quantity)
        {
            if (Length != 0)
            {
                if (Length > 1)
                {
                    L2Node tmp = root;
                    int lastEl = Length - quantity;

                    for (int i = 0; i < lastEl - 1; i++)
                        tmp = tmp.Next;

                    tmp.Next.Previous = null;
                    tmp.Next = null;
                    end = tmp;
                    Length -= quantity;
                }
                else
                {
                    root = null;
                    end = null;
                    Length = 0;
                }
            }
        }

        public int[] Return()
        {
            int[] array = new int[Length];
            if (Length != 0)
            {
                L2Node tmp = root;
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
            L2Node prev = null, current = root, next;
            end = current;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                current.Previous = next;
                prev = current;
                current = next;
            }

            root = prev;
        }

        public void SortArrayInc()
        {
            L2Node sorted = null;

            L2Node current = root;
            while (current != null)
            {
                L2Node next = current.Next;

                current.Previous = current.Next = null;

                sorted = sortedInsertInc(sorted, current);

                current = next;
            }

            root = sorted;
        }

        public void SortArrayDec()
        {
            L2Node sorted = null;

            L2Node current = root;
            while (current != null)
            {
                L2Node next = current.Next;

                current.Previous = current.Next = null;

                sorted = sortedInsertDec(sorted, current);

                current = next;
            }

            root = sorted;
        }

        private L2Node sortedInsertInc(L2Node head_ref, L2Node newNode)
        {
            L2Node current;

            if (head_ref == null)
                head_ref = newNode;

            else if (head_ref.Value >= newNode.Value)
            {
                newNode.Next = head_ref;
                newNode.Next.Previous = newNode;
                head_ref = newNode;
            }

            else
            {
                current = head_ref;

                while (current.Next != null && current.Next.Value < newNode.Value)
                    current = current.Next;

                newNode.Next = current.Next;

                if (current.Next != null)
                    newNode.Next.Previous = newNode;

                current.Next = newNode;
                newNode.Previous = current;
            }
            return head_ref;
        }

        private L2Node sortedInsertDec(L2Node head_ref, L2Node newNode)
        {
            L2Node current;

            if (head_ref == null)
                head_ref = newNode;
            else if (head_ref.Value <= newNode.Value)
            {
                newNode.Next = head_ref;
                newNode.Next.Previous = newNode;
                head_ref = newNode;
            }
            else
            {
                current = head_ref;

                while (current.Next != null && current.Next.Value > newNode.Value)
                    current = current.Next;

                newNode.Next = current.Next;

                if (current.Next != null)
                    newNode.Next.Previous = newNode;

                current.Next = newNode;
                newNode.Previous = current;
            }

            return head_ref;
        }
    }
}
