using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazedForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Bold);
            label2.Font = new Font(label2.Font, label2.Font.Style | FontStyle.Bold);
            comboBoxMaterial.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double width, height, square, cost=0;
            if (double.TryParse(widthtextBox.Text, out width) == false) MessageBox.Show("Помилка введення значення ширини!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (double.TryParse(heighttextBox.Text, out height) == false) MessageBox.Show("Помилка введення значення висоти!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            square = width * height;
                if (checkBox1.Checked == true)
                {
                    cost = 35.0;
                }
            comboBoxMaterial.SelectedIndexChanged += comboBoxMaterial_SelectedIndexChanged;
            if (OnePacketRadioButton.Checked==true)
            {
                if (comboBoxMaterial.SelectedIndex == 0)
                    cost +=0.25*square;
                if (comboBoxMaterial.SelectedIndex == 1) cost += 0.05 * square;
                if (comboBoxMaterial.SelectedIndex == 2) cost += 0.15 * square;
            }
            if (TwoPacketRadioButton.Checked == true)
            {
                if (comboBoxMaterial.SelectedIndex == 0)
                    cost += 0.30 * square;
                if (comboBoxMaterial.SelectedIndex == 1) cost += 0.10 * square;
                if (comboBoxMaterial.SelectedIndex == 2) cost += 0.20 * square;

            }
            res.Text = cost.ToString();

        }

        private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
                string selectedState = comboBoxMaterial.SelectedItem.ToString();
            }
        }
    }
