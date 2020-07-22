using SimpsonMethod.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace SimpsonMethod
{
    class ChartPolynomial : Equation
    {
        
        private List<double> xValues = new List<double>();
        private List<double> yValues = new List<double>();
        private List<double> yValuesArea = new List<double>();
        private List<double> xValuesArea = new List<double>();
        public ChartPolynomial(double[] _polynomialValues, char[] _arithmeticSymbol, int _numberDividingPoints, double _beginningIntegrationInterval, double _endingIntegrationInterval)
        {
            polynomialValues = _polynomialValues;
            numberDividingPoints = _numberDividingPoints;
            beginningIntegrationInterval = _beginningIntegrationInterval;
            endingIntegrationInterval = _endingIntegrationInterval;
            arithmeticSymbol = _arithmeticSymbol;
            
            
        }

        
        public void ParabolaPoints()
        {
            int endInt;
            if (beginningIntegrationInterval > endingIntegrationInterval)
            {
                
                yValuesArea.Add(calculatingFunction(polynomialValues, arithmeticSymbol, endingIntegrationInterval));
                xValuesArea.Add(endingIntegrationInterval);
                if (endingIntegrationInterval <0)
                {
                   endInt = -Convert.ToInt32(endingIntegrationInterval);
                }else
                {
                    endInt = Convert.ToInt32(endingIntegrationInterval);
                }
                for (int i = -20 -endInt; i <= 20 + Convert.ToInt32(beginningIntegrationInterval); i++)
                {
                    xValues.Add(i);
                    calculatingFunction(polynomialValues, arithmeticSymbol, i);
                    yValues.Add(valuePolynomialFunction);
                   
                    if (endingIntegrationInterval < i && beginningIntegrationInterval > i)
                    {
                        yValuesArea.Add(calculatingFunction(polynomialValues, arithmeticSymbol, i - 0.25));
                        xValuesArea.Add(i);
                    }

                }
                yValuesArea.Add(calculatingFunction(polynomialValues, arithmeticSymbol, beginningIntegrationInterval));
                xValuesArea.Add(beginningIntegrationInterval);
            }
            else{
                yValuesArea.Add(calculatingFunction(polynomialValues, arithmeticSymbol, beginningIntegrationInterval));
                xValuesArea.Add(beginningIntegrationInterval);
                if (endingIntegrationInterval < 0)
                {
                    endInt = -Convert.ToInt32(beginningIntegrationInterval);
                }
                else
                {
                    endInt = Convert.ToInt32(beginningIntegrationInterval);
                }
                for (int i = -20 - endInt; i <= 20 + Convert.ToInt32(endingIntegrationInterval); i++)
                {
                    xValues.Add(i);
                    calculatingFunction(polynomialValues, arithmeticSymbol, i);
                    yValues.Add(valuePolynomialFunction);

                    if (endingIntegrationInterval > i && beginningIntegrationInterval < i)
                    {
                        yValuesArea.Add(calculatingFunction(polynomialValues, arithmeticSymbol, i-0.25));
                        xValuesArea.Add(i);
                    }

                }

                yValuesArea.Add(calculatingFunction(polynomialValues, arithmeticSymbol, endingIntegrationInterval));
                xValuesArea.Add(endingIntegrationInterval);
            }
                   
        }
       
        
        public double giveXTopParabola()
        {
            double xTop = (-polynomialValues[1]) / (2 * polynomialValues[2]);
            if (double.IsNaN(xTop))
            {
                xTop = 0;
            }
            return xTop;
        }
        public double giveYTopParabola()
        {
            double yTop= (-(Math.Pow(polynomialValues[1], 2) - 4 * polynomialValues[2] * polynomialValues[0]) / (2 * polynomialValues[2]));
            if (double.IsNaN(yTop))
            {
                yTop = 0;
            }
            return yTop;
        }


        public List<double> giveXValues()
        {
            return xValues;
        }
        public List<double> giveYValues()
        {
            return yValues;
        }

        public List<double> giveYValuesArea()
        {
            return yValuesArea;

        }
        public List<double> giveXValuesArea()
        {
            return xValuesArea;

        }


    }
}
