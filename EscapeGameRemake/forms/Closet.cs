using EscapeGameRemake.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EscapeGameRemake.forms
{
    public partial class Closet : Form
    {
        public Closet()
        {
            InitializeComponent();
        }

        private void Closet_Load(object sender, EventArgs e)
        {

        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Coridoor());
        }
    }
}
