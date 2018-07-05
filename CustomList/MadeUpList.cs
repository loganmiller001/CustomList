using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MadeUpList
    {
        public string Words { get; set; }
        public int Numbers { get; set; }

        public MadeUpList()
        {
            List<int> myMadeUpList = new List<int>();

        }
        public float[] myMadeUpList = new float[10] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11 };

        public void AddIndex(int value)
        {

            MadeUpList[] myList = new MadeUpList[12];
            myList[0] = new MadeUpList { };
            myList[1] = new MadeUpList { };
            myList[2] = new MadeUpList { };



        }

        public void RemoveCount(int value)
        {
            MadeUpList[] myList = new MadeUpList[12];
            int[] MadeUpList = new[] { 12, 13, 14, 15, 16 };
            MadeUpList.Except(new int[] { 12 }).ToArray();

        }

        [System.Runtime.CompilerServices.IndexerName("MyIndexer")]
        public float this[int index]
        {
            get
            {
                return myMadeUpList[index];
            }
            set
            {
                myMadeUpList[index] = value;
            }
        }

        public override string ToString()
        {
            return "Person " + Words + Numbers + " ";
           
            
        }
    }
}
    


