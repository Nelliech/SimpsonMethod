namespace SimpsonMethod.Views
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMethodSimpson = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMethodSimpson)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMethodSimpson
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMethodSimpson.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMethodSimpson.Legends.Add(legend1);
            this.chartMethodSimpson.Location = new System.Drawing.Point(1, 2);
            this.chartMethodSimpson.Name = "chartMethodSimpson";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "f(x)";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
            series2.Legend = "Legend1";
            series2.Name = "Pole pod parabolą";
            series2.YValuesPerPoint = 2;
            this.chartMethodSimpson.Series.Add(series1);
            this.chartMethodSimpson.Series.Add(series2);
            this.chartMethodSimpson.Size = new System.Drawing.Size(787, 436);
            this.chartMethodSimpson.TabIndex = 0;
            this.chartMethodSimpson.Text = "chart1";
            this.chartMethodSimpson.Click += new System.EventHandler(this.chartMethodSimpson_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartMethodSimpson);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChartForm";
            this.ShowIcon = false;
            this.Text = "Metoda Simpsona";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMethodSimpson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMethodSimpson;
    }
}