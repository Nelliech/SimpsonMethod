using SimpsonMethod.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimpsonMethod
{
    public partial class CountingWindow : Form
    {
        
        public CountingWindow()
        {
            InitializeComponent();
        }
        private void CountingWindow_Load(object sender, EventArgs e)
        {
            arithmeticSymbol1.SelectedIndex = 0;
            arithmeticSymbol2.SelectedIndex = 0;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
           
                    double beginningIntegrationInterval;
                    double endingIntegrationInterval;
                    int dividingPoint;

                    try
                    {
                        beginningIntegrationInterval = Double.Parse(beginningIntegrationIntervalTextbox.Text, CultureInfo.InvariantCulture);
                    }
                    catch (System.SystemException)
                    {
                        MessageBox.Show("Nie poprawna wartość xp");
                        return;
                    }

                    try
                    {
                        endingIntegrationInterval = Double.Parse(endingIntegrationIntervalTextbox.Text, CultureInfo.InvariantCulture);

                    }
                    catch (System.SystemException)
                    {
                        MessageBox.Show("Nie poprawna wartość xk");
                        return;
                    }

                    dividingPoint = Convert.ToInt32(dividingPointTextbox.Text);

                    Equation calculating = new Equation(beginningIntegrationInterval, endingIntegrationInterval, dividingPoint);
                    calculating.convertingToArrayDouble(polynomialX2.Text, polynomialX1.Text, polynomialX0.Text);
                    calculating.convertingToArrayChar(arithmeticSymbol1.Text, arithmeticSymbol2.Text);
                    calculating.Final();



             
                    FinalValues fV = new FinalValues(calculating.givePolynomialValues(), calculating.giveArithmeticSymbol(), calculating.giveNumberDividingPoints(),
                        calculating.giveBeginningIntegrationInterval(), calculating.giveEndingIntegrationInterval(), calculating.finalValueFunctionIntegral);
                    ChartForm cF = new ChartForm(calculating.givePolynomialValues(), calculating.giveArithmeticSymbol(), calculating.giveNumberDividingPoints(), 
                        calculating.giveBeginningIntegrationInterval(), calculating.giveEndingIntegrationInterval());

                    fV.Show();
                    cF.Show();
                    this.Close();
             
           
         
                       
        }

        

        private void dividingPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private void xK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-') )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void xP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')&& (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void polynomialX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void polynomialX0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void polynomialX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')&&(e.KeyChar!='-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Start st = new Start();
            st.Show();
            this.Close();
        }
    }
} 
