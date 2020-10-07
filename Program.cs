using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation val = new Validation();
            Console.WriteLine("Enter the first name of the user:");
            String firstName = Console.ReadLine();
            while (!val.FirstNameValidation(firstName))
            {
                Console.WriteLine("Enter a valid First Name with first letter as Capital and minimum 3 character");
               firstName= Console.ReadLine();
            }
            Console.WriteLine("Enter the last name of the user:");
            String lastName = Console.ReadLine();
            while(!val.LastNameValidation(lastName))
            {
                Console.WriteLine("Enter a valid Last Name with first letter as Capital and minimum 3 character");
                lastName = Console.ReadLine();
            }
            Console.WriteLine("Enter a valid Email Id: ");
            String email = Console.ReadLine();
            while(!val.EmailidValidation(email))
            {
                Console.WriteLine("Email Id is not valid. Enter Again: ");
                email = Console.ReadLine();
            }
            Console.WriteLine("Enter the Mobile Number of the User: ");
            String mobileNo = Console.ReadLine();
            while(!val.MobileNumberValidation(mobileNo))
            {
                Console.WriteLine("Enter a 10 digit mobile number preceeded with country code: ");
                mobileNo = Console.ReadLine();
            }
            Console.WriteLine("Enter a password: ");
            String password1 = Console.ReadLine();
            while(!val.PasswordValidation(password1))
            {
                Console.WriteLine("Enter a password with minimum 8 characters ");
                password1 = Console.ReadLine();
            }
            Console.WriteLine("Registration Successful.");
            Console.WriteLine("Name of the User :" + firstName + " " + lastName);
            Console.WriteLine("Email ID of User : " + email);
            Console.WriteLine("Mobile Number of User: " + mobileNo);

        }
    }
}
