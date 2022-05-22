using System.Windows.Forms;

namespace EscapeGameRemake.src
{
    public static class Utility
    {
        public static void OpenForm(Form targetForm) // For the Program.cs one (root form doesn't have a mainForm)
        {
            targetForm.FormClosed += Form_FormClosed;
            targetForm.Shown += TargetForm_Shown;
            targetForm.Show();
        }

        private static void TargetForm_Shown(object sender, System.EventArgs e)
        {
            Form form = (Form)sender;
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl.Name.Contains("button"))
                {
                    Button btn = (Button)ctrl;
                    btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                }
            }
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

        public static void AddMapToForm(Form MainForm)
        {
            Map map = new Map(MainForm);
            map.Create();
        }

        public static void OpenChest(Form MainForm)
        {
            forms.Chest chest = new forms.Chest();
            chest.Size = new System.Drawing.Size(MainForm.Width, MainForm.Height);
            chest.ShowDialog();
        }

        public static void AddEyetoForm(Form MainForm, System.Drawing.Bitmap Image)
        {
            Eye eye = new Eye(MainForm, Image);
            eye.Create();
        }
    }
}
