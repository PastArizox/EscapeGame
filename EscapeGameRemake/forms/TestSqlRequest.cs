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
    public partial class TestSqlRequest : Form
    {
        private const string pirate_cove_request = "update room set PirateCove = enabled ; ";

        private const string all_request = "update animatronic set status = enabled ; ";
        private const string foxy_request = "update animatronic set status = enabled where name = foxy ; ";
        private const string freddy_request = "update animatronic set status = enabled where name = freddy ; ";
        private const string bonny_request = "update animatronic set status = enabled where name = bonny ; ";
        private const string chica_request = "update animatronic set status = enabled where name = chica ; ";

        public TestSqlRequest()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button_Click(object sender, EventArgs e)
        {
            label1.Text += (((Button)sender).Text).ToLower() + " ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text == foxy_request) PirateCove.opened = true;
            switch (label1.Text)
            {
                case pirate_cove_request:
                    PirateCove.opened = true;
                    // Play sound
                    MessageBox.Show("Pirate Cove Opened");
                    Close();
                    break;
                case all_request:
                    MessageBox.Show("Impossible d'activer tous les animatronics : Surcharge du transit de données\nTrouvez un moyen de les activer sans surcharger le système.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
