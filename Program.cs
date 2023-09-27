using Console_program_with_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_program_with_objects.Classes;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            UserInputDataProvider userInputDataProvider = new UserInputDataProvider();
            User newUser = new User(userInputDataProvider.GetUserAge());

            newUser.FirstName = userInputDataProvider.GetName();
            newUser.LastName = userInputDataProvider.GetName();
            newUser.ChoiseGend = userInputDataProvider.ChoiseGender();


            var getInfoForUser = newUser.ToString();
            Console.WriteLine(getInfoForUser);
        }
    }
}

