
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.textBoxF2_1 = new System.Windows.Forms.TextBox();
            this.textBoxF2_2 = new System.Windows.Forms.TextBox();
            this.textBoxF2_3 = new System.Windows.Forms.TextBox();
            this.form2_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxF2_1
            // 
            this.textBoxF2_1.Location = new System.Drawing.Point(122, 24);
            this.textBoxF2_1.Name = "textBoxF2_1";
            this.textBoxF2_1.Size = new System.Drawing.Size(200, 20);
            this.textBoxF2_1.TabIndex = 0;
            // 
            // textBoxF2_2
            // 
            this.textBoxF2_2.Location = new System.Drawing.Point(122, 62);
            this.textBoxF2_2.Name = "textBoxF2_2";
            this.textBoxF2_2.Size = new System.Drawing.Size(200, 20);
            this.textBoxF2_2.TabIndex = 1;
            // 
            // textBoxF2_3
            // 
            this.textBoxF2_3.Location = new System.Drawing.Point(122, 100);
            this.textBoxF2_3.Name = "textBoxF2_3";
            this.textBoxF2_3.Size = new System.Drawing.Size(200, 20);
            this.textBoxF2_3.TabIndex = 2;
            // 
            // form2_button
            // 
            this.form2_button.Location = new System.Drawing.Point(122, 150);
            this.form2_button.Name = "form2_button";
            this.form2_button.Size = new System.Drawing.Size(200, 34);
            this.form2_button.TabIndex = 3;
            this.form2_button.Text = "Submit";
            this.form2_button.UseVisualStyleBackColor = true;
            this.form2_button.Click += new System.EventHandler(this.form2_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.form2_button);
            this.Controls.Add(this.textBoxF2_3);
            this.Controls.Add(this.textBoxF2_2);
            this.Controls.Add(this.textBoxF2_1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxF2_1;
        private System.Windows.Forms.TextBox textBoxF2_2;
        private System.Windows.Forms.TextBox textBoxF2_3;
        private System.Windows.Forms.Button form2_button;
    }
}