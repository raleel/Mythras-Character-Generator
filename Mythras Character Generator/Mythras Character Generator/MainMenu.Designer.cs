namespace Mythras_Character_Generator
{
    partial class MainMenu
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.fillLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.baseMythrasButton = new System.Windows.Forms.Button();
            this.fillPanel.SuspendLayout();
            this.fillLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(954, 100);
            this.topPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 461);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(954, 100);
            this.bottomPanel.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 100);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 361);
            this.leftPanel.TabIndex = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(754, 100);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(200, 361);
            this.rightPanel.TabIndex = 3;
            // 
            // fillPanel
            // 
            this.fillPanel.Controls.Add(this.fillLayoutPanel);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(200, 100);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(554, 361);
            this.fillPanel.TabIndex = 4;
            // 
            // fillLayoutPanel
            // 
            this.fillLayoutPanel.Controls.Add(this.baseMythrasButton);
            this.fillLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.fillLayoutPanel.Name = "fillLayoutPanel";
            this.fillLayoutPanel.Size = new System.Drawing.Size(554, 361);
            this.fillLayoutPanel.TabIndex = 0;
            // 
            // baseMythrasButton
            // 
            this.baseMythrasButton.Location = new System.Drawing.Point(3, 3);
            this.baseMythrasButton.Name = "baseMythrasButton";
            this.baseMythrasButton.Size = new System.Drawing.Size(268, 168);
            this.baseMythrasButton.TabIndex = 0;
            this.baseMythrasButton.Text = "Base Mythras";
            this.baseMythrasButton.UseVisualStyleBackColor = true;
            this.baseMythrasButton.Click += new System.EventHandler(this.baseMythrasButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.fillPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "System Select";
            this.fillPanel.ResumeLayout(false);
            this.fillLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel fillPanel;
        private System.Windows.Forms.FlowLayoutPanel fillLayoutPanel;
        private System.Windows.Forms.Button baseMythrasButton;
    }
}