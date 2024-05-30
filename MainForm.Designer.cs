namespace Spravoshnic_HSR
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.rolecomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.tipcomboBox = new System.Windows.Forms.ComboBox();
            this.pytecomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrButton = new System.Windows.Forms.Button();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.FeedBackbutton = new System.Windows.Forms.Button();
            this.SelectFormBTN = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.AuthButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавлениеОбъектаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltrPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewPanel
            // 
            this.ViewPanel.AutoScroll = true;
            this.ViewPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(0, 185);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1031, 424);
            this.ViewPanel.TabIndex = 11;
            this.ViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPanel_Paint);
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.BackColor = System.Drawing.Color.Black;
            this.FiltrPanel.Controls.Add(this.rolecomboBox);
            this.FiltrPanel.Controls.Add(this.label4);
            this.FiltrPanel.Controls.Add(this.FindButton);
            this.FiltrPanel.Controls.Add(this.tipcomboBox);
            this.FiltrPanel.Controls.Add(this.pytecomboBox);
            this.FiltrPanel.Controls.Add(this.label2);
            this.FiltrPanel.Controls.Add(this.label1);
            this.FiltrPanel.Controls.Add(this.FiltrButton);
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 55);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(1031, 130);
            this.FiltrPanel.TabIndex = 13;
            // 
            // rolecomboBox
            // 
            this.rolecomboBox.FormattingEnabled = true;
            this.rolecomboBox.Items.AddRange(new object[] {
            "",
            "DD",
            "SapDD",
            "SapDD or DD",
            "Sap",
            "Hiler",
            "Defens",
            "Debaffer"});
            this.rolecomboBox.Location = new System.Drawing.Point(161, 63);
            this.rolecomboBox.Name = "rolecomboBox";
            this.rolecomboBox.Size = new System.Drawing.Size(156, 32);
            this.rolecomboBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(589, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Стихия";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(919, 44);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(100, 46);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // tipcomboBox
            // 
            this.tipcomboBox.FormattingEnabled = true;
            this.tipcomboBox.Items.AddRange(new object[] {
            "",
            "Физический",
            "Леденой",
            "Ветреной",
            "Электрический",
            "Огненый",
            "Квантовый",
            "Мнимый"});
            this.tipcomboBox.Location = new System.Drawing.Point(687, 63);
            this.tipcomboBox.Name = "tipcomboBox";
            this.tipcomboBox.Size = new System.Drawing.Size(156, 32);
            this.tipcomboBox.TabIndex = 6;
            // 
            // pytecomboBox
            // 
            this.pytecomboBox.FormattingEnabled = true;
            this.pytecomboBox.Items.AddRange(new object[] {
            "",
            "Разрушение",
            "Гармония",
            "Изобилие",
            "Охота",
            "Эрудикция",
            "Небытие",
            "Сохранение"});
            this.pytecomboBox.Location = new System.Drawing.Point(402, 63);
            this.pytecomboBox.Name = "pytecomboBox";
            this.pytecomboBox.Size = new System.Drawing.Size(156, 32);
            this.pytecomboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(337, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(8, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Роль в отряде";
            // 
            // FiltrButton
            // 
            this.FiltrButton.Location = new System.Drawing.Point(3, 6);
            this.FiltrButton.Name = "FiltrButton";
            this.FiltrButton.Size = new System.Drawing.Size(125, 33);
            this.FiltrButton.TabIndex = 0;
            this.FiltrButton.Text = "Фильтр";
            this.FiltrButton.UseVisualStyleBackColor = true;
            this.FiltrButton.Click += new System.EventHandler(this.FiltrButton_Click);
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.Color.MediumBlue;
            this.UserPanel.Controls.Add(this.FeedBackbutton);
            this.UserPanel.Controls.Add(this.SelectFormBTN);
            this.UserPanel.Controls.Add(this.HelpButton);
            this.UserPanel.Controls.Add(this.RegButton);
            this.UserPanel.Controls.Add(this.HelloLabel);
            this.UserPanel.Controls.Add(this.AuthButton);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UserPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(1031, 55);
            this.UserPanel.TabIndex = 12;
            // 
            // FeedBackbutton
            // 
            this.FeedBackbutton.Location = new System.Drawing.Point(920, 10);
            this.FeedBackbutton.Name = "FeedBackbutton";
            this.FeedBackbutton.Size = new System.Drawing.Size(100, 37);
            this.FeedBackbutton.TabIndex = 5;
            this.FeedBackbutton.Text = "Тех.Под";
            this.FeedBackbutton.UseVisualStyleBackColor = true;
            this.FeedBackbutton.Click += new System.EventHandler(this.FeedBackbutton_Click_1);
            // 
            // SelectFormBTN
            // 
            this.SelectFormBTN.Location = new System.Drawing.Point(715, 10);
            this.SelectFormBTN.Name = "SelectFormBTN";
            this.SelectFormBTN.Size = new System.Drawing.Size(156, 37);
            this.SelectFormBTN.TabIndex = 4;
            this.SelectFormBTN.Text = "Избранное";
            this.SelectFormBTN.UseVisualStyleBackColor = true;
            this.SelectFormBTN.Click += new System.EventHandler(this.SelectFormBTN_Click_1);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(877, 10);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(40, 37);
            this.HelpButton.TabIndex = 3;
            this.HelpButton.Text = "?\r\n";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click_1);
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(553, 10);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(156, 37);
            this.RegButton.TabIndex = 2;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click_1);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLabel.Location = new System.Drawing.Point(170, 18);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(97, 20);
            this.HelloLabel.TabIndex = 1;
            this.HelloLabel.Text = "label_Neim";
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(3, 10);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(136, 37);
            this.AuthButton.TabIndex = 0;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеОбъектаToolStripMenuItem,
            this.удалениеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 70);
            // 
            // добавлениеОбъектаToolStripMenuItem
            // 
            this.добавлениеОбъектаToolStripMenuItem.Name = "добавлениеОбъектаToolStripMenuItem";
            this.добавлениеОбъектаToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.добавлениеОбъектаToolStripMenuItem.Text = "Добавить персонажа";
            this.добавлениеОбъектаToolStripMenuItem.Click += new System.EventHandler(this.добавлениеОбъектаToolStripMenuItem_Click_1);
            // 
            // удалениеToolStripMenuItem
            // 
            this.удалениеToolStripMenuItem.Name = "удалениеToolStripMenuItem";
            this.удалениеToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.удалениеToolStripMenuItem.Text = "Удаление персонажа";
            this.удалениеToolStripMenuItem.Click += new System.EventHandler(this.удалениеToolStripMenuItem_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1031, 609);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.FiltrPanel);
            this.Controls.Add(this.UserPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Panel FiltrPanel;
        private System.Windows.Forms.ComboBox rolecomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ComboBox tipcomboBox;
        private System.Windows.Forms.ComboBox pytecomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FiltrButton;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Button FeedBackbutton;
        private System.Windows.Forms.Button SelectFormBTN;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавлениеОбъектаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеToolStripMenuItem;
    }
}