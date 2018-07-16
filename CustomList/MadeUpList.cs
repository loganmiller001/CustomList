﻿using System;
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

        public void Remove(T a)
        {

        }

        //public bool RemoveCount(T itemToRemove)
        //{
        //    T[] newArray = new T[ArrayCapacity];

        //    for (int i = 0; i < ArrayCount; i++ )
        //    {
        //        if (Array[i].Equals(itemToRemove))
        //        {
        //            ArrayCount--;
        //            ShiftArray();
        //            return true;
        //        }

        //    }
        //    return false;
        //}

        //public void ShiftArray()
        //{
        //    T[] newArray = new T[ArrayCapacity];

        //    for (int i = 0; i < ArrayCount; i++)
        //    {
        //        newArray[i] = Array[i];
        //    }
        //    Array = newArray;
        //}


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
            MadeUpList<T>newArray = Array1 + Array2;
            return newArray;
        }

        public static MadeUpList<T> operator - (MadeUpList<T> Array1, MadeUpList<T> Array2)
        {
            MadeUpList<T> newArray = Array1 - Array2;
            return newArray;
        }

        public void ZipArrays(T SecondArray)
        {
            int[] Array1 = { 1, 2, 3, 4, };
            string[] Array2 = { "one", "two", "three", "four" };

            var newArray = Array1.Zip(Array2, (first, second) => first + "" + second);

            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
        }



    }
}
    


