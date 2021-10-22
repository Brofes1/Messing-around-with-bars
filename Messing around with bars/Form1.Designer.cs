namespace Messing_around_with_bars
{
    partial class BarProgram
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
            this.test = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maxdisplay = new System.Windows.Forms.TextBox();
            this.othermaxdisplay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HP = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.HPbigger = new System.Windows.Forms.ProgressBar();
            this.maxbigger = new System.Windows.Forms.ProgressBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(40, 31);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(373, 10);
            this.test.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Inc.Max";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // maxdisplay
            // 
            this.maxdisplay.Location = new System.Drawing.Point(125, 130);
            this.maxdisplay.Name = "maxdisplay";
            this.maxdisplay.Size = new System.Drawing.Size(100, 20);
            this.maxdisplay.TabIndex = 12;
            this.maxdisplay.Visible = false;
            // 
            // othermaxdisplay
            // 
            this.othermaxdisplay.Location = new System.Drawing.Point(286, 130);
            this.othermaxdisplay.Name = "othermaxdisplay";
            this.othermaxdisplay.Size = new System.Drawing.Size(100, 20);
            this.othermaxdisplay.TabIndex = 13;
            this.othermaxdisplay.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "max";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "maxinbar";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "HP";
            // 
            // HP
            // 
            this.HP.Location = new System.Drawing.Point(40, 86);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(373, 10);
            this.HP.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 47;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "dmg";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "heal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // HPbigger
            // 
            this.HPbigger.Location = new System.Drawing.Point(40, 67);
            this.HPbigger.Maximum = 15;
            this.HPbigger.Name = "HPbigger";
            this.HPbigger.Size = new System.Drawing.Size(373, 10);
            this.HPbigger.TabIndex = 50;
            // 
            // maxbigger
            // 
            this.maxbigger.Location = new System.Drawing.Point(40, 12);
            this.maxbigger.Maximum = 15;
            this.maxbigger.Name = "maxbigger";
            this.maxbigger.Size = new System.Drawing.Size(373, 10);
            this.maxbigger.TabIndex = 51;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "debug";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // BarProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 159);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.maxbigger);
            this.Controls.Add(this.HPbigger);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.othermaxdisplay);
            this.Controls.Add(this.maxdisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test);
            this.Name = "BarProgram";
            this.Text = "Bar Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar test;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox maxdisplay;
        private System.Windows.Forms.TextBox othermaxdisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar HP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar HPbigger;
        private System.Windows.Forms.ProgressBar maxbigger;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

