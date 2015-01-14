namespace EmployeeInformationSystem.UI
{
    partial class UpdateUI
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
            this.employeeGroupBox = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.designationComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeGroupBox
            // 
            this.employeeGroupBox.Controls.Add(this.idTextBox);
            this.employeeGroupBox.Controls.Add(this.label5);
            this.employeeGroupBox.Controls.Add(this.updateButton);
            this.employeeGroupBox.Controls.Add(this.designationComboBox);
            this.employeeGroupBox.Controls.Add(this.addressTextBox);
            this.employeeGroupBox.Controls.Add(this.emailTextBox);
            this.employeeGroupBox.Controls.Add(this.nameTextBox);
            this.employeeGroupBox.Controls.Add(this.label1);
            this.employeeGroupBox.Controls.Add(this.label4);
            this.employeeGroupBox.Controls.Add(this.label2);
            this.employeeGroupBox.Controls.Add(this.label3);
            this.employeeGroupBox.Location = new System.Drawing.Point(7, 25);
            this.employeeGroupBox.Name = "employeeGroupBox";
            this.employeeGroupBox.Size = new System.Drawing.Size(375, 272);
            this.employeeGroupBox.TabIndex = 3;
            this.employeeGroupBox.TabStop = false;
            this.employeeGroupBox.Text = "Employee Information";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(95, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Id";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(271, 201);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // designationComboBox
            // 
            this.designationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.designationComboBox.FormattingEnabled = true;
            this.designationComboBox.Location = new System.Drawing.Point(95, 201);
            this.designationComboBox.Name = "designationComboBox";
            this.designationComboBox.Size = new System.Drawing.Size(170, 21);
            this.designationComboBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(95, 124);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(251, 67);
            this.addressTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(95, 98);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(251, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(95, 72);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(251, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Designation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // UpdateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 309);
            this.Controls.Add(this.employeeGroupBox);
            this.Name = "UpdateUI";
            this.Text = "UpdateUI";
            this.employeeGroupBox.ResumeLayout(false);
            this.employeeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox employeeGroupBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox designationComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}