namespace NewCLand
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxKinder = new System.Windows.Forms.TextBox();
            this.tbxEinkommen = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.tbxAusgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kindergeld";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anzahl Kinder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Höhe Einkommen:";
            // 
            // tbxKinder
            // 
            this.tbxKinder.Location = new System.Drawing.Point(212, 105);
            this.tbxKinder.Name = "tbxKinder";
            this.tbxKinder.Size = new System.Drawing.Size(130, 31);
            this.tbxKinder.TabIndex = 3;
            this.tbxKinder.TextChanged += new System.EventHandler(this.tbxKinder_TextChanged);
            // 
            // tbxEinkommen
            // 
            this.tbxEinkommen.Location = new System.Drawing.Point(212, 152);
            this.tbxEinkommen.Name = "tbxEinkommen";
            this.tbxEinkommen.Size = new System.Drawing.Size(130, 31);
            this.tbxEinkommen.TabIndex = 4;
            this.tbxEinkommen.TextChanged += new System.EventHandler(this.tbxEinkommen_TextChanged);
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(18, 205);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(139, 45);
            this.btnBerechnen.TabIndex = 5;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // tbxAusgabe
            // 
            this.tbxAusgabe.Enabled = false;
            this.tbxAusgabe.Location = new System.Drawing.Point(13, 273);
            this.tbxAusgabe.Name = "tbxAusgabe";
            this.tbxAusgabe.Size = new System.Drawing.Size(333, 31);
            this.tbxAusgabe.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 331);
            this.Controls.Add(this.tbxAusgabe);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.tbxEinkommen);
            this.Controls.Add(this.tbxKinder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxKinder;
        private System.Windows.Forms.TextBox tbxEinkommen;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.TextBox tbxAusgabe;
    }
}

