namespace quadratzahlen
{
    partial class baseform
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
            this.lbEntries = new System.Windows.Forms.ListBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEntries
            // 
            this.lbEntries.FormattingEnabled = true;
            this.lbEntries.ItemHeight = 16;
            this.lbEntries.Location = new System.Drawing.Point(12, 45);
            this.lbEntries.Name = "lbEntries";
            this.lbEntries.Size = new System.Drawing.Size(343, 500);
            this.lbEntries.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(13, 13);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(154, 25);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Quadratzahlen";
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(280, 12);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 27);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "Run";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // baseform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 561);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lbEntries);
            this.Name = "baseform";
            this.Text = "Quadratzahlen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEntries;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnFill;
    }
}

