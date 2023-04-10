
namespace BirthdayReminder
{
    partial class frmMain
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
            this.btnAddContact = new System.Windows.Forms.Button();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveContact = new System.Windows.Forms.Button();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnSortByDate = new System.Windows.Forms.Button();
            this.bnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(45, 409);
            this.btnAddContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(111, 84);
            this.btnAddContact.TabIndex = 3;
            this.btnAddContact.Text = "&Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(378, 93);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(256, 30);
            this.dtpBirthdate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the name of a contact:";
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.ItemHeight = 25;
            this.lstContacts.Location = new System.Drawing.Point(36, 145);
            this.lstContacts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(589, 254);
            this.lstContacts.TabIndex = 3;
            this.lstContacts.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(378, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 30);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the birthdate of a contact:";
            // 
            // btnRemoveContact
            // 
            this.btnRemoveContact.Location = new System.Drawing.Point(165, 409);
            this.btnRemoveContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveContact.Name = "btnRemoveContact";
            this.btnRemoveContact.Size = new System.Drawing.Size(111, 84);
            this.btnRemoveContact.TabIndex = 4;
            this.btnRemoveContact.Text = "&Remove Contact";
            this.btnRemoveContact.UseVisualStyleBackColor = true;
            this.btnRemoveContact.Click += new System.EventHandler(this.btnRemoveContact_Click);
            // 
            // btnSortByName
            // 
            this.btnSortByName.Location = new System.Drawing.Point(285, 409);
            this.btnSortByName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(111, 84);
            this.btnSortByName.TabIndex = 5;
            this.btnSortByName.Text = "Sort by &Name";
            this.btnSortByName.UseVisualStyleBackColor = true;
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // btnSortByDate
            // 
            this.btnSortByDate.Location = new System.Drawing.Point(405, 409);
            this.btnSortByDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortByDate.Name = "btnSortByDate";
            this.btnSortByDate.Size = new System.Drawing.Size(111, 84);
            this.btnSortByDate.TabIndex = 6;
            this.btnSortByDate.Text = "Sort by &Date";
            this.btnSortByDate.UseVisualStyleBackColor = true;
            this.btnSortByDate.Click += new System.EventHandler(this.btnSortByDate_Click);
            // 
            // bnQuit
            // 
            this.bnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnQuit.Location = new System.Drawing.Point(525, 409);
            this.bnQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnQuit.Name = "bnQuit";
            this.bnQuit.Size = new System.Drawing.Size(111, 84);
            this.bnQuit.TabIndex = 7;
            this.bnQuit.Text = "&Quit";
            this.bnQuit.UseVisualStyleBackColor = true;
            this.bnQuit.Click += new System.EventHandler(this.bnQuit_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAddContact;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnQuit;
            this.ClientSize = new System.Drawing.Size(677, 532);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstContacts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.bnQuit);
            this.Controls.Add(this.btnSortByDate);
            this.Controls.Add(this.btnSortByName);
            this.Controls.Add(this.btnRemoveContact);
            this.Controls.Add(this.btnAddContact);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birthday Reminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveContact;
        private System.Windows.Forms.Button btnSortByName;
        private System.Windows.Forms.Button btnSortByDate;
        private System.Windows.Forms.Button bnQuit;
    }
}

