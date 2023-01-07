using System; // means that we can use classes form the System namespace
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

// Press F5 to compile and execute code

// ** SYNTAX, OUTPUT ** //

namespace HelloWorld     // namespace is a container for classes and other namespaces. Used to organise code
{
    class Program       // class is a container for data and methods. Every lien of code thats run in C# must be inside a class
    {                   // In this example we named the class Program
        static void Main(string[] args)     // This is the Main Method
        {
            Console.WriteLine("Hello World");       // Console is the class of the system space which has a WriteLine() method
                                                    // WriteLine() method prints text
                                                    // If you omit 'using System' then you would write System.Console.WriteLine() instead

            // You can also use the WriteLine method to perform mathematical calculations
            Console.WriteLine(5 * 6);

            // Write prints output too but not on a seperate line
            Console.Write("Today is Saturday ");
            Console.Write("French fries");


            // ** VARIABLES ** //

            // data types
            /* int - stores whole numbers from -2147483648 to 2147483647
             * long - stores large whole numbers from -9223372036854775808 to 9223372036854775807.
             *        End the value with an 'L'
             * float, double , decimal - stores decimal numbers. In order of presicison and bit size. 
             *                          Use 'F' after the number for a float, D for double
             * char - stores single characters in 'A'
             * string - stores text in "It's cold"
             * bool - stores true or false */

            // to create a variable you must specifiy the style and assign it a value
            int myNumber = 64;
            Console.WriteLine(myNumber);

            double myDoubleNum = 3.846527D;
            bool myBool = false;
            char myChar = 'a';

            // once a variable has been declared it doesnt need to be declared again
            string myColour = "green";
            myColour = "purple";
            Console.WriteLine(myColour);

            // Constants

            //if you dont want a variable to be overwritten you can declare a variable as 'const' 
            const int myFaveNum = 824;
            // myFaveNum = 7256; this gives an error as myFaveNum cannot be overwrittern
            Console.WriteLine(myFaveNum);

            // Display Variables 

            // use '+' to combine text and a variable in the console window
            Console.WriteLine(myColour + " is my favourite colour!");

            // or concatenation
            string firstName = "Fred ";
            string surName = "Flinstone";
            string name = string.Concat(firstName, surName);
            Console.WriteLine(name);

            // or interpolation
            string name2 = $"My full name is : {firstName} {surName}";
            Console.WriteLine(name2);

            // Declare many variables
            // you can declare multiple variables of the same type using a comma seperated list
            string myFriend1 = "Gemma", myFriend2 = "Lucy", myFriend3 = "Fred";
            Console.WriteLine(myFriend1 + myFriend2 + myFriend3);


            // ** Casting ** //
            // when a variable is converted by one data type to another
            double myDouble = 93.2648D;
            // you have to put the new type in parantheses
            int myInt = (int)myDouble;
            Console.WriteLine(myInt); // outputs 93

            /* There are also build-in conversion methods such as:
             * Convert.ToBoolean
             * Convert.ToDouble
             * Convert.ToString
             * Convert.ToInt32(int)
             * Convert.ToInt64(long) */
            // example
            int myInt1 = 82;
            double myDouble1 = 8345.97356D;
            bool myBoolean = true;

            Console.WriteLine(Convert.ToDouble(myInt1));
            Console.WriteLine(Convert.ToInt32(myDouble1));
            Console.WriteLine(Convert.ToString(myBoolean));


            // ** Get User Input ** //
            // use the method ReadLine to get user input
            // Example: asking for a username
            Console.WriteLine("Enter username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Your username is " + userName);

            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();
            Convert.ToInt32(age);
            Console.WriteLine("You are " + age + " years old!");


            // ** Operators ** //
            /* x += 3       is the same as  x = x + 3
               x ^= 3       is the same as  x = x ^ 3  
               x != y       means x is not equal to y

            logical operators
               x < 5 && y > 2       returns true is both statements are true
               x < 5 || y > 2       returns true is one statement is true
               !(x < 5 && y > 2"    returns true is both statements are false */


            // ** Maths methods ** //

            // find the highest values out of the two values given
            Console.WriteLine(Math.Max(23, 45));
            // finds the lowest
            Console.WriteLine(Math.Min(23, 45));
            // finds the square root of a value
            Math.Sqrt(64);
            // finds the absolute value (positive) of a value
            Math.Abs(-273);
            // Rounds a values to nearest whole number
            Math.Round(2.378);

            // ** Strings ** //

            // find the length of a string
            string myAnimals = "Dog, Cat, Mouse, Frog, Giraffe";
            Console.WriteLine(myAnimals.Length);

            // change a string to upper and lower case
            Console.WriteLine(myAnimals.ToUpper());
            Console.WriteLine(myAnimals.ToLower());

            // Access strings
            // access characters in a string
            string myString = "Hello. How are you?";
            Console.WriteLine(myString[0] + " " + myString[4]);      // prints H o

            // finds the index position of specific character
            Console.WriteLine(myString.IndexOf("e"));      // outputs 1

            // creates a new string from a string
            int charPos = myString.IndexOf("y");
            string yourString = myString.Substring(charPos);
            Console.WriteLine(yourString);

            // if you want to use double quotes, commas or backslash in strings 
            string play = "Chloe said, \"I love this TV program \"";
            string txt = "Lucy\'s dog is called Archie";
            string text = "Here\'s how you use a \\ in a string";
            // \n for a new line


            // ** Booleans ** //

            // example of using booleans
            bool amI24YearsOld = true;
            bool doILikeBananas = false;
            Console.WriteLine(amI24YearsOld);   // outputs True
            Console.WriteLine(doILikeBananas);  // outputs False

            // Using Booleans for logic
            int x = 3; int y = 6;
            Console.WriteLine(x > y);       // outputs False
            Console.WriteLine(37 > 2);        // outputs True
            Console.WriteLine(23 == 12);    // outputs False

            // ** If...., ifelse and Else statements ** //
            Console.WriteLine("Hello. Welcome to the voting centre. Enter your age to see \n what elections you are eligable for.");
            Console.WriteLine("Enter your age: ");
            String usersAge = Console.ReadLine();
            int usersAgeInt = Convert.ToInt32(usersAge);
            if (usersAgeInt >= 18)
            {
                Console.WriteLine("You are eligible to vote in all elections!");

            }
            else if (usersAgeInt >= 16 && usersAgeInt <= 18)
            {
                Console.WriteLine("You are eligible to vote in the young peoples election");
            }
            else
            {
                Console.WriteLine("Unfortunatly you are not eligible to \n vote as you are below 18 years old");

            }

            // Ternary operator. alternative tif using a simple if statement
            string fruit = "plum";
            string result = (fruit == "grape") ? "Thats a match" : "Thats not a match";
            Console.WriteLine(result);
            // prints false


            // ** Switch Statememts ** //
            // use when you have many if statements
            int calc = 4;
            switch (calc)
            {
                case 1:
                    Console.WriteLine(calc + " + 2 = " + (calc + 2));
                    break;
                case 2:
                    Console.WriteLine(calc + " x by 6 = " + (calc * 6));
                    break;
                case 3:
                    Console.WriteLine(calc + " - 4 = " + (calc - 4));
                    break;
                default:
                    Console.WriteLine("do nothing");
                    break;
            }
            // outputs 3 - 4 = -1


            // ** LOOPS ** //

            // while loop example 
            int time = 8;
            while (time >= 7 && time < 12)
            {
                Console.WriteLine("It\'s morning time");
                time++;
            }
            Console.WriteLine("It\'s the afternoon");

            // do while loop
            // prints i from 5 to 1. stops when i = 0
            int i = 5;
            do
            {
                Console.WriteLine(i);
                i--;
            } while (i > 0);

            // ** FOR LOOPS ** //
            // if you know how mnay loop you want to do use a for loop
            for (int k = 7; k < 10; k++)
            {
                Console.WriteLine(k);
            }

            // nested loops
            for (int noOfSweets = 5; noOfSweets > 0; --noOfSweets)
            {
                Console.WriteLine("You've eaten one sweet!");

                for (int noOfRolls = 0; noOfRolls <= 0; ++noOfRolls)
                {
                    Console.WriteLine("You've gotten chubbier");
                }
            }

            // foreach loops
            // used only for loops in an array
            string[] flowers = { "Viola", "Pansie", "Rose", "Sunflower" };
            foreach (string f in flowers)
            {
                Console.WriteLine(f);
                if (f == "Rose")
                    continue;               // continues the loop
            }


            // ** Arrays ** //
            // used to declare mutliple values in a single variable instead of declaring seperate values
            string[] houses = { "flat", "bungalow", "detatched", "semi-detatched" };
            Console.WriteLine(houses[3]);

            // to change a specific value refer to teh index number
            houses[3] = "house share";
            Console.WriteLine(houses[3]);

            // to find out how many elements an array
            Console.WriteLine(houses.Length);

            // other ways to write arrays
            // Create an array of four elements, and add values later
            string[] birds = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] clothes = new string[] { "hat", "trousers", "t-shirt", "socks" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] drinks = { "tea", "coffee", "lemonade", "water" };

            // if you declare an array and initialise it later you have to use the new keyword
            // declare on array
            string[] dogs;

            // add values using new
            dogs = new string[] { "labarador", "spaniel", "dashund", "yorkshire terrier" };
            Console.WriteLine(dogs);

            // loop through an array
            string[] juice = { "orange", "apple", "cramberry", "pinapple", "mango" };
            for (int j = 0; j < juice.Length; j++)
            {
                Console.WriteLine(juice[j]);
            }

            // can also use foreach loops ot loop through arrays (see line 270)

            // sort an array
            // sorts into alphabetical order
            Array.Sort(juice);
            foreach (string q in juice)
            {
                Console.WriteLine(q);
            }

            // 
            int[] numberList = { 1, 2, 3, 55, 34, 72, 83 };
            x = numberList.Max();
            Console.WriteLine(x);
            // .Sum     finds the sum of the array
            // .Min     finds the minimum value in the array

            // multidimesnional arrays
            // to create a 2D array, add each array within its own set of curly braces

            int[,] numbers = { { 1, 2, 7 }, { 3, 6, 9 } };
            Console.WriteLine(numbers[0, 2]);

            // int[,,] makes a 3D array

            // changing elements of a 2D array
            int[,] moreNumbers = { { 2, 4, 6 }, { 5, 7, 9 } };
            moreNumbers[0, 0] = 5;
            Console.WriteLine(moreNumbers[0, 0]);

            // loop through a 2D array
            // you need to use one loop for each dimension
            // we have to use GetLength
            int[,] moreNumbers2 = { { 4, 2, 1 }, { 5, 3, 2 } };
            for (int s = 0; s < moreNumbers2.GetLength(0); s++)
            {
                for (int l = 0; l < moreNumbers2.GetLength(1); l++)
                {
                    Console.WriteLine(moreNumbers2[s, l]);
                }
            }
        }








    }
}