namespace Mythras_Character_Generator
{
    partial class SystemSelectForm
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
            this.MythrasSelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MythrasSelectButton
            // 
            this.MythrasSelectButton.Location = new System.Drawing.Point(322, 53);
            this.MythrasSelectButton.Name = "MythrasSelectButton";
            this.MythrasSelectButton.Size = new System.Drawing.Size(198, 65);
            this.MythrasSelectButton.TabIndex = 0;
            this.MythrasSelectButton.Text = "Mythras";
            this.MythrasSelectButton.UseVisualStyleBackColor = true;
            this.MythrasSelectButton.Click += new System.EventHandler(this.MythrasSelectButton_Click);
            // 
            // SystemSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 342);
            this.Controls.Add(this.MythrasSelectButton);
            this.Name = "SystemSelectForm";
            this.Text = "System Select";
            this.Load += new System.EventHandler(this.SystemSelectForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MythrasSelectButton;
    }
}

