namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.labelScore = new System.Windows.Forms.Label();
            this.ActiveScorelabel2 = new System.Windows.Forms.Label();
            this.FirstNumlabel3 = new System.Windows.Forms.Label();
            this.Multiplerlabel4 = new System.Windows.Forms.Label();
            this.SecondNumlabel5 = new System.Windows.Forms.Label();
            this.Timerlabel6 = new System.Windows.Forms.Label();
            this.AnswertextBox1 = new System.Windows.Forms.TextBox();
            this.Donebutton1 = new System.Windows.Forms.Button();
            this.Startbutton2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Orange;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(71, 77);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(147, 55);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "score";
            // 
            // ActiveScorelabel2
            // 
            this.ActiveScorelabel2.AutoSize = true;
            this.ActiveScorelabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ActiveScorelabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveScorelabel2.Location = new System.Drawing.Point(237, 77);
            this.ActiveScorelabel2.Name = "ActiveScorelabel2";
            this.ActiveScorelabel2.Size = new System.Drawing.Size(52, 55);
            this.ActiveScorelabel2.TabIndex = 1;
            this.ActiveScorelabel2.Text = "0";
            // 
            // FirstNumlabel3
            // 
            this.FirstNumlabel3.AutoSize = true;
            this.FirstNumlabel3.BackColor = System.Drawing.Color.Yellow;
            this.FirstNumlabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumlabel3.Location = new System.Drawing.Point(501, 302);
            this.FirstNumlabel3.Name = "FirstNumlabel3";
            this.FirstNumlabel3.Size = new System.Drawing.Size(69, 73);
            this.FirstNumlabel3.TabIndex = 2;
            this.FirstNumlabel3.Text = "0";
            // 
            // Multiplerlabel4
            // 
            this.Multiplerlabel4.AutoSize = true;
            this.Multiplerlabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Multiplerlabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplerlabel4.Location = new System.Drawing.Point(650, 302);
            this.Multiplerlabel4.Name = "Multiplerlabel4";
            this.Multiplerlabel4.Size = new System.Drawing.Size(58, 73);
            this.Multiplerlabel4.TabIndex = 3;
            this.Multiplerlabel4.Text = "*";
            // 
            // SecondNumlabel5
            // 
            this.SecondNumlabel5.AutoSize = true;
            this.SecondNumlabel5.BackColor = System.Drawing.Color.Yellow;
            this.SecondNumlabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNumlabel5.Location = new System.Drawing.Point(774, 302);
            this.SecondNumlabel5.Name = "SecondNumlabel5";
            this.SecondNumlabel5.Size = new System.Drawing.Size(69, 73);
            this.SecondNumlabel5.TabIndex = 4;
            this.SecondNumlabel5.Text = "0";
            // 
            // Timerlabel6
            // 
            this.Timerlabel6.AutoSize = true;
            this.Timerlabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Timerlabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timerlabel6.Location = new System.Drawing.Point(1076, 77);
            this.Timerlabel6.Name = "Timerlabel6";
            this.Timerlabel6.Size = new System.Drawing.Size(52, 55);
            this.Timerlabel6.TabIndex = 5;
            this.Timerlabel6.Text = "0";
            // 
            // AnswertextBox1
            // 
            this.AnswertextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswertextBox1.Location = new System.Drawing.Point(514, 438);
            this.AnswertextBox1.Name = "AnswertextBox1";
            this.AnswertextBox1.Size = new System.Drawing.Size(295, 62);
            this.AnswertextBox1.TabIndex = 6;
            // 
            // Donebutton1
            // 
            this.Donebutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Donebutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donebutton1.Location = new System.Drawing.Point(592, 545);
            this.Donebutton1.Name = "Donebutton1";
            this.Donebutton1.Size = new System.Drawing.Size(159, 69);
            this.Donebutton1.TabIndex = 7;
            this.Donebutton1.Text = "Done";
            this.Donebutton1.UseVisualStyleBackColor = false;
            this.Donebutton1.Click += new System.EventHandler(this.Donebutton1_Click);
            // 
            // Startbutton2
            // 
            this.Startbutton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Startbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbutton2.Location = new System.Drawing.Point(592, 646);
            this.Startbutton2.Name = "Startbutton2";
            this.Startbutton2.Size = new System.Drawing.Size(159, 66);
            this.Startbutton2.TabIndex = 8;
            this.Startbutton2.Text = "Start";
            this.Startbutton2.UseVisualStyleBackColor = false;
            this.Startbutton2.Click += new System.EventHandler(this.Startbutton2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(522, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 106);
            this.label1.TabIndex = 9;
            this.label1.Text = "MATH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 80);
            this.label2.TabIndex = 10;
            this.label2.Text = "QUIZ GAME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.pieces_math_puzzle_scattered_background_pieces_math_puzzle_scattered_blue_background_1062966161;
            this.ClientSize = new System.Drawing.Size(1257, 738);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Startbutton2);
            this.Controls.Add(this.Donebutton1);
            this.Controls.Add(this.AnswertextBox1);
            this.Controls.Add(this.Timerlabel6);
            this.Controls.Add(this.SecondNumlabel5);
            this.Controls.Add(this.Multiplerlabel4);
            this.Controls.Add(this.FirstNumlabel3);
            this.Controls.Add(this.ActiveScorelabel2);
            this.Controls.Add(this.labelScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label ActiveScorelabel2;
        private System.Windows.Forms.Label FirstNumlabel3;
        private System.Windows.Forms.Label Multiplerlabel4;
        private System.Windows.Forms.Label SecondNumlabel5;
        private System.Windows.Forms.Label Timerlabel6;
        private System.Windows.Forms.TextBox AnswertextBox1;
        private System.Windows.Forms.Button Donebutton1;
        private System.Windows.Forms.Button Startbutton2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

