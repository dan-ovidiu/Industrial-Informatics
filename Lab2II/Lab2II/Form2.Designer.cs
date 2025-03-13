namespace Lab2II
{
    partial class Form2
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
            this.resultedText = new System.Windows.Forms.TextBox();
            this.inputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getTextBtn = new System.Windows.Forms.Button();
            this.showForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultedText
            // 
            this.resultedText.Location = new System.Drawing.Point(327, 189);
            this.resultedText.Name = "resultedText";
            this.resultedText.ReadOnly = true;
            this.resultedText.Size = new System.Drawing.Size(100, 31);
            this.resultedText.TabIndex = 0;
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(327, 105);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(100, 31);
            this.inputText.TabIndex = 5;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Copied text";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // getTextBtn
            // 
            this.getTextBtn.Location = new System.Drawing.Point(302, 270);
            this.getTextBtn.Name = "getTextBtn";
            this.getTextBtn.Size = new System.Drawing.Size(139, 53);
            this.getTextBtn.TabIndex = 4;
            this.getTextBtn.Text = "Get Text";
            this.getTextBtn.UseVisualStyleBackColor = true;
            this.getTextBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // showForm1
            // 
            this.showForm1.Location = new System.Drawing.Point(545, 270);
            this.showForm1.Name = "showForm1";
            this.showForm1.Size = new System.Drawing.Size(163, 53);
            this.showForm1.TabIndex = 6;
            this.showForm1.Text = "Show Form1";
            this.showForm1.UseVisualStyleBackColor = true;
            this.showForm1.Click += new System.EventHandler(this.showForm1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showForm1);
            this.Controls.Add(this.getTextBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.resultedText);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultedText;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getTextBtn;
        private System.Windows.Forms.Button showForm1;
    }
}