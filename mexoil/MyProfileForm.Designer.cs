namespace mexoil
{
    partial class MyProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBonusPoints = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ur_id_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProfileUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бонусы:";
            // 
            // textBoxBonusPoints
            // 
            this.textBoxBonusPoints.AutoSize = true;
            this.textBoxBonusPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBonusPoints.Location = new System.Drawing.Point(116, 176);
            this.textBoxBonusPoints.Name = "textBoxBonusPoints";
            this.textBoxBonusPoints.Size = new System.Drawing.Size(19, 25);
            this.textBoxBonusPoints.TabIndex = 1;
            this.textBoxBonusPoints.Text = "-";
            this.textBoxBonusPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ваш ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ur_id_label
            // 
            this.ur_id_label.AutoSize = true;
            this.ur_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ur_id_label.Location = new System.Drawing.Point(116, 223);
            this.ur_id_label.Name = "ur_id_label";
            this.ur_id_label.Size = new System.Drawing.Size(19, 25);
            this.ur_id_label.TabIndex = 3;
            this.ur_id_label.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mexoil.Properties.Resources.ProfilePicture;
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(183, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пользователь:";
            // 
            // ProfileUsername
            // 
            this.ProfileUsername.AutoSize = true;
            this.ProfileUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileUsername.Location = new System.Drawing.Point(336, 12);
            this.ProfileUsername.Name = "ProfileUsername";
            this.ProfileUsername.Size = new System.Drawing.Size(19, 25);
            this.ProfileUsername.TabIndex = 6;
            this.ProfileUsername.Text = "-";
            this.ProfileUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProfileUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ur_id_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBonusPoints);
            this.Controls.Add(this.label1);
            this.Name = "MyProfileForm";
            this.Text = "MyProfileForm";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MyProfileForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textBoxBonusPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ur_id_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProfileUsername;
    }
}