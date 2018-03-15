namespace Rechenprüfer
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
            this.txtZahl1 = new System.Windows.Forms.TextBox();
            this.txtZahl2 = new System.Windows.Forms.TextBox();
            this.txtErgebnis = new System.Windows.Forms.TextBox();
            this.lblAddition = new System.Windows.Forms.Label();
            this.lblSubtraktion = new System.Windows.Forms.Label();
            this.lblMultiplikation = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblQuote = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zahl 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zahl 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ergebnis";
            // 
            // txtZahl1
            // 
            this.txtZahl1.Location = new System.Drawing.Point(157, 21);
            this.txtZahl1.Name = "txtZahl1";
            this.txtZahl1.Size = new System.Drawing.Size(100, 31);
            this.txtZahl1.TabIndex = 3;
            // 
            // txtZahl2
            // 
            this.txtZahl2.Location = new System.Drawing.Point(157, 85);
            this.txtZahl2.Name = "txtZahl2";
            this.txtZahl2.Size = new System.Drawing.Size(100, 31);
            this.txtZahl2.TabIndex = 4;
            // 
            // txtErgebnis
            // 
            this.txtErgebnis.Location = new System.Drawing.Point(157, 148);
            this.txtErgebnis.Name = "txtErgebnis";
            this.txtErgebnis.Size = new System.Drawing.Size(100, 31);
            this.txtErgebnis.TabIndex = 5;
            // 
            // lblAddition
            // 
            this.lblAddition.AutoSize = true;
            this.lblAddition.Location = new System.Drawing.Point(367, 27);
            this.lblAddition.Name = "lblAddition";
            this.lblAddition.Size = new System.Drawing.Size(0, 25);
            this.lblAddition.TabIndex = 6;
            // 
            // lblSubtraktion
            // 
            this.lblSubtraktion.AutoSize = true;
            this.lblSubtraktion.Location = new System.Drawing.Point(367, 82);
            this.lblSubtraktion.Name = "lblSubtraktion";
            this.lblSubtraktion.Size = new System.Drawing.Size(0, 25);
            this.lblSubtraktion.TabIndex = 7;
            // 
            // lblMultiplikation
            // 
            this.lblMultiplikation.AutoSize = true;
            this.lblMultiplikation.Location = new System.Drawing.Point(367, 135);
            this.lblMultiplikation.Name = "lblMultiplikation";
            this.lblMultiplikation.Size = new System.Drawing.Size(0, 25);
            this.lblMultiplikation.TabIndex = 8;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(367, 182);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(0, 25);
            this.lblDivision.TabIndex = 9;
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Location = new System.Drawing.Point(367, 234);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(0, 25);
            this.lblQuote.TabIndex = 10;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(83, 219);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(137, 40);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Start";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 321);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblMultiplikation);
            this.Controls.Add(this.lblSubtraktion);
            this.Controls.Add(this.lblAddition);
            this.Controls.Add(this.txtErgebnis);
            this.Controls.Add(this.txtZahl2);
            this.Controls.Add(this.txtZahl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rechenprüfer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZahl1;
        private System.Windows.Forms.TextBox txtZahl2;
        private System.Windows.Forms.TextBox txtErgebnis;
        private System.Windows.Forms.Label lblAddition;
        private System.Windows.Forms.Label lblSubtraktion;
        private System.Windows.Forms.Label lblMultiplikation;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Button btnCheck;
    }
}

