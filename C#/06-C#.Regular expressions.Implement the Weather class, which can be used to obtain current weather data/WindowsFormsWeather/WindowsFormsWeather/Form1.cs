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

namespace RegexDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ok = "OK";
        string error = "Помилка";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPhone_Click(object sender, EventArgs e)
        {
            Regex regPhone = new Regex(@"\+380\d\d\d\d\d\d\d\d\d");
            Match phoneMatch = regPhone.Match(textBoxPhone.Text);
            if (phoneMatch.Success)
            {
                labelPhone.ForeColor = Color.Green;
                labelPhone.Text = ok;
            }
            else
            {
                labelPhone.ForeColor = Color.Red;
                labelPhone.Text = error;
            }
        }

        private void buttonPassport_Click(object sender, EventArgs e)
        {
            Regex regPassport = new Regex(@"(?:А[АВТЕКМОНСЮ]|В[АВЕНСТО]|Е[СКМНАВОР]|С[ЕСАВЮРКМТИНО]|К[АВСЕКМНСР]|М[ЕЮСКАНО]|Н[АЕСК]|ТТ) \d{6}");;
            Match passMatch = regPassport.Match(textBoxPassport.Text);
            if (passMatch.Success)
            {
                labelPassport.ForeColor = Color.Green;
                labelPassport.Text = ok;
            }
            else
            {
                labelPassport.ForeColor = Color.Red;
                labelPassport.Text = error;
            }
        }


        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Regex regNum = new Regex(@"([1-8][0-9][3-6][1-4][1-5])");
            Match numMatch = regNum.Match(textBoxNumber.Text);
            if (numMatch.Success)
            {
                labelNum.ForeColor = Color.Green;
                labelNum.Text = ok;
            }
            else
            {
                labelNum.ForeColor = Color.Red;
                labelNum.Text = error;
            }

        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            Regex regName = new Regex(@"([А-ЯІҐЄ]{1}[а-яіґє]{1,30})");
            Match nameMatch = regName.Match(textBoxName.Text);
            if (nameMatch.Success)
            {
                labelName.ForeColor = Color.Green;
                labelName.Text = ok;
            }
            else
            {
                labelName.ForeColor = Color.Red;
                labelName.Text = error;
            }
        }

        private void buttonTime_Click(object sender, EventArgs e)
        {
            Regex regTime = new Regex(@"(?:1[0-9]|2[0-3]|0[0-9]):[0-5][0-9]");
            Match timeMatch = regTime.Match(textBoxTime.Text);

            if (timeMatch.Success)
            {
                labelTime.ForeColor = Color.Green;
                labelTime.Text = ok;
            }

            else
            {
                labelTime.ForeColor = Color.Red;
                labelTime.Text = error;
            }
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            Regex regEmail = new Regex("(?:[A-Za-z0-9_&]+)@(?:[a-z]+.(?:.com|.net|.ua|.com.ua))"); ;
            Match emailMatch = regEmail.Match(textBoxEmail.Text);

            if (emailMatch.Success)
            {
                labelEmail.ForeColor = Color.Green;
                labelEmail.Text = ok;
            }
            else
            {
                labelEmail.ForeColor = Color.Red;
                labelEmail.Text = error;
            }
        }
    }
}

