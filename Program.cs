using System;

namespace UserInfo 
{
    struct UserDetails
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name, please: ");
            string userName = Console.ReadLine();

            Console.Write("please, input your surname: ");
            string userSurname = Console.ReadLine();

            Console.Write("Please, enter your city of birth: ");
            string city = Console.ReadLine();

            Console.Write("please, enter your Age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine($"Details of the User are name: {userName} surname:{userSurname} city:{city} age:{userAge} ");

        }
    }
}