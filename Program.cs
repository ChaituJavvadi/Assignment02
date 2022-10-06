using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Program
    {
        static int lengthOfRectangle;
        static int widthOfRectangle;
        static int menuOption;
        static void Main(string[] args)
        {
            //Prompt user for length and width of rectangle
            bool validLength = true;
            do
            {
                Console.WriteLine("Enter the length of the rectangle");
                validLength = int.TryParse(Console.ReadLine(), out var userLength);
                if (validLength)
                {
                    if (userLength <= 0)
                    {
                        Console.WriteLine("Please enter a number greater than zero");
                        validLength = false;
                    }
                    else
                    {
                        lengthOfRectangle = userLength;
                    }
                }
                else
                {
                    Console.WriteLine("Enter an integer value");
                }

            } while (!validLength);


            bool validWidth = true;
            do
            {
                Console.WriteLine("Enter the width of the rectangle");
                validWidth = int.TryParse(Console.ReadLine(), out var userWidth);
                if (validWidth)
                {
                    if (userWidth <= 0)
                    {
                        Console.WriteLine("Please enter a number greater than zero");
                        validWidth = false;
                    }
                    else
                    {
                        widthOfRectangle = userWidth;
                    }
                }
                else
                {
                    Console.WriteLine("Enter an integer value");
                }

            } while (!validWidth);

            Menu();
        }

        //Method to display options
        public static void Menu()
        {
            bool validOption = true;
            bool exit = false;
            do
            {
                // Validate user selected option
                do
                {
                    Console.WriteLine("Please choose an option \n 1.Get Rectangle Length \n 2.Change Rectangle Length \n 3.Get Rectangle Width \n 4.Change Rectangle Width \n 5. Get Rectangle Perimeter \n 6.Get Rectangle Area \n 7.Exit ");
                    validOption = int.TryParse(Console.ReadLine(), out var userOption);
                    if (validOption)
                    {
                        if (userOption < 1 || userOption > 7)
                        {
                            Console.WriteLine("Please choose valid option(1-7)");
                            validOption = false;
                        }
                        else
                        {
                            menuOption = userOption;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid number");
                    }
                } while (!validOption);

                // Perform functions based on user selection
                Rectangle rectangle = new Rectangle(lengthOfRectangle, widthOfRectangle);
                switch (menuOption)
                {
                    case 1:
                        var length = rectangle.GetCurrentLength();
                        Console.WriteLine("Length of rectangle is :" + length);
                        break;
                    case 2:
                        bool validLength = true;
                        do
                        {
                            Console.WriteLine("Enter the new length of the rectangle");
                            validLength = int.TryParse(Console.ReadLine(), out var userLength);
                            if (validLength)
                            {
                                if (userLength <= 0)
                                {
                                    Console.WriteLine("Please enter a number greater than zero");
                                    validLength = false;
                                }
                                else
                                {
                                    lengthOfRectangle = userLength;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Enter an integer value");
                            }

                        } while (!validLength);
                        var newLength = rectangle.SetNewLength(lengthOfRectangle);
                        Console.WriteLine("New length of rectangle is :" + newLength);
                        break;
                    case 3:
                        var width = rectangle.GetCurrentWidth();
                        Console.WriteLine("Width of rectangle is :" + width);
                        break;
                    case 4:
                        bool validWidth = true;
                        do
                        {
                            Console.WriteLine("Enter the new width of the rectangle");
                            validWidth = int.TryParse(Console.ReadLine(), out var userWidth);
                            if (validWidth)
                            {
                                if (userWidth <= 0)
                                {
                                    Console.WriteLine("Please enter a number greater than zero");
                                    validWidth = false;
                                }
                                else
                                {
                                    widthOfRectangle = userWidth;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Enter an integer value");
                            }

                        } while (!validWidth);
                        var newWidth = rectangle.SetNewWidth(widthOfRectangle);
                        Console.WriteLine("New width of rectangle is :" + newWidth);
                        break;
                    case 5:
                        var perimetre = rectangle.GetPerimeter();
                        Console.WriteLine("Perimetre of rectangle is :" + perimetre);
                        break;
                    case 6:
                        var area = rectangle.GetArea();
                        Console.WriteLine("Area of rectangle is :" + area);
                        break;
                    case 7:
                        exit = true;
                        break;
                    default:
                        break;
                }
            } while (!exit);
            Console.ReadLine();
        }
    }
}
