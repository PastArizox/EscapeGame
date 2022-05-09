
namespace EscapeGameRemake.forms
{
    partial class Coridoor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coridoor));
            this.return_button = new System.Windows.Forms.Button();
            this.closet_button = new System.Windows.Forms.Button();
            this.dining_button = new System.Windows.Forms.Button();
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
            this.return_button.TabIndex = 13;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // closet_button
            // 
            this.closet_button.BackColor = System.Drawing.Color.Transparent;
            this.closet_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closet_button.FlatAppearance.BorderSize = 0;
            this.closet_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closet_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closet_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closet_button.Location = new System.Drawing.Point(440, 212);
            this.closet_button.Margin = new System.Windows.Forms.Padding(2);
            this.closet_button.Name = "closet_button";
            this.closet_button.Size = new System.Drawing.Size(24, 220);
            this.closet_button.TabIndex = 14;
            this.closet_button.UseVisualStyleBackColor = false;
            this.closet_button.Click += new System.EventHandler(this.closet_button_Click);
            // 
            // dining_button
            // 
            this.dining_button.BackColor = System.Drawing.Color.Transparent;
            this.dining_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dining_button.FlatAppearance.BorderSize = 0;
            this.dining_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dining_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dining_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dining_button.Location = new System.Drawing.Point(495, 200);
            this.dining_button.Margin = new System.Windows.Forms.Padding(2);
            this.dining_button.Name = "dining_button";
            this.dining_button.Size = new System.Drawing.Size(194, 254);
            this.dining_button.TabIndex = 15;
            this.dining_button.UseVisualStyleBackColor = false;
            this.dining_button.Click += new System.EventHandler(this.dining_button_Click);
            // 
            // Coridoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 612);
            this.Controls.Add(this.dining_button);
            this.Controls.Add(this.closet_button);
            this.Controls.Add(this.return_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Coridoor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coridoor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button closet_button;
        private System.Windows.Forms.Button dining_button;
    }
}