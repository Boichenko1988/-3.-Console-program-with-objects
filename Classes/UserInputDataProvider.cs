using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Console_program_with_objects.Classes
{
    public class UserInputDataProvider
    {



        public string GetName()
        {
            Console.Write("Enter your Name: ");
            string firstName = Console.ReadLine();

            if (IsCorrectNameSurname(firstName))
            {
                return firstName;
            }
            else
            {
                int attempts = 0;
                while (attempts < 2)
                {
                    Console.WriteLine("Error! Please enter only symbols (A-Z): ");
                    firstName = Console.ReadLine();
                    if (IsCorrectNameSurname(firstName))
                    {
                        return firstName;
                    }
                    attempts++;
                }
                Console.WriteLine("Exceeded maximum attempts. Setting default value.");
                return "Default";
            }
        }

      


        private static bool IsCorrectNameSurname(string inputStr)
        {
            var pattern = new Regex("^[A-Za-z]{2,}$");
            return pattern.IsMatch(inputStr);

        }
        public Gender ChoiseGender()
        {
            Console.WriteLine("Choose your gender, press 1 if you male or 2 if you female: ");
          

            bool isCorrectMode = Enum.TryParse(Console.ReadLine(), out Gender gender);

            if (!isCorrectMode || !Enum.IsDefined(typeof(Gender), gender))
            {
                Console.Write("Error, pleace try again: ");
                gender=ChoiseGender();
            }
            else
            {
                if (gender == Gender.Male)
                {
                    return Gender.Male;
                }
                else if (gender == Gender.Female)
                {
                    return Gender.Female;
                }
            }
         
            return gender;

        }

        public int GetUserAge()
        {
            int age = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    if (age >= 1 && age <= 120)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Error! Age must be between 1 and 120. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Error! Invalid input. Please enter a valid number.");
                }
            }

            return age;
        }


    }
}
