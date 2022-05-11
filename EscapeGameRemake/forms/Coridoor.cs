using System;
using System.Windows.Forms;
using EscapeGameRemake.src;

namespace EscapeGameRemake.forms
{
    public partial class Coridoor : Form
    {
        public Coridoor()
        {
            InitializeComponent();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Office());
        }

        private void closet_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Closet());
        }

        private void dining_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Dining());
        }

        private void Coridoor_Load(object sender, EventArgs e)
        {

        }

        private void Coridoor_Shown(object sender, EventArgs e)
        {
            
        }

        private void paper1_button_Click(object sender, EventArgs e)
        {
            Utility.AddPaperToForm(this, "");
        }

        private void paper2_button_Click(object sender, EventArgs e)
        {
            Utility.AddPaperToForm(this, "");
        }
    }
}
