
namespace CST_150Activity15
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitLucky_btn = new System.Windows.Forms.Button();
            this.lowNum_ud = new System.Windows.Forms.NumericUpDown();
            this.highNum_ud = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.lowNum_ud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highNum_ud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "We\'ll give you a lucky number between:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Low";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "High";
            // 
            // submitLucky_btn
            // 
            this.submitLucky_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitLucky_btn.Location = new System.Drawing.Point(257, 351);
            this.submitLucky_btn.Name = "submitLucky_btn";
            this.submitLucky_btn.Size = new System.Drawing.Size(227, 44);
            this.submitLucky_btn.TabIndex = 5;
            this.submitLucky_btn.Text = "Get Your Lucky Number!!";
            this.submitLucky_btn.UseVisualStyleBackColor = true;
            this.submitLucky_btn.Click += new System.EventHandler(this.submitLucky_btn_Click);
            // 
            // lowNum_ud
            // 
            this.lowNum_ud.Location = new System.Drawing.Point(153, 256);
            this.lowNum_ud.Name = "lowNum_ud";
            this.lowNum_ud.Size = new System.Drawing.Size(120, 22);
            this.lowNum_ud.TabIndex = 6;
            // 
            // highNum_ud
            // 
            this.highNum_ud.Location = new System.Drawing.Point(498, 256);
            this.highNum_ud.Name = "highNum_ud";
            this.highNum_ud.Size = new System.Drawing.Size(120, 22);
            this.highNum_ud.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highNum_ud);
            this.Controls.Add(this.lowNum_ud);
            this.Controls.Add(this.submitLucky_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lucky Number Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lowNum_ud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highNum_ud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitLucky_btn;
        private System.Windows.Forms.NumericUpDown lowNum_ud;
        private System.Windows.Forms.NumericUpDown highNum_ud;
    }
}

