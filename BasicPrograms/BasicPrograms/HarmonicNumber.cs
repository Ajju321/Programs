﻿//-----------------------------------------------------------------------
// <copyright file="HarmonicNumber.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class is use To  the Harmonic Number
    /// 1/1+1/2+1/3+1/4+1/5=2.2833333
    /// </summary>
 public class HarmonicNumber
    {
        /// <summary>
        /// The utility class
        /// </summary>
      readonly Utility utility = new Utility();

        /// <summary>
        /// This variable use to Take Number From User
        /// </summary>
    private int number;

        /// <summary>
        /// Harmonics the number.
        /// </summary>
        public void HarmonicNum()
        {
            Console.WriteLine("Enter The Number : ");
            this.number = this.utility.ReadInt();

            double result = this.utility.HarmonicNumber(this.number);
            Console.WriteLine(result);
        }
    }
}