using System;

namespace UsernameExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string newPassword;
            string passwordVerification;

            Console.WriteLine("Please enter your new password.");
            newPassword = Console.ReadLine();
            Console.WriteLine("Please re-enter your password for verification.");
            passwordVerification = Console.ReadLine();


            if (newPassword == passwordVerification)
            {
                Console.WriteLine("Your new password has been accepted!");
            }
            else
            {
                Console.WriteLine("Your verification did not match.");
            }
            Console.ReadLine();
        }   

    }
}
