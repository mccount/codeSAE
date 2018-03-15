namespace groesserkleiner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxNumberOne = new System.Windows.Forms.TextBox();
            this.tbxNumberTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBigger = new System.Windows.Forms.TextBox();
            this.tbxSmaller = new System.Windows.Forms.TextBox();
            this.lblBigger = new System.Windows.Forms.Label();
            this.lblSmaller = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNumberOne
            // 
            this.tbxNumberOne.Location = new System.Drawing.Point(194, 40);
            this.tbxNumberOne.Name = "tbxNumberOne";
            this.tbxNumberOne.Size = new System.Drawing.Size(275, 31);
            this.tbxNumberOne.TabIndex = 0;
            this.tbxNumberOne.TextChanged += new System.EventHandler(this.tbxNumberOne_TextChanged);
            // 
            // tbxNumberTwo
            // 
            this.tbxNumberTwo.Location = new System.Drawing.Point(194, 100);
            this.tbxNumberTwo.Name = "tbxNumberTwo";
            this.tbxNumberTwo.Size = new System.Drawing.Size(275, 31);
            this.tbxNumberTwo.TabIndex = 1;
            this.tbxNumberTwo.TextChanged += new System.EventHandler(this.tbxNumberTwo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Zahl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Zahl";
            // 
            // tbxBigger
            // 
            this.tbxBigger.Enabled = false;
            this.tbxBigger.Location = new System.Drawing.Point(194, 216);
            this.tbxBigger.Name = "tbxBigger";
            this.tbxBigger.Size = new System.Drawing.Size(275, 31);
            this.tbxBigger.TabIndex = 4;
            // 
            // tbxSmaller
            // 
            this.tbxSmaller.Enabled = false;
            this.tbxSmaller.Location = new System.Drawing.Point(194, 284);
            this.tbxSmaller.Name = "tbxSmaller";
            this.tbxSmaller.Size = new System.Drawing.Size(275, 31);
            this.tbxSmaller.TabIndex = 5;
            // 
            // lblBigger
            // 
            this.lblBigger.AutoSize = true;
            this.lblBigger.Location = new System.Drawing.Point(20, 219);
            this.lblBigger.Name = "lblBigger";
            this.lblBigger.Size = new System.Drawing.Size(139, 25);
            this.lblBigger.TabIndex = 6;
            this.lblBigger.Text = "Größere Zahl";
            this.lblBigger.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSmaller
            // 
            this.lblSmaller.AutoSize = true;
            this.lblSmaller.Location = new System.Drawing.Point(20, 287);
            this.lblSmaller.Name = "lblSmaller";
            this.lblSmaller.Size = new System.Drawing.Size(139, 25);
            this.lblSmaller.TabIndex = 7;
            this.lblSmaller.Text = "Kleinere Zahl";
            this.lblSmaller.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(173, 386);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(142, 45);
            this.btnCompare.TabIndex = 8;
            this.btnCompare.Text = "Ermitteln";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 468);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.lblSmaller);
            this.Controls.Add(this.lblBigger);
            this.Controls.Add(this.tbxSmaller);
            this.Controls.Add(this.tbxBigger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNumberTwo);
            this.Controls.Add(this.tbxNumberOne);
            this.Name = "Form1";
            this.Text = "Größer / Kleiner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNumberOne;
        private System.Windows.Forms.TextBox tbxNumberTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxBigger;
        private System.Windows.Forms.TextBox tbxSmaller;
        private System.Windows.Forms.Label lblBigger;
        private System.Windows.Forms.Label lblSmaller;
        private System.Windows.Forms.Button btnCompare;
    }
}

