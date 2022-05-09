using System.Windows.Forms;
using EscapeGameRemake.src;

namespace EscapeGameRemake.forms
{
    public partial class OfficeDesk : Form
    {
        public OfficeDesk()
        {
            InitializeComponent();
        }

        private void return_button_Click(object sender, System.EventArgs e)
        {
            Utility.OpenForm(this, new Office());
        }

        private void nose_honk_button_Click(object sender, System.EventArgs e)
        {
            SoundController.Play(SoundType.NOSE_HONK);
        }

        private void paper1_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPaperToForm(this, "Une base de données est un ensemble d'informations qui " +
                                         "est organisé de manière à être facilement accessible, géré " +
                                         "et mis à jour. Elle est utilisée par les organisations comme " +
                                         "méthode de stockage, de gestion et de récupération de l’informations.\n\n" +
                                         "Les données sont organisées en lignes, colonnes et tableaux et sont " +
                                         "indexées pour faciliter la recherche d'informations.");
        }

        private void paper2_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPaperToForm(this, "Des données se sont perdues dans cette salle. Vous pourrez trouver le code " +
                                         "en triant les données dans les bonnes catégories.\n\n\n\n\n\n\n\n" +
                                         "Attention à Bonnie, il n'aime pas beaucoup les humains.");
        }

        private void paper3_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPaperToForm(this, "\n\n\n\n\n\n\n\n\n\n          It's me");
        }

        private void postit1_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPostItToForm(this, 
                "               Dauphin\n" +   
                "   Addax\n\n" +
                "                               Ara bleu\n\n\n" +
                "       Poissons");
        }

        private void postit2_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPostItToForm(this,
                "   Caïman\n\n" +
                "                       Cobra\n" +
                "Argali\n\n\n" +
                "       Reptiles");
        }

        private void postit3_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPostItToForm(this,
                "              Buse\n\n" +
                "                           Canard\n" +
                "Bariroussa\n" +
                "             Buffle\n\n" +
                "                   Mammifère");
        }

        private void postit4_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPostItToForm(this, 
                "             Cerf\n\n" +
                "    Python\n" +
                "                        Caméléon");
        }

        private void postit5_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPostItToForm(this, 
                "                      Couleuvre\n\n" +
                "       Esturgeon\n\n\n" +
                "                   Chevreuil");
        }

        private void postit6_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPostItToForm(this,
                "Ablette\n\n" +
                "                               Bar\n\n" +
                "       Espadon\n" +
                "                       Capucin\n" +
                " Crotale");
        }

        private void postit7_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPostItToForm(this, "");
        }

        private void postit8_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPostItToForm(this,
                "                           Faucon\n" +
                "       Tortue\n\n" +
                "Balène\n\n" +
                "                   Oiseaux");
        }
    }
}