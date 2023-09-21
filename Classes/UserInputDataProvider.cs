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
         


        public string GetUserName()
        {

            Console.Write("Enter your Name: ");
            string firstName = Console.ReadLine();

            if (IsCorrectNameSurname(firstName))
            {
                return firstName;
            }
            else
            {
                Console.WriteLine("Error! Please enter only symbols(A-Z): ");
                GetUserName();
            }
            return firstName;
        }
        public string GetLastName()
        {
            Console.Write("Enter your LastName: ");
            string lastName = Console.ReadLine();

            if (IsCorrectNameSurname(lastName))
            {
                return lastName;
            }
            else
            {
                Console.WriteLine("Error! Please enter only symbols(A-Z): ");
                GetLastName();
            }
            return lastName;

        }
        private static bool IsCorrectNameSurname(string inputStr)
        {
            var pattern = new Regex("[A-Za-z]+$");
            return pattern.IsMatch(inputStr);

        }
        public Gender ChoiseGender()
        {
            Console.WriteLine("Choose your gender, press 1 if you male or 2 if you female: ");
            int gender = Convert.ToInt32(Console.ReadLine());

            if (gender == 1)
            {
                return Gender.Male;
            }
            else if (gender == 2)
            {
                return Gender.Female;
            }
            else
            {
                Console.Write("Error, pleace try again: ");
                ChoiseGender();
            }
            Gender genderUser = (Gender)gender;

            return genderUser;

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
