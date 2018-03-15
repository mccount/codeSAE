namespace wuerfelspiel
{
    partial class spielform
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
            this.lbWuerfe = new System.Windows.Forms.ListBox();
            this.lblHeading1 = new System.Windows.Forms.Label();
            this.lblHeading2 = new System.Windows.Forms.Label();
            this.tbxAnzahl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnWurfelGluck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWuerfe
            // 
            this.lbWuerfe.FormattingEnabled = true;
            this.lbWuerfe.ItemHeight = 25;
            this.lbWuerfe.Location = new System.Drawing.Point(12, 100);
            this.lbWuerfe.Name = "lbWuerfe";
            this.lbWuerfe.Size = new System.Drawing.Size(489, 704);
            this.lbWuerfe.TabIndex = 0;
            // 
            // lblHeading1
            // 
            this.lblHeading1.AutoSize = true;
            this.lblHeading1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading1.Location = new System.Drawing.Point(12, 22);
            this.lblHeading1.Name = "lblHeading1";
            this.lblHeading1.Size = new System.Drawing.Size(248, 51);
            this.lblHeading1.TabIndex = 1;
            this.lblHeading1.Text = "Würfelspiel";
            // 
            // lblHeading2
            // 
            this.lblHeading2.AutoSize = true;
            this.lblHeading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading2.Location = new System.Drawing.Point(528, 203);
            this.lblHeading2.Name = "lblHeading2";
            this.lblHeading2.Size = new System.Drawing.Size(189, 33);
            this.lblHeading2.TabIndex = 2;
            this.lblHeading2.Text = "Anzahl Würfe";
            // 
            // tbxAnzahl
            // 
            this.tbxAnzahl.Enabled = false;
            this.tbxAnzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAnzahl.HideSelection = false;
            this.tbxAnzahl.Location = new System.Drawing.Point(534, 240);
            this.tbxAnzahl.Name = "tbxAnzahl";
            this.tbxAnzahl.Size = new System.Drawing.Size(183, 44);
            this.tbxAnzahl.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(529, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Spiel starten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWurfelGluck
            // 
            this.btnWurfelGluck.Location = new System.Drawing.Point(534, 739);
            this.btnWurfelGluck.Name = "btnWurfelGluck";
            this.btnWurfelGluck.Size = new System.Drawing.Size(205, 65);
            this.btnWurfelGluck.TabIndex = 5;
            this.btnWurfelGluck.Text = "Weiteres Spiel: Würfelglück";
            this.btnWurfelGluck.UseVisualStyleBackColor = true;
            this.btnWurfelGluck.Click += new System.EventHandler(this.btnWurfelGluck_Click);
            // 
            // spielform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(754, 822);
            this.Controls.Add(this.btnWurfelGluck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxAnzahl);
            this.Controls.Add(this.lblHeading2);
            this.Controls.Add(this.lblHeading1);
            this.Controls.Add(this.lbWuerfe);
            this.Name = "spielform";
            this.Text = "Würfelspiel";
            this.Load += new System.EventHandler(this.spielform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWuerfe;
        private System.Windows.Forms.Label lblHeading1;
        private System.Windows.Forms.Label lblHeading2;
        private System.Windows.Forms.TextBox tbxAnzahl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWurfelGluck;
    }
}

