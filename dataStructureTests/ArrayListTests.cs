using NUnit.Framework;
using dataStructures;

namespace dataStructureTests
{
    public class Tests
    {
        [TestCase(new int[] { 0, 1, 2, 4 }, 5, ExpectedResult = new int[] { 0, 1, 2, 4, 5 })]
        [TestCase(new int[] { }, 5, ExpectedResult = new int[] { 5 })]
        [TestCase(new int[] { 0 }, -2135, ExpectedResult = new int[] { 0, -2135 })]
        public int[] AddTest(int[] array, int a)
        {
            IdataStructures actual = new ArrayList(array);
            actual.Add(a);

            return actual.Return();
        }

        [TestCase(new int[] { 0, 1, 3 }, new int[] { 4, 2, 1, 0 }, ExpectedResult = new int[] { 0, 1, 3, 4, 2, 1, 0 })]
        [TestCase(new int[] { }, new int[] { -1, 2, 0 }, ExpectedResult = new int[] { -1, 2, 0 })]
        [TestCase(new int[] { }, new int[] { }, ExpectedResult = new int[] { })]
        public int[] AddTest(int[] array, int[] a)
        {
            ArrayList actual = new ArrayList(array);
            actual.Add(a);

            return actual.Return();
        }

        [TestCase(new int[] { 0, 1, 2, 4 }, 2, 5, ExpectedResult = new int[] { 0, 1, 5, 2, 4 })]
        [TestCase(new int[] { }, 0, 1, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 0 }, 0, -2135, ExpectedResult = new int[] { -2135, 0 })]
        public int[] AddTest(int[] array, int index, int a)
        {
            ArrayList actual = new ArrayList(array);
            actual.Add(index, a);

            return actual.Return();
        }

        [TestCase(new int[] { 0, 1, 2, 4 }, 1, new int[] { 9, 8, 7 }, ExpectedResult = new int[] { 0, 9, 8, 7, 1, 2, 4 })]
        [TestCase(new int[] { 999 }, 0, new int[] { 1, -2, 3 }, ExpectedResult = new int[] { 1, -2, 3, 999 })]
        [TestCase(new int[] { }, 0, new int[] { }, ExpectedResult = new int[] { })]
        public int[] AddTest(int[] array, int index, int[] a)
        {
            ArrayList actual = new ArrayList(array);
            actual.Add(index, a);

            return actual.Return();
        }

        [TestCase(new int[] { 0, 1, 2, 4 }, 5, ExpectedResult = new int[] { 5, 0, 1, 2, 4 })]
        [TestCase(new int[] { }, 5, ExpectedResult = new int[] { 5 })]
        [TestCase(new int[] { 0 }, -2135, ExpectedResult = new int[] { -2135, 0 })]
        public int[] AddToBegginingTest(int[] array, int a)
        {
            ArrayList actual = new ArrayList(array);
            actual.AddToBeggining(a);

            return actual.Return();
        }

        [TestCase(new int[] { 0, 1, 2, 4 }, new int[] { 7, 8, 9 }, ExpectedResult = new int[] { 7, 8, 9, 0, 1, 2, 4 })]
        [TestCase(new int[] { }, new int[] { 1, 2, 4 }, ExpectedResult = new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 0 }, new int[] { -23, 67 }, ExpectedResult = new int[] { -23, 67, 0 })]
        public int[] AddToBegginingTest(int[] array, int[] a)
        {
            ArrayList actual = new ArrayList(array);
            actual.AddToBeggining(a);

            return actual.Return();
        }

        [TestCase(new int[] { 0, 1, 2, 4 }, ExpectedResult = new int[] { 0, 1, 2 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 0 }, ExpectedResult = new int[] { })]
        public int[] RemoveTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            actual.Remove();

            return actual.Return();
        }

        [TestCase(new int[] { 0, 1, 2, 4 }, 2, ExpectedResult = new int[] { 0, 1, 4 })]
        [TestCase(new int[] { 0 }, 0, ExpectedResult = new int[] { })]
        public int[] RemoveTest(int[] array, int a)
        {
            ArrayList actual = new ArrayList(array);
            actual.Remove(a);

            return actual.Return();
        }

        [TestCase(new int[] { 0, 1, 2, 4 }, 1, 3, ExpectedResult = new int[] { 0 })]
        [TestCase(new int[] { 0, 1, 2, 4, 45, 231, -46 }, 3, 2, ExpectedResult = new int[] { 0, 1, 2, 231, -46 })]
        [TestCase(new int[] { 0 }, 0, 1, ExpectedResult = new int[] { })]
        [TestCase(new int[] { }, 0, 1, ExpectedResult = new int[] { })]
        public int[] RemoveTest(int[] array, int index, int quantity)
        {
            ArrayList actual = new ArrayList(array);
            actual.Remove(index, quantity);

            return actual.Return();
        }

        [TestCase(new int[] { 0, 1, 4, 5 }, ExpectedResult = new int[] { 1, 4, 5 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 4 }, ExpectedResult = new int[] { })]
        public int[] RemoveFirstElementTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemoveFirstElement();

            return actual.Return();
        }

        [TestCase(new int[] { 0, 1, 4, 5 }, 3, ExpectedResult = new int[] { 5 })]
        [TestCase(new int[] { 0, 1, 4, 5, -99, 24, 65 }, 3, ExpectedResult = new int[] { 5, -99, 24, 65 })]
        [TestCase(new int[] { }, 1, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 4 }, 1, ExpectedResult = new int[] { })]
        public int[] RemoveFirstElementTest(int[] array, int quantity)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemoveFirstElement(quantity);

            return actual.Return();
        }

        [TestCase(new int[] { 0, 1, 4, 5 }, 3, ExpectedResult = new int[] { 0 })]
        [TestCase(new int[] { 0, 1, 4, 5, -99, 24, 65 }, 3, ExpectedResult = new int[] { 0, 1, 4, 5 })]
        [TestCase(new int[] { }, 1, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 4 }, 1, ExpectedResult = new int[] { })]
        public int[] RemoveLastElementTest(int[] array, int quantity)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemoveLastElement(quantity);

            return actual.Return();
        }

        [TestCase(new int[] { 0, 1, 9, 2, 4, 6 }, 2, ExpectedResult = 3)]
        [TestCase(new int[] { }, 2, ExpectedResult = -1)]
        [TestCase(new int[] { -231, -678, 789, 231 }, 111, ExpectedResult = -1)]
        public int GetIndexTest(int[] array, int element)
        {
            ArrayList actualOb = new ArrayList(array);
            int actual = actualOb.GetIndex(element);

            return actual;
        }

        [TestCase(new int[] { 2, 3, 123, 56, 79 }, ExpectedResult = new int[] { 79, 56, 123, 3, 2 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 2 }, ExpectedResult = new int[] { 2 })]
        [TestCase(new int[] { 1, 9 }, ExpectedResult = new int[] { 9, 1 })]
        public int[] ReversTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            actual.Reverse();

            return actual.Return();
        }

        [TestCase (new int[] { 3, 1, 6, 8, 89, 23, 111 }, ExpectedResult = 1)]
        [TestCase (new int[] { -3, 1, -6, 8, -89, 23, 111, 0 }, ExpectedResult = -89)]
        [TestCase (new int[] { }, ExpectedResult = 0)]
        public int MinTest(int[] array)
        {
            ArrayList actualOb = new ArrayList(array);
            int actual = actualOb.Min();

            return actual;
        }

        [TestCase(new int[] { 3, 1, 6, 8, 89, 23, 111 }, ExpectedResult = 111)]
        [TestCase(new int[] { -3, 1, -6, 8, -89, 23, 0 }, ExpectedResult = 23)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int MaxTest(int[] array)
        {
            ArrayList actualOb = new ArrayList(array);
            int actual = actualOb.Max();

            return actual;
        }

        [TestCase(new int[] { 3, 1, 6, 8, 89, 23, 111 }, ExpectedResult = new int[] { 1, 3, 6, 8, 23, 89, 111 })]
        [TestCase(new int[] { -3, 1, -6, 8, -89, 23, 0 }, ExpectedResult = new int[] { -89, -6, -3, 0, 1, 8, 23 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        public int[] SortArrayIncTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            actual.SortArrayInc();

            return actual.Return();
        }

        [TestCase(new int[] { 3, 1, 6, 8, 89, 23, 111 }, ExpectedResult = new int[] { 111, 89, 23, 8, 6, 3, 1 })]
        [TestCase(new int[] { -3, 1, -6, 8, -89, 23, 0 }, ExpectedResult = new int[] { 23, 8, 1, 0, -3, -6, -89 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        public int[] SortArrayDecTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            actual.SortArrayDec();

            return actual.Return();
        }

        [TestCase(new int[] { 3, 1, 6, 8, 89, 23, 111, 3, 67, 3 }, 3, ExpectedResult = new int[] { 1, 6, 8, 89, 23, 111, 67 })]
        [TestCase(new int[] { -3, 1, -6, 8, -89, 23, 0 }, -89, ExpectedResult = new int[] { -3, 1, -6, 8, 23, 0 })]
        [TestCase(new int[] { }, 0, ExpectedResult = new int[] { })]
        public int[] RemoveElementTest(int[] array, int element)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemoveElement(element);

            return actual.Return();
        }

        [TestCase(new int[] { 3, 1, 6, 8, 89, 23, 111, 3, 67, 3 }, 3, ExpectedResult = 8)]
        [TestCase(new int[] { -3, 1, -6, 8, -89, 23, 0 }, 5, ExpectedResult = 23)]
        [TestCase(new int[] { }, 0, ExpectedResult = -1)]
        public int GetElementTest(int[] array, int index)
        {
            ArrayList actual = new ArrayList(array);

            return actual[index];
        }

        [TestCase(new int[] { 3, 1, 6, 8, 89, 23, 111, 3, 67, 3 }, 3, 44, ExpectedResult = new int[] { 3, 1, 6, 44, 89, 23, 111, 3, 67, 3 })]
        [TestCase(new int[] { -3, 1, -6, 8, -89, 23, 0 }, 5, 111, ExpectedResult = new int[] { -3, 1, -6, 8, -89, 111, 0 })]
        [TestCase(new int[] { }, 0, 1, ExpectedResult = new int[] { })]
        public int[] SetElementTest(int[] array, int index, int num)
        {
            ArrayList actual = new ArrayList(array);
            actual[index] = num;

            return actual.Return(); 
        }

        [TestCase(new int[] { 3, 1, 6, 8, 89, 23, 111, 3, 67, 3 }, ExpectedResult = 6)]
        [TestCase(new int[] { -3, 1, -6, 8, -89, 23, 0 }, ExpectedResult = 5)]
        [TestCase(new int[] { }, ExpectedResult = -1)]
        public int GetMaxElementIndexTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);

            return actual.MaxElementIndex;
        }

        [TestCase(new int[] { 3, 1, 6, 8, 89, 23, 111, 3, 67, 3 }, ExpectedResult = 1)]
        [TestCase(new int[] { -3, 1, -6, 8, -89, 23, 0 }, ExpectedResult = 4)]
        [TestCase(new int[] { }, ExpectedResult = -1)]
        public int GetMinElementIndexTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);

            return actual.MinElementIndex;
        }
    }
}