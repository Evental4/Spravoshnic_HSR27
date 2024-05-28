namespace Spravoshnic_HSR
{
    partial class AddPersForm
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
            this.PicButton = new System.Windows.Forms.Button();
            this.PersPictureBox = new System.Windows.Forms.PictureBox();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.PythComboBox = new System.Windows.Forms.ComboBox();
            this.TipComboBox = new System.Windows.Forms.ComboBox();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.WebTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RancsTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SpidTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AtcTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DefTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HpTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sevebutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PersPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PicButton
            // 
            this.PicButton.Location = new System.Drawing.Point(674, 564);
            this.PicButton.Name = "PicButton";
            this.PicButton.Size = new System.Drawing.Size(122, 66);
            this.PicButton.TabIndex = 71;
            this.PicButton.Text = "Добавить картинку\r\n";
            this.PicButton.UseVisualStyleBackColor = true;
            this.PicButton.Click += new System.EventHandler(this.PicButton_Click);
            // 
            // PersPictureBox
            // 
            this.PersPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PersPictureBox.Location = new System.Drawing.Point(356, 421);
            this.PersPictureBox.Name = "PersPictureBox";
            this.PersPictureBox.Size = new System.Drawing.Size(288, 209);
            this.PersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PersPictureBox.TabIndex = 70;
            this.PersPictureBox.TabStop = false;
           
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(356, 29);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(440, 373);
            this.InfoTextBox.TabIndex = 69;
            // 
            // PythComboBox
            // 
            this.PythComboBox.FormattingEnabled = true;
            this.PythComboBox.Items.AddRange(new object[] {
            "",
            "Разрушение",
            "Гармония",
            "Изобилие",
            "Охота",
            "Эрудикция",
            "Небытие",
            "Сохранение"});
            this.PythComboBox.Location = new System.Drawing.Point(17, 208);
            this.PythComboBox.Name = "PythComboBox";
            this.PythComboBox.Size = new System.Drawing.Size(312, 32);
            this.PythComboBox.TabIndex = 68;
            // 
            // TipComboBox
            // 
            this.TipComboBox.FormattingEnabled = true;
            this.TipComboBox.Items.AddRange(new object[] {
            "",
            "Физический",
            "Леденой",
            "Ветреной",
            "Электрический",
            "Огненый",
            "Квантовый",
            "Мнимый"});
            this.TipComboBox.Location = new System.Drawing.Point(17, 147);
            this.TipComboBox.Name = "TipComboBox";
            this.TipComboBox.Size = new System.Drawing.Size(312, 32);
            this.TipComboBox.TabIndex = 67;
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            "",
            "DD",
            "SapDD",
            "SapDD or DD",
            "Sap",
            "Hiler",
            "Defens",
            "Debaffer"});
            this.RoleComboBox.Location = new System.Drawing.Point(16, 91);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(313, 32);
            this.RoleComboBox.TabIndex = 66;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(13, 184);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 24);
            this.label19.TabIndex = 65;
            this.label19.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(12, 244);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 24);
            this.label18.TabIndex = 64;
            this.label18.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(12, 305);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 24);
            this.label17.TabIndex = 63;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(12, 360);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 24);
            this.label16.TabIndex = 62;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(12, 421);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 24);
            this.label15.TabIndex = 61;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(12, 481);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 24);
            this.label14.TabIndex = 60;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(13, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 24);
            this.label13.TabIndex = 59;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(12, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 24);
            this.label12.TabIndex = 58;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(12, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 24);
            this.label11.TabIndex = 57;
            this.label11.Text = "*";
            // 
            // WebTextBox
            // 
            this.WebTextBox.Location = new System.Drawing.Point(17, 558);
            this.WebTextBox.Name = "WebTextBox";
            this.WebTextBox.Size = new System.Drawing.Size(312, 29);
            this.WebTextBox.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 533);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 24);
            this.label10.TabIndex = 55;
            this.label10.Text = "Web";
            // 
            // RancsTextBox
            // 
            this.RancsTextBox.Location = new System.Drawing.Point(17, 504);
            this.RancsTextBox.Name = "RancsTextBox";
            this.RancsTextBox.Size = new System.Drawing.Size(312, 29);
            this.RancsTextBox.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 53;
            this.label9.Text = "Rancs-pop";
            // 
            // SpidTextBox
            // 
            this.SpidTextBox.Location = new System.Drawing.Point(17, 444);
            this.SpidTextBox.Name = "SpidTextBox";
            this.SpidTextBox.Size = new System.Drawing.Size(312, 29);
            this.SpidTextBox.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 51;
            this.label7.Text = "Spid";
            // 
            // AtcTextBox
            // 
            this.AtcTextBox.Location = new System.Drawing.Point(17, 383);
            this.AtcTextBox.Name = "AtcTextBox";
            this.AtcTextBox.Size = new System.Drawing.Size(312, 29);
            this.AtcTextBox.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 24);
            this.label8.TabIndex = 49;
            this.label8.Text = "Atc";
            // 
            // DefTextBox
            // 
            this.DefTextBox.Location = new System.Drawing.Point(17, 328);
            this.DefTextBox.Name = "DefTextBox";
            this.DefTextBox.Size = new System.Drawing.Size(312, 29);
            this.DefTextBox.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Def";
            // 
            // HpTextBox
            // 
            this.HpTextBox.Location = new System.Drawing.Point(17, 267);
            this.HpTextBox.Name = "HpTextBox";
            this.HpTextBox.Size = new System.Drawing.Size(312, 29);
            this.HpTextBox.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Hp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Путь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Стихия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Роль в отряде";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(17, 29);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(312, 29);
            this.NameTextBox.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Имя";
            // 
            // Sevebutton
            // 
            this.Sevebutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Sevebutton.Location = new System.Drawing.Point(0, 677);
            this.Sevebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sevebutton.Name = "Sevebutton";
            this.Sevebutton.Size = new System.Drawing.Size(810, 54);
            this.Sevebutton.TabIndex = 39;
            this.Sevebutton.Text = "Сохранить";
            this.Sevebutton.UseVisualStyleBackColor = true;
            this.Sevebutton.Click += new System.EventHandler(this.Sevebutton_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddPersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 731);
            this.Controls.Add(this.PicButton);
            this.Controls.Add(this.PersPictureBox);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.PythComboBox);
            this.Controls.Add(this.TipComboBox);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.WebTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RancsTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SpidTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AtcTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DefTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HpTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sevebutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddPersForm";
            this.Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)(this.PersPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PicButton;
        private System.Windows.Forms.PictureBox PersPictureBox;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.ComboBox PythComboBox;
        private System.Windows.Forms.ComboBox TipComboBox;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox WebTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RancsTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SpidTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AtcTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DefTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HpTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sevebutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}