//-----------------------------------------------------------------------
// <copyright file="Weight.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Mehboob Shaikh</author>
//-----------------------------------------------------------------------
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]

namespace QuantityMeasurementProblem
{
    using System;
    using NUnit.Framework;

    /// <summary>
    /// This Class is Used To Compare and Add two Weight
    /// </summary>
    public class Weight
    {
        /// <summary>
        /// This value is used to convert into Kilogram
        /// </summary>
        private double conversionValue = 1000;

        /// <summary>
        /// Enum is Used To Declare Enumerated Constants
        /// </summary>
        public enum Unit
        {
            /// <summary>
            /// It Indicates that Weight is in kilogram
            /// </summary>
            KiloGrams,

            /// <summary>
            /// It Indicates that Weight is in gram
            /// </summary>
            Grams,

            /// <summary>
            /// It is Used To Convert The Value Of gram into kilogram
            /// </summary>
            GramsToKiloGrams,

            /// <summary>
            /// It is Used To Convert The Value Of T into kilogram
            /// </summary>
            TonneToKiloGrams
        }

        /// <summary>
        /// This Method Is used to Convert The Weight from one to Another
        /// </summary>
        /// <param name="unit">It tells us About the Which weight is to be Convert</param>
        /// <param name="value">It Contains the value Which we convert</param>
        /// <returns>It Returns the Converted Value into kilogram Format</returns>
        public double ConvertValueToKiloGrams(Unit unit, double value)
        {
            try
            {
                // Check If Unit Is Equal To GramsToKiloGrams Then Convert The gram Value Into kilogram
                if (unit.Equals(Unit.GramsToKiloGrams))
                {
                    return value / this.conversionValue;
                }
                else if (unit.Equals(Unit.TonneToKiloGrams))
                {
                    return value * this.conversionValue;
                }

                return value;
            }
            catch (QuantityMeasurementException e)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.InvalidValue, e.Message);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This Method Performs The Addition of two inch Values
        /// </summary>
        /// <param name="firstKiloGramValue">It Contains the First kilogram Value</param>
        /// <param name="secondKiloGramValue">It Contains The Second kilogram Value</param>
        /// <returns>It Returns The Addition of that two values in kilogram Format</returns>
        public double AddTWoWeights(double firstKiloGramValue, double secondKiloGramValue)
        {
            try
            {
                // Addition of two kilogram values
                return firstKiloGramValue + secondKiloGramValue;
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
