using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTempConvert_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(txtCelsius.Text);
            double farhenheit = (celsius / 5 * 9) + 32;
            txtFahrenheit.Text = farhenheit.ToString("f2");
        }
    }
}
