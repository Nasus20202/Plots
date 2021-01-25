
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszObrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rysujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(11, 43);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(893, 505);
            this.formsPlot1.TabIndex = 0;
            this.formsPlot1.Load += new System.EventHandler(this.formsPlot1_Load);
            // 
            // equationText
            // 
            this.equationText.Location = new System.Drawing.Point(122, 572);
            this.equationText.Name = "equationText";
            this.equationText.Size = new System.Drawing.Size(336, 20);
            this.equationText.TabIndex = 1;
            this.equationText.Text = "x + 1 + 2 + 3";
            this.equationText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(800, 582);
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
            this.label1.Location = new System.Drawing.Point(11, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wpisz równanie:   y = ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Od";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Do";
            // 
            // fromText
            // 
            this.fromText.Location = new System.Drawing.Point(491, 573);
            this.fromText.Name = "fromText";
            this.fromText.Size = new System.Drawing.Size(76, 20);
            this.fromText.TabIndex = 6;
            this.fromText.Text = "-10";
            // 
            // toText
            // 
            this.toText.Location = new System.Drawing.Point(600, 574);
            this.toText.Name = "toText";
            this.toText.Size = new System.Drawing.Size(80, 20);
            this.toText.TabIndex = 7;
            this.toText.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 577);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Krok";
            // 
            // stepText
            // 
            this.stepText.Location = new System.Drawing.Point(721, 574);
            this.stepText.Name = "stepText";
            this.stepText.Size = new System.Drawing.Size(73, 20);
            this.stepText.TabIndex = 9;
            this.stepText.Text = "0,1";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(800, 553);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(104, 23);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Czyść (Shift + C)";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Shift + scroll = zmiania osi OY       Control + Scroll = zmiania osi OX";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(758, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Krzysztof Nasuta © 2021";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.pomocToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszObrazToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // zapiszObrazToolStripMenuItem
            // 
            this.zapiszObrazToolStripMenuItem.Name = "zapiszObrazToolStripMenuItem";
            this.zapiszObrazToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszObrazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszObrazToolStripMenuItem.Text = "&Zapisz";
            this.zapiszObrazToolStripMenuItem.Click += new System.EventHandler(this.zapiszObrazToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rysujToolStripMenuItem,
            this.czyśćToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "&Edycja";
            // 
            // rysujToolStripMenuItem
            // 
            this.rysujToolStripMenuItem.Name = "rysujToolStripMenuItem";
            this.rysujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rysujToolStripMenuItem.Text = "&Rysuj";
            this.rysujToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // czyśćToolStripMenuItem
            // 
            this.czyśćToolStripMenuItem.Name = "czyśćToolStripMenuItem";
            this.czyśćToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.czyśćToolStripMenuItem.Text = "&Czyść";
            this.czyśćToolStripMenuItem.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "&Pomoc";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "&Info";
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz &jako";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(913, 612);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Wykresy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rysujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czyśćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszObrazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
    }
}

