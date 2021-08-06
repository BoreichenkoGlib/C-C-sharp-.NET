using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combinations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelNk.Visible = false;
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            int n, k;
            n = (int)numericUpDownN.Value;
            k = (int)numericUpDownK.Value;

            int result = 0, up = 1, down = 1, down2 = 1;
            string[] split;
            int[] arr;
            switch (comboBoxCombination.SelectedIndex)
            {

                case 0:
                    result = (int)Math.Pow(n, k);
                    break;
                case 1:
                    down = 1;
                    up = 1;
                    for (int i = 1; i <= n; i++)
                        up *= i;
                    for (int i = 1; i <= n - k; i++)
                        down *= i;

                    result = up / down;
                    break;
                case 2:
                    down = 1;
                    up = 1;
                    for (int i = 1; i <= n; i++)
                        up *= i;
                    for (int i = 1; i <= n - k; i++)
                        down *= i;
                    for (int i = 1; i <= k; i++)
                        down2 *= i;

                    result = up / (down * down2);
                    break;
                case 3:
                    down = 1;
                    up = 1;
                    n += k - 1;
                    for (int i = 1; i <= n; i++)
                        up *= i;
                    for (int i = 1; i <= n - k; i++)
                        down *= i;
                    for (int i = 1; i <= k; i++)
                        down2 *= i;

                    result = up / (down * down2);
                    break;
                case 4:
                    down = 1;
                    up = 1;
                    for (int i = 1; i <= n; i++)
                        up *= i;

                    result = up;
                    break;
                case 5:
                    for (int i = 1; i <= n; i++)
                        up *= i;
                    split = textBoxKArr.Text.Split(' ');
                    arr = new int[split.Length];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = int.Parse(split[i]);
                    }

                    int tmp = 1;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        tmp = 1;
                        for (int j = 1; j <= arr[i]; j++)
                        {
                            tmp *= j;
                        }
                        arr[i] = tmp;
                    }
                    down = 1;
                    up = 1;
                    for (int i = 0; i < arr.Length; i++)
                        down *= arr[i];

                    for (int i = 1; i <= n; i++)
                        up *= i;

                    result = up / down;
                    break;
            }
            textBoxResult.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownK.Visible = true;
            textBoxKArr.Visible = false;
        }

        private void ComboBoxCombination_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxCombination.SelectedIndex == 5)
            {
                numericUpDownK.Visible = false;
                textBoxKArr.Visible = true;
                labelNk.Visible = true;
            }
            else if (comboBoxCombination.SelectedIndex == 4)
            {
                numericUpDownK.Visible = false;
                textBoxKArr.Visible = false;
                labelK.Visible = false;
                labelNk.Visible = false;
            }
            else
            {
                numericUpDownK.Visible = true;
                textBoxKArr.Visible = false;
                labelK.Visible = true;
                labelNk.Visible = false;
            }
        }
    }
}
