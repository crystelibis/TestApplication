namespace TestApp {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(407, 58);
            button1.Name = "button1";
            button1.Size = new Size(381, 29);
            button1.TabIndex = 0;
            button1.Text = "Execute";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 211);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(675, 185);
            textBox2.TabIndex = 2;
            textBox2.Text = "Status: Calculation is not started.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(407, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "100";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(699, 401);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(50, 27);
            textBox3.TabIndex = 12;
            textBox3.ReadOnly = true;
            // 
            // button2
            // 
            button2.Location = new Point(514, 12);
            button2.Name = "button2";
            button2.Size = new Size(274, 29);
            button2.TabIndex = 4;
            button2.Text = "Generate Files";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(407, 93);
            button3.Name = "button3";
            button3.Size = new Size(381, 29);
            button3.TabIndex = 5;
            button3.Text = "Show current result";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(407, 128);
            button4.Name = "button4";
            button4.Size = new Size(381, 29);
            button4.TabIndex = 6;
            button4.Text = "Show result";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(298, 20);
            label1.TabIndex = 7;
            label1.Text = "1. Enter files count and click 'Generate Files':";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(246, 20);
            label2.TabIndex = 8;
            label2.Text = "2. Click 'Execute' to start calculation:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 188);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 9;
            label3.Text = "Results Window:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 93);
            label4.Name = "label4";
            label4.Size = new Size(385, 20);
            label4.TabIndex = 10;
            label4.Text = "3. Click 'Show current result' to show intermediate results:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 132);
            label5.Name = "label5";
            label5.Size = new Size(389, 20);
            label5.TabIndex = 11;
            label5.Text = "OR click 'Show result' to show results after full calculation:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Name = "Form1";
            Text = "File content calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}