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
            bool celsiusValid = Double.TryParse(txtCelsius.Text, out double celsius); //validating argument 

            if (celsiusValid)
                {
                //takes argument celsius makes it a double instead
                //of a string, converts to farhenheit, back to a string to 2 
                //decimal places.
                //double celsius = Convert.ToDouble(txtCelsius.Text);
                //above line not necessary after validation checking, changes data type as well 
                double farhenheit = (celsius / 5 * 9) + 32;
                txtFahrenheit.Text = farhenheit.ToString("f2");
                txtFahrenheit.Focus();
                }
            else
            {
                MessageBox.Show("please enter numbers", "Error");
            }
        }

        private void btnVolumeConvert_Click(object sender, EventArgs e)
        {
            bool mililitresValid = Double.TryParse(txtMililitres.Text, out double mililitres); //validating argument 

            if (mililitresValid)
            {
                //double mililitres = Convert.ToDouble(txtMililitres.Text);
                double cups = (mililitres / 263.59);
                txtCups.Text = cups.ToString("f2");
                txtCups.Focus();
            }
            else
            {
                MessageBox.Show("please enter numbers", "Error");

            }
        }
    }
}
