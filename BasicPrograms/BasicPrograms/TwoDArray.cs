﻿// <copyright file="TwoDArray.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace BasicPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class is use to implements operation on array like insert Integer, double and boolean
    /// </summary>
   public class TwoDArray
     {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
       public static void Main(string[] args)
        {
        Label: try
            {
                Utility utility = new Utility();

                //// Creating and initializing of array Object

                object[,] array = new object[2, 2];

                ////takes the integer from the user
                Console.WriteLine("Enter the Elements for Interger Array : ");
                for (int r = 0; r < 2; r++)
                {
                    for (int c = 0; c < 2; c++)
                    {
                        ////takes the double type of values
                        array[r, c] = utility.ReadInt();
                    }
                }

                ////display the interger array
                Console.WriteLine("Display the interger Matrix");
                utility.DisplayArray(array);

                ////Inser the double values into the array
                Console.WriteLine("Enter the Elements for Double  Array : ");
                for (int r = 0; r < 2; r++)
                {
                    for (int c = 0; c < 2; c++)
                    {
                        ////takes the double type of values
                        array[r, c] = utility.ReadDouble();
                    }
                }
                ////display the double double type array
                Console.WriteLine("Display the Double Matrix");
                utility.DisplayArray(array);

                ////insert the boolean type values into array
                Console.WriteLine("Enter the Elements for Boolean Array : ");
                for (int r = 0; r < 2; r++)
                {
                    for (int c = 0; c < 2; c++)
                    {
                        ////takes the boolean type of values
                        array[r, c] = utility.ReadString();
                    }
                }

                ////display the boolean type of array
                Console.WriteLine("Displsay the boolean Array");
                utility.DisplayArray(array);

                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter correct input");
                goto Label;
            }
        }
    }
}