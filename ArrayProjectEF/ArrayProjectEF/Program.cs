using System;

namespace ArrayProjectEF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user to enter a whole number for array size.
            Console.WriteLine("Enter a whole number for the array size.");

            // Converts and stores whole number value in arraySize.
            int arraySize = Convert.ToInt32(Console.ReadLine());

            // Creates int array of the size the user enters.
            int[] numbers = new int[arraySize];

            // Sum variable set to the value of 0.
            int sum = 0;

            // int i set to 0, i will go until it reaches arraySize, i++ increments by 1 each time   
            for(int i = 0; i < arraySize; i++)
            {
                // Asks user to enter a whole number for array size.
                Console.WriteLine("Enter a whole number for the array size.");

                // starts at 0 and assigns each number a new value until end of array.
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                // Will add every number in array to the sum.
                sum += numbers[i];
            }

            // Interpolates the sum in a console.writeline.
            Console.WriteLine($"The sum of the array is {sum}\n");

            // Sorts the numbers in array for us. 
            Array.Sort(numbers);

            // Array header
            Console.WriteLine("Array");

            // Loop through each through all the elements and print to a console.
            foreach(int number in numbers)
            {
                // Prints number to console.
                Console.WriteLine(number);
            }
        }
    }
}
