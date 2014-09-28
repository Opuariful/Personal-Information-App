using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string firstName = "";
        string lastName = "";
        string fathersName = "";
        string mothersName = "";
        string address = "";

        

        private void saveButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fathersName = fathersNameTextBox.Text;
            mothersName = mothersNameTextBox.Text;
            address = addressTextBox.Text;


            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            fathersNameTextBox.Text = "";
            mothersNameTextBox.Text = "";
            addressTextBox.Text = "";


        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FirstName:" + firstName + "\n LastName:" + lastName);
        }

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FirstName:" + firstName + "\n LastName:" + lastName + "\n father's Name :" + fathersName + "\n Mother's Name :" + mothersName + "\n Address :" + address);
        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("father's Name :" + fathersName + "\n Mother's Name :" + mothersName + "\n Address :" + address);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address :" + address);
        }
    }
}
