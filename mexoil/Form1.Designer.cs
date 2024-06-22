namespace mexoil
{
    partial class Form1
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
            this.button3 = new System.Windows.Forms.Button();
            this.sign_in_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextUsername = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.admin_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(274, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 62);
            this.button3.TabIndex = 0;
            this.button3.Text = "Sign Up";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sign_in_button
            // 
            this.sign_in_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign_in_button.Location = new System.Drawing.Point(583, 358);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Size = new System.Drawing.Size(204, 62);
            this.sign_in_button.TabIndex = 1;
            this.sign_in_button.Text = "Sign In";
            this.sign_in_button.UseVisualStyleBackColor = true;
            this.sign_in_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(268, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "USERNAME";
            // 
            // TextUsername
            // 
            this.TextUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextUsername.Location = new System.Drawing.Point(274, 154);
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.Size = new System.Drawing.Size(253, 35);
            this.TextUsername.TabIndex = 2;
            // 
            // TextPassword
            // 
            this.TextPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextPassword.Location = new System.Drawing.Point(274, 259);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(253, 35);
            this.TextPassword.TabIndex = 4;
            this.TextPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(268, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "PASSWORD";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // admin_button
            // 
            this.admin_button.Location = new System.Drawing.Point(969, 517);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(125, 59);
            this.admin_button.TabIndex = 5;
            this.admin_button.Text = "База данных";
            this.admin_button.UseVisualStyleBackColor = true;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mexoil.Properties.Resources.logo_mexoil;
            this.pictureBox1.Location = new System.Drawing.Point(969, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1106, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.admin_button);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sign_in_button);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button sign_in_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextUsername;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

