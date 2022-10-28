using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findmax
{
    internal class PrintArray<T>
    {
        private T[] inputArray;
        private PrintArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }

        public void ToPrint()
        {
            foreach (var ele in inputArray)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("--------");
        }

        internal void toPrint()
        {
            throw new NotImplementedException();
        }
    }
}
