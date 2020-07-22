using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpsonMethod
{
    public class Equation
    {
        protected double beginningIntegrationInterval; // początek przedziału całkowania. ---------------------------------------------Xp
        protected double endingIntegrationInterval; //koniec przedziału całkowania.----------------------------------------------------Xk
        private double distanceTwoAdjacentSubdivisionPoints; // odległość między dwoma sąsiednimi punktami podziałowymi. ------------dx
        private double splitPointPosition; //  pozycja punktu podziałowego. ---------------------------------------------------------x
        private double sumFunctionValuesMindpoints = 0; // suma wartości funkcji w punktach środkowych. ---------------------------------St
        protected double valuePolynomialFunction; // Wartość fukcji f(x) z tem że, 'x' to nie pozycja punktu podziałowego.
        private double valueFunctionIntegral = 0;  // wartość całki oznaczonej funkcji f(x) w przedziale <xp,xk>.-----------------------s
        public double finalValueFunctionIntegral; // wartość całki oznaczonej funkcji f(x) w przedziale <xp,xk>.-----------------------s

        protected int numberDividingPoints; // liczba punktów podziałowych. -----------------------------------------------------------n
        private int splitPointCounter = 1;//  licznik punktów podziałowych.----------------------------------------------------------i

        protected double[] polynomialValues = new double[3];// trzy wartości wielomianu po kolei x^2, x ,

        protected char[] arithmeticSymbol = new char[2];// 2 symbole działan artmetycznech np +,-

        public Equation()
        {
            beginningIntegrationInterval = 0;
            endingIntegrationInterval = 0;
            numberDividingPoints = 0;
        }
        public Equation(double _beginningIntegrationInterval, double _endingIntegrationInterval, int _numberDividingPoints)
        {
            beginningIntegrationInterval = _beginningIntegrationInterval;
            endingIntegrationInterval = _endingIntegrationInterval;
            numberDividingPoints = _numberDividingPoints;

            distanceTwoAdjacentSubdivisionPoints = (_endingIntegrationInterval - _beginningIntegrationInterval) / _numberDividingPoints; //dx
           



        }
        ~Equation() { }

        protected double calculatingFunction(double[] _polynomialValues, char[] _arithmeticSymbol, double _variableValue)
        {
            switch (_arithmeticSymbol[0])
            {
                case '+':

                    if (_arithmeticSymbol[1] == '-')
                    {
                        valuePolynomialFunction = _polynomialValues[0] * Math.Pow(_variableValue, 2) + _polynomialValues[1] * _variableValue - _polynomialValues[2];//f(x)=a2x^2 + a1x^2 - a0
                    }
                    else
                    {
                        valuePolynomialFunction = _polynomialValues[0] * Math.Pow(_variableValue, 2) + _polynomialValues[1] * _variableValue + _polynomialValues[2];//f(x)=a2x^2 + a1x^2 + a0
                    }
                    
                    break;
                case '-':
                    if (_arithmeticSymbol[1] == '-') 
                    {
                        valuePolynomialFunction = _polynomialValues[0] * Math.Pow(_variableValue, 2) - _polynomialValues[1] * _variableValue - _polynomialValues[2];//f(x)=a2x^2 - a1x^2 - a0
                    }
                    else
                    {
                        valuePolynomialFunction = _polynomialValues[0] * Math.Pow(_variableValue, 2) - _polynomialValues[1] * _variableValue + _polynomialValues[2];//f(x)=a2x^2 - a1x^2 + a0
                    }

                    break;
                default:
                    
                    break;

            }
            
            return valuePolynomialFunction;
        }
        private double calculatingFunction(double[] _polynomialValues, char[] _arithmeticSymbol, double _variableValue1, double _variableValue2)
        {
            
            switch (_arithmeticSymbol[0])
            {
                case '+':

                    if (_arithmeticSymbol[1] == '-')
                    {
                        valuePolynomialFunction = _polynomialValues[0] * Math.Pow((_variableValue1 - (_variableValue2 / 2)), 2) + _polynomialValues[1]
                            * (_variableValue1 - (_variableValue2 / 2)) - _polynomialValues[2];                                                //f(x)=a2x^2 + a1x^2 - a0
                    }
                    else
                    {
                        valuePolynomialFunction = _polynomialValues[0] * Math.Pow((_variableValue1 - (_variableValue2 / 2)), 2) + _polynomialValues[1]
                            * (_variableValue1 - (_variableValue2 / 2)) + _polynomialValues[2];                                                //f(x)=a2x^2 + a1x^2 + a0
                      
                    }
                   
                    break;
                case '-':
                    if (_arithmeticSymbol[1] == '-')
                    {
                        valuePolynomialFunction = _polynomialValues[0] * Math.Pow((_variableValue1 - (_variableValue2 / 2)), 2) - _polynomialValues[1]
                            * (_variableValue1 - (_variableValue2 / 2)) - _polynomialValues[2];                                                //f(x)=a2x^2 - a1x^2 - a0
                    }
                    else
                    {
                        valuePolynomialFunction = _polynomialValues[0] * Math.Pow((_variableValue1 - (_variableValue2 / 2)), 2) - _polynomialValues[1]
                            * (_variableValue1 - (_variableValue2 / 2)) + _polynomialValues[2];                                                //f(x)=a2x^2 - a1x^2 + a0
                    }

                    break;
                default:

                    break;
            }
          
            return valuePolynomialFunction;
        }
        private void summingMidpointsFunction()                                                                                                            //St=St+f(x-dx/2)
        {
            sumFunctionValuesMindpoints += calculatingFunction(polynomialValues, arithmeticSymbol,
                splitPointPosition, distanceTwoAdjacentSubdivisionPoints);
           
        }


        private void splittingPointPositions(double _beginningIntegrationInterval, double _distanceTwoAdjacentSubdivisionPoints, int _splitPointCounter)         // x
        {

            splitPointPosition = _beginningIntegrationInterval + _splitPointCounter * _distanceTwoAdjacentSubdivisionPoints;
           
        }

        private void calculatingValueFunctionIntegral( double _valuePolynomialFunction) //s
        {

            valueFunctionIntegral += _valuePolynomialFunction;
            
        }
        private void calculatingValueFunctionIntegralFinal()//s final
        {

            finalValueFunctionIntegral =(distanceTwoAdjacentSubdivisionPoints / 6) * (calculatingFunction(polynomialValues, arithmeticSymbol, beginningIntegrationInterval) +
                calculatingFunction(polynomialValues, arithmeticSymbol, endingIntegrationInterval) + 2 * valueFunctionIntegral + 4 * sumFunctionValuesMindpoints);
          
        }
        public void Final()
        {
            
            for (splitPointCounter=1; splitPointCounter <= numberDividingPoints; splitPointCounter++)
            {
                
                splittingPointPositions(beginningIntegrationInterval, distanceTwoAdjacentSubdivisionPoints, splitPointCounter);
                summingMidpointsFunction();                                                                                                          

                if(splitPointCounter< numberDividingPoints)
                {
                    
                    calculatingValueFunctionIntegral(calculatingFunction(polynomialValues, arithmeticSymbol, splitPointPosition));
                   
                }
                

            }
            
            calculatingValueFunctionIntegralFinal();

           

        }
        public double giveBeginningIntegrationInterval()
        {
            return beginningIntegrationInterval;
        }

        public double giveEndingIntegrationInterval()
        {
            return endingIntegrationInterval;
        }

        public int giveNumberDividingPoints()
        {
            return numberDividingPoints;
        }

        public double[] givePolynomialValues()
        {
            return polynomialValues;
        }

        public char[] giveArithmeticSymbol()
        {
            return arithmeticSymbol;
        }



        public void convertingToArrayDouble(params string[] paramList)
        {
            
                for (int i = 0; i < paramList.Length; i++)
                {
                    try
                    {
                        polynomialValues[i] = Double.Parse(paramList[i], CultureInfo.InvariantCulture);

                    }
                    catch (System.FormatException)
                    {
                        polynomialValues[i] = 0;
                    }
                }
            

        }
        public void convertingToArrayChar(params string[] paramList)
        {
            
            for (int i = 0; i < paramList.Length; i++)
            {
                arithmeticSymbol[i] = char.Parse(paramList[i]);
            }

        }
    }
}
