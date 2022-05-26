//auto-generated code start
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;//declared for Thread.Sleep(1000); (line 43)

namespace Indietro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //auto-generated code end
            Console.Clear(); //clears the console from texts
            string titolo = @"

████████╗░█████╗░██████╗░███╗░░██╗░█████╗░  ██╗███╗░░██╗██████╗░██╗███████╗████████╗██████╗░░█████╗░
╚══██╔══╝██╔══██╗██╔══██╗████╗░██║██╔══██╗  ██║████╗░██║██╔══██╗██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
░░░██║░░░██║░░██║██████╔╝██╔██╗██║███████║  ██║██╔██╗██║██║░░██║██║█████╗░░░░░██║░░░██████╔╝██║░░██║
░░░██║░░░██║░░██║██╔══██╗██║╚████║██╔══██║  ██║██║╚████║██║░░██║██║██╔══╝░░░░░██║░░░██╔══██╗██║░░██║
░░░██║░░░╚█████╔╝██║░░██║██║░╚███║██║░░██║  ██║██║░╚███║██████╔╝██║███████╗░░░██║░░░██║░░██║╚█████╔╝
░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝  ╚═╝╚═╝░░╚══╝╚═════╝░╚═╝╚══════╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░

 - Crediti: Calabrese#0001 - 
 - Github: https://github.com/Nick06888/ -

            ";
            //Console.WriteLine and Console.Write are the same thing but with the first "command" uses the whole line
            Console.WriteLine(titolo); //prints on the console the string titolo
            Console.Title = "Calabrese#0001 - Pronto"; //changes console's title
            Console.BackgroundColor = ConsoleColor.DarkGreen; //changes font color
            Console.Write("Numero >"); //prints on the screen "Numero >" (translated into english: Number >)
            Console.BackgroundColor = ConsoleColor.Black; //resets font color

            Console.Write(" "); //prints space on the console for the input
            long a = Convert.ToInt64(Console.ReadLine()); //listens for input, long (integer) "a" will become the number you'll type  
            Console.Clear(); //clears the console from texts
            Console.BackgroundColor = ConsoleColor.DarkGreen; //changes font color
            Console.WriteLine("Caricamento..."); //prints "Caricamento..." on the console (translated in english: Loading...)
            Console.BackgroundColor = ConsoleColor.Black; //resets font color
            Thread.Sleep(1000); //took from System.Threading declared at the top of the code, it makes the program wait 1000 ms (1s) making the loading... effect
            Console.Clear(); //clears the console from texts
            if (a < 0 || a == 0) //this boolean expression (it means that can return True [happened] or False [Didn't happen]) checks if the number you typed is negative or equal to zero
            {
                Console.BackgroundColor = ConsoleColor.DarkRed; //changes font color
                Console.Write("Coglione il numero deve essere positivo e diverso da zero!");//prints on the console an italian expression to say "you did something wrong" because we don't wanna that the number we typed go under 0
                Console.ReadKey();//waits for user key (enter, space...)
                return;//it stops the program process
            }

            //      - THE MOST IMPORTANT PART IN THE CODE -
            // --------------------------------------------------
            //for cycle which prints the number backwards until 0:
            // 1) We declare the long b which is equal to a, suppose we typed the number 10, long b will be 10
            // 2) We declare when the program stops, in this case it will stop when b will be minor or equal to a (never), so we created an infinite loop
            // 3) We declare what the program must do when it's in the cycle, in this case every time the cycle restarts it will subtract 1 to long b
            // PS: We can also use:
            // while (true) {
            //
            //    if (b == 0) {
            //       ...
            //       replace return; with break;
            //    }
            // }
            for (long b = a; b <= a; b--)
            {
                
                if (b == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red; //changes font color
                    Console.Write(String.Format(b + " <- Fine")); //when b becomes 0 will print 0 <- Fine (translated in english: 0 <- End)
                    Console.Title = "Calabrese#0001 - Completato";//changes the console title
                    Console.BackgroundColor = ConsoleColor.Black; //resets font color
                    Console.Write("\nGrazie per aver usato il mio programma!"); // "Press enter to continue"
                    Console.ReadKey();//waits for user key (enter, space...)
                    return;//if b is equal to 0 it stops the program process
                }
                Console.WriteLine(b);//prints the value of 
                Console.Title = String.Format("Calabrese#0001 - "+b);//changes the console title with the value of b
            }
            // --------------------------------------------------


        }
    }
}
//PS: Sorry for my bad english
//-----------------------------------------------------------------------------------------------------//

//░█▀▀█ ▒█▄░▒█ 　 ▀█▀ ▀▀█▀▀ ░█▀▀█ ▒█░░░ ▀█▀ ░█▀▀█ ▒█▄░▒█ 　 ▒█▀▀█ ▒█▀▀█ ▒█▀▀▀█ ▒█▀▀█ ▒█▀▀█ ░█▀▀█ ▒█▀▄▀█ 
//▒█▄▄█ ▒█▒█▒█ 　 ▒█░ ░▒█░░ ▒█▄▄█ ▒█░░░ ▒█░ ▒█▄▄█ ▒█▒█▒█ 　 ▒█▄▄█ ▒█▄▄▀ ▒█░░▒█ ▒█░▄▄ ▒█▄▄▀ ▒█▄▄█ ▒█▒█▒█
//▒█░▒█ ▒█░░▀█ 　 ▄█▄ ░▒█░░ ▒█░▒█ ▒█▄▄█ ▄█▄ ▒█░▒█ ▒█░░▀█ 　 ▒█░░░ ▒█░▒█ ▒█▄▄▄█ ▒█▄▄█ ▒█░▒█ ▒█░▒█ ▒█░░▒█

//-----------------------------------------------------------------------------------------------------//
