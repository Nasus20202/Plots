
namespace Plots
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
            this.components = new System.ComponentModel.Container();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.equationText = new System.Windows.Forms.TextBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromText = new System.Windows.Forms.TextBox();
            this.toText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stepText = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(12, 12);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(893, 505);
            this.formsPlot1.TabIndex = 0;
            this.formsPlot1.Load += new System.EventHandler(this.formsPlot1_Load);
            // 
            // equationText
            // 
            this.equationText.Location = new System.Drawing.Point(123, 541);
            this.equationText.Name = "equationText";
            this.equationText.Size = new System.Drawing.Size(336, 20);
            this.equationText.TabIndex = 1;
            this.equationText.Text = "x + 1 + 2 + 3";
            this.equationText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(801, 551);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(104, 23);
            this.drawBtn.TabIndex = 2;
            this.drawBtn.Text = "Rysuj (D)";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wpisz równanie:   y = ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Od";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Do";
            // 
            // fromText
            // 
            this.fromText.Location = new System.Drawing.Point(492, 542);
            this.fromText.Name = "fromText";
            this.fromText.Size = new System.Drawing.Size(76, 20);
            this.fromText.TabIndex = 6;
            this.fromText.Text = "-10";
            // 
            // toText
            // 
            this.toText.Location = new System.Drawing.Point(601, 543);
            this.toText.Name = "toText";
            this.toText.Size = new System.Drawing.Size(80, 20);
            this.toText.TabIndex = 7;
            this.toText.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Krok";
            // 
            // stepText
            // 
            this.stepText.Location = new System.Drawing.Point(722, 543);
            this.stepText.Name = "stepText";
            this.stepText.Size = new System.Drawing.Size(73, 20);
            this.stepText.TabIndex = 9;
            this.stepText.Text = "0,1";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(801, 522);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(104, 23);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Czyść (Shift + C)";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(917, 583);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.stepText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.fromText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.equationText);
            this.Controls.Add(this.formsPlot1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Wykresy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.TextBox equationText;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fromText;
        private System.Windows.Forms.TextBox toText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stepText;
        private System.Windows.Forms.Button clearBtn;
    }
}

