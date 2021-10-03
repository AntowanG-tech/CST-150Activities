
namespace CST_150Activity1
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
            this.showFullName_btn = new System.Windows.Forms.Button();
            this.firstName_txtbox = new System.Windows.Forms.TextBox();
            this.lastName_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showFullName_btn
            // 
            this.showFullName_btn.Location = new System.Drawing.Point(331, 340);
            this.showFullName_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showFullName_btn.Name = "showFullName_btn";
            this.showFullName_btn.Size = new System.Drawing.Size(181, 68);
            this.showFullName_btn.TabIndex = 0;
            this.showFullName_btn.Text = "Show Full Name:";
            this.showFullName_btn.UseVisualStyleBackColor = true;
            this.showFullName_btn.Click += new System.EventHandler(this.showFullName_btn_Click);
            // 
            // firstName_txtbox
            // 
            this.firstName_txtbox.Location = new System.Drawing.Point(303, 148);
            this.firstName_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstName_txtbox.Name = "firstName_txtbox";
            this.firstName_txtbox.Size = new System.Drawing.Size(259, 22);
            this.firstName_txtbox.TabIndex = 1;
            this.firstName_txtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastName_txtbox
            // 
            this.lastName_txtbox.Location = new System.Drawing.Point(303, 203);
            this.lastName_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastName_txtbox.Name = "lastName_txtbox";
            this.lastName_txtbox.Size = new System.Drawing.Size(259, 22);
            this.lastName_txtbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(342, 265);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(237, 265);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(80, 17);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Enter Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 610);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastName_txtbox);
            this.Controls.Add(this.firstName_txtbox);
            this.Controls.Add(this.showFullName_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Activity1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showFullName_btn;
        private System.Windows.Forms.TextBox firstName_txtbox;
        private System.Windows.Forms.TextBox lastName_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dateLabel;
    }
}

