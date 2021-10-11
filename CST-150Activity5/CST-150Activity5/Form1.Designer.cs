
namespace CST_150Activity5
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
            System.Windows.Forms.Button openTheFile_btn_Click;
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.listOfWords_txtbox = new System.Windows.Forms.TextBox();
            this.convertedTextBox_lbl = new System.Windows.Forms.Label();
            this.lowercase_btn_Click = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.findFirstAndLast_btn = new System.Windows.Forms.Button();
            this.findLongestWord_btn = new System.Windows.Forms.Button();
            this.mostVowels_btn = new System.Windows.Forms.Button();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveToFile_btn = new System.Windows.Forms.Button();
            openTheFile_btn_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openTheFile_btn_Click
            // 
            openTheFile_btn_Click.Location = new System.Drawing.Point(113, 141);
            openTheFile_btn_Click.Name = "openTheFile_btn_Click";
            openTheFile_btn_Click.Size = new System.Drawing.Size(155, 39);
            openTheFile_btn_Click.TabIndex = 2;
            openTheFile_btn_Click.Text = "Open a text file";
            openTheFile_btn_Click.UseVisualStyleBackColor = true;
            openTheFile_btn_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // listOfWords_txtbox
            // 
            this.listOfWords_txtbox.Location = new System.Drawing.Point(332, 141);
            this.listOfWords_txtbox.Multiline = true;
            this.listOfWords_txtbox.Name = "listOfWords_txtbox";
            this.listOfWords_txtbox.Size = new System.Drawing.Size(283, 367);
            this.listOfWords_txtbox.TabIndex = 0;
            this.listOfWords_txtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // convertedTextBox_lbl
            // 
            this.convertedTextBox_lbl.AutoSize = true;
            this.convertedTextBox_lbl.Location = new System.Drawing.Point(432, 108);
            this.convertedTextBox_lbl.Name = "convertedTextBox_lbl";
            this.convertedTextBox_lbl.Size = new System.Drawing.Size(61, 17);
            this.convertedTextBox_lbl.TabIndex = 1;
            this.convertedTextBox_lbl.Text = "File Text";
            // 
            // lowercase_btn_Click
            // 
            this.lowercase_btn_Click.Location = new System.Drawing.Point(113, 196);
            this.lowercase_btn_Click.Name = "lowercase_btn_Click";
            this.lowercase_btn_Click.Size = new System.Drawing.Size(155, 39);
            this.lowercase_btn_Click.TabIndex = 3;
            this.lowercase_btn_Click.Text = "Convert to lowercase";
            this.lowercase_btn_Click.UseVisualStyleBackColor = true;
            this.lowercase_btn_Click.Click += new System.EventHandler(this.lowercase_btn_Click_Click);
            // 
            // findFirstAndLast_btn
            // 
            this.findFirstAndLast_btn.Location = new System.Drawing.Point(113, 252);
            this.findFirstAndLast_btn.Name = "findFirstAndLast_btn";
            this.findFirstAndLast_btn.Size = new System.Drawing.Size(155, 46);
            this.findFirstAndLast_btn.TabIndex = 4;
            this.findFirstAndLast_btn.Text = "Find first and last word";
            this.findFirstAndLast_btn.UseVisualStyleBackColor = true;
            this.findFirstAndLast_btn.Click += new System.EventHandler(this.findFirstAndLast_btn_Click);
            // 
            // findLongestWord_btn
            // 
            this.findLongestWord_btn.Location = new System.Drawing.Point(113, 317);
            this.findLongestWord_btn.Name = "findLongestWord_btn";
            this.findLongestWord_btn.Size = new System.Drawing.Size(155, 48);
            this.findLongestWord_btn.TabIndex = 5;
            this.findLongestWord_btn.Text = "Find longest word";
            this.findLongestWord_btn.UseVisualStyleBackColor = true;
            this.findLongestWord_btn.Click += new System.EventHandler(this.findLongestWord_btn_Click);
            // 
            // mostVowels_btn
            // 
            this.mostVowels_btn.Location = new System.Drawing.Point(113, 383);
            this.mostVowels_btn.Name = "mostVowels_btn";
            this.mostVowels_btn.Size = new System.Drawing.Size(155, 49);
            this.mostVowels_btn.TabIndex = 6;
            this.mostVowels_btn.Text = "Find most vowels";
            this.mostVowels_btn.UseVisualStyleBackColor = true;
            this.mostVowels_btn.Click += new System.EventHandler(this.mostVowels_btn_Click);
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(658, 141);
            this.result_textBox.Multiline = true;
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.Size = new System.Drawing.Size(241, 367);
            this.result_textBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Button Stat Results";
            // 
            // saveToFile_btn
            // 
            this.saveToFile_btn.Location = new System.Drawing.Point(113, 459);
            this.saveToFile_btn.Name = "saveToFile_btn";
            this.saveToFile_btn.Size = new System.Drawing.Size(164, 49);
            this.saveToFile_btn.TabIndex = 9;
            this.saveToFile_btn.Text = "Save";
            this.saveToFile_btn.UseVisualStyleBackColor = true;
            this.saveToFile_btn.Click += new System.EventHandler(this.saveToFile_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 555);
            this.Controls.Add(this.saveToFile_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.mostVowels_btn);
            this.Controls.Add(this.findLongestWord_btn);
            this.Controls.Add(this.findFirstAndLast_btn);
            this.Controls.Add(this.lowercase_btn_Click);
            this.Controls.Add(openTheFile_btn_Click);
            this.Controls.Add(this.convertedTextBox_lbl);
            this.Controls.Add(this.listOfWords_txtbox);
            this.Name = "Form1";
            this.Text = "Activity 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox listOfWords_txtbox;
        private System.Windows.Forms.Label convertedTextBox_lbl;
        private System.Windows.Forms.Button lowercase_btn_Click;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button findFirstAndLast_btn;
        private System.Windows.Forms.Button findLongestWord_btn;
        private System.Windows.Forms.Button mostVowels_btn;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveToFile_btn;
    }
}

