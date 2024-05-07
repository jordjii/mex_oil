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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бонусы:";
            // 
            // textBoxBonusPoints
            // 
            this.textBoxBonusPoints.AutoSize = true;
            this.textBoxBonusPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBonusPoints.Location = new System.Drawing.Point(185, 53);
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
            this.label2.Location = new System.Drawing.Point(92, 100);
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
            this.ur_id_label.Location = new System.Drawing.Point(185, 100);
            this.ur_id_label.Name = "ur_id_label";
            this.ur_id_label.Size = new System.Drawing.Size(19, 25);
            this.ur_id_label.TabIndex = 3;
            this.ur_id_label.Text = "-";
            // 
            // MyProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ur_id_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBonusPoints);
            this.Controls.Add(this.label1);
            this.Name = "MyProfileForm";
            this.Text = "MyProfileForm";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MyProfileForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textBoxBonusPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ur_id_label;
    }
}