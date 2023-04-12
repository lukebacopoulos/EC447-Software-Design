namespace Lab6v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Filename_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Key_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Browse_button = new System.Windows.Forms.Button();
            this.Enc_button = new System.Windows.Forms.Button();
            this.Dec_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Filename_box
            // 
            this.Filename_box.Location = new System.Drawing.Point(38, 60);
            this.Filename_box.Name = "Filename_box";
            this.Filename_box.Size = new System.Drawing.Size(308, 27);
            this.Filename_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name:";
            // 
            // Key_box
            // 
            this.Key_box.Location = new System.Drawing.Point(38, 133);
            this.Key_box.Name = "Key_box";
            this.Key_box.Size = new System.Drawing.Size(137, 27);
            this.Key_box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key:";
            // 
            // Browse_button
            // 
            this.Browse_button.Location = new System.Drawing.Point(364, 60);
            this.Browse_button.Name = "Browse_button";
            this.Browse_button.Size = new System.Drawing.Size(82, 27);
            this.Browse_button.TabIndex = 4;
            this.Browse_button.Text = "Browse";
            this.Browse_button.UseVisualStyleBackColor = true;
            this.Browse_button.Click += new System.EventHandler(this.Browse_button_Click);
            // 
            // Enc_button
            // 
            this.Enc_button.Location = new System.Drawing.Point(38, 190);
            this.Enc_button.Name = "Enc_button";
            this.Enc_button.Size = new System.Drawing.Size(91, 27);
            this.Enc_button.TabIndex = 5;
            this.Enc_button.Text = "Encrypt";
            this.Enc_button.UseVisualStyleBackColor = true;
            this.Enc_button.Click += new System.EventHandler(this.Enc_button_Click);
            // 
            // Dec_button
            // 
            this.Dec_button.Location = new System.Drawing.Point(159, 190);
            this.Dec_button.Name = "Dec_button";
            this.Dec_button.Size = new System.Drawing.Size(98, 27);
            this.Dec_button.TabIndex = 6;
            this.Dec_button.Text = "Decrypt";
            this.Dec_button.UseVisualStyleBackColor = true;
            this.Dec_button.Click += new System.EventHandler(this.Dec_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 297);
            this.Controls.Add(this.Dec_button);
            this.Controls.Add(this.Enc_button);
            this.Controls.Add(this.Browse_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Key_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filename_box);
            this.Name = "Form1";
            this.Text = "File Encrypt/Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Filename_box;
        private Label label1;
        private TextBox Key_box;
        private Label label2;
        private Button Browse_button;
        private Button Enc_button;
        private Button Dec_button;
    }
}