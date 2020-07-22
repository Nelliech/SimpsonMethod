namespace SimpsonMethod
{
    partial class CountingWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.beginningIntegrationIntervalTextbox = new System.Windows.Forms.TextBox();
            this.endingIntegrationIntervalTextbox = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.dividingPointTextbox = new System.Windows.Forms.TextBox();
            this.labelXp = new System.Windows.Forms.Label();
            this.labelXk = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.polynomialX2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.polynomialX1 = new System.Windows.Forms.TextBox();
            this.polynomialX0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arithmeticSymbol2 = new System.Windows.Forms.ComboBox();
            this.arithmeticSymbol1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // beginningIntegrationIntervalTextbox
            // 
            this.beginningIntegrationIntervalTextbox.Location = new System.Drawing.Point(87, 188);
            this.beginningIntegrationIntervalTextbox.Name = "beginningIntegrationIntervalTextbox";
            this.beginningIntegrationIntervalTextbox.Size = new System.Drawing.Size(116, 20);
            this.beginningIntegrationIntervalTextbox.TabIndex = 0;
            this.beginningIntegrationIntervalTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xP_KeyPress);
            // 
            // endingIntegrationIntervalTextbox
            // 
            this.endingIntegrationIntervalTextbox.Location = new System.Drawing.Point(685, 188);
            this.endingIntegrationIntervalTextbox.Name = "endingIntegrationIntervalTextbox";
            this.endingIntegrationIntervalTextbox.Size = new System.Drawing.Size(116, 20);
            this.endingIntegrationIntervalTextbox.TabIndex = 1;
            this.endingIntegrationIntervalTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xK_KeyPress);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.White;
            this.buttonCalculate.Location = new System.Drawing.Point(401, 71);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(103, 40);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Oblicz";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // dividingPointTextbox
            // 
            this.dividingPointTextbox.Location = new System.Drawing.Point(363, 250);
            this.dividingPointTextbox.Name = "dividingPointTextbox";
            this.dividingPointTextbox.Size = new System.Drawing.Size(116, 20);
            this.dividingPointTextbox.TabIndex = 3;
            this.dividingPointTextbox.Text = "10";
            this.dividingPointTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dividingPoint_KeyPress);
            // 
            // labelXp
            // 
            this.labelXp.AutoSize = true;
            this.labelXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelXp.Location = new System.Drawing.Point(84, 172);
            this.labelXp.Name = "labelXp";
            this.labelXp.Size = new System.Drawing.Size(193, 13);
            this.labelXp.TabIndex = 4;
            this.labelXp.Text = "Początek przedziału całkowania";
            // 
            // labelXk
            // 
            this.labelXk.AutoSize = true;
            this.labelXk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelXk.Location = new System.Drawing.Point(681, 172);
            this.labelXk.Name = "labelXk";
            this.labelXk.Size = new System.Drawing.Size(179, 13);
            this.labelXk.TabIndex = 5;
            this.labelXk.Text = "Koniec przedziału całkowania";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoints.Location = new System.Drawing.Point(359, 234);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(178, 13);
            this.labelPoints.TabIndex = 6;
            this.labelPoints.Text = "Liczba punktów podziałowych";
            // 
            // polynomialX2
            // 
            this.polynomialX2.Location = new System.Drawing.Point(229, 32);
            this.polynomialX2.Name = "polynomialX2";
            this.polynomialX2.Size = new System.Drawing.Size(103, 20);
            this.polynomialX2.TabIndex = 7;
            this.polynomialX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.polynomialX2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "f(x)";
            // 
            // polynomialX1
            // 
            this.polynomialX1.Location = new System.Drawing.Point(426, 32);
            this.polynomialX1.Name = "polynomialX1";
            this.polynomialX1.Size = new System.Drawing.Size(103, 20);
            this.polynomialX1.TabIndex = 9;
            this.polynomialX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.polynomialX1_KeyPress);
            // 
            // polynomialX0
            // 
            this.polynomialX0.Location = new System.Drawing.Point(611, 34);
            this.polynomialX0.Name = "polynomialX0";
            this.polynomialX0.Size = new System.Drawing.Size(103, 20);
            this.polynomialX0.TabIndex = 11;
            this.polynomialX0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.polynomialX0_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "x2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "x1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "x0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.returnButton);
            this.groupBox1.Controls.Add(this.arithmeticSymbol2);
            this.groupBox1.Controls.Add(this.arithmeticSymbol1);
            this.groupBox1.Controls.Add(this.buttonCalculate);
            this.groupBox1.Controls.Add(this.polynomialX2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.polynomialX1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.polynomialX0);
            this.groupBox1.Location = new System.Drawing.Point(12, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 112);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // arithmeticSymbol2
            // 
            this.arithmeticSymbol2.FormattingEnabled = true;
            this.arithmeticSymbol2.Items.AddRange(new object[] {
            "+",
            "-"});
            this.arithmeticSymbol2.Location = new System.Drawing.Point(537, 33);
            this.arithmeticSymbol2.Name = "arithmeticSymbol2";
            this.arithmeticSymbol2.Size = new System.Drawing.Size(39, 21);
            this.arithmeticSymbol2.TabIndex = 15;
            this.arithmeticSymbol2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // arithmeticSymbol1
            // 
            this.arithmeticSymbol1.FormattingEnabled = true;
            this.arithmeticSymbol1.Items.AddRange(new object[] {
            "+",
            "-"});
            this.arithmeticSymbol1.Location = new System.Drawing.Point(339, 32);
            this.arithmeticSymbol1.Name = "arithmeticSymbol1";
            this.arithmeticSymbol1.Size = new System.Drawing.Size(39, 21);
            this.arithmeticSymbol1.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(1, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(927, 136);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(210, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(571, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Całkowanie numeryczne metodą Simpsona";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SimpsonMethod.Properties.Resources.Logo_polskojezyczne;
            this.pictureBox1.InitialImage = global::SimpsonMethod.Properties.Resources.Logo_polskojezyczne;
            this.pictureBox1.Location = new System.Drawing.Point(7, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(6, 72);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(103, 40);
            this.returnButton.TabIndex = 16;
            this.returnButton.Text = "Wróć";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // CountingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelXk);
            this.Controls.Add(this.labelXp);
            this.Controls.Add(this.dividingPointTextbox);
            this.Controls.Add(this.endingIntegrationIntervalTextbox);
            this.Controls.Add(this.beginningIntegrationIntervalTextbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metoda Simpsona";
            this.Load += new System.EventHandler(this.CountingWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox beginningIntegrationIntervalTextbox;
        private System.Windows.Forms.TextBox endingIntegrationIntervalTextbox;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox dividingPointTextbox;
        private System.Windows.Forms.Label labelXp;
        private System.Windows.Forms.Label labelXk;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.TextBox polynomialX2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox polynomialX1;
        private System.Windows.Forms.TextBox polynomialX0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox arithmeticSymbol1;
        private System.Windows.Forms.ComboBox arithmeticSymbol2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button returnButton;
    }
}

