namespace PSgenerator
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
            this.title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pass_len = new System.Windows.Forms.TextBox();
            this.demo_txt = new System.Windows.Forms.Label();
            this.ran_pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(26, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(149, 34);
            this.title.TabIndex = 0;
            this.title.Text = "PSgenerator";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(184, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "GENERATE PASSWORD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pass_len
            // 
            this.pass_len.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pass_len.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass_len.Location = new System.Drawing.Point(242, 102);
            this.pass_len.MaxLength = 300;
            this.pass_len.Name = "pass_len";
            this.pass_len.Size = new System.Drawing.Size(37, 20);
            this.pass_len.TabIndex = 3;
            // 
            // demo_txt
            // 
            this.demo_txt.AutoSize = true;
            this.demo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demo_txt.Location = new System.Drawing.Point(164, 72);
            this.demo_txt.Name = "demo_txt";
            this.demo_txt.Size = new System.Drawing.Size(199, 13);
            this.demo_txt.TabIndex = 4;
            this.demo_txt.Text = "Ender below the lenght of your password";
            // 
            // ran_pass
            // 
            this.ran_pass.AutoSize = true;
            this.ran_pass.Location = new System.Drawing.Point(222, 183);
            this.ran_pass.Name = "ran_pass";
            this.ran_pass.Size = new System.Drawing.Size(0, 13);
            this.ran_pass.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 264);
            this.Controls.Add(this.ran_pass);
            this.Controls.Add(this.demo_txt);
            this.Controls.Add(this.pass_len);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(562, 303);
            this.MinimumSize = new System.Drawing.Size(562, 303);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSgenerator";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pass_len;
        private System.Windows.Forms.Label demo_txt;
        private System.Windows.Forms.Label ran_pass;
    }
}

