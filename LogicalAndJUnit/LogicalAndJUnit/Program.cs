﻿//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace LogicalAndJUnit
{
    using System;

    /// <summary>
    /// Main program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
        Label:
            try
            {
                int choice;
                bool flag = true;
                Utility utility = new Utility();
                while (flag)
                {
                    Console.WriteLine(" 1. Coupon Number ");
                    Console.WriteLine(" 2. Start Time ");
                    Console.WriteLine(" 3. Gambler ");
                    Console.WriteLine(" 4. Vending Machine ");
                    Console.WriteLine(" 5. Day Of Week ");
                    Console.WriteLine(" 6. Temprature Conversion ");
                    Console.WriteLine(" 7. Monthly Payment ");
                    Console.WriteLine(" 8. Square Root ");
                    Console.WriteLine(" 9. Exit ");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                    Console.WriteLine(" Enter Your Choice ");
                    choice = utility.ReadInt();
                    switch (choice)
                    {
                        case 1:
                            CouponNumber genrateCoupon = new CouponNumber();
                            genrateCoupon.GenrateCoupon();
                            break;
                        case 2:
                            StopwatchSimulate st = new StopwatchSimulate();
                            st.SimulateTime();
                            break;
                        case 3:
                            Gambler g = new Gambler();
                            g.WinOrLoss();
                            break;
                            case 4:
                            VendingMachine vm = new VendingMachine();
                            vm.MachineVending();
                            break;
                        case 5:
                            DayOfWeek dw = new DayOfWeek();
                            dw.WeekDay();
                            break;
                        case 6:
                            TemperatureConversion tc = new TemperatureConversion();
                            tc.TempConversion();
                            break;
                        case 7:
                            MonthlyPayment mp = new MonthlyPayment();
                            mp.MonthlyPay();
                            break;
                        case 8:
                            SquareRoot sr = new SquareRoot();
                            sr.FindSquareRoot();
                            break;
                        case 9:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong Input please Try Agian");
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter correct option");
                goto Label;
            }
        }
    }
}