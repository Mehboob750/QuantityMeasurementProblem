//-----------------------------------------------------------------------
// <copyright file="Length.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Mehboob Shaikh</author>
//-----------------------------------------------------------------------
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]

namespace QuantityMeasurementProblem
{
    using System;

    /// <summary>
    /// This Class is Used To Compare and Add two Lengths
    /// </summary>
    public class Length
    {
        /// <summary>
        /// This value is used At the Time Of Feet to Inch Conversion
        /// </summary>
        private double feetToInchValue = 12.0;

        /// <summary>
        ///  This value is used At the Time Of Yard to Inch Conversion
        /// </summary>
        private double yardToInchValue = 36.0;

        /// <summary>
        ///  This value is used At the Time Of cm to Inch Conversion
        /// </summary>
        private double centiMeterToInchValue = 2.5;

        /// <summary>
        /// Enum is Used To Declare Enumerated Constants
        /// </summary>
        public enum Unit 
        { 
            /// <summary>
            /// It Indicates that Length is in Inch
            /// </summary>
            Inch, 
           
           /// <summary>
           /// It is Used To Convert The Value Of Feet into Inch
           /// </summary>
            FeetToInch,

            /// <summary>
            /// It is Used To Convert The Value Of Yard into Inch
            /// </summary>
            YardToInch,

            /// <summary>
            /// It is Used To Convert The Value Of cm into Inch
            /// </summary>
            CentiMeterToInch
        }

        /// <summary>
        /// This Method Is used to Convert The Length from one to Another
        /// </summary>
        /// <param name="unit">It tells us About the Which Length is to be Convert</param>
        /// <param name="value">It Contains the value Which we convert</param>
        /// <returns>It Returns the Converted Value into Inch Format</returns>
        public double ConvertValueToInch(Unit unit, double value)
        {
            try
            {
                // Check If Unit Is Equal To FeetToInch Then Convert The Feet Value Into Inch
                if (unit.Equals(Unit.FeetToInch))
                {
                    return value * this.feetToInchValue;
                }
                else if (unit.Equals(Unit.YardToInch))
                {
                    return value * this.yardToInchValue;
                }
                else if (unit.Equals(Unit.CentiMeterToInch))
                {
                    return value / this.centiMeterToInchValue;
                }

                return value;
            }
            catch (Exception e)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// This Method Performs The Addition of two inch Values
        /// </summary>
        /// <param name="firstInchValue">It Contains the First Inch Value</param>
        /// <param name="secondInchValue">It Contains The Second Inch Value</param>
        /// <returns>It Returns The Addition of that two values in inch Format</returns>
        public double AddTWoLengths(double firstInchValue, double secondInchValue)
        {
            // Add the two Inch Values
            return firstInchValue + secondInchValue;
        }
    }
}
