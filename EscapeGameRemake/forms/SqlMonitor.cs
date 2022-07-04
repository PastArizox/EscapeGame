using System;
using System.Windows.Forms;
using EscapeGameRemake.src;

namespace EscapeGameRemake.forms
{
    public partial class SqlMonitor : Form
    {
        private const string pirate_cove_request = "update room set status = enabled where name = piratecove ; ";

        private const string all_request = "update animatronic set status = enabled ; ";
        private const string foxy_request_on = "update animatronic set status = enabled where name = foxy ; ";
        private const string freddy_request_on = "update animatronic set status = enabled where name = freddy ; ";
        private const string bonnie_request_on = "update animatronic set status = enabled where name = bonnie ; ";
        private const string chica_request_on = "update animatronic set status = enabled where name = chica ; ";

        public SqlMonitor()
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
            //if (label1.Text == foxy_request_on) PirateCove.opened = true;
            switch (label1.Text)
            {
                case pirate_cove_request:
                    PirateCove.opened = true;
                    SoundController.Play(SoundType.RIDEAU);
                    Close();
                    break;
                case all_request:
                    MessageBox.Show("Impossible d'activer tous les animatronics : Surcharge du transit de données\nTrouvez un moyen de les activer sans surcharger le système.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label1.Text = "";
                    break;
                case foxy_request_on:
                    if (PirateCove.opened)
                    {
                        if (!PirateCove.foxy_enabled)
                        {
                            PirateCove.foxy_enabled = true;
                            SoundController.Play(SoundType.ANIMATRONIC_ON);
                            Close();
                        }
                    } else
                    {
                        MessageBox.Show("Foxy ne peut pas être activé pour le moment.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        label1.Text = "";
                        Close();
                    }
                    break;
                case freddy_request_on:
                    if (!Stage.freddy_enabled)
                    {
                        Stage.freddy_enabled = true;
                        SoundController.Play(SoundType.ANIMATRONIC_ON);
                        Close();
                    }
                    break;
                case bonnie_request_on:
                    if (!Backstage.bonnie_enabled)
                    {
                        Backstage.bonnie_enabled = true;
                        SoundController.Play(SoundType.ANIMATRONIC_ON);
                        Close();
                    }
                    break;
                case chica_request_on:
                    if (!Kitchen.chica_enabled)
                    {
                        Kitchen.chica_enabled = true;
                        SoundController.Play(SoundType.ANIMATRONIC_ON);
                        Close();
                    }
                    break;
                default:
                    MessageBox.Show("Something went wrong...", "ErrorSqlRequest", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label1.Text = "";
                    SoundController.Play(SoundType.ERROR_SQL);    
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
