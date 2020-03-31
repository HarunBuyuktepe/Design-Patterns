namespace WinFormAbstractFactory
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
            this.cmBoxPhoneBrand = new System.Windows.Forms.ComboBox();
            this.cmBoxPhoneModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.rTxtBox_Features = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmBoxPhoneBrand
            // 
            this.cmBoxPhoneBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxPhoneBrand.FormattingEnabled = true;
            this.cmBoxPhoneBrand.Items.AddRange(new object[] {
            "Nokia",
            "Samsung"});
            this.cmBoxPhoneBrand.Location = new System.Drawing.Point(232, 24);
            this.cmBoxPhoneBrand.Name = "cmBoxPhoneBrand";
            this.cmBoxPhoneBrand.Size = new System.Drawing.Size(121, 24);
            this.cmBoxPhoneBrand.TabIndex = 0;
            // 
            // cmBoxPhoneModel
            // 
            this.cmBoxPhoneModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxPhoneModel.FormattingEnabled = true;
            this.cmBoxPhoneModel.Items.AddRange(new object[] {
            "Normal",
            "Smart"});
            this.cmBoxPhoneModel.Location = new System.Drawing.Point(232, 78);
            this.cmBoxPhoneModel.Name = "cmBoxPhoneModel";
            this.cmBoxPhoneModel.Size = new System.Drawing.Size(121, 24);
            this.cmBoxPhoneModel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Mobile Phone Brand : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Mobile Phone Model : ";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(232, 122);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(121, 45);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show Mobile Phone Features";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // rTxtBox_Features
            // 
            this.rTxtBox_Features.Location = new System.Drawing.Point(152, 187);
            this.rTxtBox_Features.Name = "rTxtBox_Features";
            this.rTxtBox_Features.ReadOnly = true;
            this.rTxtBox_Features.Size = new System.Drawing.Size(201, 142);
            this.rTxtBox_Features.TabIndex = 5;
            this.rTxtBox_Features.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.rTxtBox_Features);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBoxPhoneModel);
            this.Controls.Add(this.cmBoxPhoneBrand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBoxPhoneBrand;
        private System.Windows.Forms.ComboBox cmBoxPhoneModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RichTextBox rTxtBox_Features;
    }
}

