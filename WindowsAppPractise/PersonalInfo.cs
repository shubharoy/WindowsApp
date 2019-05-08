using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppPractise
{
    public partial class PersonalInfo : Form
    {
        public PersonalInfo()
        {
            InitializeComponent();
        }

        private void saveShowBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string phoneNo = phoneNoTextBox.Text;
            string emailAddress = emailTextBox.Text;
            string address = addressTextBox.Text;
            string nationality = nationalityComboBox.SelectedItem.ToString();
            string gendar = "";
            if (maleRadioBtn.Checked)
            {
                gendar = maleRadioBtn.Text;
            }
            else
            {
                gendar = femaleRadioBtn.Text;
            }
            
            //Show Information Panel
            nameShowTextBox.Text = firstName + " " + lastName;
            phoneNoShowTextBox.Text = phoneNo;
            emailShowTextBox.Text = emailAddress;
            addressShowTextBox.Text = address;
            natinalityShowTextBox.Text = nationality;
            gendarShowTextBox.Text = gendar;

            //Clear Text Box
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            phoneNoTextBox.Clear();
            emailTextBox.Clear();
            addressTextBox.Clear();
            maleRadioBtn.Checked = false;
            femaleRadioBtn.Checked = false;
            nationalityComboBox.SelectedItem = null;
        }

        private void secondActivityBtn_Click(object sender, EventArgs e)
        {
            SecondActivity secondForm = new SecondActivity();
            this.Hide();
            secondForm.ShowDialog();
            this.Close();

        }

      
    }
}
