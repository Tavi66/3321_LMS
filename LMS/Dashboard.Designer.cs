namespace LMS
{
    partial class Dashboard
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
            this.ModifyPanel = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.ModifyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModifyPanel
            // 
            this.ModifyPanel.Controls.Add(this.editButton);
            this.ModifyPanel.Location = new System.Drawing.Point(845, 69);
            this.ModifyPanel.Name = "ModifyPanel";
            this.ModifyPanel.Size = new System.Drawing.Size(105, 453);
            this.ModifyPanel.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(15, 16);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 581);
            this.Controls.Add(this.ModifyPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ModifyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ModifyPanel;
        private System.Windows.Forms.Button editButton;

    }
}