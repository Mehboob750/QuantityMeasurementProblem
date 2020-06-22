//-----------------------------------------------------------------------
// <copyright file="WeightTestCases.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Mehboob Shaikh</author>
//-----------------------------------------------------------------------
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]

namespace NUnitTestQuantityMeasurement
{
    using NUnit.Framework;
    using QuantityMeasurementProblem;

    /// <summary>
    /// This class Contains the TestCases to check the functionality of Weight Class
    /// </summary>
    public class WeightTestCases
    {
        /// <summary>
        /// Created Reference of Weight Class to Access it Globally
        /// </summary>
        private Weight weight = null;

        /// <summary>
        /// Created the Object of Weight Class
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.weight = new Weight();
        }

        /// <summary>
        /// Given 0.0 KiloGram And 0.0 KiloGram When Value Checked Returns the Equal
        /// </summary>
        [Test]
        public void Given0KiloGramAnd0KiloGram_ShouldReturnsEqual()
        {
            double firstKiloGramsValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.KiloGrams, 0.0);
            double secondKiloGramsValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.KiloGrams, 0.0);
            Assert.AreEqual(firstKiloGramsValue, secondKiloGramsValue);
        }

        /// <summary>
        /// Given 0.0 KiloGram And 1.0 KiloGram When Value Checked Returns the Not Equal
        /// </summary>
        [Test]
        public void Given0KiloGramAnd1KiloGram_ShouldReturnsNotEqual()
        {
            double firstKiloGramsValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.KiloGrams, 0.0);
            double secondKiloGramsValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.KiloGrams, 1.0);
            Assert.AreNotEqual(firstKiloGramsValue, secondKiloGramsValue);
        }

        /// <summary>
        /// Given 0.0 Gram And 0.0 Gram When Value Checked Returns the Equal
        /// </summary>
        [Test]
        public void Given0GramAnd0Gram_ShouldReturnsEqual()
        {
            double firstGramsValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.GramsToKiloGrams, 0.0);
            double secondGramsValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.GramsToKiloGrams, 0.0);
            Assert.AreEqual(firstGramsValue, secondGramsValue);
        }

        /// <summary>
        /// Given 0.0 Gram And 1.0 Gram When Value Checked Returns the Not Equal
        /// </summary>
        [Test]
        public void Given0GramAnd1Gram_ShouldReturnsNotEqual()
        {
            double firstGramsValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.GramsToKiloGrams, 0.0);
            double secondGramsValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.GramsToKiloGrams, 1.0);
            Assert.AreNotEqual(firstGramsValue, secondGramsValue);
        }

        /// <summary>
        /// Given 1.0 KiloGram And 1000.0 KiloGram When Value Checked Returns the Equal
        /// </summary>
        [Test]
        public void Given1KiloGramAnd1000Grams_ShouldReturnsEqual()
        {
            double kiloGramValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.KiloGrams, 1.0);
            double gramValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.GramsToKiloGrams, 1000.0);
            Assert.AreEqual(kiloGramValue, gramValue);
        }

        /// <summary>
        /// Given 0.0 t And 0.0 t When Value Checked Returns the Equal
        /// </summary>
        [Test]
        public void Given0TonneAnd0Tonne_ShouldReturnsEqual()
        {
            double firstTonneValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.TonneToKiloGrams, 0.0);
            double secondTonneValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.TonneToKiloGrams, 0.0);
            Assert.AreEqual(firstTonneValue, secondTonneValue);
        }

        /// <summary>
        /// Given 0.0 t And 1.0 t When Value Checked Returns the Not Equal
        /// </summary>
        [Test]
        public void Given0TonneAnd1Tonne_ShouldReturnsNotEqual()
        {
            double firstTonneValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.TonneToKiloGrams, 0.0);
            double secondTonneValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.TonneToKiloGrams, 1.0);
            Assert.AreNotEqual(firstTonneValue, secondTonneValue);
        }

        /// <summary>
        /// Given 0.0 t And 1.0 KiloGram When Value Checked Returns the Not Equal
        /// </summary>
        [Test]
        public void Given1TonneAnd1KiloGram_ShouldReturnsNotEqual()
        {
            double tonneValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.TonneToKiloGrams, 1.0);
            double kiloGramValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.KiloGrams, 1.0);
            Assert.AreNotEqual(tonneValue, kiloGramValue);
        }

        /// <summary>
        /// Given 1.0 t And 1000.0 KiloGram When Value Checked Returns the Equal
        /// </summary>
        [Test]
        public void Given1TonneAnd1000KiloGrams_ShouldReturnsEqual()
        {
            double tonneValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.TonneToKiloGrams, 1.0);
            double kiloGramValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.KiloGrams, 1000.0);
            Assert.AreEqual(tonneValue, kiloGramValue);
        }

        /// <summary>
        /// Given 1.0 KiloGram And 1.0 KiloGram When Added Returns 2.0
        /// </summary>
        [Test]
        public void Given1KiloGramAnd1KiloGram_WhenAdded_ShouldReturnSum()
        {
            double firstKiloGramValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.KiloGrams, 1.0);
            double secondKiloGramValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.KiloGrams, 1.0);
            double actualValue = this.weight.AddTWoWeights(firstKiloGramValue, secondKiloGramValue);
            double expectedValue = 2.0;
            Assert.AreEqual(expectedValue, actualValue);
        }

        /// <summary>
        /// Given 1.0 t And 1000.0 Gram When Added Returns 1001.0
        /// </summary>
        [Test]
        public void Given1TonneAnd1000Gram_WhenAdded_ShouldReturnSum()
        {
            double tonneValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.TonneToKiloGrams, 1.0);
            double gramValue = this.weight.ConvertValueToKiloGrams(Weight.Unit.GramsToKiloGrams, 1000.0);
            double actualValue = this.weight.AddTWoWeights(tonneValue, gramValue);
            double expectedValue = 1001.0;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
