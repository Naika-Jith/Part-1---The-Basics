using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1___The_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro Tutorial

            //Hello World
            Console.WriteLine("Hello World!");

            //Assigning a Variable
            string aFriend = "Bill";
            Console.WriteLine(aFriend);

            aFriend = "Maira";
            Console.WriteLine(aFriend);
            Console.WriteLine( "Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend} ");

            string firstFriend = "Maira";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

            //
            string greeting = "          Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");
            //

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello );

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            //Exploring Contains

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            //Input, Output and Variables

            //1.
            string firstName = "Zainab";
            Console.WriteLine($"Hey there, {firstName}");
            Console.WriteLine("Het there," + firstName);

            //2.

            string passPhrase = "Hey There";
            Console.WriteLine($"The passPhrase {passPhrase} has {passPhrase.Length} characters");

            //3.

            // The trim () method romeoves all leading trailing whitespace character

            //4. 

            string schoolCheer = "Programmers are the best!";
            Console.WriteLine( schoolCheer.ToUpper());

            //5.

            string theSong = "I like the stars, you like the moon";
            Console.WriteLine(theSong.StartsWith("you"));
            Console.WriteLine(theSong.EndsWith("moon"));

          




        }
    }
}
