
namespace EscapeGameRemake.forms
{
    partial class Chest
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
            this.key1_button = new System.Windows.Forms.Button();
            this.key2_button = new System.Windows.Forms.Button();
            this.eye_button = new System.Windows.Forms.Button();
            this.paper_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // key1_button
            // 
            this.key1_button.BackColor = System.Drawing.Color.Transparent;
            this.key1_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key1_button.FlatAppearance.BorderSize = 0;
            this.key1_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key1_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key1_button.Location = new System.Drawing.Point(448, 453);
            this.key1_button.Margin = new System.Windows.Forms.Padding(2);
            this.key1_button.Name = "key1_button";
            this.key1_button.Size = new System.Drawing.Size(31, 66);
            this.key1_button.TabIndex = 19;
            this.key1_button.UseVisualStyleBackColor = false;
            this.key1_button.Click += new System.EventHandler(this.key1_button_Click);
            // 
            // key2_button
            // 
            this.key2_button.BackColor = System.Drawing.Color.Transparent;
            this.key2_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key2_button.FlatAppearance.BorderSize = 0;
            this.key2_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key2_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key2_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key2_button.Location = new System.Drawing.Point(611, 454);
            this.key2_button.Margin = new System.Windows.Forms.Padding(2);
            this.key2_button.Name = "key2_button";
            this.key2_button.Size = new System.Drawing.Size(31, 66);
            this.key2_button.TabIndex = 20;
            this.key2_button.UseVisualStyleBackColor = false;
            this.key2_button.Click += new System.EventHandler(this.key2_button_Click);
            // 
            // eye_button
            // 
            this.eye_button.BackColor = System.Drawing.Color.Transparent;
            this.eye_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eye_button.FlatAppearance.BorderSize = 0;
            this.eye_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eye_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eye_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eye_button.Location = new System.Drawing.Point(671, 340);
            this.eye_button.Margin = new System.Windows.Forms.Padding(2);
            this.eye_button.Name = "eye_button";
            this.eye_button.Size = new System.Drawing.Size(118, 103);
            this.eye_button.TabIndex = 21;
            this.eye_button.UseVisualStyleBackColor = false;
            this.eye_button.Visible = false;
            this.eye_button.Click += new System.EventHandler(this.eye_button_Click);
            // 
            // paper_button
            // 
            this.paper_button.BackColor = System.Drawing.Color.Transparent;
            this.paper_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paper_button.FlatAppearance.BorderSize = 0;
            this.paper_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.paper_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.paper_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paper_button.Location = new System.Drawing.Point(372, 319);
            this.paper_button.Margin = new System.Windows.Forms.Padding(2);
            this.paper_button.Name = "paper_button";
            this.paper_button.Size = new System.Drawing.Size(163, 124);
            this.paper_button.TabIndex = 22;
            this.paper_button.UseVisualStyleBackColor = false;
            this.paper_button.Visible = false;
            this.paper_button.Click += new System.EventHandler(this.paper_button_Click);
            // 
            // Chest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImage = global::EscapeGameRemake.Properties.Resources.Chest_OFF_OFF;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 651);
            this.Controls.Add(this.paper_button);
            this.Controls.Add(this.eye_button);
            this.Controls.Add(this.key2_button);
            this.Controls.Add(this.key1_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Chest";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chest";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Chest_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Chest_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button key1_button;
        private System.Windows.Forms.Button key2_button;
        private System.Windows.Forms.Button eye_button;
        private System.Windows.Forms.Button paper_button;
    }
}