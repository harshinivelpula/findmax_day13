
namespace findmax
{
    class program
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var ele in inputArray)
            {
                Console.WriteLine(ele);
            }
        }
        public static void toPrint(double[] inputArray)
        {
            foreach (double ele in inputArray)
            {
                Console.WriteLine(ele);
            }
        }
        public static void toPrint(char[] inputArray)
        {
            foreach (char ele in inputArray)
            {
                Console.WriteLine(ele);
            }
        }
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 3, 4, 5, 6, };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'a', 'b', 'g' };

            //program.toPrint(intArray);
            //program.toPrint(doubleArray);
            //program.toPrint(charArray);
            //PrintArray<int> intobj = PrintArray<int>(intArray);
            //intobj.toPrint();

            //PrintArray<double> doubleobj = PrintArray<double>(doubleArray);
            //doubleobj.toPrint();

            //PrintArray<char> Charobj = PrintArray<Char>(charArray);
            //Charobj.toPrint();

            int firstnumber = 80, secondnumber = 60, thirdnumber = 10;

            //int val = firstnumber.CompareTo(secondnumber);
            //Console.WriteLine(val);
            int num = MaximumNumber<int>.MaximumIntegerNumber(firstnumber, secondnumber, thirdnumber);

            Console.WriteLine(num + "is greater among three");



        }
    }
}
