namespace Spravoshnic_HSR
{
    partial class CenterForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Enterbutton = new System.Windows.Forms.Button();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Enterbutton
            // 
            this.Enterbutton.Location = new System.Drawing.Point(593, 315);
            this.Enterbutton.Name = "Enterbutton";
            this.Enterbutton.Size = new System.Drawing.Size(108, 40);
            this.Enterbutton.TabIndex = 0;
            this.Enterbutton.Text = "Зайти\r\n";
            this.Enterbutton.UseVisualStyleBackColor = true;
            this.Enterbutton.Click += new System.EventHandler(this.Enterbutton_Click);
            // 
            // Helpbutton
            // 
            this.Helpbutton.Location = new System.Drawing.Point(593, 361);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(108, 44);
            this.Helpbutton.TabIndex = 1;
            this.Helpbutton.Text = "Справка";
            this.Helpbutton.UseVisualStyleBackColor = true;
            this.Helpbutton.Click += new System.EventHandler(this.Helpbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(593, 411);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(108, 40);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.Text = "Выход";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Enterbutton);
            this.groupBox1.Controls.Add(this.Exitbutton);
            this.groupBox1.Controls.Add(this.Helpbutton);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 457);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Савочник по Honkai Star Reil";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(0, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(713, 429);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            // 
            // CenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 460);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CenterForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Enterbutton;
        private System.Windows.Forms.Button Helpbutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

