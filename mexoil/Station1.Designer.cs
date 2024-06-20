namespace mexoil
{
    partial class Station1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.admin_button = new System.Windows.Forms.Button();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PayViaBonusCard = new System.Windows.Forms.Button();
            this.MyProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Column 1",
            "Column 2",
            "Column 3"});
            this.comboBox1.Location = new System.Drawing.Point(303, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(193, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Choose Column";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "92",
            "95",
            "98",
            "Diesel"});
            this.comboBox2.Location = new System.Drawing.Point(303, 149);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox2.Size = new System.Drawing.Size(193, 33);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Choose Fuel";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(303, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 31);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(363, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liters";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PayButton
            // 
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayButton.Location = new System.Drawing.Point(335, 284);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(133, 50);
            this.PayButton.TabIndex = 4;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // admin_button
            // 
            this.admin_button.Location = new System.Drawing.Point(663, 379);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(125, 59);
            this.admin_button.TabIndex = 6;
            this.admin_button.Text = "База данных";
            this.admin_button.UseVisualStyleBackColor = true;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalAmountTextBox.Location = new System.Drawing.Point(29, 390);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(193, 31);
            this.totalAmountTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PayViaBonusCard
            // 
            this.PayViaBonusCard.Location = new System.Drawing.Point(324, 340);
            this.PayViaBonusCard.Name = "PayViaBonusCard";
            this.PayViaBonusCard.Size = new System.Drawing.Size(155, 55);
            this.PayViaBonusCard.TabIndex = 9;
            this.PayViaBonusCard.Text = "Pay Via Bonus Card";
            this.PayViaBonusCard.UseVisualStyleBackColor = true;
            this.PayViaBonusCard.Click += new System.EventHandler(this.PayViaBonusCard_Click);
            // 
            // MyProfile
            // 
            this.MyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyProfile.Location = new System.Drawing.Point(663, 314);
            this.MyProfile.Name = "MyProfile";
            this.MyProfile.Size = new System.Drawing.Size(125, 59);
            this.MyProfile.TabIndex = 10;
            this.MyProfile.Text = "My Profile";
            this.MyProfile.UseVisualStyleBackColor = true;
            this.MyProfile.Click += new System.EventHandler(this.MyProfile_Click);
            // 
            // Station1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyProfile);
            this.Controls.Add(this.PayViaBonusCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.admin_button);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Station1";
            this.Text = "Station1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PayViaBonusCard;
        private System.Windows.Forms.Button MyProfile;
    }
}