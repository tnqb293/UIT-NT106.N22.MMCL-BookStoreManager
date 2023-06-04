namespace Server
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
            this.btnsSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsSetting
            // 
            this.btnsSetting.Location = new System.Drawing.Point(86, 34);
            this.btnsSetting.Name = "btnsSetting";
            this.btnsSetting.Size = new System.Drawing.Size(197, 66);
            this.btnsSetting.TabIndex = 0;
            this.btnsSetting.Text = "Setting IP";
            this.btnsSetting.UseVisualStyleBackColor = true;
            this.btnsSetting.Click += new System.EventHandler(this.btnsSetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 280);
            this.Controls.Add(this.btnsSetting);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsSetting;
    }
}

