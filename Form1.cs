using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            int numVal = Convert.ToInt32(num_Input.Value);
            int iterations = Convert.ToInt32(num_Iterations.Value);
            TrinityFunction(numVal, iterations);
        }
        

        private double TriangulateNumericalValue(double numVal)
        {
            double val = 0;
            int intVal = Convert.ToInt32(numVal);
            char[] chars = intVal.ToString().ToCharArray();
            foreach (char c in chars)
            {
                int tNum = Convert.ToInt32(c.ToString());
                val += Math.Pow(tNum, 3);
            }
            return val;
        }


        private void TrinityFunction(int num, int iterations)
        {
            StringBuilder output = new StringBuilder();
            double result = num;
            for (int i = 0; i < iterations; i++)
            {
                result = TriangulateNumericalValue(result);
                int intResult = Convert.ToInt32(result);
                output.Append(String.Format("{0}: {1}", i + 1, intResult) + Environment.NewLine);
            }

            tbx_Output.Text = output.ToString();
        }

    }
}
