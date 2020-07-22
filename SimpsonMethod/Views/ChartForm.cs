using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace SimpsonMethod.Views
{
    public partial class ChartForm : Form
    {
        private double[] polynomialValues = new double[3];
        private char[] arithmeticSymbol = new char[2];
        private int numberDividingPoints;
        private double beginningIntegrationInterval;
        private double endingIntegrationInterval;

        List<double> xValues = new List<double>();
        List<double> yValues = new List<double>();
        public ChartForm()
        {

        }
        public ChartForm(double[] _polynomialValues, char[] _arithmeticSymbol, int _numberDividingPoints, double _beginningIntegrationInterval, double _endingIntegrationInterval)
        {
            InitializeComponent();

            polynomialValues = _polynomialValues;
            arithmeticSymbol = _arithmeticSymbol;
            numberDividingPoints = _numberDividingPoints;
            beginningIntegrationInterval = _beginningIntegrationInterval;
            endingIntegrationInterval = _endingIntegrationInterval;
            
        }
        
        private void Chart_Load(object sender, EventArgs e)
        {
            ChartPolynomial chart = new ChartPolynomial(polynomialValues, arithmeticSymbol, numberDividingPoints, beginningIntegrationInterval, endingIntegrationInterval);
            chart.ParabolaPoints();
           
            chartMethodSimpson.ChartAreas[0].AxisX.Interval = 1;            
            chartMethodSimpson.Series["f(x)"].Points.DataBindXY(chart.giveXValues(),chart.giveYValues());    
            chartMethodSimpson.Series["Pole pod parabolą"].Points.DataBindXY(chart.giveXValuesArea(), chart.giveYValuesArea());
        
        }

        private void chartMethodSimpson_Click(object sender, EventArgs e)
        {

        }
    }
}
