namespace Elektron_saat
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(160, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 157);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(441, 63);
            label5.Name = "label5";
            label5.Size = new Size(34, 39);
            label5.TabIndex = 4;
            label5.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(356, 63);
            label4.Name = "label4";
            label4.Size = new Size(28, 38);
            label4.TabIndex = 3;
            label4.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(257, 63);
            label3.Name = "label3";
            label3.Size = new Size(34, 39);
            label3.TabIndex = 2;
            label3.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(149, 63);
            label2.Name = "label2";
            label2.Size = new Size(28, 38);
            label2.TabIndex = 1;
            label2.Text = ":";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(41, 63);
            label1.Name = "label1";
            label1.Size = new Size(34, 39);
            label1.TabIndex = 0;
            label1.Text = "0";
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(365, 315);
            button1.Name = "button1";
            button1.Size = new Size(145, 41);
            button1.TabIndex = 1;
            button1.Text = "Saat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 453);
            Controls.Add(button1);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}
