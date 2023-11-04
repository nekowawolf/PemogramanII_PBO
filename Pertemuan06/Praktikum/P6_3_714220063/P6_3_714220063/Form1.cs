using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714220063
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "");
                epWrong.SetError(txtHuruf, "Tidak Boleh Kosong");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul");
                }
                else
                {
                    epWarning.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "Tidak Boleh Kosong");
                epCorrect.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtAngka, "Betul");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                }
                else
                {
                    epWarning.SetError(txtAngka, "Inputan hanya boleh angka!");
                    epWrong.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "");
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "Tidak Boleh Kosong");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[a-zA-Z]{2,}$"))
                {
                    epCorrect.SetError(txtEmail, "Betul");
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                }
                else
                {
                    epWarning.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka1, "");
                epWrong.SetError(txtAngka1, "Tidak Boleh Kosong");
                epCorrect.SetError(txtAngka1, "");
            }
            if (txtAngka1.Text.All(char.IsNumber))
            {
                epWarning.SetError(txtAngka1, "");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }
            else
            {
                epWarning.SetError(txtAngka1, "Inputan hanya boleh angka!");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }
            if (int.TryParse(txtAngka1.Text, out int angka1) && int.TryParse(txtAngka2.Text, out int angka2))
            {
                if (angka1 > angka2)
                {
                    epCorrect.SetError(txtAngka1, "Betul");
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                }
                else if (angka1 <= angka2)
                {
                    epWarning.SetError(txtAngka1, "Angka 1 harus lebih besar dari Angka 2");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "");
                }
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "");
                epWrong.SetError(txtAngka2, "Tidak Boleh Kosong");
                epCorrect.SetError(txtAngka2, "");
            }
            if (txtAngka2.Text.All(char.IsNumber))
            {
                epWarning.SetError(txtAngka2, "");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
            else
            {
                epWarning.SetError(txtAngka2, "Inputan hanya boleh angka!");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
            if (int.TryParse(txtAngka1.Text, out int angka1) && int.TryParse(txtAngka2.Text, out int angka2))
            {
                if (angka1 > angka2)
                {
                    epCorrect.SetError(txtAngka2, "Betul");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "");
                }
                else if (angka1 <= angka2)
                {
                    epWarning.SetError(txtAngka2, "Angka 2 harus lebih kecil dari Angka 1");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "");
                }
            }
        }
    }
}
