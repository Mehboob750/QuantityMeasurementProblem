using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProblem
{
    public class Weight
    {
        public enum Unit
        {
            KiloGrams,
            Grams,
            GramsToKiloGrams,
            TonneToKiloGrams
        }

        public double ConvertValueToKiloGrams(Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Unit.GramsToKiloGrams))
                {
                    return value / 1000;
                }
                else if (unit.Equals(Unit.TonneToKiloGrams))
                {
                    return value * 1000;
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
