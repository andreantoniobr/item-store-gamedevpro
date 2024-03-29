using System;

namespace FinalItemStore
{
    public class InputController
    {
        public static int GetUserInput()
        {
            int userInputInt;
            string userInputString = Console.ReadLine().Trim();            

            if (int.TryParse(userInputString, out userInputInt))
            {
                userInputInt--;
                return userInputInt;
            }
            else
            {
                return -1;
            }
        }
    }
}