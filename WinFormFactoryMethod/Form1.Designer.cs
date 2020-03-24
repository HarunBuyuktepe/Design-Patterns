namespace WinFormFactoryMethod
{
    partial class Form1
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.date_Birthday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_name_surname = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_card_type = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_credit_limit = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_annual_charge = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cbox_Cards = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(124, 52);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 22);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(124, 93);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(100, 22);
            this.txt_Surname.TabIndex = 2;
            // 
            // date_Birthday
            // 
            this.date_Birthday.Location = new System.Drawing.Point(124, 132);
            this.date_Birthday.Name = "date_Birthday";
            this.date_Birthday.Size = new System.Drawing.Size(200, 22);
            this.date_Birthday.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Birthday :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Card Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(23, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Your Account and Card Details : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name - Surname :";
            // 
            // lbl_name_surname
            // 
            this.lbl_name_surname.AutoSize = true;
            this.lbl_name_surname.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_name_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name_surname.ForeColor = System.Drawing.Color.Black;
            this.lbl_name_surname.Location = new System.Drawing.Point(185, 309);
            this.lbl_name_surname.Name = "lbl_name_surname";
            this.lbl_name_surname.Size = new System.Drawing.Size(0, 20);
            this.lbl_name_surname.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(72, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Card Type :";
            // 
            // lbl_card_type
            // 
            this.lbl_card_type.AutoSize = true;
            this.lbl_card_type.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_card_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_card_type.ForeColor = System.Drawing.Color.Black;
            this.lbl_card_type.Location = new System.Drawing.Point(185, 351);
            this.lbl_card_type.Name = "lbl_card_type";
            this.lbl_card_type.Size = new System.Drawing.Size(0, 20);
            this.lbl_card_type.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(62, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Credit Limit :";
            // 
            // lbl_credit_limit
            // 
            this.lbl_credit_limit.AutoSize = true;
            this.lbl_credit_limit.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_credit_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_credit_limit.ForeColor = System.Drawing.Color.Black;
            this.lbl_credit_limit.Location = new System.Drawing.Point(185, 391);
            this.lbl_credit_limit.Name = "lbl_credit_limit";
            this.lbl_credit_limit.Size = new System.Drawing.Size(0, 20);
            this.lbl_credit_limit.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(38, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Annual Charge :";
            // 
            // lbl_annual_charge
            // 
            this.lbl_annual_charge.AutoSize = true;
            this.lbl_annual_charge.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_annual_charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_annual_charge.ForeColor = System.Drawing.Color.Black;
            this.lbl_annual_charge.Location = new System.Drawing.Point(185, 429);
            this.lbl_annual_charge.Name = "lbl_annual_charge";
            this.lbl_annual_charge.Size = new System.Drawing.Size(0, 20);
            this.lbl_annual_charge.TabIndex = 15;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(124, 213);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(86, 28);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cbox_Cards
            // 
            this.cbox_Cards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Cards.ForeColor = System.Drawing.Color.Black;
            this.cbox_Cards.FormattingEnabled = true;
            this.cbox_Cards.Items.AddRange(new object[] {
            "MoneyBack",
            "Platinium",
            "Titanium"});
            this.cbox_Cards.Location = new System.Drawing.Point(124, 170);
            this.cbox_Cards.Name = "cbox_Cards";
            this.cbox_Cards.Size = new System.Drawing.Size(116, 24);
            this.cbox_Cards.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 463);
            this.Controls.Add(this.cbox_Cards);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_annual_charge);
            this.Controls.Add(this.lbl_credit_limit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_card_type);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_name_surname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_Birthday);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.txt_Name);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.DateTimePicker date_Birthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_name_surname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_card_type;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_credit_limit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_annual_charge;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cbox_Cards;
    }
}

