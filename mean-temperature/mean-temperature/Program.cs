/*
 * Grading ID: M5477
 * Lab: 5
 * Due Date: Mar 3 2019
 * Course Section: 01
 * Description: This program performs a sentinel loop to calculate a mean temperature.
 */

using static System.Console;

namespace mean_temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            const int STOP = 999, // The number being used to stop the program
                LOW = -20,        // The lowest temperature allowed
                HIGH = 130;       // The highest temperature allowed
            int counter = 0,    // A counter for the number of temperatures entered.
                temperature,    // The temperature reported by the user
                temperatureSum = 0; // The sum of temperatures provided by the user.
            double mean; // The mean temperature
            bool valid; // Boolean for if a valid temperature was entered

            WriteLine($"Enter temperatures from {LOW} to {HIGH} ({STOP} to stop)");
            Write("Enter temperature: ");
            valid = int.TryParse(ReadLine(), out temperature);

            while (temperature != 999)
            {
                if (valid && temperature >= LOW && temperature <= HIGH)
                {
                    temperatureSum += temperature;
                    counter++;

                    Write("Enter temperature: ");
                    valid = int.TryParse(ReadLine(), out temperature);
                }
                else
                {
                    WriteLine($"Valid temperatures range from {LOW} to {HIGH}. Please reenter temperature.");

                    Write("Enter temperature: ");
                    valid = int.TryParse(ReadLine(), out temperature);
                }
            }

            mean = (double)temperatureSum / counter;

            WriteLine($"You entered {counter} valid temperatures.");
            WriteLine($"The mean temperature is {mean:F1} degrees.");
        }
    }
}
