﻿//-----------------------------------------------------------------------
// <copyright file="QuantityMeasurementException.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Mehboob Shaikh</author>
//-----------------------------------------------------------------------
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]

namespace QuantityMeasurementProblem
{
    using System;

    /// <summary>
    /// This Class used to Define Custom Exceptions
    /// </summary>
    public class QuantityMeasurementException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public QuantityMeasurementException()
        {
        }

        /// <summary>
        /// Parameterized constructor used to Initialize type of Exception
        /// </summary>
        /// <param name="type">It contains the type of Exception</param>
        /// <param name="message">It contains the message</param>
        public QuantityMeasurementException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

        /// <summary>
        /// Enum is Used to define Enumerated Data types
        /// </summary>
        public enum ExceptionType
        {
            InvalidValue
        }

        /// <summary>
        /// It creates the Reference of Exception Type
        /// </summary>
        public ExceptionType type { get; set; }
    }
}
