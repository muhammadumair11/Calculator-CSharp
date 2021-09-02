
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayText = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.decimalbtn = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.prevText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayText
            // 
            this.displayText.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.displayText.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.displayText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayText.Location = new System.Drawing.Point(8, 5);
            this.displayText.Name = "displayText";
            this.displayText.Size = new System.Drawing.Size(263, 90);
            this.displayText.TabIndex = 0;
            this.displayText.Text = "0";
            this.displayText.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num1.Location = new System.Drawing.Point(5, 98);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(60, 50);
            this.num1.TabIndex = 1;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num2.Location = new System.Drawing.Point(71, 98);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(60, 50);
            this.num2.TabIndex = 2;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num3.Location = new System.Drawing.Point(137, 98);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(60, 50);
            this.num3.TabIndex = 3;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.reset.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reset.Location = new System.Drawing.Point(202, 98);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(69, 106);
            this.reset.TabIndex = 4;
            this.reset.Text = "AC";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num6.Location = new System.Drawing.Point(137, 154);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(60, 50);
            this.num6.TabIndex = 7;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num5.Location = new System.Drawing.Point(71, 154);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(60, 50);
            this.num5.TabIndex = 6;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num4.Location = new System.Drawing.Point(5, 154);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(60, 50);
            this.num4.TabIndex = 5;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num9.Location = new System.Drawing.Point(137, 210);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(60, 50);
            this.num9.TabIndex = 10;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num8.Location = new System.Drawing.Point(71, 210);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(60, 50);
            this.num8.TabIndex = 9;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num7.Location = new System.Drawing.Point(5, 210);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(60, 50);
            this.num7.TabIndex = 8;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sum.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sum.Location = new System.Drawing.Point(137, 266);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(60, 50);
            this.sum.TabIndex = 13;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // decimalbtn
            // 
            this.decimalbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.decimalbtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decimalbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.decimalbtn.Location = new System.Drawing.Point(71, 266);
            this.decimalbtn.Name = "decimalbtn";
            this.decimalbtn.Size = new System.Drawing.Size(60, 50);
            this.decimalbtn.TabIndex = 12;
            this.decimalbtn.Text = ".";
            this.decimalbtn.UseVisualStyleBackColor = false;
            this.decimalbtn.Click += new System.EventHandler(this.decimalbtn_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num0.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num0.Location = new System.Drawing.Point(5, 266);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(60, 106);
            this.num0.TabIndex = 11;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.div.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.div.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.div.Location = new System.Drawing.Point(203, 322);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(68, 50);
            this.div.TabIndex = 16;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sub.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sub.Location = new System.Drawing.Point(71, 322);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(60, 50);
            this.sub.TabIndex = 15;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mul.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mul.Location = new System.Drawing.Point(137, 322);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(60, 50);
            this.mul.TabIndex = 14;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.equal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.equal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equal.Location = new System.Drawing.Point(202, 210);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(69, 106);
            this.equal.TabIndex = 17;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // prevText
            // 
            this.prevText.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.prevText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prevText.Location = new System.Drawing.Point(12, 18);
            this.prevText.Name = "prevText";
            this.prevText.Size = new System.Drawing.Size(250, 22);
            this.prevText.TabIndex = 18;
            this.prevText.Text = "0";
            this.prevText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(277, 380);
            this.Controls.Add(this.prevText);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.decimalbtn);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.displayText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label displayText;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button decimalbtn;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Label prevText;
    }
}

