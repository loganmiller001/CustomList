using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            MadeUpList myMadeupList = new MadeUpList();
            myMadeupList[3] = 58.3F;
            myMadeupList[5] = 60.1F;

            for(int i = 0; i <10; i++)
            {
                Console.WriteLine ("Element #{0} = {1}", i, myMadeupList[i]);
            }
        }
    }
}
