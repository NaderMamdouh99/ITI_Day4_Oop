using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lab
            Complex c1 = new Complex(7, 6);

            Console.WriteLine(c1.GetMagnitude());
            Complex c2 = new Complex(4, 7);
            Complex c3 = new Complex(4, 7);
            //adding
            Console.WriteLine(c1 + c2);
            //minus
            Console.WriteLine(c1 - c2);
            //++
            Console.WriteLine(c1++);
            //--
            Console.WriteLine(c1--);

            //casting
            c1 = (Complex)10;
            Console.WriteLine("cast: " + c1);

            int value;
            value = (int)c1;
            Console.WriteLine("cast: " + value);

            Console.WriteLine("equal :: " + c1.Equals(c2));
            Console.WriteLine("equal :: " + c2.Equals(c3)); 
            #endregion

        }
    }
}
