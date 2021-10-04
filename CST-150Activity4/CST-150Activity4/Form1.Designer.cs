
namespace CST_150Activity4
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
            this.secondsLabel = new System.Windows.Forms.Label();
            this.SecondsInput_txtBox = new System.Windows.Forms.TextBox();
            this.timeConversion_btn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeFormatLabel = new System.Windows.Forms.Label();
            this.timeResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(156, 141);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(126, 17);
            this.secondsLabel.TabIndex = 0;
            this.secondsLabel.Text = "Seconds Elapsed: ";
            // 
            // SecondsInput_txtBox
            // 
            this.SecondsInput_txtBox.Location = new System.Drawing.Point(277, 141);
            this.SecondsInput_txtBox.Name = "SecondsInput_txtBox";
            this.SecondsInput_txtBox.Size = new System.Drawing.Size(100, 22);
            this.SecondsInput_txtBox.TabIndex = 2;
            // 
            // timeConversion_btn
            // 
            this.timeConversion_btn.Location = new System.Drawing.Point(250, 249);
            this.timeConversion_btn.Name = "timeConversion_btn";
            this.timeConversion_btn.Size = new System.Drawing.Size(127, 47);
            this.timeConversion_btn.TabIndex = 3;
            this.timeConversion_btn.Text = "Time Conversion";
            this.timeConversion_btn.UseVisualStyleBackColor = true;
            this.timeConversion_btn.Click += new System.EventHandler(this.timeConversion_btn_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(203, 179);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(47, 17);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Time: ";
            // 
            // timeFormatLabel
            // 
            this.timeFormatLabel.AutoSize = true;
            this.timeFormatLabel.Location = new System.Drawing.Point(389, 181);
            this.timeFormatLabel.Name = "timeFormatLabel";
            this.timeFormatLabel.Size = new System.Drawing.Size(154, 17);
            this.timeFormatLabel.TabIndex = 6;
            this.timeFormatLabel.Text = "Format: [d : hr : min : s]";
            // 
            // timeResultLabel
            // 
            this.timeResultLabel.AutoSize = true;
            this.timeResultLabel.Location = new System.Drawing.Point(298, 181);
            this.timeResultLabel.Name = "timeResultLabel";
            this.timeResultLabel.Size = new System.Drawing.Size(31, 17);
            this.timeResultLabel.TabIndex = 7;
            this.timeResultLabel.Text = "N/A";
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 480);
            this.Controls.Add(this.timeResultLabel);
            this.Controls.Add(this.timeFormatLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeConversion_btn);
            this.Controls.Add(this.SecondsInput_txtBox);
            this.Controls.Add(this.secondsLabel);
            this.Name = "Form1";
            this.Text = "Activity4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.TextBox SecondsInput_txtBox;
        private System.Windows.Forms.Button timeConversion_btn;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeFormatLabel;
        private System.Windows.Forms.Label timeResultLabel;
    }
}

