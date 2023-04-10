using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayReminder
{
    public partial class frmMain : Form
    {

        private List<Contact> contacts = new List<Contact>();

        private const string FILE_NAME = "Contacts.txt";
        public frmMain()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");
            loadContacts();
            displayContacts();
        }

        /// <summary>
        /// Add Contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "") {
                MessageBox.Show("Enter a correct name!", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtName.Text = "";
                txtName.Focus();
                return;
            }

            contacts.Add(new Contact(txtName.Text,dtpBirthdate.Value));
            displayContacts();
            saveContacts();

            dtpBirthdate.Value = DateTime.Now;
            txtName.Text = "";
            txtName.Focus();
        }
        /// <summary>
        /// Remove Contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveContact_Click(object sender, EventArgs e)
        {
            if (lstContacts.SelectedIndex == -1)
            {
                MessageBox.Show("Select one contact in the list!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lstContacts.Items.Remove(lstContacts.SelectedIndex);
            contacts.RemoveAt(lstContacts.SelectedIndex);
            displayContacts();
            saveContacts();
        }
        /// <summary>
        /// Sort by Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortByName_Click(object sender, EventArgs e)
        {
            contacts=contacts.OrderBy(contact => contact.Name).ToList();
            displayContacts();
        }
        /// <summary>
        /// Sort by Date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            contacts = contacts.OrderBy(contact => contact.Birthdate).ToList();
            displayContacts();
        }
        /// <summary>
        /// Quit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Display contacts
        /// </summary>
        private void displayContacts()
        {
            lstContacts.Items.Clear();
            for (int i = 0; i < contacts.Count; i++)
            {
                lstContacts.Items.Add(contacts[i].Name + "     " + contacts[i].Birthdate.ToShortDateString());
            }
        }
        /// <summary>
        /// Save contacts
        /// </summary>
        private void saveContacts() {
            using (StreamWriter streamWriter = new StreamWriter(FILE_NAME))
            {
                for (int i = 0; i < contacts.Count; i++) {
                    streamWriter.WriteLine(contacts[i].Name + "|" + contacts[i].Birthdate.ToShortDateString());
                }
            }
        }
        /// <summary>
        /// Load contacts
        /// </summary>
        private void loadContacts()
        {
            if (File.Exists(FILE_NAME)) {
                foreach (string line in System.IO.File.ReadLines(FILE_NAME))
                {
                    string[] values = line.Split('|');
                    contacts.Add(new Contact(values[0], DateTime.Parse(values[1])));
                }
            }
        }
    }
}
