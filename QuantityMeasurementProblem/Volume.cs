//-----------------------------------------------------------------------
// <copyright file="Volume.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Mehboob Shaikh</author>
//-----------------------------------------------------------------------
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]

namespace QuantityMeasurementProblem
{
    using System;

    /// <summary>
    /// This Class is Used To Compare and Add two Volumes
    /// </summary>
    public class Volume
    {
        /// <summary>
        /// This value is used At the Time Of Gallon to L Conversion
        /// </summary>
        private double gallonToLitreValue = 3.78;

        /// <summary>
        /// This value is used At the Time Of Ml to L Conversion
        /// </summary>
        private double miliLitreToLitreValue = 1000;

        /// <summary>
        /// Enum is Used To Declare Enumerated Constants
        /// </summary>
        public enum Unit
        {
            /// <summary>
            /// It Indicates that Volume is in Gallon
            /// </summary>
            Gallon,

            /// <summary>
            /// It Indicates that Volume is in L
            /// </summary>
            Litre,

            /// <summary>
            /// It Indicates that Convert the Volume From Gallon to L
            /// </summary>
            GallonToLitre,

            /// <summary>
            /// It Indicates that Convert the Volume From Ml to L
            /// </summary>
            MiliLitreToLitre
        }

        /// <summary>
        /// This Method Is used to Convert The Volume from one to Another
        /// </summary>
        /// <param name="unit">It tells us About the Which Volume is to be Convert</param>
        /// <param name="value">It Contains the value Which we convert</param>
        /// <returns>It Returns the Converted Value into L Format</returns>
        public double ConvertValueToLitre(Unit unit, double value)
        {
            try
            {
                // Check If Unit Is Equal To GallonToLitre Then Convert The Gallon Value Into L
                if (unit.Equals(Unit.GallonToLitre))
                {
                    return value * this.gallonToLitreValue;
                }
                else if (unit.Equals(Unit.MiliLitreToLitre))
                {
                    return value / this.miliLitreToLitreValue;
                }

                return value;
            }
            catch (Exception e)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// This Method is used to add two Volumes
        /// </summary>
        /// <param name="firstLitreValue">It contains the first value in L</param>
        /// <param name="secondLitreValue">It contains the second value in L</param>
        /// <returns>It returns the addition of two values in L</returns>
        public double AddTWoVolumes(double firstLitreValue, double secondLitreValue)
        {
            // Add the two values 
            return firstLitreValue + secondLitreValue;
        }
    }
}
