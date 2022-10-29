using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idont
{
    public class Algoritm
    {   
        public void funk(int count, string words)
        {   
            for (int i = 0; i < count ; count--)
            {
                //System.Threading.Thread.Sleep(1000);
               
                Console.Write($"{words}");
            }
        }
    }
}
