namespace mexoil
{
    partial class FormChooseFuelStation
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
            this.join_station1 = new System.Windows.Forms.Button();
            this.join_station2 = new System.Windows.Forms.Button();
            this.join_station3 = new System.Windows.Forms.Button();
            this.MyProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // join_station1
            // 
            this.join_station1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.join_station1.Location = new System.Drawing.Point(92, 104);
            this.join_station1.Name = "join_station1";
            this.join_station1.Size = new System.Drawing.Size(169, 222);
            this.join_station1.TabIndex = 0;
            this.join_station1.Text = "STATION 1";
            this.join_station1.UseVisualStyleBackColor = true;
            this.join_station1.Click += new System.EventHandler(this.join_station1_Click);
            // 
            // join_station2
            // 
            this.join_station2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.join_station2.Location = new System.Drawing.Point(319, 104);
            this.join_station2.Name = "join_station2";
            this.join_station2.Size = new System.Drawing.Size(169, 222);
            this.join_station2.TabIndex = 1;
            this.join_station2.Text = "STATION 2";
            this.join_station2.UseVisualStyleBackColor = true;
            this.join_station2.Click += new System.EventHandler(this.join_station2_Click);
            // 
            // join_station3
            // 
            this.join_station3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.join_station3.Location = new System.Drawing.Point(545, 104);
            this.join_station3.Name = "join_station3";
            this.join_station3.Size = new System.Drawing.Size(169, 222);
            this.join_station3.TabIndex = 2;
            this.join_station3.Text = "STATION 3";
            this.join_station3.UseVisualStyleBackColor = true;
            this.join_station3.Click += new System.EventHandler(this.join_station3_Click);
            // 
            // MyProfile
            // 
            this.MyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyProfile.Location = new System.Drawing.Point(663, 379);
            this.MyProfile.Name = "MyProfile";
            this.MyProfile.Size = new System.Drawing.Size(125, 59);
            this.MyProfile.TabIndex = 6;
            this.MyProfile.Text = "My Profile";
            this.MyProfile.UseVisualStyleBackColor = true;
            this.MyProfile.Click += new System.EventHandler(this.MyProfile_Click);
            // 
            // FormChooseFuelStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyProfile);
            this.Controls.Add(this.join_station3);
            this.Controls.Add(this.join_station2);
            this.Controls.Add(this.join_station1);
            this.Name = "FormChooseFuelStation";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button join_station1;
        private System.Windows.Forms.Button join_station2;
        private System.Windows.Forms.Button join_station3;
        private System.Windows.Forms.Button MyProfile;
    }
}