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
        public Backstage()
        {
            InitializeComponent();
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
            TestSqlRequest form = new TestSqlRequest();
            form.ShowDialog();
        }
    }
}
