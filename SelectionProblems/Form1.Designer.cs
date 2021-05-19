
namespace SelectionProblems
{
    partial class Form1
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
            this.BtnSizeSelector = new System.Windows.Forms.Button();
            this.BtnPassOrFail = new System.Windows.Forms.Button();
            this.BtnGrading = new System.Windows.Forms.Button();
            this.BtnGasRates = new System.Windows.Forms.Button();
            this.BtnTelegram = new System.Windows.Forms.Button();
            this.BtnElectricityRates = new System.Windows.Forms.Button();
            this.BtnTaxBracket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSizeSelector
            // 
            this.BtnSizeSelector.Location = new System.Drawing.Point(12, 12);
            this.BtnSizeSelector.Name = "BtnSizeSelector";
            this.BtnSizeSelector.Size = new System.Drawing.Size(193, 34);
            this.BtnSizeSelector.TabIndex = 0;
            this.BtnSizeSelector.Text = "Small, Medium and Large";
            this.BtnSizeSelector.UseVisualStyleBackColor = true;
            this.BtnSizeSelector.Click += new System.EventHandler(this.BtnSizeSelector_Click);
            // 
            // BtnPassOrFail
            // 
            this.BtnPassOrFail.Location = new System.Drawing.Point(12, 52);
            this.BtnPassOrFail.Name = "BtnPassOrFail";
            this.BtnPassOrFail.Size = new System.Drawing.Size(193, 34);
            this.BtnPassOrFail.TabIndex = 1;
            this.BtnPassOrFail.Text = "Pass or Fail";
            this.BtnPassOrFail.UseVisualStyleBackColor = true;
            this.BtnPassOrFail.Click += new System.EventHandler(this.BtnPassOrFail_Click);
            // 
            // BtnGrading
            // 
            this.BtnGrading.Location = new System.Drawing.Point(12, 92);
            this.BtnGrading.Name = "BtnGrading";
            this.BtnGrading.Size = new System.Drawing.Size(193, 34);
            this.BtnGrading.TabIndex = 2;
            this.BtnGrading.Text = "Grading ";
            this.BtnGrading.UseVisualStyleBackColor = true;
            this.BtnGrading.Click += new System.EventHandler(this.BtnGrading_Click);
            // 
            // BtnGasRates
            // 
            this.BtnGasRates.Location = new System.Drawing.Point(12, 132);
            this.BtnGasRates.Name = "BtnGasRates";
            this.BtnGasRates.Size = new System.Drawing.Size(193, 34);
            this.BtnGasRates.TabIndex = 3;
            this.BtnGasRates.Text = "Gas Rates";
            this.BtnGasRates.UseVisualStyleBackColor = true;
            this.BtnGasRates.Click += new System.EventHandler(this.BtnGasRates_Click);
            // 
            // BtnTelegram
            // 
            this.BtnTelegram.Location = new System.Drawing.Point(12, 172);
            this.BtnTelegram.Name = "BtnTelegram";
            this.BtnTelegram.Size = new System.Drawing.Size(193, 34);
            this.BtnTelegram.TabIndex = 4;
            this.BtnTelegram.Text = "Telegram Word Cost";
            this.BtnTelegram.UseVisualStyleBackColor = true;
            this.BtnTelegram.Click += new System.EventHandler(this.BtnTelegram_Click);
            // 
            // BtnElectricityRates
            // 
            this.BtnElectricityRates.Location = new System.Drawing.Point(12, 212);
            this.BtnElectricityRates.Name = "BtnElectricityRates";
            this.BtnElectricityRates.Size = new System.Drawing.Size(193, 34);
            this.BtnElectricityRates.TabIndex = 5;
            this.BtnElectricityRates.Text = "Electricity Rates";
            this.BtnElectricityRates.UseVisualStyleBackColor = true;
            this.BtnElectricityRates.Click += new System.EventHandler(this.BtnElectricityRates_Click);
            // 
            // BtnTaxBracket
            // 
            this.BtnTaxBracket.Location = new System.Drawing.Point(12, 252);
            this.BtnTaxBracket.Name = "BtnTaxBracket";
            this.BtnTaxBracket.Size = new System.Drawing.Size(193, 34);
            this.BtnTaxBracket.TabIndex = 6;
            this.BtnTaxBracket.Text = "Tax Bracket Placer";
            this.BtnTaxBracket.UseVisualStyleBackColor = true;
            this.BtnTaxBracket.Click += new System.EventHandler(this.BtnTaxBracket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 299);
            this.Controls.Add(this.BtnTaxBracket);
            this.Controls.Add(this.BtnElectricityRates);
            this.Controls.Add(this.BtnTelegram);
            this.Controls.Add(this.BtnGasRates);
            this.Controls.Add(this.BtnGrading);
            this.Controls.Add(this.BtnPassOrFail);
            this.Controls.Add(this.BtnSizeSelector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSizeSelector;
        private System.Windows.Forms.Button BtnPassOrFail;
        private System.Windows.Forms.Button BtnGrading;
        private System.Windows.Forms.Button BtnGasRates;
        private System.Windows.Forms.Button BtnTelegram;
        private System.Windows.Forms.Button BtnElectricityRates;
        private System.Windows.Forms.Button BtnTaxBracket;
    }
}

