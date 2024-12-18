namespace Tic_Tac_Toe_3._0
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.CPUTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player1 Wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(325, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU Wins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(181, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Draws:";
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(59, 110);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(79, 77);
            this.A1.TabIndex = 3;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(181, 110);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(79, 77);
            this.A2.TabIndex = 4;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(301, 110);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(79, 77);
            this.A3.TabIndex = 5;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(59, 193);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(79, 77);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(181, 193);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(79, 77);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(301, 193);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(79, 77);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(59, 276);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(79, 77);
            this.C1.TabIndex = 3;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(181, 276);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(79, 77);
            this.C2.TabIndex = 4;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(301, 276);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(79, 77);
            this.C3.TabIndex = 5;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(169, 392);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(106, 31);
            this.button10.TabIndex = 6;
            this.button10.Text = "Restart";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.RestartGame);
            // 
            // CPUTimer
            // 
            this.CPUTimer.Interval = 1000;
            this.CPUTimer.Tick += new System.EventHandler(this.CPUmove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 459);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button A1;
        private Button A2;
        private Button A3;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button C1;
        private Button C2;
        private Button C3;
        private Button button10;
        private System.Windows.Forms.Timer CPUTimer;
    }
}