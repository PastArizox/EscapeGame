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
    public partial class FinalDoor : Form
    {
        public FinalDoor()
        {
            InitializeComponent();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new MiddleDining());
        }
    }
}
