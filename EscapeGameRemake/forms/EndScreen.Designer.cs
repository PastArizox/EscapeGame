
namespace EscapeGameRemake.forms
{
    partial class EndScreen
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
            this.back_button = new System.Windows.Forms.Button();
            this.nose_honk_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Location = new System.Drawing.Point(208, 547);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(677, 42);
            this.back_button.TabIndex = 4;
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // nose_honk_button
            // 
            this.nose_honk_button.BackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.nose_honk_button.FlatAppearance.BorderSize = 0;
            this.nose_honk_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nose_honk_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nose_honk_button.Location = new System.Drawing.Point(543, 285);
            this.nose_honk_button.Margin = new System.Windows.Forms.Padding(2);
            this.nose_honk_button.Name = "nose_honk_button";
            this.nose_honk_button.Size = new System.Drawing.Size(29, 15);
            this.nose_honk_button.TabIndex = 5;
            this.nose_honk_button.UseVisualStyleBackColor = false;
            this.nose_honk_button.Visible = false;
            this.nose_honk_button.Click += new System.EventHandler(this.nose_honk_button_Click);
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeGameRemake.Properties.Resources.EndScreen_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 612);
            this.Controls.Add(this.nose_honk_button);
            this.Controls.Add(this.back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EndScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndScreen_background";
            this.Load += new System.EventHandler(this.EndScreen_background_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button nose_honk_button;
    }
}