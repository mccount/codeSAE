namespace wuerfelspiel
{
    partial class WuerfelGlueck
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
            this.lblWunsch = new System.Windows.Forms.Label();
            this.lblBenAnzahl = new System.Windows.Forms.Label();
            this.lblHaufigkeit = new System.Windows.Forms.Label();
            this.tbxAnzahl2 = new System.Windows.Forms.TextBox();
            this.tbxBenWurfe = new System.Windows.Forms.TextBox();
            this.tbxHaufigkeit = new System.Windows.Forms.TextBox();
            this.lblProzent = new System.Windows.Forms.Label();
            this.btnWuerfeln = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWunsch
            // 
            this.lblWunsch.AutoSize = true;
            this.lblWunsch.Location = new System.Drawing.Point(13, 13);
            this.lblWunsch.Name = "lblWunsch";
            this.lblWunsch.Size = new System.Drawing.Size(240, 25);
            this.lblWunsch.TabIndex = 0;
            this.lblWunsch.Text = "Gewünschte Anzahl 6er";
            // 
            // lblBenAnzahl
            // 
            this.lblBenAnzahl.AutoSize = true;
            this.lblBenAnzahl.Location = new System.Drawing.Point(87, 62);
            this.lblBenAnzahl.Name = "lblBenAnzahl";
            this.lblBenAnzahl.Size = new System.Drawing.Size(166, 25);
            this.lblBenAnzahl.TabIndex = 1;
            this.lblBenAnzahl.Text = "Benötigte Würfe";
            // 
            // lblHaufigkeit
            // 
            this.lblHaufigkeit.AutoSize = true;
            this.lblHaufigkeit.Location = new System.Drawing.Point(61, 115);
            this.lblHaufigkeit.Name = "lblHaufigkeit";
            this.lblHaufigkeit.Size = new System.Drawing.Size(192, 25);
            this.lblHaufigkeit.TabIndex = 2;
            this.lblHaufigkeit.Text = "Relative Häufigkeit";
            // 
            // tbxAnzahl2
            // 
            this.tbxAnzahl2.Location = new System.Drawing.Point(270, 10);
            this.tbxAnzahl2.Name = "tbxAnzahl2";
            this.tbxAnzahl2.Size = new System.Drawing.Size(128, 31);
            this.tbxAnzahl2.TabIndex = 3;
            // 
            // tbxBenWurfe
            // 
            this.tbxBenWurfe.Enabled = false;
            this.tbxBenWurfe.Location = new System.Drawing.Point(270, 59);
            this.tbxBenWurfe.Name = "tbxBenWurfe";
            this.tbxBenWurfe.Size = new System.Drawing.Size(284, 31);
            this.tbxBenWurfe.TabIndex = 4;
            // 
            // tbxHaufigkeit
            // 
            this.tbxHaufigkeit.Enabled = false;
            this.tbxHaufigkeit.Location = new System.Drawing.Point(270, 112);
            this.tbxHaufigkeit.Name = "tbxHaufigkeit";
            this.tbxHaufigkeit.Size = new System.Drawing.Size(329, 31);
            this.tbxHaufigkeit.TabIndex = 5;
            // 
            // lblProzent
            // 
            this.lblProzent.AutoSize = true;
            this.lblProzent.Location = new System.Drawing.Point(605, 115);
            this.lblProzent.Name = "lblProzent";
            this.lblProzent.Size = new System.Drawing.Size(31, 25);
            this.lblProzent.TabIndex = 6;
            this.lblProzent.Text = "%";
            // 
            // btnWuerfeln
            // 
            this.btnWuerfeln.Location = new System.Drawing.Point(176, 185);
            this.btnWuerfeln.Name = "btnWuerfeln";
            this.btnWuerfeln.Size = new System.Drawing.Size(116, 42);
            this.btnWuerfeln.TabIndex = 7;
            this.btnWuerfeln.Text = "Würfeln";
            this.btnWuerfeln.UseVisualStyleBackColor = true;
            this.btnWuerfeln.Click += new System.EventHandler(this.btnWuerfeln_Click);
            // 
            // WuerfelGlueck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 239);
            this.Controls.Add(this.btnWuerfeln);
            this.Controls.Add(this.lblProzent);
            this.Controls.Add(this.tbxHaufigkeit);
            this.Controls.Add(this.tbxBenWurfe);
            this.Controls.Add(this.tbxAnzahl2);
            this.Controls.Add(this.lblHaufigkeit);
            this.Controls.Add(this.lblBenAnzahl);
            this.Controls.Add(this.lblWunsch);
            this.Name = "WuerfelGlueck";
            this.Text = "Würfelglück";
            this.Load += new System.EventHandler(this.WuerfelGlueck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWunsch;
        private System.Windows.Forms.Label lblBenAnzahl;
        private System.Windows.Forms.Label lblHaufigkeit;
        private System.Windows.Forms.TextBox tbxAnzahl2;
        private System.Windows.Forms.TextBox tbxBenWurfe;
        private System.Windows.Forms.TextBox tbxHaufigkeit;
        private System.Windows.Forms.Label lblProzent;
        private System.Windows.Forms.Button btnWuerfeln;
    }
}