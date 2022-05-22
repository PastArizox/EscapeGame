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
    public partial class Chest : Form
    {
        private static bool key1 = false;
        private static bool key2 = false;

        public static bool opened = false;

        public Chest()
        {
            InitializeComponent();
        }

        private void check_state()
        {
            if (opened)
            {
                BackgroundImage = Properties.Resources.Chest_ON_OFF;
                key1_button.Visible = false;
                key2_button.Visible = false;
                paper_button.Visible = true;
                if (Backstage.bonnie_enabled)
                {
                    BackgroundImage = Properties.Resources.Chest_ON_ON;
                    eye_button.Visible = true;
                }
            }
        }

        private void check_keys()
        {
            if (key1 && key2)
            {
                opened = true;
                check_state();
            }
        }

        private void runErrorMessage()
        {
            MessageBox.Show("On dirait que tu ne possèdes pas la clé pour ouvrir ce cadenas...", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Chest_Load(object sender, EventArgs e)
        {
            check_state();
        }

        private void key1_button_Click(object sender, EventArgs e)
        {
            if (Player.key1 && !key1)
            {
                key1 = true;
                MessageBox.Show("Cadenas 1 ouvert", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check_keys();
            } else { runErrorMessage(); };
        }

        private void key2_button_Click(object sender, EventArgs e)
        {
            if (Player.key2 && !key2)
            {
                key2 = true;
                MessageBox.Show("Cadenas 2 ouvert", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check_keys();
            }
            else { runErrorMessage(); };
        }

        private void Chest_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void chest_image_panel_Paint(object sender, PaintEventArgs e)
        {
            Close();
        }

        private void paper_button_Click(object sender, EventArgs e)
        {
            Utility.AddPaperToForm(this, "\nRegarde le robot dans le bon oeil et tu trouveras ton chemin." +
                                         "\n\nS'ils dorment, une requête pourrait vous aider à les réveiller." +
                                         "\n\nLe premier en partant de la fin est le jaune, celui après le " +
                                         "premier en partant du début est le rouge, celui entre les deux cités est le marron " +
                                         "et le dernier est le violet.");
        }

        private void eye_button_Click(object sender, EventArgs e)
        {
            Utility.AddEyetoForm(this, Properties.Resources.Bonnie_Eye);
        }
    }
}
