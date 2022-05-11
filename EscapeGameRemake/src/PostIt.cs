using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace EscapeGameRemake.src
{
    class PostIt
    {
        private readonly Bitmap Image = Properties.Resources.PostIt;
        private readonly string Text;

        private readonly int Width;
        private readonly int Height;
        private readonly int PosX;
        private readonly int PosY;

        private readonly Form MainForm;
        private forms.OverObject newForm;
        private readonly List<string> OffControls = new List<string>();

        private PictureBox PB;

        public PostIt(Form MainForm, string Text)
        {
            Width = MainForm.Width - MainForm.Width / 2;
            Height = MainForm.Height - MainForm.Height / 4;
            PosX = MainForm.Width / 2 - Width / 2;
            PosY = MainForm.Height / 2 - Height / 2;
            this.Text = Text;
            this.MainForm = MainForm;
        }

        public void Create()
        {
            //DisableBackgroundEvents();
            Label TextLabel = InitLabel(Text);
            PictureBox Paper = InitPictureBox(TextLabel, Image);
            PB = Paper;

            newForm = new forms.OverObject();
            newForm.Size = new Size(Width, Height);
            // newForm.Parent = MainForm;
            newForm.Controls.Add(PB);
            newForm.ShowDialog();
        }

        /*private void DisableBackgroundEvents()
        {
            for (int i = 0; i < MainForm.Controls.Count; i++)
            {
                if (MainForm.Controls[i].Visible)
                {
                    OffControls.Add(MainForm.Controls[i].Name);
                    MainForm.Controls[i].Visible = false;
                }
            }
        }
        private void EnableBackgroundEvents()
        {
            for (int i = 0; i < OffControls.Count; i++)
            {
                for (int j = 0; j < MainForm.Controls.Count; j++)
                {
                    if (MainForm.Controls[j].Name == OffControls[i])
                    {
                        OffControls.Remove(MainForm.Controls[j].Name);
                        MainForm.Controls[j].Visible = true;
                    }
                }
            }
        }*/

        private Label InitLabel(string Text)
        {
            Label LBL = new Label
            {
                Text = Text,
                ForeColor = Color.Black,
                Font = new Font("Miriam Libre", 25),
                BackColor = Color.Transparent,
                AutoSize = false,
                Size = new Size(Width - 100, Height - 100),
                Location = new Point(50, 120)
            };
            LBL.MouseClick += Close_MouseClick;
            return LBL;
        }

        private PictureBox InitPictureBox(Label TextLabel, Bitmap Image)
        {
            PictureBox PB = new PictureBox
            {
                //Location = new Point(PosX, PosY),
                Location = new Point(0, 0),
                Size = new Size(Width, Height),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Image = Image
            };
            PB.Controls.Add(TextLabel);
            PB.MouseClick += Close_MouseClick;
            PB.Cursor = Cursors.Hand;
            return PB;
        }

        private void Close_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm.Controls.Remove(PB);
            newForm.Close();
            //EnableBackgroundEvents();
        }
    }
}
