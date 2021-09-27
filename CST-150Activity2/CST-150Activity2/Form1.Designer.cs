
namespace CST_150Activity2
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
            this.fahrenheitValueInput_txtbox = new System.Windows.Forms.TextBox();
            this.celsiusValue_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conversionAction_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fahrenheitValueInput_txtbox
            // 
            this.fahrenheitValueInput_txtbox.Location = new System.Drawing.Point(244, 96);
            this.fahrenheitValueInput_txtbox.Name = "fahrenheitValueInput_txtbox";
            this.fahrenheitValueInput_txtbox.Size = new System.Drawing.Size(100, 20);
            this.fahrenheitValueInput_txtbox.TabIndex = 0;
            // 
            // celsiusValue_txtbox
            // 
            this.celsiusValue_txtbox.Location = new System.Drawing.Point(244, 192);
            this.celsiusValue_txtbox.Name = "celsiusValue_txtbox";
            this.celsiusValue_txtbox.Size = new System.Drawing.Size(100, 20);
            this.celsiusValue_txtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Fahrenheit Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conversion to Celsius Temperature";
            // 
            // conversionAction_btn
            // 
            this.conversionAction_btn.Location = new System.Drawing.Point(170, 238);
            this.conversionAction_btn.Name = "conversionAction_btn";
            this.conversionAction_btn.Size = new System.Drawing.Size(102, 35);
            this.conversionAction_btn.TabIndex = 4;
            this.conversionAction_btn.Text = "Convert";
            this.conversionAction_btn.UseVisualStyleBackColor = true;
            this.conversionAction_btn.Click += new System.EventHandler(this.conversionAction_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 302);
            this.Controls.Add(this.conversionAction_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.celsiusValue_txtbox);
            this.Controls.Add(this.fahrenheitValueInput_txtbox);
            this.Name = "Form1";
            this.Text = "Temperature Conversion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fahrenheitValueInput_txtbox;
        private System.Windows.Forms.TextBox celsiusValue_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button conversionAction_btn;
    }
}

