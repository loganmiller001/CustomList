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
        //public T this[int i] {get { return Array[i]; } set { Array[i] = value; } }
        public string Words { get; set; }
        public int Numbers { get; set; }
        int top = 0;

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
            return "Person " + Words + Numbers + " ";
           
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            for ( int index = top - 1; index > 0; index --)
            {
                yield return Array[index];
            }

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static MadeUpList<T> operator + (MadeUpList<T> madeUpList)
        {
            return madeUpList;
        }

    }
}
    


