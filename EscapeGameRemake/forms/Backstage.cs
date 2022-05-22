using EscapeGameRemake.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeGameRemake.forms
{
    public partial class Backstage : Form
    {
        public static bool bonnie_enabled = false;

        private void check_state()
        {
            if (bonnie_enabled)
            {
                BackgroundImage = Properties.Resources.Backstage_ON_background;
            }
        }
        public Backstage()
        {
            InitializeComponent();
        }

        private void Backstage_Load(object sender, EventArgs e)
        {
            check_state();
        }

        private void screamer_button_Click(object sender, EventArgs e)
        {
            Screamer.Run(this, Path.Name.BACKSTAGE_JS, false);
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Dining());
        }

        private void computer_button_Click(object sender, EventArgs e)
        {
            SqlMonitor form = new SqlMonitor();
            form.ShowDialog();
        }
    }
}
