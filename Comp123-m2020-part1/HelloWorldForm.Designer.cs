﻿namespace Comp123_m2020_part1
{
    partial class HelloWorldForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WelcomeLabel.Location = new System.Drawing.Point(231, 190);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(178, 47);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Hello, World!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClickMeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ClickMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ClickMeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ClickMeButton.Location = new System.Drawing.Point(241, 268);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(158, 43);
            this.ClickMeButton.TabIndex = 1;
            this.ClickMeButton.Text = "Click Me!";
            this.ClickMeButton.UseVisualStyleBackColor = false;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.ClickMeButton);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HelloWorldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ClickMeButton;
    }
}

