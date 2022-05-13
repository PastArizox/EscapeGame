using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscapeGameRemake.src;

namespace EscapeGameRemake.forms
{
    public partial class MiddleDining : Form
    {
        public MiddleDining()
        {
            InitializeComponent();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Dining());
        }

        private void middledining_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Stage());
        }

        private void finaldoor_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new FinalDoor());
        }
    }
}
