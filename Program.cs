using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // different variable types examples. 
            string characterName = "Cody";
            char initialLastName = 'M';
            int characterAge = 25;
            double gpa = 3.8;
            bool isMale = true;

            Console.WriteLine("The character " + characterName + " is " + characterAge + " years old."); // write a line with newline characters at end.

            Console.Write("Hello "); // write a string with no newline char at end
            Console.Write("World\n");

            Console.WriteLine("The capitalized name is " + characterName.ToUpper()); // you can use string meathods 

            Console.WriteLine("First initial: " + characterName[0] + " Last Initial: " + initialLastName); // you can use string indexing

            Console.ReadLine(); // wait for user to press enter before closing. 

            //////////Math///////////

            Console.WriteLine(5 + 5);
            Console.WriteLine("Modulus of 10 / 5 is: " + 10 % 5);

            characterAge++;
            Console.WriteLine("Happy Birthday! You are now " + characterAge);

            Console.WriteLine("The max of 4 and 90 is: " + Math.Max(4, 90));



            //////////User input///////////

            Console.Write("input a sting: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("You typed " + userInput + " and the length is " + userInput.Length);


            //////////Calculator///////////

            Console.Write("type in the first number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("type in the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is {0}", (num + num2));

            //////////Arrays///////////

            string[] catNames = { "Joey", "Pheeb", "Dwight" };
            Console.WriteLine("In order from youngest to oldest: {0}, {1} and {2}", catNames[2], catNames[0], catNames[1]);
            catNames[0] = "Dumbo";
            Console.WriteLine($"Joey is now {catNames[0]}");
            string catIntroduction = $"Introducing {catNames[0]}, {catNames[1]} and {catNames[2]}";
            Console.WriteLine(catIntroduction);

            //////////calling functions///////////

            SayHi("Cody");

            Console.WriteLine($"5 cubed is {CubeNumber(5)}");

            //////////conditional statements///////////

            bool isOver18 = true;
            if (isOver18)
            {
                Console.WriteLine("You are over 18");
            } else
            {
                Console.WriteLine("You are a youngster");
            }

            Console.WriteLine($"The max between 2 and 3 is {GetMax(2, 3)}");

            string is25GreaterThan20 = (25 > 20) ? "Yes" : "No";

            Console.WriteLine($"Is 25 > 20? {is25GreaterThan20}");

            Book book1 = new Book("Refrigerators", "Bob Vance", 1000);
            Console.WriteLine($"{book1.author} wrote {book1.title}");

            Student cody = new Student("Cody", "Comp Sci", 3.9);
            Console.WriteLine($"It is {cody.HasHonors()} that Cody has honors.");

            cody.Gpa = -1.0;

            Console.WriteLine($"It is {cody.HasHonors()} that Cody has honors.");

            Console.WriteLine($"There are currently {cody.GetStudentCount()} students.");
        }

        static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}.");
        }

        static int CubeNumber(int num)
        {
            return num * num * num;
        }

        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

    }
}
