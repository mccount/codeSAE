namespace kreditantrag
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
            this.lblAlter = new System.Windows.Forms.Label();
            this.tbxAlter = new System.Windows.Forms.TextBox();
            this.btnCommit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlter
            // 
            this.lblAlter.AutoSize = true;
            this.lblAlter.Location = new System.Drawing.Point(29, 39);
            this.lblAlter.Name = "lblAlter";
            this.lblAlter.Size = new System.Drawing.Size(200, 25);
            this.lblAlter.TabIndex = 0;
            this.lblAlter.Text = "Bitte Alter eingeben";
            // 
            // tbxAlter
            // 
            this.tbxAlter.Location = new System.Drawing.Point(34, 82);
            this.tbxAlter.Name = "tbxAlter";
            this.tbxAlter.Size = new System.Drawing.Size(241, 31);
            this.tbxAlter.TabIndex = 1;
            this.tbxAlter.TextChanged += new System.EventHandler(this.tbxAlter_TextChanged);
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(408, 76);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(166, 43);
            this.btnCommit.TabIndex = 2;
            this.btnCommit.Text = "Bestätigen";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 163);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.tbxAlter);
            this.Controls.Add(this.lblAlter);
            this.Name = "Form1";
            this.Text = "Kreditantrag";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlter;
        private System.Windows.Forms.TextBox tbxAlter;
        private System.Windows.Forms.Button btnCommit;
    }
}

