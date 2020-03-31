namespace WinFormSingleton
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxLog = new System.Windows.Forms.TextBox();
            this.txtBoxRole = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application State Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "LoginId :";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLog.Location = new System.Drawing.Point(136, 235);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(0, 20);
            this.lblLog.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(54, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "RoleId :";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRole.Location = new System.Drawing.Point(136, 279);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(0, 20);
            this.lblRole.TabIndex = 4;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblState.Location = new System.Drawing.Point(136, 310);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 20);
            this.lblState.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(54, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "RoleId :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(47, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "LogInId :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(62, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "State :";
            // 
            // txtBoxLog
            // 
            this.txtBoxLog.Location = new System.Drawing.Point(126, 89);
            this.txtBoxLog.Name = "txtBoxLog";
            this.txtBoxLog.Size = new System.Drawing.Size(134, 22);
            this.txtBoxLog.TabIndex = 9;
            // 
            // txtBoxRole
            // 
            this.txtBoxRole.Location = new System.Drawing.Point(126, 134);
            this.txtBoxRole.Name = "txtBoxRole";
            this.txtBoxRole.Size = new System.Drawing.Size(134, 22);
            this.txtBoxRole.TabIndex = 10;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.Info;
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheck.Location = new System.Drawing.Point(185, 177);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 31);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 345);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtBoxRole);
            this.Controls.Add(this.txtBoxLog);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxLog;
        private System.Windows.Forms.TextBox txtBoxRole;
        private System.Windows.Forms.Button btnCheck;
    }
}

