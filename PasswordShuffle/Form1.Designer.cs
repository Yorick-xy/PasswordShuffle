namespace PasswordShuffle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.checkBoxLetters = new System.Windows.Forms.CheckBox();
            this.checkBoxNumbers = new System.Windows.Forms.CheckBox();
            this.checkBoxCaract = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNbCaract = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(233, 367);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(134, 58);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Générer";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // checkBoxLetters
            // 
            this.checkBoxLetters.AutoSize = true;
            this.checkBoxLetters.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxLetters.Location = new System.Drawing.Point(106, 228);
            this.checkBoxLetters.Name = "checkBoxLetters";
            this.checkBoxLetters.Size = new System.Drawing.Size(96, 32);
            this.checkBoxLetters.TabIndex = 1;
            this.checkBoxLetters.Text = "Lettres";
            this.checkBoxLetters.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumbers
            // 
            this.checkBoxNumbers.AutoSize = true;
            this.checkBoxNumbers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxNumbers.Location = new System.Drawing.Point(249, 228);
            this.checkBoxNumbers.Name = "checkBoxNumbers";
            this.checkBoxNumbers.Size = new System.Drawing.Size(104, 32);
            this.checkBoxNumbers.TabIndex = 2;
            this.checkBoxNumbers.Text = "Chiffres";
            this.checkBoxNumbers.UseVisualStyleBackColor = true;
            // 
            // checkBoxCaract
            // 
            this.checkBoxCaract.AutoSize = true;
            this.checkBoxCaract.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxCaract.Location = new System.Drawing.Point(106, 293);
            this.checkBoxCaract.Name = "checkBoxCaract";
            this.checkBoxCaract.Size = new System.Drawing.Size(211, 32);
            this.checkBoxCaract.TabIndex = 3;
            this.checkBoxCaract.Text = "Caractères spéciaux";
            this.checkBoxCaract.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nb caractères";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(102, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mot de passe généré";
            // 
            // textBoxNbCaract
            // 
            this.textBoxNbCaract.Location = new System.Drawing.Point(117, 137);
            this.textBoxNbCaract.Multiline = true;
            this.textBoxNbCaract.Name = "textBoxNbCaract";
            this.textBoxNbCaract.Size = new System.Drawing.Size(376, 44);
            this.textBoxNbCaract.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(52, 534);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(529, 44);
            this.textBoxPassword.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 625);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNbCaract);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxCaract);
            this.Controls.Add(this.checkBoxNumbers);
            this.Controls.Add(this.checkBoxLetters);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonGenerate;
        private CheckBox checkBoxLetters;
        private CheckBox checkBoxNumbers;
        private CheckBox checkBoxCaract;
        private Label label1;
        private Label label2;
        private TextBox textBoxNbCaract;
        private TextBox textBoxPassword;
    }
}