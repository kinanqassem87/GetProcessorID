namespace GetProcessorID
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnMother = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(12, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(301, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // btnPro
            // 
            this.btnPro.Location = new System.Drawing.Point(12, 48);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(129, 23);
            this.btnPro.TabIndex = 1;
            this.btnPro.Text = "رقم المعالج";
            this.btnPro.UseVisualStyleBackColor = true;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // btnMother
            // 
            this.btnMother.Location = new System.Drawing.Point(178, 48);
            this.btnMother.Name = "btnMother";
            this.btnMother.Size = new System.Drawing.Size(135, 23);
            this.btnMother.TabIndex = 2;
            this.btnMother.Text = "رقم اللوحة الام";
            this.btnMother.UseVisualStyleBackColor = true;
            this.btnMother.Click += new System.EventHandler(this.btnMother_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 87);
            this.Controls.Add(this.btnMother);
            this.Controls.Add(this.btnPro);
            this.Controls.Add(this.txtNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الحصول على ارقام الكمبيوتر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnMother;
    }
}

