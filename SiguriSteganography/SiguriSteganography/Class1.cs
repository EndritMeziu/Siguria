using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiguriSteganography
{
    class Class1
    {
        
        public void main(String[] args)
        {
            for(int i=0;i<100;i++)
            {
                if ((1 << (i % 8)) > 0)
                {
                    Console.WriteLine(i);
                }
                else
                    Console.WriteLine("0");
            }
        }
    }
}
