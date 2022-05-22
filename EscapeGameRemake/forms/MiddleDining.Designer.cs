
namespace EscapeGameRemake.forms
{
    partial class MiddleDining
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
            this.stage_button = new System.Windows.Forms.Button();
            this.finaldoor_button = new System.Windows.Forms.Button();
            this.arcade_button = new System.Windows.Forms.Button();
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
            this.return_button.TabIndex = 24;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // stage_button
            // 
            this.stage_button.BackColor = System.Drawing.Color.Transparent;
            this.stage_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage_button.FlatAppearance.BorderSize = 0;
            this.stage_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.stage_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stage_button.Location = new System.Drawing.Point(2, 69);
            this.stage_button.Margin = new System.Windows.Forms.Padding(2);
            this.stage_button.Name = "stage_button";
            this.stage_button.Size = new System.Drawing.Size(301, 442);
            this.stage_button.TabIndex = 25;
            this.stage_button.UseVisualStyleBackColor = false;
            this.stage_button.Click += new System.EventHandler(this.stage_button_Click);
            // 
            // finaldoor_button
            // 
            this.finaldoor_button.BackColor = System.Drawing.Color.Transparent;
            this.finaldoor_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finaldoor_button.FlatAppearance.BorderSize = 0;
            this.finaldoor_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.finaldoor_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.finaldoor_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finaldoor_button.Location = new System.Drawing.Point(415, 260);
            this.finaldoor_button.Margin = new System.Windows.Forms.Padding(2);
            this.finaldoor_button.Name = "finaldoor_button";
            this.finaldoor_button.Size = new System.Drawing.Size(86, 166);
            this.finaldoor_button.TabIndex = 26;
            this.finaldoor_button.UseVisualStyleBackColor = false;
            this.finaldoor_button.Click += new System.EventHandler(this.finaldoor_button_Click);
            // 
            // arcade_button
            // 
            this.arcade_button.BackColor = System.Drawing.Color.Transparent;
            this.arcade_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arcade_button.FlatAppearance.BorderSize = 0;
            this.arcade_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.arcade_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.arcade_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arcade_button.Location = new System.Drawing.Point(850, 251);
            this.arcade_button.Margin = new System.Windows.Forms.Padding(2);
            this.arcade_button.Name = "arcade_button";
            this.arcade_button.Size = new System.Drawing.Size(260, 166);
            this.arcade_button.TabIndex = 27;
            this.arcade_button.UseVisualStyleBackColor = false;
            this.arcade_button.Click += new System.EventHandler(this.arcade_button_Click);
            // 
            // MiddleDining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeGameRemake.Properties.Resources.MiddleDining_OFF_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 612);
            this.Controls.Add(this.arcade_button);
            this.Controls.Add(this.finaldoor_button);
            this.Controls.Add(this.stage_button);
            this.Controls.Add(this.return_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MiddleDining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiddleDining";
            this.Load += new System.EventHandler(this.MiddleDining_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button stage_button;
        private System.Windows.Forms.Button finaldoor_button;
        private System.Windows.Forms.Button arcade_button;
    }
}