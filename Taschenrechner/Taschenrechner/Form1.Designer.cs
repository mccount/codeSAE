namespace Taschenrechner
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
            this.lblNumberOne = new System.Windows.Forms.Label();
            this.lblNumberTwo = new System.Windows.Forms.Label();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraktion = new System.Windows.Forms.Button();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDerivative = new System.Windows.Forms.Button();
            this.lblDerivative = new System.Windows.Forms.Label();
            this.tbxDerivative = new System.Windows.Forms.TextBox();
            this.gbxMode = new System.Windows.Forms.GroupBox();
            this.rbtnExpanded = new System.Windows.Forms.RadioButton();
            this.rbtnSimple = new System.Windows.Forms.RadioButton();
            this.gbxMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxNumberOne
            // 
            this.tbxNumberOne.Location = new System.Drawing.Point(187, 120);
            this.tbxNumberOne.Name = "tbxNumberOne";
            this.tbxNumberOne.Size = new System.Drawing.Size(100, 31);
            this.tbxNumberOne.TabIndex = 0;
            this.tbxNumberOne.TextChanged += new System.EventHandler(this.tbxNumberOne_TextChanged);
            // 
            // tbxNumberTwo
            // 
            this.tbxNumberTwo.Location = new System.Drawing.Point(187, 197);
            this.tbxNumberTwo.Name = "tbxNumberTwo";
            this.tbxNumberTwo.Size = new System.Drawing.Size(100, 31);
            this.tbxNumberTwo.TabIndex = 1;
            this.tbxNumberTwo.TextChanged += new System.EventHandler(this.tbxNumberTwo_TextChanged);
            // 
            // lblNumberOne
            // 
            this.lblNumberOne.AutoSize = true;
            this.lblNumberOne.Location = new System.Drawing.Point(60, 125);
            this.lblNumberOne.Name = "lblNumberOne";
            this.lblNumberOne.Size = new System.Drawing.Size(72, 25);
            this.lblNumberOne.TabIndex = 2;
            this.lblNumberOne.Text = "Zahl 1";
            // 
            // lblNumberTwo
            // 
            this.lblNumberTwo.AutoSize = true;
            this.lblNumberTwo.Location = new System.Drawing.Point(60, 197);
            this.lblNumberTwo.Name = "lblNumberTwo";
            this.lblNumberTwo.Size = new System.Drawing.Size(72, 25);
            this.lblNumberTwo.TabIndex = 3;
            this.lblNumberTwo.Text = "Zahl 2";
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(618, 332);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(74, 74);
            this.btnMultiplication.TabIndex = 4;
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(618, 92);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(74, 74);
            this.btnDivision.TabIndex = 5;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(618, 252);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(74, 74);
            this.btnAddition.TabIndex = 6;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraktion
            // 
            this.btnSubtraktion.Location = new System.Drawing.Point(618, 172);
            this.btnSubtraktion.Name = "btnSubtraktion";
            this.btnSubtraktion.Size = new System.Drawing.Size(74, 74);
            this.btnSubtraktion.TabIndex = 7;
            this.btnSubtraktion.Text = "-";
            this.btnSubtraktion.UseVisualStyleBackColor = true;
            this.btnSubtraktion.Click += new System.EventHandler(this.btnSubtraktion_Click);
            // 
            // tbxResult
            // 
            this.tbxResult.Enabled = false;
            this.tbxResult.Location = new System.Drawing.Point(187, 371);
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(242, 31);
            this.tbxResult.TabIndex = 8;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(60, 371);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(97, 25);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Ergebnis";
            // 
            // btnDerivative
            // 
            this.btnDerivative.Location = new System.Drawing.Point(618, 12);
            this.btnDerivative.Name = "btnDerivative";
            this.btnDerivative.Size = new System.Drawing.Size(74, 74);
            this.btnDerivative.TabIndex = 10;
            this.btnDerivative.Text = "∂";
            this.btnDerivative.UseVisualStyleBackColor = true;
            this.btnDerivative.Click += new System.EventHandler(this.btnDerivative_Click);
            // 
            // lblDerivative
            // 
            this.lblDerivative.AutoSize = true;
            this.lblDerivative.Location = new System.Drawing.Point(60, 277);
            this.lblDerivative.Name = "lblDerivative";
            this.lblDerivative.Size = new System.Drawing.Size(78, 25);
            this.lblDerivative.TabIndex = 11;
            this.lblDerivative.Text = "Formel";
            // 
            // tbxDerivative
            // 
            this.tbxDerivative.Location = new System.Drawing.Point(187, 277);
            this.tbxDerivative.Name = "tbxDerivative";
            this.tbxDerivative.Size = new System.Drawing.Size(242, 31);
            this.tbxDerivative.TabIndex = 12;
            // 
            // gbxMode
            // 
            this.gbxMode.Controls.Add(this.rbtnExpanded);
            this.gbxMode.Controls.Add(this.rbtnSimple);
            this.gbxMode.Location = new System.Drawing.Point(40, 24);
            this.gbxMode.Name = "gbxMode";
            this.gbxMode.Size = new System.Drawing.Size(457, 74);
            this.gbxMode.TabIndex = 13;
            this.gbxMode.TabStop = false;
            this.gbxMode.Text = "Arbeitsmodus";
            // 
            // rbtnExpanded
            // 
            this.rbtnExpanded.AutoSize = true;
            this.rbtnExpanded.Location = new System.Drawing.Point(187, 33);
            this.rbtnExpanded.Name = "rbtnExpanded";
            this.rbtnExpanded.Size = new System.Drawing.Size(127, 29);
            this.rbtnExpanded.TabIndex = 2;
            this.rbtnExpanded.TabStop = true;
            this.rbtnExpanded.Text = "Erweitert";
            this.rbtnExpanded.UseVisualStyleBackColor = true;
            this.rbtnExpanded.CheckedChanged += new System.EventHandler(this.rbtnExpanded_CheckedChanged);
            // 
            // rbtnSimple
            // 
            this.rbtnSimple.AutoSize = true;
            this.rbtnSimple.Location = new System.Drawing.Point(6, 33);
            this.rbtnSimple.Name = "rbtnSimple";
            this.rbtnSimple.Size = new System.Drawing.Size(115, 29);
            this.rbtnSimple.TabIndex = 1;
            this.rbtnSimple.TabStop = true;
            this.rbtnSimple.Text = "Einfach";
            this.rbtnSimple.UseVisualStyleBackColor = true;
            this.rbtnSimple.CheckedChanged += new System.EventHandler(this.rbtnSimple_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 438);
            this.Controls.Add(this.gbxMode);
            this.Controls.Add(this.tbxDerivative);
            this.Controls.Add(this.lblDerivative);
            this.Controls.Add(this.btnDerivative);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.btnSubtraktion);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.lblNumberTwo);
            this.Controls.Add(this.lblNumberOne);
            this.Controls.Add(this.tbxNumberTwo);
            this.Controls.Add(this.tbxNumberOne);
            this.Name = "Form1";
            this.Text = "Taschenrechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxMode.ResumeLayout(false);
            this.gbxMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNumberOne;
        private System.Windows.Forms.TextBox tbxNumberTwo;
        private System.Windows.Forms.Label lblNumberOne;
        private System.Windows.Forms.Label lblNumberTwo;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraktion;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDerivative;
        private System.Windows.Forms.Label lblDerivative;
        private System.Windows.Forms.TextBox tbxDerivative;
        private System.Windows.Forms.GroupBox gbxMode;
        private System.Windows.Forms.RadioButton rbtnExpanded;
        private System.Windows.Forms.RadioButton rbtnSimple;
    }
}

