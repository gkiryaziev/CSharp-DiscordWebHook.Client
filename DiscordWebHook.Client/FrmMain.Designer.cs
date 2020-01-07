namespace DiscordWebHook.Client
{
    partial class FrmMain
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
            this.lblStatusCode = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_StatusCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatusCode
            // 
            this.lblStatusCode.AutoSize = true;
            this.lblStatusCode.Location = new System.Drawing.Point(162, 47);
            this.lblStatusCode.Name = "lblStatusCode";
            this.lblStatusCode.Size = new System.Drawing.Size(13, 13);
            this.lblStatusCode.TabIndex = 0;
            this.lblStatusCode.Text = "0";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(72, 94);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(251, 13);
            this.label_Description.TabIndex = 1;
            this.label_Description.Text = "The example GUI application is under development.";
            // 
            // label_StatusCode
            // 
            this.label_StatusCode.AutoSize = true;
            this.label_StatusCode.Location = new System.Drawing.Point(72, 47);
            this.label_StatusCode.Name = "label_StatusCode";
            this.label_StatusCode.Size = new System.Drawing.Size(68, 13);
            this.label_StatusCode.TabIndex = 2;
            this.label_StatusCode.Text = "Status Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "To understand how the application works, see the code.";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_StatusCode);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.lblStatusCode);
            this.Name = "FrmMain";
            this.Text = "Example GUI App";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatusCode;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_StatusCode;
        private System.Windows.Forms.Label label1;
    }
}

