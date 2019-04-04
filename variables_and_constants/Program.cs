using System;

namespace variables_and_constants
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice =  20.95f;
            char character = 'A';
            string firstName = "Milo";
            bool isWorking = true;
            const float Pi = 3.14f;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

        }
    }
}
