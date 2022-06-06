namespace QuickSortVisualization
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RS_button = new System.Windows.Forms.Button();
            this.QS_button = new System.Windows.Forms.Button();
            this.BS_button = new System.Windows.Forms.Button();
            this.VrijemeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(26, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(843, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RS_button
            // 
            this.RS_button.Location = new System.Drawing.Point(744, 57);
            this.RS_button.Name = "RS_button";
            this.RS_button.Size = new System.Drawing.Size(125, 31);
            this.RS_button.TabIndex = 1;
            this.RS_button.Text = "Random Shuffle";
            this.RS_button.UseVisualStyleBackColor = true;
            this.RS_button.Click += new System.EventHandler(this.RS_button_Click);
            // 
            // QS_button
            // 
            this.QS_button.Location = new System.Drawing.Point(26, 57);
            this.QS_button.Name = "QS_button";
            this.QS_button.Size = new System.Drawing.Size(103, 31);
            this.QS_button.TabIndex = 2;
            this.QS_button.Text = "QuickSort";
            this.QS_button.UseVisualStyleBackColor = true;
            this.QS_button.Click += new System.EventHandler(this.QS_button_Click);
            // 
            // BS_button
            // 
            this.BS_button.Location = new System.Drawing.Point(135, 57);
            this.BS_button.Name = "BS_button";
            this.BS_button.Size = new System.Drawing.Size(103, 31);
            this.BS_button.TabIndex = 3;
            this.BS_button.Text = "BubbleSort";
            this.BS_button.UseVisualStyleBackColor = true;
            this.BS_button.Click += new System.EventHandler(this.BS_button_Click);
            // 
            // VrijemeLabel
            // 
            this.VrijemeLabel.AutoSize = true;
            this.VrijemeLabel.Location = new System.Drawing.Point(23, 451);
            this.VrijemeLabel.Name = "VrijemeLabel";
            this.VrijemeLabel.Size = new System.Drawing.Size(59, 17);
            this.VrijemeLabel.TabIndex = 4;
            this.VrijemeLabel.Text = "Vrijeme:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Broj poziva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Broj zamijena: ";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(290, 57);
            this.trackBar1.Maximum = 250;
            this.trackBar1.Minimum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(274, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Brzina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(917, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VrijemeLabel);
            this.Controls.Add(this.BS_button);
            this.Controls.Add(this.QS_button);
            this.Controls.Add(this.RS_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "QuckSort Visualization";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RS_button;
        private System.Windows.Forms.Button QS_button;
        private System.Windows.Forms.Button BS_button;
        private System.Windows.Forms.Label VrijemeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
    }
}

