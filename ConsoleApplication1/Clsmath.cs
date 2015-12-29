using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Clsmath
    {

        public delegate int pointerToadd(int x, int y);

        public pointerToadd getPointer(int i) 
        {
            pointerToadd operation = null;

            if (i == 1)
            {
                operation = Add;
            }
            if (i == 2)
            {
                operation = Sub;
            }
            if (i == 3)
            {
                operation = Sub;
            }

            return operation;
        }
        private int Add(int i, int y)
        {
            return i + y;
        }
        private int Sub(int i, int y)
        {
            return i - y;
        }
        private int Multi(int i, int y)
        {
            return i * y;
        }
        private int Div(int i, int y)
        {
            return i / y;
        }

    }

    class program
    {


         static void Main(String[] args) {


             Clsmath objMath = new Clsmath();
             int[] input= new int[2];
              input[0] = Convert.ToInt32(Console.ReadLine());
              input[1] = Convert.ToInt32(Console.ReadLine());
              int result = objMath.getPointer(1).Invoke(input[0], input[1]);
             Console.WriteLine(result);
             Console.ReadLine();
         
         }
    }
}
