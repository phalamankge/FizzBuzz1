using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz1
{
    public FizzBuzzer()
    {

    }
    public bool  Print1To100()
    {
         bool ret = false;
        
        for(int i = 1; 1 <= 100; i++)
        {
            Console.WriteLine(i + ",");
        }

        ret = true;
        return ret;
    }

    public bool MultiplesOfThreee()
    {
        bool ret = false;

        for (int i = 1; 1 <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i + ","+"Fizz" + " ");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine(i + "," + "Buzz" + " ");
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine(i + "," + "Buzz" + " ");
            }
            else
            {
                Console.WriteLine(i + ",");
            }   
            
        }

        ret = true;
        return ret;
    }
}
