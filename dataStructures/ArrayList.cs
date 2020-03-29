using System;
using System.Collections.Generic;
using System.Text;

namespace dataStructures
{
    public class ArrayList : IdataStructures
    {
        private int[] array;
        private int length;

        public int Length { get { return this.length; } }
        public int this[int i] { 
            get {
                if (length > i)
                    return array[i];
                else return -1;
            }
            set { 
                if (length > i)
                    array[i] = value; 
            } 
        }

        public int MaxElementIndex
        {
            get
            {
                int index = this.GetIndex(this.Max());

                return index;
            }
        }

        public int MinElementIndex
        {
            get
            {
                int index = this.GetIndex(this.Min());

                return index;
            }
        }

        public ArrayList()
        {
            array = new int[0];
            length = 0;
        }

        public ArrayList(int a)
        {
            array = new int[1];
            array[0] = a;
            length = 1;
        }
        public ArrayList(int[] array)
        {
            this.array = array;
            length = array.Length;
        }

        private void UpArraySize()
        {
            int newL = Convert.ToInt32(array.Length * 1.3 + 1);
            int[] newArray = new int[newL];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }

        private void DownArraySize()
        {
            int newL = Convert.ToInt32(array.Length - (array.Length * .3));
            int[] newArray = array;
            array = new int[newL];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = newArray[i];
            }
        }

        private void MoveArrayElementsToRight(int a)
        {
            if (length >= array.Length)
            {
                UpArraySize();
            }

            for (int i = length - 1; i >= a; i--)
            {
                array[i + 1] = array[i];
            }
            
        }

        private void MoveArrayElementsToRight(int index, int[] arr)
        {
            while (length + arr.Length > array.Length)
            {
                UpArraySize();
            }
            int shift = arr.Length;

            for (int i = length - 1; i >= index; i--)
            {
                array[i + shift] = array[i];
            }

        }

        public void Add(int a)
        {
            if (length >= array.Length)
            {
                UpArraySize();
            }

            array[length] = a;
            length++;
        }

        public void Add(int[] a)
        {
            while (length + a.Length > array.Length)
            {
                UpArraySize();
            }

            for (int i = 0; i < a.Length; i++)
            {
                array[length + i] = a[i];
            }

            length += a.Length;
        }

        public void Add(int index, int a)
        {
            if (index < length)
            {
                MoveArrayElementsToRight(index);
                array[index] = a;
                length++;
            }
        }

        public void Add(int index, int[] a)
        {
            if (index < length)
            {
                MoveArrayElementsToRight(index, a);
                for(int i = 0; i < a.Length; i++)
                    array[index + i] = a[i];

                length += a.Length;
            }
        }

        public void AddToBeggining(int a)
        {
            MoveArrayElementsToRight(0);
            array[0] = a;
            length++;
        }

        public void AddToBeggining(int[] a)
        {
            MoveArrayElementsToRight(0, a);
            for (int i = 0; i < a.Length; i++)
            {
                array[i] = a[i];
            }

            length += a.Length;
        }

        public void Remove()
        {
            if (length > 1)
            {
                array[length - 1] = 0;
            }
            else
                array = new int[0];

            if (length != 0)
                length--;

            if (length + length * .3 + 1 < array.Length)
                DownArraySize();
        }

        public void Remove(int index)
        {
            if (length > 1)
            {
                for (int i = index; i < length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
            }
            else
                array = new int[0];

            if(length != 0)
                length--;

            if (length + length * .3 + 1 < array.Length)
                DownArraySize();
        }

        public void Remove(int index, int quantity)
        {
            if (length > 1 )
            {
                if (length - index > quantity)
                {
                    for (int i = index; i < length - quantity; i++)
                    {
                        array[i] = array[i + quantity];
                    }
                }

                length -= quantity;
            }else
            {
                length = 0;
            }


            if (length + length * .3 + 1 < array.Length)
                DownArraySize();
        }

        public void RemoveFirstElement()
        {
            for (int i = 0; i < length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            if (length != 0)
                length--;
            
            if (length == 0)
                array = new int[0];

            if (length + length * .3 + 1 < array.Length)
                DownArraySize();
        }

        public void RemoveFirstElement(int quantity)
        {
            if (length > 1)
            {
                if (length > quantity)
                {
                    for (int i = 0; i < length - quantity; i++)
                    {
                        array[i] = array[i + quantity];
                    }
                }

                length -= quantity;
            }
            else
            {
                length = 0;
            }


            if (length + length * .3 + 1 < array.Length)
                DownArraySize();
        }

        public void RemoveLastElement(int quantity)
        {
            if (length > 1)
            {
                while (length < quantity)
                {
                    quantity--;
                }

                length -= quantity;
            }
            else
            {
                length = 0;
            }


            if (length + length * .3 + 1 < array.Length)
                DownArraySize();
        }

        public int GetIndex(int element)
        {
            for (int i = 0; i < length; i++)
            {
                if (array[i] == element)
                    return i;
            }

            return -1;
        }

        public void Reverse()
        {
            for (int i = 0; i < length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[length - i - 1];
                array[length - i - 1] = temp;
            }
        }

        public int Max()
        {
            int max;

            if (length != 0)
            {
                max = array[0];
                for (int i = 1; i < length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
            }
            else
                max = 0;

            return max;
        }

        public int Min()
        {
            int min;
            if (length != 0)
            {
                min = array[0];
                for (int i = 1; i < length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
            }
            else
                min = 0;

            return min;
        }

        public void SortArrayInc()
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void SortArrayDec()
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void RemoveElement(int a)
        {
            for (int i = 0; i < length; i++)
            {
                if (array[i] == a)
                    Remove(i);
            }
        }

        public int[] Return()
        {
            int[] arrayForReturn = new int[length];
            for (int i = 0; i < arrayForReturn.Length; i++)
            {
                arrayForReturn[i] = array[i];
            }

            return arrayForReturn;
        }
    }
}
