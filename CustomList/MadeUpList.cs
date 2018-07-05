using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MadeUpList<T>:IEnumerable
    {
        public T[] Array { get; set; }
        public int ArrayCapacity { get; set; }
        public T this[int i] {get { return Array[i]; } set { Array[i] = value; } }
        public string Words { get; set; }
        public int Numbers { get; set; }

        public MadeUpList()
        {
            List<int> myMadeUpList = new List<int>();

        }
        public int[] myList = new int[6] { 1, 2, 3, 4, 5, 6};
        public float[] myMadeUpList = new float[10] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11 };

        public void AddIndex(int value)
        {

            MadeUpList<T>[] myList = new MadeUpList<T>[12];
            myList[1] = new MadeUpList<T> { };
            myList[2] = new MadeUpList<T> { };



        }

        public void RemoveCount(int value)
        {
            MadeUpList<T>[] myList = new MadeUpList<T>[12];
            int[] MadeUpList = new[] { 12, 13, 14, 15, 16 };
            MadeUpList.Except(new int[] { 12 }).ToArray();

        }

        
        //public float this[int index]
        //{
        //    get
        //    {
        //        return myMadeUpList[index];
        //    }
        //    set
        //    {
        //        myMadeUpList[index] = value;
        //    }
        //}

        public override string ToString()
        {
            return "Person " + Words + Numbers + " ";
           
            
        }

        public IEnumerator<int> GetEnumerator()
        {
            yield return myList[0];
            yield return myList[1];
            yield return myList[2];
            yield return myList[3];
            yield return myList[4];
            yield return myList[5];
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
    


