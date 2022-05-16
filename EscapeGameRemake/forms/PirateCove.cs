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
    public partial class PirateCove : Form
    {
        public static bool opened = false;

        public PirateCove()
        {
            InitializeComponent();
        }

        private void PirateCove_Load(object sender, EventArgs e)
        {
            CheckCurtain();
        }

        private void CheckCurtain()
        {
            if (opened)
            {
                BackgroundImage = Properties.Resources.PirateCove_ON_background;
                openable_button.Visible = false;
                // Visible = true sur les buttons sur foxy
            }
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Dining());
        }

        private void openable_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("On dirait que ce rideau est connecté à une base de donnée...\nOn doit pouvoir l'ouvrir grâce à une requête...", "PirateCove", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
