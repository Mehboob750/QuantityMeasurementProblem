using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QuantityMeasurementProblem;

namespace NUnitTestQuantityMeasurement
{
    class VolumeTestCases
    {
        private Volume litre = null;
        private Volume gallon = null;
        private Volume miliLitre = null;

        [SetUp]
        public void Setup()
        {
            this.litre = new Volume();
            this.gallon = new Volume();
            this.miliLitre = new Volume();
        }

        /// <summary>
        /// Given Zero gallon And Zero gallon Returns the Equal
        /// </summary>
        [Test]
        public void Given0GallonAnd0Gallon_ShouldReturnsEqual()
        {
            double firstGallonValue = gallon.ConvertValueToInch(Volume.Unit.Gallon, 0.0);
            double secondGallonValue = gallon.ConvertValueToInch(Volume.Unit.Gallon, 0.0);
            Assert.AreEqual(firstGallonValue, secondGallonValue);
        }

        [Test]
        public void Given0GallonAndNull_ShouldReturnsNotEqual()
        {
            double firstGallonValue = gallon.ConvertValueToInch(Volume.Unit.Gallon, 0.0);
            Volume secondGallonValue = null;
            Assert.AreNotEqual(firstGallonValue, secondGallonValue);
        }

        [Test]
        public void GivenTwoObjects_WhenCheckReference_ShouldReturnFalse()
        {
            Volume firstObject = new Volume();
            Volume secondObject = new Volume();
            bool areEqual = System.Object.ReferenceEquals(firstObject, secondObject);
            Assert.IsFalse(areEqual);
        }

        [Test]
        public void GivenTwoObjects_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {

            Volume firstObject = new Volume();
            Volume secondObject = new Volume();
            firstObject = secondObject;
            bool areEqual = System.Object.ReferenceEquals(firstObject, secondObject);
            Assert.IsTrue(areEqual);
        }

        [Test]
        public void GivenTwoObjects_WhenTypeChecked_ShouldReturnEqual()
        {
            double firstGallonValue = gallon.ConvertValueToInch(Volume.Unit.Gallon, 3.0);
            double secondGallonValue = gallon.ConvertValueToInch(Volume.Unit.Gallon, 3.0);
            Assert.AreEqual(firstGallonValue.GetType(), secondGallonValue.GetType());
        }

        [Test]
        public void Given0GallonAnd1Gallon_WhenValueChecked_ShouldReturnNotEqual()
        {
            double firstGallonValue = gallon.ConvertValueToInch(Volume.Unit.GallonToLitre, 0.0);
            double secondGallonValue = gallon.ConvertValueToInch(Volume.Unit.GallonToLitre, 1.0);
            Assert.AreNotEqual(firstGallonValue, secondGallonValue);
        }

        [Test]
        public void Given0LitreAnd0Litre_WhenValueChecked_ShouldReturnEqual()
        {
            double firstLitreValue = litre.ConvertValueToInch(Volume.Unit.Litre, 0.0);
            double secondLitreValue = litre.ConvertValueToInch(Volume.Unit.Litre, 0.0);
            Assert.AreEqual(firstLitreValue, secondLitreValue);
        }

        [Test]
        public void Given0LitreAnd1Litre_WhenValueChecked_ShouldReturnEqual()
        {
            double firstLitreValue = litre.ConvertValueToInch(Volume.Unit.Litre, 0.0);
            double secondLitreValue = litre.ConvertValueToInch(Volume.Unit.Litre, 1.0);
            Assert.AreNotEqual(firstLitreValue, secondLitreValue);
        }

        [Test]
        public void Given1GallonAnd3Point78Litre_WhenValueChecked_ShouldReturnEqual()
        {
            double gallonValue = gallon.ConvertValueToInch(Volume.Unit.GallonToLitre, 1.0);
            double litreValue = litre.ConvertValueToInch(Volume.Unit.Litre, 3.78);
            Assert.AreEqual(gallonValue, litreValue);
        }

        [Test]
        public void Given0MiliLitreAnd0MiliLitre_WhenValueChecked_ShouldReturnEqual()
        {
            double firstMiliLitreValue = miliLitre.ConvertValueToInch(Volume.Unit.MiliLitreToLitre, 0.0);
            double secondMiliLitreValue = miliLitre.ConvertValueToInch(Volume.Unit.MiliLitreToLitre, 0.0);
            Assert.AreEqual(firstMiliLitreValue, secondMiliLitreValue);
        }

        [Test]
        public void Given1LitreAnd1000MiliLitre_WhenValueChecked_ShouldReturnEqual()
        {
            double litreValue = litre.ConvertValueToInch(Volume.Unit.Litre, 1.0);
            double miliLitreValue = miliLitre.ConvertValueToInch(Volume.Unit.MiliLitreToLitre, 1000.0);
            Assert.AreEqual(litreValue, miliLitreValue);
        }

        [Test]
        public void Given1LitreAnd1Litre_WhenAdded_ShouldReturnSum()
        {
            double firstLitreValue = litre.ConvertValueToInch(Volume.Unit.Litre, 1.0);
            double secondLitreValue = litre.ConvertValueToInch(Volume.Unit.Litre, 1.0);
            double ActualValue = litre.AddTWoVolumes(firstLitreValue, secondLitreValue);
            double ExpectedValue = 2.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }

        [Test]
        public void Given1GallonAnd1Gallon_WhenAdded_ShouldReturnSum()
        {
            double firstGallonValue = gallon.ConvertValueToInch(Volume.Unit.GallonToLitre, 1.0);
            double secondGallonValue = gallon.ConvertValueToInch(Volume.Unit.GallonToLitre, 1.0);
            double ActualValue = gallon.AddTWoVolumes(firstGallonValue, secondGallonValue);
            double ExpectedValue = 7.56;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }

        [Test]
        public void Given1GallonAnd3point78Litre_WhenAdded_ShouldReturnSum()
        {
            double gallonValue = gallon.ConvertValueToInch(Volume.Unit.GallonToLitre, 1.0);
            double litreValue = litre.ConvertValueToInch(Volume.Unit.Litre, 3.78);
            double ActualValue = litre.AddTWoVolumes(gallonValue,litreValue);
            double ExpectedValue = 7.56;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
    }
}
