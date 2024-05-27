namespace Spravoshnic_HSR
{
    partial class RegForm
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
            this.RePassTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FamilyTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RePassTB
            // 
            this.RePassTB.Location = new System.Drawing.Point(12, 351);
            this.RePassTB.Name = "RePassTB";
            this.RePassTB.PasswordChar = '*';
            this.RePassTB.Size = new System.Drawing.Size(298, 29);
            this.RePassTB.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Подтверждение пароля";
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(12, 269);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(298, 29);
            this.PassTB.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Пароль";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(12, 189);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(298, 29);
            this.LoginTB.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Логин";
            // 
            // FamilyTB
            // 
            this.FamilyTB.Location = new System.Drawing.Point(12, 117);
            this.FamilyTB.Name = "FamilyTB";
            this.FamilyTB.Size = new System.Drawing.Size(298, 29);
            this.FamilyTB.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Фамилия";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(12, 48);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(298, 29);
            this.NameTB.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Имя";
            // 
            // RegButton
            // 
            this.RegButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RegButton.Location = new System.Drawing.Point(0, 409);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(330, 42);
            this.RegButton.TabIndex = 11;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click_1);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 451);
            this.Controls.Add(this.RePassTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FamilyTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RegForm";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RePassTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FamilyTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegButton;
    }
}