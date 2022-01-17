using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Selection sort
            int[] numberArray = { 7, 34, 16, 2, 37, 16, 10, 67, 43, 29, 12, 1, 5, 91 }; //The array going to be sorted
            int oldLocation = 0;
            int lowestValue;


            for (int i = numberArray.Length - 1; i >= 0; i--) //Runs through the array in reverse. i will be used to keep track of where the lowest value will be moved to.
            {
                lowestValue = numberArray[i]; //Sets lowestValue to i, making sure the program doesnt swap any values that have already been sorted.

                for (int j = i; j >= 0; j--) //Loops through the array, starting at i.
                {
                    if (numberArray[j] < lowestValue) //Checks if the current int is lower then lowestValue. If true, it updates lowestValue and store its position.
                    {
                        lowestValue = numberArray[j];
                        oldLocation = j;
                    }


                    if (j == 0) //Checks if this is the final iteration through of the loop. If true, it will move the lowest value to i's position.
                    {
                        numberArray[oldLocation] = numberArray[i];
                        numberArray[i] = lowestValue;
                    }
                }
            }





            //Removing duplicate values
            int[] tempArray = new int[numberArray.Length];
            int counter = 0;
            int dupeCheck = numberArray[0] - 1;


            for (int i = 0; i < tempArray.Length; i++) //Iterates through each value in the array starting at [1].
            {
                if (numberArray[i] != dupeCheck) //Checks if the current value is the same as the previous value.
                {
                    tempArray[counter] = numberArray[i]; //Adds the value to a temporary array at the position of a counter.
                    counter++; //Increments the counter by 1
                }
                dupeCheck = numberArray[i]; //Gets the previous value in the array.


                if (i == tempArray.Length - 1) //Checks if this is the final iteration of the loop.
                {
                    numberArray = new int[counter]; //Creates a new array with numberArray using the counter variable as the size.

                    for (int j = 0; j < counter; j++) //Loops until j reaches the value of counter, as to exclude the nil values at the end
                    {
                        numberArray[j] = tempArray[j]; //Adds each value of tempArray into numberArray.
                    }
                }
            }





            //Displays the sorted array
            Console.WriteLine(string.Join(", ", numberArray));
        }
    }
}