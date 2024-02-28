using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //DONE: Create an integer Array of size 50
            int[] numbers = new int[50];

            //DONE: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);

            //DONE: Print the first number of the array
            Console.WriteLine($"First number: {numbers[0]}");

            //DONE: Print the last number of the array
            Console.WriteLine($"Last number: {numbers[49]}");

            Console.WriteLine("All Numbers Original:");
            //DONE: UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //DONE: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */


            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //DONE: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //DONE: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //DONE: Create an integer List
            List<int> numberList = new List<int>();

            //DONE: Print the capacity of the list to the console
            Console.WriteLine($"Initial capacity: {numberList.Capacity}");

            //DONE: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numberList);

            //DONE: Print the new capacity
            Console.WriteLine($"Populated capacity: {numberList.Capacity}");


            Console.WriteLine("---------------------");

            //DONE: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            int searchNumber;
            bool isValidInput = false;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out searchNumber);
                if (!isValidInput)
                {
                    Console.WriteLine("Not a valid input, please enter a valid integer.");
                }
            } while (!isValidInput);

            NumberChecker(numberList, searchNumber);



            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //DONE: UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");


            //DONE: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numberList);
            NumberPrinter(numberList);
            
            Console.WriteLine("------------------");

            //DONE: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numberList.Sort();
            NumberPrinter(numberList);
            
            Console.WriteLine("------------------");

            //DONE: Convert the list to an array and store that into a variable
            Console.WriteLine("Converted list into an array:");
            int[] listArray = numberList.ToArray();
            NumberPrinter(listArray);

            //DONE: Clear the list
            numberList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count;i++)
            {
                if (numberList[i] % 2 == 1)
                {
                    numberList[i] = 0;
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if(numberList.Contains(searchNumber))
            {
                Console.WriteLine($"The number {searchNumber} is present in the list.");
            }
            else
            {
                Console.WriteLine($"The number {searchNumber} isn't present in the list.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 50 + 1));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                
                numbers[i] = rng.Next(0, 50 + 1);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                // Swap elements at left and right indices
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                // Move to next pair of elements
                left++;
                right--;
            }

        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
