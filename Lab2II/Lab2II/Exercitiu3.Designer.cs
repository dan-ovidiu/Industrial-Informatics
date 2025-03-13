namespace Lab2II
{
    partial class Exercitiu3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adunareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scadereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inmultireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impartireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(321, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(321, 247);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 31);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adunareToolStripMenuItem,
            this.scadereToolStripMenuItem,
            this.inmultireToolStripMenuItem,
            this.impartireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 42);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adunareToolStripMenuItem
            // 
            this.adunareToolStripMenuItem.Name = "adunareToolStripMenuItem";
            this.adunareToolStripMenuItem.Size = new System.Drawing.Size(50, 38);
            this.adunareToolStripMenuItem.Text = "+";
            this.adunareToolStripMenuItem.Click += new System.EventHandler(this.adunareToolStripMenuItem_Click);
            // 
            // scadereToolStripMenuItem
            // 
            this.scadereToolStripMenuItem.Name = "scadereToolStripMenuItem";
            this.scadereToolStripMenuItem.Size = new System.Drawing.Size(44, 38);
            this.scadereToolStripMenuItem.Text = "-";
            this.scadereToolStripMenuItem.Click += new System.EventHandler(this.scadereToolStripMenuItem_Click);
            // 
            // inmultireToolStripMenuItem
            // 
            this.inmultireToolStripMenuItem.Name = "inmultireToolStripMenuItem";
            this.inmultireToolStripMenuItem.Size = new System.Drawing.Size(44, 38);
            this.inmultireToolStripMenuItem.Text = "*";
            this.inmultireToolStripMenuItem.Click += new System.EventHandler(this.inmultireToolStripMenuItem_Click);
            // 
            // impartireToolStripMenuItem
            // 
            this.impartireToolStripMenuItem.Name = "impartireToolStripMenuItem";
            this.impartireToolStripMenuItem.Size = new System.Drawing.Size(43, 38);
            this.impartireToolStripMenuItem.Text = "/";
            this.impartireToolStripMenuItem.Click += new System.EventHandler(this.impartireToolStripMenuItem_Click);
            // 
            // Exercitiu3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Exercitiu3";
            this.Text = "Exercitiu3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adunareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scadereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inmultireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impartireToolStripMenuItem;
    }
}