using System;

namespace Ref_and_out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:");
            string name = Console.ReadLine();
            //creates value "name" as string, user input of readline inbuilt function
            string message = MakeGreeting(name);
            //calls makegreeting function, sets string "message" equal to result
            Console.WriteLine(message);

            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            int nameLength = FullName(name, lastName, out string fullname);
            Console.WriteLine("Your full name is " + fullname + ". It has this many letters: "
                + nameLength);

            Capitalize(ref fullname);
            Console.WriteLine("Your name in uppercase: " + fullname);

            Console.WriteLine("Press any key to exit"); //writeline function seems to be a print function
            Console.ReadKey();
        }
        static string MakeGreeting(string name)
        {
            return "Hello " + name + "!!";

        }
        static int FullName(string firstName, string lastName, out string fullName)
        {
            //this function uses two arguments, firstName and lastName, and returns a new 
            //value: fullName with the out function. the out function initializes the 
            //object in this function. It also seems to implicitly return an Int because of the 
            // static int specified in the call
            fullName = firstName + " " + lastName;
            return fullName.Length;
        }
        static void Capitalize(ref string fullname)
        {
            fullname = fullname.ToUpper();
            //this function accepts an argument "fullname" with ref, and returns the 
            //already initialized object "fullname". ref passes arguments both ways
        }
    }
}
