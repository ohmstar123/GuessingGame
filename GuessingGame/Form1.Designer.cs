﻿namespace GuessingGame
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.picknumberLabel = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.Location = new System.Drawing.Point(292, 78);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(209, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Guessing Game";
            // 
            // picknumberLabel
            // 
            this.picknumberLabel.AutoSize = true;
            this.picknumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picknumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.picknumberLabel.Location = new System.Drawing.Point(238, 145);
            this.picknumberLabel.Name = "picknumberLabel";
            this.picknumberLabel.Size = new System.Drawing.Size(306, 24);
            this.picknumberLabel.TabIndex = 1;
            this.picknumberLabel.Text = "Enter a number between 1 and 100";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(375, 216);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(40, 20);
            this.Input.TabIndex = 2;
            // 
            // guessButton
            // 
            this.guessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guessButton.ForeColor = System.Drawing.SystemColors.Control;
            this.guessButton.Location = new System.Drawing.Point(331, 260);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(124, 50);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-1, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 70);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.picknumberLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label picknumberLabel;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label label1;
    }
}
