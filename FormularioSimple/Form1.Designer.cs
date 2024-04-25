namespace FormularioSimple
{
    partial class Form1
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
            this.btValidate = new System.Windows.Forms.Button();
            this.textFirstPassword = new System.Windows.Forms.TextBox();
            this.textSecondPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btValidate
            // 
            this.btValidate.Location = new System.Drawing.Point(113, 98);
            this.btValidate.Name = "btValidate";
            this.btValidate.Size = new System.Drawing.Size(143, 76);
            this.btValidate.TabIndex = 0;
            this.btValidate.Text = "Validate";
            this.btValidate.UseVisualStyleBackColor = true;
            this.btValidate.Click += new System.EventHandler(this.btValidate_Click);
            // 
            // textFirstPassword
            // 
            this.textFirstPassword.Location = new System.Drawing.Point(99, 16);
            this.textFirstPassword.Name = "textFirstPassword";
            this.textFirstPassword.Size = new System.Drawing.Size(259, 20);
            this.textFirstPassword.TabIndex = 1;
            this.textFirstPassword.UseSystemPasswordChar = true;
            // 
            // textSecondPassword
            // 
            this.textSecondPassword.Location = new System.Drawing.Point(99, 56);
            this.textSecondPassword.Name = "textSecondPassword";
            this.textSecondPassword.Size = new System.Drawing.Size(259, 20);
            this.textSecondPassword.TabIndex = 2;
            this.textSecondPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Repeat Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSecondPassword);
            this.Controls.Add(this.textFirstPassword);
            this.Controls.Add(this.btValidate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btValidate;
        private System.Windows.Forms.TextBox textFirstPassword;
        private System.Windows.Forms.TextBox textSecondPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

