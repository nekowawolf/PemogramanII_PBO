using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714220063
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbNama_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNama.Text))
            {
                epWarning.SetError(tbNama, "");
                epWrong.SetError(tbNama, "Can't be Empty");
                epCorrect.SetError(tbNama, "");
            }
            else if (tbNama.Text.All(c => Char.IsUpper(c) || c == ' '))
            {
                epWarning.SetError(tbNama, "");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "Correct");
            }
            else
            {
                epWarning.SetError(tbNama, "Inputs can only be uppercase letters!");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "");
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                epWarning.SetError(tbEmail, "");
                epWrong.SetError(tbEmail, "Can't be Empty");
                epCorrect.SetError(tbEmail, "");
            }
            else if (tbEmail.Text.All(c => Char.IsLower(c) || Char.IsDigit(c) || c == '@' || c == '.' || c == '_') && Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(tbEmail, "");
                epWrong.SetError(tbEmail, "");
                epCorrect.SetError(tbEmail, "Corrcet");
            }
            else
            {
                epWarning.SetError(tbEmail, "Wrong email format must be lowercase!\nExample: a@b.c");
                epWrong.SetError(tbEmail, "");
                epCorrect.SetError(tbEmail, "");
            }
        }

        private void tb_umur_Leave(object sender, EventArgs e)
        {
            if (tb_umur.Text == "")
            {
                epWarning.SetError(tb_umur, "");
                epWrong.SetError(tb_umur, "Can't be Empty");
                epCorrect.SetError(tb_umur, "");
            }
            else if (tb_umur.Text.Length != 2 || !tb_umur.Text.All(Char.IsDigit))
            {
                epWarning.SetError(tb_umur, "Input only 2-digit numbers");
                epWrong.SetError(tb_umur, "");
                epCorrect.SetError(tb_umur, "");
            }
            else
            {
                epWarning.SetError(tb_umur, "");
                epWrong.SetError(tb_umur, "");
                epCorrect.SetError(tb_umur, "Corrcet");
            }
        }

        private void cb_gender_Leave(object sender, EventArgs e)
        {
            if (cb_gender.Text == "")
            {
                epWarning.SetError(cb_gender, "");
                epWrong.SetError(cb_gender, "Can't be Empty");
                epCorrect.SetError(cb_gender, "");
            }
            else if (cb_gender.SelectedIndex != -1)
            {
                epWarning.SetError(cb_gender, "");
                epWrong.SetError(cb_gender, "");
                epCorrect.SetError(cb_gender, "Corrcet");
            }
            else
            {
                epWarning.SetError(cb_gender, "Choose your gender!");
                epWrong.SetError(cb_gender, "");
                epCorrect.SetError(cb_gender, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNama.Text) || !tbNama.Text.All(c => Char.IsUpper(c) || c == ' '))
            {
                MessageBox.Show("The name must be filled in and can only contain uppercase letters and spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cb_gender.Text) || cb_gender.SelectedIndex == -1)
            {
                MessageBox.Show("Gender must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbEmail.Text) || !Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                MessageBox.Show("Emails must be filled in the correct format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_umur.Text) || tb_umur.Text.Length != 2 || !tb_umur.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Age must be filled in with a 2-digit number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "PDF Files|*.pdf|Word Documents|*.doc;*.docx|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string output = $"Name: {tbNama.Text}\nGender: {cb_gender.SelectedItem}\nEmail: {tbEmail.Text}\nAge: {tb_umur.Text} Year\n\nSuccessfully Registered!, wait for further info from email :)";
                MessageBox.Show(output, "Successfully Registered!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a CV file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "All Files|*.*"; 

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string selectedFilePath = openFileDialog.FileName;
                
            }
        }
    }
}
