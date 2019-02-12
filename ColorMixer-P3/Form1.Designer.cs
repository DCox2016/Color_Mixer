namespace ColorMixer_P3
{
    partial class ColorForm
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
            this.colorGroup2 = new System.Windows.Forms.GroupBox();
            this.redButton2 = new System.Windows.Forms.RadioButton();
            this.blueButton2 = new System.Windows.Forms.RadioButton();
            this.yellowButton2 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorGroup1 = new System.Windows.Forms.GroupBox();
            this.redButton1 = new System.Windows.Forms.RadioButton();
            this.blueButton1 = new System.Windows.Forms.RadioButton();
            this.yellowButton1 = new System.Windows.Forms.RadioButton();
            this.mixButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.colorGroup2.SuspendLayout();
            this.colorGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGroup2
            // 
            this.colorGroup2.Controls.Add(this.redButton2);
            this.colorGroup2.Controls.Add(this.blueButton2);
            this.colorGroup2.Controls.Add(this.yellowButton2);
            this.colorGroup2.Location = new System.Drawing.Point(432, 50);
            this.colorGroup2.Name = "colorGroup2";
            this.colorGroup2.Size = new System.Drawing.Size(268, 242);
            this.colorGroup2.TabIndex = 0;
            this.colorGroup2.TabStop = false;
            this.colorGroup2.Text = "Select the Second Color";
            // 
            // redButton2
            // 
            this.redButton2.AutoSize = true;
            this.redButton2.Location = new System.Drawing.Point(50, 68);
            this.redButton2.Name = "redButton2";
            this.redButton2.Size = new System.Drawing.Size(82, 29);
            this.redButton2.TabIndex = 5;
            this.redButton2.TabStop = true;
            this.redButton2.Text = "Red";
            this.redButton2.UseVisualStyleBackColor = true;
            // 
            // blueButton2
            // 
            this.blueButton2.AutoSize = true;
            this.blueButton2.Location = new System.Drawing.Point(50, 122);
            this.blueButton2.Name = "blueButton2";
            this.blueButton2.Size = new System.Drawing.Size(86, 29);
            this.blueButton2.TabIndex = 6;
            this.blueButton2.TabStop = true;
            this.blueButton2.Text = "Blue";
            this.blueButton2.UseVisualStyleBackColor = true;
            // 
            // yellowButton2
            // 
            this.yellowButton2.AutoSize = true;
            this.yellowButton2.Location = new System.Drawing.Point(50, 176);
            this.yellowButton2.Name = "yellowButton2";
            this.yellowButton2.Size = new System.Drawing.Size(107, 29);
            this.yellowButton2.TabIndex = 7;
            this.yellowButton2.TabStop = true;
            this.yellowButton2.Text = "Yellow";
            this.yellowButton2.UseVisualStyleBackColor = true;
            // 
            // colorGroup1
            // 
            this.colorGroup1.Controls.Add(this.redButton1);
            this.colorGroup1.Controls.Add(this.blueButton1);
            this.colorGroup1.Controls.Add(this.yellowButton1);
            this.colorGroup1.Location = new System.Drawing.Point(117, 50);
            this.colorGroup1.Name = "colorGroup1";
            this.colorGroup1.Size = new System.Drawing.Size(250, 242);
            this.colorGroup1.TabIndex = 1;
            this.colorGroup1.TabStop = false;
            this.colorGroup1.Text = "Select the First Color";
            // 
            // redButton1
            // 
            this.redButton1.AutoSize = true;
            this.redButton1.Location = new System.Drawing.Point(39, 68);
            this.redButton1.Name = "redButton1";
            this.redButton1.Size = new System.Drawing.Size(82, 29);
            this.redButton1.TabIndex = 2;
            this.redButton1.TabStop = true;
            this.redButton1.Text = "Red";
            this.redButton1.UseVisualStyleBackColor = true;
            // 
            // blueButton1
            // 
            this.blueButton1.AutoSize = true;
            this.blueButton1.Location = new System.Drawing.Point(39, 122);
            this.blueButton1.Name = "blueButton1";
            this.blueButton1.Size = new System.Drawing.Size(86, 29);
            this.blueButton1.TabIndex = 3;
            this.blueButton1.TabStop = true;
            this.blueButton1.Text = "Blue";
            this.blueButton1.UseVisualStyleBackColor = true;
            // 
            // yellowButton1
            // 
            this.yellowButton1.AutoSize = true;
            this.yellowButton1.Location = new System.Drawing.Point(39, 176);
            this.yellowButton1.Name = "yellowButton1";
            this.yellowButton1.Size = new System.Drawing.Size(107, 29);
            this.yellowButton1.TabIndex = 4;
            this.yellowButton1.TabStop = true;
            this.yellowButton1.Text = "Yellow";
            this.yellowButton1.UseVisualStyleBackColor = true;
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(228, 318);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(159, 59);
            this.mixButton.TabIndex = 2;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(405, 318);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(159, 59);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.colorGroup1);
            this.Controls.Add(this.colorGroup2);
            this.Name = "ColorForm";
            this.Text = "Color Mixer";
            this.Load += new System.EventHandler(this.ColorForm_Load);
            this.colorGroup2.ResumeLayout(false);
            this.colorGroup2.PerformLayout();
            this.colorGroup1.ResumeLayout(false);
            this.colorGroup1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox colorGroup2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox colorGroup1;
        private System.Windows.Forms.RadioButton redButton2;
        private System.Windows.Forms.RadioButton blueButton2;
        private System.Windows.Forms.RadioButton yellowButton2;
        private System.Windows.Forms.RadioButton redButton1;
        private System.Windows.Forms.RadioButton blueButton1;
        private System.Windows.Forms.RadioButton yellowButton1;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.Button exitButton;
    }
}

