﻿using System;
using System.Windows.Forms;

namespace EscapeGameRemake.forms
{
    public partial class Digicode : Form
    {
        private int DoorCode;
        private bool typedCode = false;

        public Digicode(Form mainForm, int DoorCode)
        {
            InitializeComponent();
            this.DoorCode = DoorCode;
        }

        public bool getTypedCode()
        {
            return typedCode;
        }

        public bool check_code()
        {
            if (code_label.Text != "")
                return DoorCode == short.Parse(code_label.Text);
            return false;

        }

        private void addToLabel(string nb)
        {
            code_label.Text += nb;
            if (code_label.Text.Length == 4)
            {
                MessageBox.Show("Vérification du code ...");
                typedCode = true;
                Close();
            }
        }

        private void digicode_button1_Click(object sender, EventArgs e)
        {
            addToLabel("1");
        }

        private void digicode_button2_Click(object sender, EventArgs e)
        {
            addToLabel("2");
        }

        private void digicode_button3_Click(object sender, EventArgs e)
        {
            addToLabel("3");
        }

        private void digicode_button4_Click(object sender, EventArgs e)
        {
            addToLabel("4");
        }

        private void digicode_button5_Click(object sender, EventArgs e)
        {
            addToLabel("5");
        }

        private void digicode_button6_Click(object sender, EventArgs e)
        {
            addToLabel("6");
        }

        private void digicode_button7_Click(object sender, EventArgs e)
        {
            addToLabel("7");
        }

        private void digicode_button8_Click(object sender, EventArgs e)
        {
            addToLabel("8");
        }

        private void digicode_button9_Click(object sender, EventArgs e)
        {
            addToLabel("9");
        }
    }
}
