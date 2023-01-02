using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool loopSwitch = false;
        int listLen = 0;
        float listSum = 0;
        float listAvg = 0;
        float maxNumber = 0;
        float minposNumber = 10000000000;
        List<float> numbers = new List<float>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (loopSwitch == false) {
            Console.Write("Enter number: ");
            string numberInput = Console.ReadLine();
            float numberInputInt = float.Parse(numberInput);

            if (numberInputInt != 0) {
                numbers.Add(numberInputInt);
                listLen = numbers.Count;
                listSum += numberInputInt;
                listAvg = listSum / listLen;
                if (numberInputInt > maxNumber) {
                    maxNumber = numberInputInt;
                }
                if ((numberInputInt < minposNumber) && (numberInputInt > 0)) {
                    minposNumber = numberInputInt;
                }
            } else {
                loopSwitch = true;
                Console.WriteLine($"The sum is: {listSum}");
                Console.WriteLine($"The average is: {listAvg}");
                Console.WriteLine($"The largest number is: {maxNumber}");
                Console.WriteLine($"The smallest positive number is: {minposNumber}");
                Console.WriteLine("The sorted list is: ");
                numbers.Sort();
                foreach (float number in numbers) {
                    Console.WriteLine(number);
                }
            }
            

        }





    }
}