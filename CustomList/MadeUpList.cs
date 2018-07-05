using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MadeUpList
    {


        public MadeUpList()
        {
            List<int> myMadeUpList = new List<int>();
        }

        public void AddIndex(int value)
        {
           
            MadeUpList[] myList = new MadeUpList[12];
            myList[0] = new MadeUpList {};
            myList[1] = new MadeUpList {};
            myList[2] = new MadeUpList {};

            
            
        }

        public void RemoveCount(int value)
        {
            MadeUpList[] myList = new MadeUpList[12];
            int[] MadeUpList = new[] {12, 13, 14, 15, 16 };
            MadeUpList.Except(new int[] { 12 }).ToArray();

        }

    }
}
