
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
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fahrenheitValueInput_txtbox
            // 
            this.fahrenheitValueInput_txtbox.BackColor = System.Drawing.Color.Aqua;
            this.fahrenheitValueInput_txtbox.Location = new System.Drawing.Point(325, 118);
            this.fahrenheitValueInput_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.fahrenheitValueInput_txtbox.Name = "fahrenheitValueInput_txtbox";
            this.fahrenheitValueInput_txtbox.Size = new System.Drawing.Size(132, 22);
            this.fahrenheitValueInput_txtbox.TabIndex = 0;
            this.fahrenheitValueInput_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // celsiusValue_txtbox
            // 
            this.celsiusValue_txtbox.BackColor = System.Drawing.Color.Aqua;
            this.celsiusValue_txtbox.Location = new System.Drawing.Point(325, 236);
            this.celsiusValue_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.celsiusValue_txtbox.Name = "celsiusValue_txtbox";
            this.celsiusValue_txtbox.Size = new System.Drawing.Size(132, 22);
            this.celsiusValue_txtbox.TabIndex = 1;
            this.celsiusValue_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(60, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Fahrenheit Temperature";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(13, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conversion to Celsius Temperature";
            // 
            // conversionAction_btn
            // 
            this.conversionAction_btn.FlatAppearance.BorderSize = 0;
            this.conversionAction_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conversionAction_btn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionAction_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.conversionAction_btn.Location = new System.Drawing.Point(227, 293);
            this.conversionAction_btn.Margin = new System.Windows.Forms.Padding(4);
            this.conversionAction_btn.Name = "conversionAction_btn";
            this.conversionAction_btn.Size = new System.Drawing.Size(136, 43);
            this.conversionAction_btn.TabIndex = 4;
            this.conversionAction_btn.Text = "Convert";
            this.conversionAction_btn.UseVisualStyleBackColor = true;
            this.conversionAction_btn.Click += new System.EventHandler(this.conversionAction_btn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(-2, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(539, 72);
            this.label3.TabIndex = 5;
            this.label3.Text = "Temperature Conversion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(539, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conversionAction_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.celsiusValue_txtbox);
            this.Controls.Add(this.fahrenheitValueInput_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label3;
    }
}

