﻿using System;
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
        public static bool foxy_enabled = false;

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
            if (opened && foxy_enabled)
            {
                BackgroundImage = Properties.Resources.PirateCove_ON_ON_background;
                openable_button.Visible = false;
                eye_button.Visible = true;
                screamer_button.Visible = true;
            } else if (opened && !foxy_enabled)
            {
                BackgroundImage = Properties.Resources.PirateCove_ON_OFF_background;
                openable_button.Visible = false;
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

        private void eye_button_Click(object sender, EventArgs e)
        {
            Utility.AddEyetoForm(this, Properties.Resources.Foxy_Eye);
        }

        private void screamer_button_Click(object sender, EventArgs e)
        {
            var Rand = new Random();
            if (Rand.Next(2) == 0)
                Screamer.Run(this, Path.Name.PIRATECOVE_JS, false);
        }
    }
}
