using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProblem
{
    public class Volume
    {
        public enum Unit
        {
            Gallon,
            Litre,
            GallonToLitre,
            MiliLitreToLitre
        }

        public double ConvertValueToInch(Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Unit.GallonToLitre))
                {
                    return value * 3.78;
                }
                else if (unit.Equals(Unit.MiliLitreToLitre))
                {
                    return value / 1000;
                }

                return value;
            }
            catch (Exception e)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.InvalidValue, e.Message);
            }
        }
    }
}
