
namespace EscapeGameRemake.forms
{
    partial class Closet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Closet));
            this.return_button = new System.Windows.Forms.Button();
            this.map_button = new System.Windows.Forms.Button();
            this.key_button = new System.Windows.Forms.Button();
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
            this.return_button.TabIndex = 14;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // map_button
            // 
            this.map_button.BackColor = System.Drawing.Color.Transparent;
            this.map_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.map_button.FlatAppearance.BorderSize = 0;
            this.map_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.map_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.map_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.map_button.Location = new System.Drawing.Point(193, 146);
            this.map_button.Margin = new System.Windows.Forms.Padding(2);
            this.map_button.Name = "map_button";
            this.map_button.Size = new System.Drawing.Size(351, 137);
            this.map_button.TabIndex = 16;
            this.map_button.UseVisualStyleBackColor = false;
            this.map_button.Click += new System.EventHandler(this.map_button_Click);
            // 
            // key_button
            // 
            this.key_button.BackColor = System.Drawing.Color.Transparent;
            this.key_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_button.FlatAppearance.BorderSize = 0;
            this.key_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.key_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.key_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_button.Location = new System.Drawing.Point(347, 494);
            this.key_button.Margin = new System.Windows.Forms.Padding(2);
            this.key_button.Name = "key_button";
            this.key_button.Size = new System.Drawing.Size(33, 14);
            this.key_button.TabIndex = 27;
            this.key_button.UseVisualStyleBackColor = false;
            this.key_button.Click += new System.EventHandler(this.key_button_Click);
            // 
            // Closet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 612);
            this.Controls.Add(this.key_button);
            this.Controls.Add(this.map_button);
            this.Controls.Add(this.return_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Closet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Closet";
            this.Load += new System.EventHandler(this.Closet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button map_button;
        private System.Windows.Forms.Button key_button;
    }
}