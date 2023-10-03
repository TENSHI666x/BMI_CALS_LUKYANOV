using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_CALS_LUKYANOV
{
    public partial class Form1 : Form
    {
        private bool gender = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMale_Click(object sender, EventArgs e)
        {
            gender = true;
            buttonMale.Enabled = false;
            buttonMale.BackColor = SystemColors.ActiveCaption;
            buttonFemale.Enabled = true;
            buttonFemale.BackColor = SystemColors.Control;
        }

        private void buttonFemale_Click(object sender, EventArgs e)
        {
            gender = false;
            buttonMale.Enabled = true;
            buttonMale.BackColor = SystemColors.Control;
            buttonFemale.Enabled = false;
            buttonFemale.BackColor = SystemColors.ActiveCaption;
        }

        private void buttonClaim_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void labelBMI_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxHealth_Click(object sender, EventArgs e)
        {

        }

        private void buttonClaim_Click_1(object sender, EventArgs e)
        {
            double BMI, height = double.Parse(textBoxHeight.Text), weight = double.Parse(textBoxWeight.Text);

            if (gender)
            {
                height /= 100;
            }
            else
            {
                height /= 110;
            }
            BMI = weight / (height * height);
            labelBMI.Text = BMI.ToString();
            if (BMI < 10)
            {
                trackBarHealth.Value = 10;
            }
            else if (BMI > 40)
            {
                trackBarHealth.Value = 40;
            }
            else
            {
                trackBarHealth.Value = (int)BMI;
            }

            if (BMI < 18.5)
            {
                labelHealth.Text = "Недовес";
                pictureBoxHealth.Image = Image.FromFile("C:\\Users\\Pikac\\source\\repos\\BMI_CALS_LUKYANOV\\Resources\\bmi-underweight-icon.png");
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                labelHealth.Text = "Здролвый";
                pictureBoxHealth.Image = Image.FromFile("C:\\Users\\Pikac\\source\\repos\\BMI_CALS_LUKYANOV\\Resources\\bmi-healthy-icon.png");
            }
            else if (BMI >= 25 && BMI < 30)
            {
                labelHealth.Text = "Лишний вес";
                pictureBoxHealth.Image = Image.FromFile("C:\\Users\\Pikac\\source\\repos\\BMI_CALS_LUKYANOV\\Resources\\bmi-overweight-icon.png");
            }
            else
            {
                labelHealth.Text = "Ожирение";
                pictureBoxHealth.Image = Image.FromFile("C:\\Users\\Pikac\\source\\repos\\BMI_CALS_LUKYANOV\\Resources\\bmi-obese-icon.png");
            }
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}