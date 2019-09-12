namespace ProjectCodeFirst
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
            this.rtxtJson = new System.Windows.Forms.RichTextBox();
            this.txtPostTitle = new System.Windows.Forms.TextBox();
            this.rtxtPostBody = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtJson
            // 
            this.rtxtJson.Location = new System.Drawing.Point(12, 12);
            this.rtxtJson.Name = "rtxtJson";
            this.rtxtJson.Size = new System.Drawing.Size(384, 426);
            this.rtxtJson.TabIndex = 0;
            this.rtxtJson.Text = "";
            // 
            // txtPostTitle
            // 
            this.txtPostTitle.Location = new System.Drawing.Point(448, 12);
            this.txtPostTitle.Name = "txtPostTitle";
            this.txtPostTitle.Size = new System.Drawing.Size(340, 26);
            this.txtPostTitle.TabIndex = 1;
            // 
            // rtxtPostBody
            // 
            this.rtxtPostBody.Location = new System.Drawing.Point(448, 64);
            this.rtxtPostBody.Name = "rtxtPostBody";
            this.rtxtPostBody.Size = new System.Drawing.Size(340, 374);
            this.rtxtPostBody.TabIndex = 2;
            this.rtxtPostBody.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtPostBody);
            this.Controls.Add(this.txtPostTitle);
            this.Controls.Add(this.rtxtJson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtJson;
        private System.Windows.Forms.TextBox txtPostTitle;
        private System.Windows.Forms.RichTextBox rtxtPostBody;
    }
}

