namespace first_steps
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
            this.btnHeading = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnPopup = new System.Windows.Forms.Button();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHeading
            // 
            this.btnHeading.Location = new System.Drawing.Point(52, 305);
            this.btnHeading.Name = "btnHeading";
            this.btnHeading.Size = new System.Drawing.Size(194, 70);
            this.btnHeading.TabIndex = 0;
            this.btnHeading.Text = "Drück mich!";
            this.btnHeading.UseVisualStyleBackColor = true;
            this.btnHeading.Click += new System.EventHandler(this.btnHeading_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(37, 25);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(402, 85);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Überschrift";
            // 
            // btnPopup
            // 
            this.btnPopup.BackColor = System.Drawing.SystemColors.Control;
            this.btnPopup.Location = new System.Drawing.Point(428, 305);
            this.btnPopup.Name = "btnPopup";
            this.btnPopup.Size = new System.Drawing.Size(194, 70);
            this.btnPopup.TabIndex = 3;
            this.btnPopup.Text = "Drück mich!";
            this.btnPopup.UseVisualStyleBackColor = false;
            this.btnPopup.Click += new System.EventHandler(this.btnPopup_Click);
            // 
            // tbxColor
            // 
            this.tbxColor.Location = new System.Drawing.Point(250, 182);
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(170, 31);
            this.tbxColor.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(682, 413);
            this.Controls.Add(this.tbxColor);
            this.Controls.Add(this.btnPopup);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnHeading);
            this.Name = "Form1";
            this.Text = "Testprogramm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHeading;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnPopup;
        private System.Windows.Forms.TextBox tbxColor;
    }
}

