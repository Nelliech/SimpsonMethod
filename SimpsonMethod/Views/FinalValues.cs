using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpsonMethod.Views
{
    public partial class FinalValues : Form
    {
        private double beginningIntegrationInterval; // początek przedziału całkowania. ---------------------------------------------Xp
        private double endingIntegrationInterval; //koniec przedziału całkowania.----------------------------------------------------Xk
        private int numberDividingPoints; // liczba punktów podziałowych. -----------------------------------------------------------n     
        private double[] polynomialValues = new double[3];// trzy wartości wielomianu po kolei x^2, x ,
        private char[] arithmeticSymbol = new char[2];// 2 symbole działan artmetycznech np +,-
        private double finalValueFunctionIntegral;

        public FinalValues()
        {

        }
        public FinalValues(double[] _polynomialValues, char[] _arithmeticSymbol, int _numberDividingPoints, double _beginningIntegrationInterval,
            double _endingIntegrationInterval, double _finalValueFunctionIntegral)
        {
            InitializeComponent();

            beginningIntegrationInterval = _beginningIntegrationInterval;
            endingIntegrationInterval = _endingIntegrationInterval;
            numberDividingPoints = _numberDividingPoints;
            polynomialValues = _polynomialValues;
            arithmeticSymbol = _arithmeticSymbol;
            finalValueFunctionIntegral = _finalValueFunctionIntegral;
        }

        private void FinalValues_Load(object sender, EventArgs e)
        {
            functionLabel.Text ="f(x)"+ Convert.ToString(polynomialValues[0]) + "x^2" + Convert.ToString(arithmeticSymbol[0]) + Convert.ToString(polynomialValues[1]) +
                "x" + Convert.ToString(arithmeticSymbol[1]) + Convert.ToString(polynomialValues[2]);
            begginingIntLabel.Text = "Początek przedziału całkowania:" + Convert.ToString(beginningIntegrationInterval);
            endIntLabel.Text = "koniec przedziału całkowania:" + Convert.ToString(endingIntegrationInterval);
            numberDivLabel.Text = "Liczba punktów podziałowych: " + Convert.ToString(numberDividingPoints);
            finalValueLabel.Text =  Convert.ToString(finalValueFunctionIntegral);

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            ChartForm cF = new ChartForm();
            CountingWindow cW = new CountingWindow();
            cF.Close();
            this.Close();
            
            cW.Show();
        }

    }
}
