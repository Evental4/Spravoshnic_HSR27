namespace Spravoshnic_HSR
{
    partial class SelectForm
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
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.SengButton = new System.Windows.Forms.Button();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.InfoPanel.Controls.Add(this.SengButton);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(984, 59);
            this.InfoPanel.TabIndex = 1;
            // 
            // SengButton
            // 
            this.SengButton.Location = new System.Drawing.Point(385, 12);
            this.SengButton.Name = "SengButton";
            this.SengButton.Size = new System.Drawing.Size(206, 31);
            this.SengButton.TabIndex = 0;
            this.SengButton.Text = "Отправить на Email";
            this.SengButton.UseVisualStyleBackColor = true;
            this.SengButton.Click += new System.EventHandler(this.SengButton_Click_1);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(984, 831);
            this.Controls.Add(this.InfoPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SelectForm";
          
            this.InfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button SengButton;
    }
}