//-----------------------------------------------------------------------
// <copyright file="VolumeTestCases.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Mehboob Shaikh</author>
//-----------------------------------------------------------------------
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]

namespace NUnitTestQuantityMeasurement
{
    using System;
    using NUnit.Framework;
    using QuantityMeasurementProblem;

    /// <summary>
    /// This class Contains the TestCases to check the functionality of Volume Class
    /// </summary>
    public class VolumeTestCases
    {
        /// <summary>
        /// Created Reference of Volume Class to Access it Globally
        /// </summary>
        private Volume volume = null;

        /// <summary>
        /// Created the Object of Volume Class
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.volume = new Volume();
        }

        /// <summary>
        /// Given 0.0 gallon And 0.0 gallon When Compare Returns the Equal
        /// </summary>
        [Test]
        public void Given0GallonAnd0Gallon_ShouldReturnsEqual()
        {
            try
            {
                double firstGallonValue = this.volume.ConvertValueToLitre(Volume.Unit.Gallon, 0.0);
                double secondGallonValue = this.volume.ConvertValueToLitre(Volume.Unit.Gallon, 0.0);
                Assert.AreEqual(firstGallonValue, secondGallonValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 gallon And Null When Compare Returns the Not Equal
        /// </summary>
        [Test]
        public void Given0GallonAndNull_ShouldReturnsNotEqual()
        {
            try
            {
                double firstGallonValue = this.volume.ConvertValueToLitre(Volume.Unit.Gallon, 0.0);
                Volume secondGallonValue = null;
                Assert.AreNotEqual(firstGallonValue, secondGallonValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given Two Objects When Reference Checked Returns Not Equal
        /// </summary>
        [Test]
        public void GivenTwoObjects_WhenCheckReference_ShouldReturnFalse()
        {
            try
            {
                Volume firstObject = new Volume();
                Volume secondObject = new Volume();
                bool result = object.ReferenceEquals(firstObject, secondObject);
                Assert.IsFalse(result);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        ///  Given Two Objects When First Assign to Second And Reference Checked Returns Equal
        /// </summary>
        [Test]
        public void GivenTwoObjects_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            try
            {
                Volume firstObject = new Volume();
                Volume secondObject = new Volume();
                firstObject = secondObject;
                bool result = object.ReferenceEquals(firstObject, secondObject);
                Assert.IsTrue(result);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        ///  Given Two Objects When Type Checked Returns Equal
        /// </summary>
        [Test]
        public void GivenTwoObjects_WhenTypeChecked_ShouldReturnEqual()
        {
            try
            {
                double firstGallonValue = this.volume.ConvertValueToLitre(Volume.Unit.Gallon, 3.0);
                double secondGallonValue = this.volume.ConvertValueToLitre(Volume.Unit.Gallon, 3.0);
                Assert.AreEqual(firstGallonValue.GetType(), secondGallonValue.GetType());
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 gallon And 1.0 gallon When Compare Returns the Not Equal
        /// </summary>
        [Test]
        public void Given0GallonAnd1Gallon_WhenValueChecked_ShouldReturnNotEqual()
        {
            try
            {
                double firstGallonValue = this.volume.ConvertValueToLitre(Volume.Unit.GallonToLitre, 0.0);
                double secondGallonValue = this.volume.ConvertValueToLitre(Volume.Unit.GallonToLitre, 1.0);
                Assert.AreNotEqual(firstGallonValue, secondGallonValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 L And 0.0 L When Compare Returns the Equal
        /// </summary>
        [Test]
        public void Given0LitreAnd0Litre_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double firstLitreValue = this.volume.ConvertValueToLitre(Volume.Unit.Litre, 0.0);
                double secondLitreValue = this.volume.ConvertValueToLitre(Volume.Unit.Litre, 0.0);
                Assert.AreEqual(firstLitreValue, secondLitreValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 L And 1.0 L When Compare Returns the Not Equal
        /// </summary>
        [Test]
        public void Given0LitreAnd1Litre_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double firstLitreValue = this.volume.ConvertValueToLitre(Volume.Unit.Litre, 0.0);
                double secondLitreValue = this.volume.ConvertValueToLitre(Volume.Unit.Litre, 1.0);
                Assert.AreNotEqual(firstLitreValue, secondLitreValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Gallon And 3.78 L When compare Returns the Equal
        /// </summary>
        [Test]
        public void Given1GallonAnd3Point78Litre_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double gallonValue = this.volume.ConvertValueToLitre(Volume.Unit.GallonToLitre, 1.0);
                double litreValue = this.volume.ConvertValueToLitre(Volume.Unit.Litre, 3.78);
                Assert.AreEqual(gallonValue, litreValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 Ml And 0.0 Ml When Compare Returns the Equal
        /// </summary>
        [Test]
        public void Given0MiliLitreAnd0MiliLitre_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double firstMiliLitreValue = this.volume.ConvertValueToLitre(Volume.Unit.MiliLitreToLitre, 0.0);
                double secondMiliLitreValue = this.volume.ConvertValueToLitre(Volume.Unit.MiliLitreToLitre, 0.0);
                Assert.AreEqual(firstMiliLitreValue, secondMiliLitreValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 L And 1000.0 Ml When Compare Returns the Equal
        /// </summary>
        [Test]
        public void Given1LitreAnd1000MiliLitre_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double litreValue = this.volume.ConvertValueToLitre(Volume.Unit.Litre, 1.0);
                double miliLitreValue = this.volume.ConvertValueToLitre(Volume.Unit.MiliLitreToLitre, 1000.0);
                Assert.AreEqual(litreValue, miliLitreValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 L And 1.0 L When Compare Returns the Equal
        /// </summary>
        [Test]
        public void Given1LitreAnd1Litre_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double firstLitreValue = this.volume.ConvertValueToLitre(Volume.Unit.Litre, 1.0);
                double secondLitreValue = this.volume.ConvertValueToLitre(Volume.Unit.Litre, 1.0);
                double actualValue = this.volume.AddTWoVolumes(firstLitreValue, secondLitreValue);
                double expectedValue = 2.0;
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Gallon And 1.0 Gallon When Added Returns 7.56
        /// </summary>
        [Test]
        public void Given1GallonAnd1Gallon_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double firstGallonValue = this.volume.ConvertValueToLitre(Volume.Unit.GallonToLitre, 1.0);
                double secondGallonValue = this.volume.ConvertValueToLitre(Volume.Unit.GallonToLitre, 1.0);
                double actualValue = this.volume.AddTWoVolumes(firstGallonValue, secondGallonValue);
                double expectedValue = 7.56;
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Gallon And 3.78 L When Added Returns 7.56
        /// </summary>
        [Test]
        public void Given1GallonAnd3point78Litre_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double gallonValue = this.volume.ConvertValueToLitre(Volume.Unit.GallonToLitre, 1.0);
                double litreValue = this.volume.ConvertValueToLitre(Volume.Unit.Litre, 3.78);
                double actualValue = this.volume.AddTWoVolumes(gallonValue, litreValue);
                double expectedValue = 7.56;
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 L And 1000.0 Ml When Added Returns 2.0
        /// </summary>
        [Test]
        public void Given1LitreAnd1000MiliLitre_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double litreValue = this.volume.ConvertValueToLitre(Volume.Unit.Litre, 1.0);
                double miliLitreValue = this.volume.ConvertValueToLitre(Volume.Unit.MiliLitreToLitre, 1000.0);
                double actualValue = this.volume.AddTWoVolumes(litreValue, miliLitreValue);
                double expectedValue = 2.0;
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Gallon And 1000.0 Ml When Added Returns 4.78
        /// </summary>
        [Test]
        public void Given1GallonAnd1000MiliLitre_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double gallonValue = this.volume.ConvertValueToLitre(Volume.Unit.GallonToLitre, 1.0);
                double miliLitreValue = this.volume.ConvertValueToLitre(Volume.Unit.MiliLitreToLitre, 1000.0);
                double actualValue = this.volume.AddTWoVolumes(gallonValue, miliLitreValue);
                double expectedValue = 4.78;
                Assert.AreEqual(expectedValue, Math.Round(actualValue, 2));
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }
    }
}
