
namespace CST_150Activity7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.enterNumberOfTerms_lbl = new System.Windows.Forms.Label();
            this.numberOfTermsInput_txtbox = new System.Windows.Forms.TextBox();
            this.calculatePi_btn = new System.Windows.Forms.Button();
            this.termInputAprroxValue_lbl = new System.Windows.Forms.Label();
            this.calculationResult_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterNumberOfTerms_lbl
            // 
            this.enterNumberOfTerms_lbl.AutoSize = true;
            this.enterNumberOfTerms_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNumberOfTerms_lbl.Location = new System.Drawing.Point(57, 89);
            this.enterNumberOfTerms_lbl.Name = "enterNumberOfTerms_lbl";
            this.enterNumberOfTerms_lbl.Size = new System.Drawing.Size(187, 29);
            this.enterNumberOfTerms_lbl.TabIndex = 0;
            this.enterNumberOfTerms_lbl.Text = "Enter # of terms:";
            this.enterNumberOfTerms_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // numberOfTermsInput_txtbox
            // 
            this.numberOfTermsInput_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTermsInput_txtbox.Location = new System.Drawing.Point(312, 89);
            this.numberOfTermsInput_txtbox.Name = "numberOfTermsInput_txtbox";
            this.numberOfTermsInput_txtbox.Size = new System.Drawing.Size(179, 34);
            this.numberOfTermsInput_txtbox.TabIndex = 1;
            this.numberOfTermsInput_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculatePi_btn
            // 
            this.calculatePi_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.calculatePi_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatePi_btn.Location = new System.Drawing.Point(62, 168);
            this.calculatePi_btn.Name = "calculatePi_btn";
            this.calculatePi_btn.Size = new System.Drawing.Size(141, 64);
            this.calculatePi_btn.TabIndex = 2;
            this.calculatePi_btn.Text = "Calculate";
            this.calculatePi_btn.UseVisualStyleBackColor = false;
            this.calculatePi_btn.Click += new System.EventHandler(this.calculatePi_btn_Click);
            // 
            // termInputAprroxValue_lbl
            // 
            this.termInputAprroxValue_lbl.AutoSize = true;
            this.termInputAprroxValue_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termInputAprroxValue_lbl.Location = new System.Drawing.Point(62, 322);
            this.termInputAprroxValue_lbl.Name = "termInputAprroxValue_lbl";
            this.termInputAprroxValue_lbl.Size = new System.Drawing.Size(221, 25);
            this.termInputAprroxValue_lbl.TabIndex = 3;
            this.termInputAprroxValue_lbl.Text = "Approximate value of pi:";
            // 
            // calculationResult_lbl
            // 
            this.calculationResult_lbl.AutoSize = true;
            this.calculationResult_lbl.Location = new System.Drawing.Point(67, 396);
            this.calculationResult_lbl.Name = "calculationResult_lbl";
            this.calculationResult_lbl.Size = new System.Drawing.Size(16, 17);
            this.calculationResult_lbl.TabIndex = 4;
            this.calculationResult_lbl.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 547);
            this.Controls.Add(this.calculationResult_lbl);
            this.Controls.Add(this.termInputAprroxValue_lbl);
            this.Controls.Add(this.calculatePi_btn);
            this.Controls.Add(this.numberOfTermsInput_txtbox);
            this.Controls.Add(this.enterNumberOfTerms_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterNumberOfTerms_lbl;
        private System.Windows.Forms.TextBox numberOfTermsInput_txtbox;
        private System.Windows.Forms.Button calculatePi_btn;
        private System.Windows.Forms.Label termInputAprroxValue_lbl;
        private System.Windows.Forms.Label calculationResult_lbl;
    }
}

