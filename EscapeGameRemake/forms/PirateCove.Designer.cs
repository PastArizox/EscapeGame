
namespace EscapeGameRemake.forms
{
    partial class PirateCove
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
            this.openable_button = new System.Windows.Forms.Button();
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
            this.return_button.TabIndex = 15;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // openable_button
            // 
            this.openable_button.BackColor = System.Drawing.Color.Transparent;
            this.openable_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openable_button.FlatAppearance.BorderSize = 0;
            this.openable_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openable_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.openable_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openable_button.Location = new System.Drawing.Point(452, 148);
            this.openable_button.Margin = new System.Windows.Forms.Padding(2);
            this.openable_button.Name = "openable_button";
            this.openable_button.Size = new System.Drawing.Size(175, 285);
            this.openable_button.TabIndex = 20;
            this.openable_button.UseVisualStyleBackColor = false;
            this.openable_button.Click += new System.EventHandler(this.openable_button_Click);
            // 
            // eye_button
            // 
            this.eye_button.BackColor = System.Drawing.Color.Transparent;
            this.eye_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eye_button.FlatAppearance.BorderSize = 0;
            this.eye_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eye_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eye_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eye_button.Location = new System.Drawing.Point(508, 176);
            this.eye_button.Margin = new System.Windows.Forms.Padding(2);
            this.eye_button.Name = "eye_button";
            this.eye_button.Size = new System.Drawing.Size(29, 27);
            this.eye_button.TabIndex = 21;
            this.eye_button.UseVisualStyleBackColor = false;
            // 
            // PirateCove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeGameRemake.Properties.Resources.PirateCove_OFF_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 612);
            this.Controls.Add(this.eye_button);
            this.Controls.Add(this.openable_button);
            this.Controls.Add(this.return_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PirateCove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PirateCove";
            this.Load += new System.EventHandler(this.PirateCove_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button openable_button;
        private System.Windows.Forms.Button eye_button;
    }
}