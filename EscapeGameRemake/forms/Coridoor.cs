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

        private void paper1_button_Click(object sender, EventArgs e)
        {
            Utility.AddPaperToForm(this, "Note à moi même :\n\n" +
                                         "\n                UPDATE table_name\n" +
                                         "\n                SET column1 = value\n" +
                                         "\n                WHERE condition;\n" +
                                         "\n\n                                                                Mike Schmidt");
        }

        private void paper2_button_Click(object sender, EventArgs e)
        {
            Utility.AddPaperToForm(this, "\n        Freddy : " + (Stage.freddy_enabled ? "enabled" : "disabled") +
                                         "\n        Bonnie : " + (Backstage.bonnie_enabled ? "enabled" : "disabled") +
                                         "\n        Chica : " + (Kitchen.chica_enabled ? "enabled" : "disabled") +
                                         "\n        Foxy : " + (PirateCove.foxy_enabled ? "enabled" : "disabled" +
                                         "\n\n                          Ne les confondez pas !" +
                                         "\n        Foxy est le renard,        Freddy l'ours,              Chica le poulet\n" +
                                         "\n     Et pour finir, Bonnie est le lapin"));
        }
    }
}
