namespace smallProj2
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
            this.timeCounter = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeCounter
            // 
            this.timeCounter.Enabled = true;
            this.timeCounter.Interval = 1000;
            this.timeCounter.Tick += new System.EventHandler(this.timeCounter_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(45, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 259);
            this.panel1.TabIndex = 1;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(43, 21);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(119, 12);
            this.dataLabel.TabIndex = 2;
            this.dataLabel.Text = System.DateTime.Now.ToString("MMM dddd H:mm:ss");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Decide";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Where to eat?";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "show detail";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 84);
            this.label2.MaximumSize = new System.Drawing.Size(200, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Resturant selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timeCounter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;

        public void createCheckbox(string[] names)
        {
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(names);
            this.checkedListBox1.Location = new System.Drawing.Point(17, 0);
            this.checkedListBox1.Size = new System.Drawing.Size(100, 200);
            this.checkedListBox1.TabIndex = 0;
            panel1.Controls.Add(this.checkedListBox1);
            this.Refresh();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

