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
        public T[] aList;

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

        public void Remove(T removeItem)
        {
     for (int i = 0; i < ArrayCount; i++)
            {
                int itemCount = 0;
                if (Array[i].Equals(removeItem))
                {
                    T[] item = new T[ArrayCount - 1];
                    ArrayCount--;
                    for(int j = 0; j < 0; j++)
                    {
                        itemCount++;
                        Array[j] = Array[j];
                    }
                    for (int j = i + 1; j < ArrayCount; j++)
                    {
                        itemCount++;
                        Array[j] = item[i];
                    }
                }
            }
        }



        public T this[int j]
        {
            get
            {
                return Array[j];
            }
            set
            {
                Array[j] = value;
            }
        }
      

        public override string ToString()
        {
            string returnValue = string.Empty;
            foreach (T item in this)
            {
                if (string.IsNullOrEmpty(returnValue))
                {
                    returnValue += item.ToString();
                }
                else
                {
                    returnValue += string.Format(", {0}", item);
                }
                
            }
            return returnValue;
            
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
            foreach (T item in Array2)
            {
                Array1.AddIndex(item);
            }
            return Array1;
        }

        public static MadeUpList<T> operator - (MadeUpList<T> Array1, MadeUpList<T> Array2)
        {
           foreach(T items in Array2)
            {
                Array1.Remove(items);
            }
            return Array1;
        }

        public MadeUpList<T> Zip(MadeUpList<T> list2)
        {
            MadeUpList<T> list1 = new MadeUpList<T>();

            for (int i = 0; i < ArrayCount + list2.ArrayCount; i++)
            {
                if (ArrayCount > i)
                {
                    list1.AddIndex(Array[i]);
                }
                if (list2.ArrayCount > i)
                {
                    list1.AddIndex(list2.Array[i]);
                }
            }
            return list1;
        }
 
        //public T ZipArrays(T[] Array1, T[] Array2)
        //{
        //    T[] mockArray = new T[ArrayCount];
        //    int startingCount = 0;
        //    int zipper = 0;

        //    foreach (var Array1_item in Array1)
        //    {
        //        foreach (var Array2_item in Array2)
        //        {
        //            if (zipper == 0)
        //            {
        //                mockArray[startingCount] = Array1_item;
        //                zipper = 1;
        //            }
        //            if (zipper == 1)
        //            {
        //                mockArray[startingCount] = Array2_item;
        //                zipper = 0;
        //            }
        //        }
        //        startingCount++;
        //    }
        //    Array[i] = mockArray[i];
        //    return Array[i];
        //}



    }
}
    


