
namespace EscapeGameRemake.forms
{
    partial class Stage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.return_button = new System.Windows.Forms.Button();
            this.eye_button = new System.Windows.Forms.Button();
            this.nose_honk_button1 = new System.Windows.Forms.Button();
            this.nose_honk_button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.Transparent;
            this.return_button.BackgroundImage = global::EscapeGameRemake.Properties.Resources.Retour;
            this.return_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_button.FlatAppearance.BorderSize = 0;
            this.return_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.return_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Location = new System.Drawing.Point(362, 562);
            this.return_button.Margin = new System.Windows.Forms.Padding(2);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(388, 41);
            this.return_button.TabIndex = 15;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // eye_button
            // 
            this.eye_button.BackColor = System.Drawing.Color.Transparent;
            this.eye_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eye_button.FlatAppearance.BorderSize = 0;
            this.eye_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eye_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eye_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eye_button.Location = new System.Drawing.Point(549, 136);
            this.eye_button.Margin = new System.Windows.Forms.Padding(2);
            this.eye_button.Name = "eye_button";
            this.eye_button.Size = new System.Drawing.Size(26, 28);
            this.eye_button.TabIndex = 21;
            this.eye_button.UseVisualStyleBackColor = false;
            this.eye_button.Visible = false;
            this.eye_button.Click += new System.EventHandler(this.eye_button_Click);
            // 
            // nose_honk_button1
            // 
            this.nose_honk_button1.BackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.nose_honk_button1.FlatAppearance.BorderSize = 0;
            this.nose_honk_button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nose_honk_button1.Location = new System.Drawing.Point(513, 152);
            this.nose_honk_button1.Margin = new System.Windows.Forms.Padding(2);
            this.nose_honk_button1.Name = "nose_honk_button1";
            this.nose_honk_button1.Size = new System.Drawing.Size(40, 15);
            this.nose_honk_button1.TabIndex = 22;
            this.nose_honk_button1.UseVisualStyleBackColor = false;
            this.nose_honk_button1.Visible = false;
            this.nose_honk_button1.Click += new System.EventHandler(this.nose_honk_button_Click);
            // 
            // nose_honk_button2
            // 
            this.nose_honk_button2.BackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.nose_honk_button2.FlatAppearance.BorderSize = 0;
            this.nose_honk_button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nose_honk_button2.Location = new System.Drawing.Point(514, 170);
            this.nose_honk_button2.Margin = new System.Windows.Forms.Padding(2);
            this.nose_honk_button2.Name = "nose_honk_button2";
            this.nose_honk_button2.Size = new System.Drawing.Size(40, 15);
            this.nose_honk_button2.TabIndex = 23;
            this.nose_honk_button2.UseVisualStyleBackColor = false;
            this.nose_honk_button2.Click += new System.EventHandler(this.nose_honk_button_Click);
            // 
            // Stage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeGameRemake.Properties.Resources.Stage_OFF_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 612);
            this.Controls.Add(this.nose_honk_button2);
            this.Controls.Add(this.nose_honk_button1);
            this.Controls.Add(this.eye_button);
            this.Controls.Add(this.return_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Stage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stage";
            this.Load += new System.EventHandler(this.Stage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button eye_button;
        private System.Windows.Forms.Button nose_honk_button1;
        private System.Windows.Forms.Button nose_honk_button2;
    }
}