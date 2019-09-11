using System;
using ChallengeResitGevin;
using NUnit.Framework;
using System.Collections.Generic;

namespace ProgramResitGevin
{
    class ProgramResit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for Square");
            Console.WriteLine("Press 2 for Rectangle");
            Console.WriteLine();

            ConsoleKeyInfo Menu1;

            Menu1 = Console.ReadKey();

            if (Menu1.Key == ConsoleKey.D1)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("What is the color?");
                    Console.WriteLine();
                    string userInput = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("What is the length of the side?");
                    Console.WriteLine();
                    int userInput2 = int.Parse(Console.ReadLine());
                    Square newSquare = new Square(userInput, userInput2);
                    Console.WriteLine();
                    Console.WriteLine("Color = " + userInput);
                    Console.WriteLine("Perimeter =  " + newSquare.GetPerimeter());
                    Console.WriteLine("Area =  " + newSquare.GetArea());
                }
                catch (InvalidIntException m)
                {
                    Console.WriteLine();
                    Console.WriteLine(m.Message);
                }
                catch (System.FormatException m)
                {
                    Console.WriteLine();
                    Console.WriteLine(m.Message);
                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                }
            }

            if (Menu1.Key == ConsoleKey.D2)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("What is the color?");
                    Console.WriteLine();
                    string userInput = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("What is the first sides length?");
                    Console.WriteLine();
                    int userInput2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (userInput2 < 1)
                    {
                        throw (new InvalidIntException(""));
                    }
                    Console.WriteLine();
                    Console.WriteLine("What is the second sides length?");
                    Console.WriteLine();
                    int userInput3 = int.Parse(Console.ReadLine());
                    Rectangle newRectangle = new Rectangle(userInput, userInput2, userInput3);
                    Console.WriteLine();
                    Console.WriteLine("Color =  " + userInput);
                    Console.WriteLine("Perimeter =  " + newRectangle.GetPerimeter());
                    Console.WriteLine("Area =  " + newRectangle.GetArea());
                }
                catch (InvalidIntException m)
                {
                    Console.WriteLine();
                    Console.WriteLine(m.Message);
                }
                catch (System.FormatException m)
                {
                    Console.WriteLine();
                    Console.WriteLine(m.Message);
                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}








