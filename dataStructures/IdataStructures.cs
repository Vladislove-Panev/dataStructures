using System;
using System.Collections.Generic;
using System.Text;

namespace dataStructures
{
    public interface IDataStructures
    {
        public int Length { get; }
        public int this[int index] { get; set; }

        public int MaxElementIndex { get; }
        public int MinElementIndex { get; }

        public void Add(int element);

        public void Add(int[] elements);

        public void Add(int index, int element);

        public void Add(int index, int[] elements);

        public void AddToBeggining(int element);

        public void AddToBeggining(int[] elements);

        public void Remove();

        public void Remove(int index);

        public void Remove(int index, int quantity);

        public void RemoveFirstElement();

        public void RemoveFirstElement(int quantity);

        public void RemoveLastElement(int quantity);

        public int GetIndex(int element);

        public void Reverse();

        public int Max();

        public int Min();

        public void SortArrayInc();

        public void SortArrayDec();

        public void RemoveElement(int element);

        public int[] Return();
        
    }
}
