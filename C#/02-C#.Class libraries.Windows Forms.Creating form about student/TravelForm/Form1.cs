using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelForm
{
    public partial class Lab6 : Form
    {
            public Lab6()
            {
                InitializeComponent();
                CountryComboBox.SelectedIndex = 0;
            }

            private void Solve_Click(object sender, EventArgs e)
            {
            int day;
            if (int.TryParse(DayCount.Text, out day) == false) MessageBox.Show("Помилка введення значення днів!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            double cost = 0;
                if (GidcheckBox.Checked == true)
                {
                    cost = day*50;
                }
                CountryComboBox.SelectedIndexChanged += comboBoxMaterial_SelectedIndexChanged;
                if (SummerRadioButton.Checked == true)
                {
                    if (CountryComboBox.SelectedIndex == 0)
                        cost += 100;
                    if (CountryComboBox.SelectedIndex == 1) cost += 160;
                    if (CountryComboBox.SelectedIndex == 2) cost += 120;
                }
                if (WinterRadioButton.Checked == true)
                {
                    if (CountryComboBox.SelectedIndex == 0)
                        cost += 150;
                    if (CountryComboBox.SelectedIndex == 1) cost += 200;
                    if (CountryComboBox.SelectedIndex == 2) cost += 180;

                }
                res.Text = cost.ToString();

            }

            private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
            {
                string selectedState = CountryComboBox.SelectedItem.ToString();
            }
        }
    }