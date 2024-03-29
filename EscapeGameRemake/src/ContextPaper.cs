﻿using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace EscapeGameRemake.src
{
    class ContextPaper
    {
        private readonly Bitmap Image = Properties.Resources.ContextPaper;

        private readonly int Width;
        private readonly int Height;
        private readonly int PosX;
        private readonly int PosY;

        private readonly Form MainForm;
        private readonly List<string> OffControls = new List<string>();

        private PictureBox PB;

        public ContextPaper(Form MainForm)
        {
            Width = MainForm.Width - MainForm.Width / 4;
            Height = MainForm.Height - MainForm.Height / 4;
            PosX = MainForm.Width / 2 - Width / 2;
            PosY = MainForm.Height / 2 - Height / 2;
            this.MainForm = MainForm;
        }

        public PictureBox Create()
        {
            DisableBackgroundEvents();
            PictureBox Paper = InitPictureBox(Image);
            PB = Paper;
            return Paper;
        }

        private void DisableBackgroundEvents()
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
        }

        private Label InitLabel(string Text)
        {
            Label LBL = new Label
            {
                Text = Text,
                ForeColor = Color.Black,
                Font = new Font("Miriam Libre", 20),
                BackColor = Color.Transparent,
                AutoSize = false,
                Size = new Size(Width - 100, Height - 100),
                Location = new Point(50, 50)
            };
            LBL.MouseClick += Close_MouseClick;
            return LBL;
        }

        private PictureBox InitPictureBox(Bitmap Image)
        {
            PictureBox PB = new PictureBox
            {
                Location = new Point(PosX, PosY),
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
            EnableBackgroundEvents();
            Utility.OpenForm(MainForm, new forms.Office());
        }
    }
}
