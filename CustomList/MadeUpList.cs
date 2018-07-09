using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MadeUpList<T> : IEnumerable
    {
        public T[] Array { get; set; }
        public int ArrayCapacity { get; set; }
        public int ArrayCount { get; set; }
        int top = 0;
        int i;

        public MadeUpList()
        {
            ArrayCapacity = 5;
            ArrayCount = 0;
            Array = new T[ArrayCapacity];

        }
        public int[] myList = new int[6] { 1, 2, 3, 4, 5, 6 };
        public float[] myMadeUpList = new float[10] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11 };

        public void AddIndex(T itemToAdd)
        {

            Array[ArrayCount] = itemToAdd;
            ArrayCount++;
            CheckCapacity();
        }

        public int Count()
        {
            return ArrayCount;
        }

        public void CheckCapacity()
        {
            if (ArrayCapacity >= ArrayCount)
            {
                ArrayCapacity += 5;
                T[] newArray = new T[ArrayCapacity];

                for (int i = 0; i < ArrayCount; i++)
                {
                    newArray[i] = Array[i];
                }
                Array = newArray;
            }
        }

        public bool RemoveCount(T itemToRemove)
        {
            T[] newArray = new T[ArrayCapacity];

            for (int i = 0; i < ArrayCount; i++ )
            {
                if (Array[i].Equals(itemToRemove))
                {
                    ArrayCount--;
                    ShiftArray();
                    return true;
                }

            }
            return false;
        }

        public void ShiftArray()
        {
            T[] newArray = new T[ArrayCapacity];

            for (int i = 0; i < ArrayCount; i++)
            {
                newArray[i] = Array[i];
            }
            newArray = Array;
        }


        public float this[int i]
        {
            get
            {
                return myMadeUpList[i];
            }
            set
            {
                myMadeUpList[i] = value;
            }

        }

        public override string ToString()
        {
            string stringArray = "";
            if (ArrayCount != 0)
            {
                for (int i = 0; i < ArrayCount; i++);
                stringArray = Convert.ToString(Array[i]);
            }

            return stringArray;
            
        }

        public IEnumerator GetEnumerator()
        {
            
            for ( int index = top - 1; index > 0; index --)
            {
                yield return myList[index];
            }

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static MadeUpList<T> operator + (MadeUpList<T> Array1, MadeUpList<T> Array2)
        {
            MadeUpList<T>newArray = Array1 + Array2;
            return newArray;
        }

        public static MadeUpList<T> operator - (MadeUpList<T> Array1, MadeUpList<T> Array2)
        {
            MadeUpList<T> newArray = Array1 - Array2;
            return newArray;
        }

        //public void ZipArrays(T SecondArray)
        //{
        //    int[] Array1 = { 1, 2, 3, 4, };
        //    string[] Array2 = { "one", "two", "three", "four" };

        //    var newArray = Array1.Zip(Array2, (first, second) => first + "" + second);

        //    foreach (var item in newArray)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        public void ZipArrays2()
        {
            string[] array1 = new string[] { "1", "2", "3" };
            string[] array2 = new string[] { "6", "7", "8" };

            string[] newArray = array1.Zip(array2, (a, b) =>
            new[] { a, b }).SelectMany(x => x).ToArray();
            
        }
    }
}
    


