﻿
namespace EscapeGameRemake.forms
{
    partial class Office
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
            this.desk_button = new System.Windows.Forms.Button();
            this.digicode_button = new System.Windows.Forms.Button();
            this.door_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.chest_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // desk_button
            // 
            this.desk_button.BackColor = System.Drawing.Color.Transparent;
            this.desk_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desk_button.FlatAppearance.BorderSize = 0;
            this.desk_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.desk_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.desk_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desk_button.Location = new System.Drawing.Point(386, 259);
            this.desk_button.Margin = new System.Windows.Forms.Padding(2);
            this.desk_button.Name = "desk_button";
            this.desk_button.Size = new System.Drawing.Size(346, 151);
            this.desk_button.TabIndex = 11;
            this.desk_button.UseVisualStyleBackColor = false;
            this.desk_button.Click += new System.EventHandler(this.desk_button_Click);
            // 
            // digicode_button
            // 
            this.digicode_button.BackColor = System.Drawing.Color.Transparent;
            this.digicode_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.digicode_button.FlatAppearance.BorderSize = 0;
            this.digicode_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.digicode_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.digicode_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digicode_button.Location = new System.Drawing.Point(98, 398);
            this.digicode_button.Margin = new System.Windows.Forms.Padding(2);
            this.digicode_button.Name = "digicode_button";
            this.digicode_button.Size = new System.Drawing.Size(43, 128);
            this.digicode_button.TabIndex = 10;
            this.digicode_button.UseVisualStyleBackColor = false;
            this.digicode_button.Click += new System.EventHandler(this.digicode_button_Click);
            // 
            // door_button
            // 
            this.door_button.BackColor = System.Drawing.Color.Transparent;
            this.door_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.door_button.FlatAppearance.BorderSize = 0;
            this.door_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.door_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.door_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door_button.Location = new System.Drawing.Point(154, 94);
            this.door_button.Margin = new System.Windows.Forms.Padding(2);
            this.door_button.Name = "door_button";
            this.door_button.Size = new System.Drawing.Size(147, 515);
            this.door_button.TabIndex = 9;
            this.door_button.UseVisualStyleBackColor = false;
            this.door_button.Visible = false;
            this.door_button.Click += new System.EventHandler(this.door_button_Click);
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
            this.return_button.TabIndex = 12;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // chest_button
            // 
            this.chest_button.BackColor = System.Drawing.Color.Transparent;
            this.chest_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chest_button.FlatAppearance.BorderSize = 0;
            this.chest_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chest_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chest_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chest_button.Location = new System.Drawing.Point(421, 474);
            this.chest_button.Margin = new System.Windows.Forms.Padding(2);
            this.chest_button.Name = "chest_button";
            this.chest_button.Size = new System.Drawing.Size(59, 32);
            this.chest_button.TabIndex = 13;
            this.chest_button.UseVisualStyleBackColor = false;
            this.chest_button.Click += new System.EventHandler(this.chest_button_Click);
            // 
            // Office
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeGameRemake.Properties.Resources.Office_OFF_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 612);
            this.Controls.Add(this.chest_button);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.desk_button);
            this.Controls.Add(this.digicode_button);
            this.Controls.Add(this.door_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Office";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Office";
            this.Load += new System.EventHandler(this.Office_Load);
            this.Shown += new System.EventHandler(this.Office_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button desk_button;
        public System.Windows.Forms.Button digicode_button;
        private System.Windows.Forms.Button door_button;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button chest_button;
    }
}