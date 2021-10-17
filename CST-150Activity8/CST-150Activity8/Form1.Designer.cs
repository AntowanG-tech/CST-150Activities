
namespace CST_150Activity8
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
            this.caloriesFromFat_lbl = new System.Windows.Forms.Label();
            this.caloriesFromCarbs_lbl = new System.Windows.Forms.Label();
            this.caloriesFromFat_txtbox = new System.Windows.Forms.TextBox();
            this.caloriesFromCarbs_txtbox = new System.Windows.Forms.TextBox();
            this.caloriesFromFatResult_lbl = new System.Windows.Forms.Label();
            this.caloriesFromCarbsResult_lbl = new System.Windows.Forms.Label();
            this.calculateFromFat_btn = new System.Windows.Forms.Button();
            this.calculateFromCarbs_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caloriesFromFat_lbl
            // 
            this.caloriesFromFat_lbl.AutoSize = true;
            this.caloriesFromFat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesFromFat_lbl.Location = new System.Drawing.Point(109, 98);
            this.caloriesFromFat_lbl.Name = "caloriesFromFat_lbl";
            this.caloriesFromFat_lbl.Size = new System.Drawing.Size(144, 20);
            this.caloriesFromFat_lbl.TabIndex = 0;
            this.caloriesFromFat_lbl.Text = "Calories From Fat";
            // 
            // caloriesFromCarbs_lbl
            // 
            this.caloriesFromCarbs_lbl.AutoSize = true;
            this.caloriesFromCarbs_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesFromCarbs_lbl.Location = new System.Drawing.Point(109, 208);
            this.caloriesFromCarbs_lbl.Name = "caloriesFromCarbs_lbl";
            this.caloriesFromCarbs_lbl.Size = new System.Drawing.Size(165, 20);
            this.caloriesFromCarbs_lbl.TabIndex = 1;
            this.caloriesFromCarbs_lbl.Text = "Calories From Carbs";
            this.caloriesFromCarbs_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // caloriesFromFat_txtbox
            // 
            this.caloriesFromFat_txtbox.Location = new System.Drawing.Point(321, 96);
            this.caloriesFromFat_txtbox.Name = "caloriesFromFat_txtbox";
            this.caloriesFromFat_txtbox.Size = new System.Drawing.Size(100, 22);
            this.caloriesFromFat_txtbox.TabIndex = 2;
            this.caloriesFromFat_txtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // caloriesFromCarbs_txtbox
            // 
            this.caloriesFromCarbs_txtbox.Location = new System.Drawing.Point(321, 208);
            this.caloriesFromCarbs_txtbox.Name = "caloriesFromCarbs_txtbox";
            this.caloriesFromCarbs_txtbox.Size = new System.Drawing.Size(100, 22);
            this.caloriesFromCarbs_txtbox.TabIndex = 3;
            // 
            // caloriesFromFatResult_lbl
            // 
            this.caloriesFromFatResult_lbl.AutoSize = true;
            this.caloriesFromFatResult_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesFromFatResult_lbl.Location = new System.Drawing.Point(500, 96);
            this.caloriesFromFatResult_lbl.Name = "caloriesFromFatResult_lbl";
            this.caloriesFromFatResult_lbl.Size = new System.Drawing.Size(140, 20);
            this.caloriesFromFatResult_lbl.TabIndex = 4;
            this.caloriesFromFatResult_lbl.Text = "= Awaiting Input...";
            // 
            // caloriesFromCarbsResult_lbl
            // 
            this.caloriesFromCarbsResult_lbl.AutoSize = true;
            this.caloriesFromCarbsResult_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesFromCarbsResult_lbl.Location = new System.Drawing.Point(500, 210);
            this.caloriesFromCarbsResult_lbl.Name = "caloriesFromCarbsResult_lbl";
            this.caloriesFromCarbsResult_lbl.Size = new System.Drawing.Size(140, 20);
            this.caloriesFromCarbsResult_lbl.TabIndex = 5;
            this.caloriesFromCarbsResult_lbl.Text = "= Awaiting Input...";
            // 
            // calculateFromFat_btn
            // 
            this.calculateFromFat_btn.Location = new System.Drawing.Point(178, 285);
            this.calculateFromFat_btn.Name = "calculateFromFat_btn";
            this.calculateFromFat_btn.Size = new System.Drawing.Size(145, 55);
            this.calculateFromFat_btn.TabIndex = 6;
            this.calculateFromFat_btn.Text = "Fats";
            this.calculateFromFat_btn.UseVisualStyleBackColor = true;
            this.calculateFromFat_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // calculateFromCarbs_btn
            // 
            this.calculateFromCarbs_btn.Location = new System.Drawing.Point(427, 285);
            this.calculateFromCarbs_btn.Name = "calculateFromCarbs_btn";
            this.calculateFromCarbs_btn.Size = new System.Drawing.Size(137, 55);
            this.calculateFromCarbs_btn.TabIndex = 7;
            this.calculateFromCarbs_btn.Text = "Carbs";
            this.calculateFromCarbs_btn.UseVisualStyleBackColor = true;
            this.calculateFromCarbs_btn.Click += new System.EventHandler(this.calculateFromCarbs_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateFromCarbs_btn);
            this.Controls.Add(this.calculateFromFat_btn);
            this.Controls.Add(this.caloriesFromCarbsResult_lbl);
            this.Controls.Add(this.caloriesFromFatResult_lbl);
            this.Controls.Add(this.caloriesFromCarbs_txtbox);
            this.Controls.Add(this.caloriesFromFat_txtbox);
            this.Controls.Add(this.caloriesFromCarbs_lbl);
            this.Controls.Add(this.caloriesFromFat_lbl);
            this.Name = "Form1";
            this.Text = "Activity 8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label caloriesFromFat_lbl;
        private System.Windows.Forms.Label caloriesFromCarbs_lbl;
        private System.Windows.Forms.TextBox caloriesFromFat_txtbox;
        private System.Windows.Forms.TextBox caloriesFromCarbs_txtbox;
        private System.Windows.Forms.Label caloriesFromFatResult_lbl;
        private System.Windows.Forms.Label caloriesFromCarbsResult_lbl;
        private System.Windows.Forms.Button calculateFromFat_btn;
        private System.Windows.Forms.Button calculateFromCarbs_btn;
    }
}

