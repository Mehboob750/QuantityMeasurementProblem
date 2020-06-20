﻿using System;
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

        [SetUp]
        public void Setup()
        {
            this.litre = new Volume();
            this.gallon = new Volume();
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
    }
}
