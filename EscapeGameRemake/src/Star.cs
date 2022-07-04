using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeGameRemake.src
{
    class Star
    {
        private readonly Bitmap Image;

        private readonly int Width;
        private readonly int Height;
        private readonly int PosX;
        private readonly int PosY;

        private readonly Form MainForm;
        private forms.OverObject newForm;
        private readonly List<string> OffControls = new List<string>();

        private PictureBox PB;

        public Star(Form MainForm, Bitmap Image)
        {
            Width = MainForm.Width - MainForm.Width / 2;
            Height = MainForm.Height - MainForm.Height / 4;
            PosX = MainForm.Width / 2 - Width / 2;
            PosY = MainForm.Height / 2 - Height / 2;
            this.MainForm = MainForm;
            this.Image = Image;
        }

        public void Create()
        {
            //DisableBackgroundEvents();
            PictureBox Paper = InitPictureBox(Image);
            PB = Paper;

            newForm = new forms.OverObject();
            newForm.Size = new Size(Width, Height);
            // newForm.Parent = MainForm;
            newForm.Controls.Add(PB);
            newForm.ShowDialog();
        }

        private PictureBox InitPictureBox(Bitmap Image)
        {
            PictureBox PB = new PictureBox
            {
                Location = new Point(0, 0),
                Size = new Size(Width, Height),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Image = Image
            };
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
