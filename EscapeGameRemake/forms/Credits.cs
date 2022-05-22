using System;
using System.Windows.Forms;
using EscapeGameRemake.src;

namespace EscapeGameRemake.forms
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new StartingMenu());
        }
    }
}
