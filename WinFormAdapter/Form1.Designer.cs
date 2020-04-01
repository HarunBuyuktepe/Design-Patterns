namespace WinFormAdapter
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
            this.btnShow = new System.Windows.Forms.Button();
            this.cmBoxCompound = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rTextDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(147, 83);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(63, 21);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cmBoxCompound
            // 
            this.cmBoxCompound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxCompound.FormattingEnabled = true;
            this.cmBoxCompound.Items.AddRange(new object[] {
            "Unknown",
            "Water",
            "Benzene",
            "Ethanol"});
            this.cmBoxCompound.Location = new System.Drawing.Point(132, 32);
            this.cmBoxCompound.Name = "cmBoxCompound";
            this.cmBoxCompound.Size = new System.Drawing.Size(99, 21);
            this.cmBoxCompound.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Compound : ";
            // 
            // rTextDisplay
            // 
            this.rTextDisplay.Location = new System.Drawing.Point(29, 132);
            this.rTextDisplay.Name = "rTextDisplay";
            this.rTextDisplay.ReadOnly = true;
            this.rTextDisplay.Size = new System.Drawing.Size(202, 153);
            this.rTextDisplay.TabIndex = 3;
            this.rTextDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 329);
            this.Controls.Add(this.rTextDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBoxCompound);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cmBoxCompound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rTextDisplay;
    }
}

