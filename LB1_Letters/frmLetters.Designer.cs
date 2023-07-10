namespace LB1_Letters
{
    partial class frmLetters
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
            this.gbLetterInfo = new System.Windows.Forms.GroupBox();
            this.gbLetterHistory = new System.Windows.Forms.GroupBox();
            this.txtLetterHistory = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.lblSentDate = new System.Windows.Forms.Label();
            this.lblTrackingNumber = new System.Windows.Forms.Label();
            this.lblAdditionalFee = new System.Windows.Forms.Label();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.txtSentDate = new System.Windows.Forms.TextBox();
            this.txtTrackingNumber = new System.Windows.Forms.TextBox();
            this.gbLetterInfo.SuspendLayout();
            this.gbLetterHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLetterInfo
            // 
            this.gbLetterInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbLetterInfo.Controls.Add(this.txtTrackingNumber);
            this.gbLetterInfo.Controls.Add(this.txtSentDate);
            this.gbLetterInfo.Controls.Add(this.txtRecipient);
            this.gbLetterInfo.Controls.Add(this.lblAdditionalFee);
            this.gbLetterInfo.Controls.Add(this.lblTrackingNumber);
            this.gbLetterInfo.Controls.Add(this.lblSentDate);
            this.gbLetterInfo.Controls.Add(this.lblRecipient);
            this.gbLetterInfo.Controls.Add(this.btnExit);
            this.gbLetterInfo.Controls.Add(this.btnClear);
            this.gbLetterInfo.Controls.Add(this.btnSend);
            this.gbLetterInfo.Location = new System.Drawing.Point(27, 26);
            this.gbLetterInfo.Name = "gbLetterInfo";
            this.gbLetterInfo.Size = new System.Drawing.Size(576, 562);
            this.gbLetterInfo.TabIndex = 0;
            this.gbLetterInfo.TabStop = false;
            // 
            // gbLetterHistory
            // 
            this.gbLetterHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbLetterHistory.Controls.Add(this.txtLetterHistory);
            this.gbLetterHistory.Location = new System.Drawing.Point(618, 26);
            this.gbLetterHistory.Name = "gbLetterHistory";
            this.gbLetterHistory.Size = new System.Drawing.Size(576, 562);
            this.gbLetterHistory.TabIndex = 1;
            this.gbLetterHistory.TabStop = false;
            // 
            // txtLetterHistory
            // 
            this.txtLetterHistory.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetterHistory.Location = new System.Drawing.Point(6, 19);
            this.txtLetterHistory.Multiline = true;
            this.txtLetterHistory.Name = "txtLetterHistory";
            this.txtLetterHistory.Size = new System.Drawing.Size(564, 537);
            this.txtLetterHistory.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(36, 450);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(133, 51);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(224, 450);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 51);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(409, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 51);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblRecipient
            // 
            this.lblRecipient.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.lblRecipient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRecipient.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipient.Location = new System.Drawing.Point(33, 51);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(222, 41);
            this.lblRecipient.TabIndex = 6;
            this.lblRecipient.Text = "Recipient:";
            this.lblRecipient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSentDate
            // 
            this.lblSentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSentDate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentDate.Location = new System.Drawing.Point(33, 135);
            this.lblSentDate.Name = "lblSentDate";
            this.lblSentDate.Size = new System.Drawing.Size(222, 41);
            this.lblSentDate.TabIndex = 7;
            this.lblSentDate.Text = "Sent Date:";
            this.lblSentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrackingNumber
            // 
            this.lblTrackingNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTrackingNumber.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackingNumber.Location = new System.Drawing.Point(33, 229);
            this.lblTrackingNumber.Name = "lblTrackingNumber";
            this.lblTrackingNumber.Size = new System.Drawing.Size(222, 41);
            this.lblTrackingNumber.TabIndex = 8;
            this.lblTrackingNumber.Text = "Tracking Number:";
            this.lblTrackingNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdditionalFee
            // 
            this.lblAdditionalFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAdditionalFee.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalFee.Location = new System.Drawing.Point(33, 352);
            this.lblAdditionalFee.Name = "lblAdditionalFee";
            this.lblAdditionalFee.Size = new System.Drawing.Size(509, 41);
            this.lblAdditionalFee.TabIndex = 9;
            this.lblAdditionalFee.Text = "(Additional Fee For Ceterified Letter)";
            this.lblAdditionalFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecipient
            // 
            this.txtRecipient.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipient.Location = new System.Drawing.Point(261, 51);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(281, 38);
            this.txtRecipient.TabIndex = 0;
            this.txtRecipient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSentDate
            // 
            this.txtSentDate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSentDate.Location = new System.Drawing.Point(261, 138);
            this.txtSentDate.Name = "txtSentDate";
            this.txtSentDate.Size = new System.Drawing.Size(281, 38);
            this.txtSentDate.TabIndex = 1;
            this.txtSentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTrackingNumber
            // 
            this.txtTrackingNumber.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackingNumber.Location = new System.Drawing.Point(261, 226);
            this.txtTrackingNumber.Name = "txtTrackingNumber";
            this.txtTrackingNumber.Size = new System.Drawing.Size(281, 38);
            this.txtTrackingNumber.TabIndex = 2;
            this.txtTrackingNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmLetters
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1236, 620);
            this.Controls.Add(this.gbLetterHistory);
            this.Controls.Add(this.gbLetterInfo);
            this.Name = "frmLetters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWD1100 - Chapters 14 - 16 Letters App";
            this.Load += new System.EventHandler(this.frmLetters_Load);
            this.gbLetterInfo.ResumeLayout(false);
            this.gbLetterInfo.PerformLayout();
            this.gbLetterHistory.ResumeLayout(false);
            this.gbLetterHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLetterInfo;
        private System.Windows.Forms.TextBox txtTrackingNumber;
        private System.Windows.Forms.TextBox txtSentDate;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.Label lblAdditionalFee;
        private System.Windows.Forms.Label lblTrackingNumber;
        private System.Windows.Forms.Label lblSentDate;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbLetterHistory;
        private System.Windows.Forms.TextBox txtLetterHistory;
    }
}

