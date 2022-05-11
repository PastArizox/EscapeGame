using System.Windows.Forms;

namespace EscapeGameRemake.src
{
    public static class Utility
    {
        public static void OpenForm(Form targetForm) // For the Program.cs one (root form doesn't have a mainForm)
        {
            targetForm.FormClosed += Form_FormClosed;
            targetForm.Show();
        }

        public static void OpenForm(Form mainForm, Form targetForm) // For all the other forms
        {
            OpenForm(targetForm);
            mainForm.Close();
        }

        private static void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // If there is no remaining form then close the application
                Application.Exit();
        }

        public static void AddPaperToForm(Form MainForm, string Text) // Add a paper to a form
        {
            SoundController.Play(SoundType.PAPER);
            // PictureBox PB = new Paper(MainForm, Text).Create();
            Paper PB = new Paper(MainForm, Text);
            PB.Create();
            /*MainForm.Controls.Add(PB);
            PB.BringToFront();*/
        }

        public static void AddPostItToForm(Form MainForm, string Text) // Add a post it to a form
        {
            SoundController.Play(SoundType.PAPER);
            // PictureBox PIT = new PostIt(MainForm, Text).Create();
            PostIt PIT = new PostIt(MainForm, Text);
            PIT.Create();
            /*MainForm.Controls.Add(PIT);
            PIT.BringToFront();*/
        }

        public static void AddContextPaperToForm(Form MainForm) // Add the context paper to a form
        {
            SoundController.Play(SoundType.PAPER);
            PictureBox PCP = new ContextPaper(MainForm).Create();
            MainForm.Controls.Add(PCP);
            PCP.BringToFront();
        }
    }
}
