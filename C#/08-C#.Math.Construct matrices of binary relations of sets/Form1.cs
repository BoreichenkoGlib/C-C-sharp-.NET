using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonToBuild_Click(object sender, EventArgs e)
        {
            this.dataGridMatrix.DataSource = null;
            this.dataGridMatrix.Rows.Clear();
            this.dataGridMatrix.Columns.Clear();
            var stringSetA = textBoxSetA.Text.Split(',');
            string[] stringSetB = textBoxSetB.Text.Split(',');

            var setA = ParseString(stringSetA);
            var setB = ParseString(stringSetB);

            dataGridMatrix.Columns.Add(string.Empty, string.Empty);
            foreach (var item in setB)
                dataGridMatrix.Columns.Add(Display(item), Display(item));

            for (int i = 0; i < setA.Count; i++)
            {
                dataGridMatrix.Rows.Add();
                dataGridMatrix.Rows[i].Cells[0].Value = Display(setA[i]);
                for (int g = 0; g < setB.Count; g++)
                    dataGridMatrix.Rows[i].Cells[g + 1].Value = Initialize(setA[i], setB[g]);
            }
        }

        private List<List<int>> ParseString(string[] input)
        {
            var result = new List<List<int>>();
            var temp = new List<int>();
            bool WasOpened = false;

            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i].Contains('{'))
                {
                    temp.Add(Convert.ToInt32(input[i].Replace("{", string.Empty)));
                    WasOpened = true;
                }


                else if (input[i].Contains('}'))
                {
                    temp.Add(Convert.ToInt32(input[i].Replace("}", string.Empty)));
                    result.Add(temp);
                    temp = new List<int>();
                    WasOpened = false;
                }

                else
                {
                    if (WasOpened) temp.Add(Convert.ToInt32(input[i]));
                    else result.Add(new List<int>() { Convert.ToInt32(input[i]) });
                }
            }

            return result;
        }

        private int Calculate(List<int> SetA, List<int> SetB)
        {
            bool totalFlag = false;
            foreach (var itemA in SetA)
            {
                if ((itemA + 2 * SetB.First()) % 3 != 0)
                {
                    totalFlag = false;
                    break;
                }
                totalFlag = true;
            }

            return totalFlag ? 1 : 0;
        }

        private int Initialize(List<int> elementASet, List<int> elementBSet)
        {
            //bool flag = false;
            //foreach (var itemA in elementASet)
            //    foreach (var itemB in elementBSet)
            //        if (itemA == itemB)
            //            flag = true;

            return Calculate(elementASet, elementBSet);

        }

        private string ConvertToString(List<int> elementSet)
        {
            string result = string.Empty;
            foreach (var item in elementSet)
                result += item.ToString() + " ";

            return result;
        }

        private string Display(IList<int> elements)
        {
            if (elements.Count == 1)
                return elements[0].ToString();

            string result = "{";

            foreach (var item in elements)
                result += item.ToString() + ",";

            result = result.Remove(result.LastIndexOf(','));
            return result + "}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSetA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
