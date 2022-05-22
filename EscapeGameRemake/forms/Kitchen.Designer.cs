
namespace EscapeGameRemake.forms
{
    partial class Kitchen
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
            this.nose_honk_button = new System.Windows.Forms.Button();
            this.eye_button = new System.Windows.Forms.Button();
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
            this.return_button.TabIndex = 26;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // nose_honk_button
            // 
            this.nose_honk_button.BackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.nose_honk_button.FlatAppearance.BorderSize = 0;
            this.nose_honk_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nose_honk_button.Location = new System.Drawing.Point(674, 420);
            this.nose_honk_button.Margin = new System.Windows.Forms.Padding(2);
            this.nose_honk_button.Name = "nose_honk_button";
            this.nose_honk_button.Size = new System.Drawing.Size(10, 10);
            this.nose_honk_button.TabIndex = 27;
            this.nose_honk_button.UseVisualStyleBackColor = false;
            this.nose_honk_button.Click += new System.EventHandler(this.nose_honk_button_Click);
            // 
            // eye_button
            // 
            this.eye_button.BackColor = System.Drawing.Color.Transparent;
            this.eye_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eye_button.FlatAppearance.BorderSize = 0;
            this.eye_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eye_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eye_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eye_button.Location = new System.Drawing.Point(569, 154);
            this.eye_button.Margin = new System.Windows.Forms.Padding(2);
            this.eye_button.Name = "eye_button";
            this.eye_button.Size = new System.Drawing.Size(16, 21);
            this.eye_button.TabIndex = 28;
            this.eye_button.UseVisualStyleBackColor = false;
            this.eye_button.Visible = false;
            this.eye_button.Click += new System.EventHandler(this.eye_button_Click);
            // 
            // Kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeGameRemake.Properties.Resources.Kitchen_OFF_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 612);
            this.Controls.Add(this.eye_button);
            this.Controls.Add(this.nose_honk_button);
            this.Controls.Add(this.return_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Kitchen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitchen";
            this.Load += new System.EventHandler(this.Kitchen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button nose_honk_button;
        private System.Windows.Forms.Button eye_button;
    }
}