using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        int numberExtension = 0;
        int comma = 3;

        float number1 = 0;
        float number2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            addComma();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumberBox.Select();
        }

        public void addComma()
        {
            if (numberExtension == comma)
            {
                txtNumberBox.Text += ',';

                comma += 3;
            }

            numberExtension += 1;
        }

        public void cleanNumbers()
        {
            txtNumberBox.Text = "";

            numberExtension = 0;
            comma = 3;
        }

        #region Number Pad

        private void button24_Click(object sender, EventArgs e)
        {
            addComma();

            txtNumberBox.Text += '1';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            addComma();

            txtNumberBox.Text += '0';
        }

        private void button23_Click(object sender, EventArgs e)
        {
            addComma();

            txtNumberBox.Text += '2';
        }

        private void button22_Click(object sender, EventArgs e)
        {
            addComma();

            txtNumberBox.Text += '3';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            addComma();

            txtNumberBox.Text += '4';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            addComma();

            txtNumberBox.Text += '5';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            addComma();

            txtNumberBox.Text += '6';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            addComma();

            txtNumberBox.Text += '7';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addComma();

            txtNumberBox.Text += '8';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addComma();

            txtNumberBox.Text += '9';
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            cleanNumbers();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string reference = txtNumberBox.Text;
            lblReference.Text = reference + " + ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string reference = txtNumberBox.Text;
            lblReference.Text = reference + " - ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string reference = txtNumberBox.Text;
            lblReference.Text = reference + " * ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string reference = txtNumberBox.Text;
            lblReference.Text = reference + " / ";
        }
    }
}
