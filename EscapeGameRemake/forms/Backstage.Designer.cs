
namespace EscapeGameRemake.forms
{
    partial class Backstage
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
            this.computer_button = new System.Windows.Forms.Button();
            this.star_button = new System.Windows.Forms.Button();
            this.screamer_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // computer_button
            // 
            this.computer_button.BackColor = System.Drawing.Color.Transparent;
            this.computer_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.computer_button.FlatAppearance.BorderSize = 0;
            this.computer_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.computer_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.computer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computer_button.Location = new System.Drawing.Point(369, 286);
            this.computer_button.Margin = new System.Windows.Forms.Padding(2);
            this.computer_button.Name = "computer_button";
            this.computer_button.Size = new System.Drawing.Size(66, 55);
            this.computer_button.TabIndex = 19;
            this.computer_button.UseVisualStyleBackColor = false;
            this.computer_button.Click += new System.EventHandler(this.computer_button_Click);
            // 
            // star_button
            // 
            this.star_button.BackColor = System.Drawing.Color.Transparent;
            this.star_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star_button.FlatAppearance.BorderSize = 0;
            this.star_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.star_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.star_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star_button.Location = new System.Drawing.Point(109, 151);
            this.star_button.Margin = new System.Windows.Forms.Padding(2);
            this.star_button.Name = "star_button";
            this.star_button.Size = new System.Drawing.Size(26, 24);
            this.star_button.TabIndex = 21;
            this.star_button.UseVisualStyleBackColor = false;
            // 
            // screamer_button
            // 
            this.screamer_button.BackColor = System.Drawing.Color.Transparent;
            this.screamer_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.screamer_button.FlatAppearance.BorderSize = 0;
            this.screamer_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.screamer_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.screamer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.screamer_button.Location = new System.Drawing.Point(102, 179);
            this.screamer_button.Margin = new System.Windows.Forms.Padding(2);
            this.screamer_button.Name = "screamer_button";
            this.screamer_button.Size = new System.Drawing.Size(92, 101);
            this.screamer_button.TabIndex = 22;
            this.screamer_button.UseVisualStyleBackColor = false;
            this.screamer_button.Visible = false;
            this.screamer_button.Click += new System.EventHandler(this.screamer_button_Click);
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
            this.return_button.TabIndex = 23;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // Backstage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeGameRemake.Properties.Resources.Backstage_OFF_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 612);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.screamer_button);
            this.Controls.Add(this.star_button);
            this.Controls.Add(this.computer_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Backstage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backstage";
            this.Load += new System.EventHandler(this.Backstage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button computer_button;
        private System.Windows.Forms.Button star_button;
        private System.Windows.Forms.Button screamer_button;
        public System.Windows.Forms.Button return_button;
    }
}