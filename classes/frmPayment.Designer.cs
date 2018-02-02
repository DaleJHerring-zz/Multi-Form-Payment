namespace Payment
{
    partial class frmPayment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.billRB = new System.Windows.Forms.RadioButton();
            this.creditRB = new System.Windows.Forms.RadioButton();
            this.ccListBox = new System.Windows.Forms.ListBox();
            this.ccTypeLabel = new System.Windows.Forms.Label();
            this.ccNumberLabel = new System.Windows.Forms.Label();
            this.ccNumberBox = new System.Windows.Forms.TextBox();
            this.expLabel = new System.Windows.Forms.Label();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.dbChkBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.billRB);
            this.groupBox1.Controls.Add(this.creditRB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing";
            // 
            // billRB
            // 
            this.billRB.AutoSize = true;
            this.billRB.Location = new System.Drawing.Point(191, 19);
            this.billRB.Name = "billRB";
            this.billRB.Size = new System.Drawing.Size(84, 17);
            this.billRB.TabIndex = 2;
            this.billRB.TabStop = true;
            this.billRB.Text = "Bill customer";
            this.billRB.UseVisualStyleBackColor = true;
            this.billRB.CheckedChanged += new System.EventHandler(this.Billing_CheckChanged);
            // 
            // creditRB
            // 
            this.creditRB.AutoSize = true;
            this.creditRB.Checked = true;
            this.creditRB.Location = new System.Drawing.Point(20, 20);
            this.creditRB.Name = "creditRB";
            this.creditRB.Size = new System.Drawing.Size(76, 17);
            this.creditRB.TabIndex = 1;
            this.creditRB.TabStop = true;
            this.creditRB.Text = "Credit card";
            this.creditRB.UseVisualStyleBackColor = true;
            this.creditRB.CheckedChanged += new System.EventHandler(this.Billing_CheckChanged);
            // 
            // ccListBox
            // 
            this.ccListBox.FormattingEnabled = true;
            this.ccListBox.Location = new System.Drawing.Point(121, 71);
            this.ccListBox.Name = "ccListBox";
            this.ccListBox.Size = new System.Drawing.Size(215, 69);
            this.ccListBox.TabIndex = 3;
            // 
            // ccTypeLabel
            // 
            this.ccTypeLabel.AutoSize = true;
            this.ccTypeLabel.Location = new System.Drawing.Point(12, 71);
            this.ccTypeLabel.Name = "ccTypeLabel";
            this.ccTypeLabel.Size = new System.Drawing.Size(81, 13);
            this.ccTypeLabel.TabIndex = 0;
            this.ccTypeLabel.Text = "Credit card type";
            // 
            // ccNumberLabel
            // 
            this.ccNumberLabel.AutoSize = true;
            this.ccNumberLabel.Location = new System.Drawing.Point(12, 152);
            this.ccNumberLabel.Name = "ccNumberLabel";
            this.ccNumberLabel.Size = new System.Drawing.Size(67, 13);
            this.ccNumberLabel.TabIndex = 0;
            this.ccNumberLabel.Text = "Card number";
            // 
            // ccNumberBox
            // 
            this.ccNumberBox.Location = new System.Drawing.Point(121, 152);
            this.ccNumberBox.Name = "ccNumberBox";
            this.ccNumberBox.Size = new System.Drawing.Size(215, 20);
            this.ccNumberBox.TabIndex = 4;
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.Location = new System.Drawing.Point(12, 186);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(80, 13);
            this.expLabel.TabIndex = 0;
            this.expLabel.Text = "Expiration date:";
            // 
            // monthBox
            // 
            this.monthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Location = new System.Drawing.Point(121, 178);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(100, 21);
            this.monthBox.TabIndex = 5;
            // 
            // yearBox
            // 
            this.yearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(236, 178);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(100, 21);
            this.yearBox.TabIndex = 6;
            // 
            // dbChkBox
            // 
            this.dbChkBox.AutoSize = true;
            this.dbChkBox.Checked = true;
            this.dbChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dbChkBox.Location = new System.Drawing.Point(15, 214);
            this.dbChkBox.Name = "dbChkBox";
            this.dbChkBox.Size = new System.Drawing.Size(158, 17);
            this.dbChkBox.TabIndex = 7;
            this.dbChkBox.Text = "Set as default billing method";
            this.dbChkBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(146, 240);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(85, 25);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(261, 240);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 25);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(354, 275);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dbChkBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.expLabel);
            this.Controls.Add(this.ccNumberBox);
            this.Controls.Add(this.ccNumberLabel);
            this.Controls.Add(this.ccTypeLabel);
            this.Controls.Add(this.ccListBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton billRB;
        private System.Windows.Forms.RadioButton creditRB;
        private System.Windows.Forms.ListBox ccListBox;
        private System.Windows.Forms.Label ccTypeLabel;
        private System.Windows.Forms.Label ccNumberLabel;
        private System.Windows.Forms.TextBox ccNumberBox;
        private System.Windows.Forms.Label expLabel;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.CheckBox dbChkBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}