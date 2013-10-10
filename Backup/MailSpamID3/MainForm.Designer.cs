namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.bt_proses = new System.Windows.Forms.Button();
            this.TextFileURL = new System.Windows.Forms.TextBox();
            this.openFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.bt_open = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFile";
            // 
            // bt_proses
            // 
            this.bt_proses.Location = new System.Drawing.Point(38, 66);
            this.bt_proses.Name = "bt_proses";
            this.bt_proses.Size = new System.Drawing.Size(75, 23);
            this.bt_proses.TabIndex = 0;
            this.bt_proses.Text = "Proses";
            this.bt_proses.UseVisualStyleBackColor = true;
            this.bt_proses.Click += new System.EventHandler(this.bt_proses_Click);
            // 
            // TextFileURL
            // 
            this.TextFileURL.Location = new System.Drawing.Point(143, 29);
            this.TextFileURL.Name = "TextFileURL";
            this.TextFileURL.Size = new System.Drawing.Size(427, 20);
            this.TextFileURL.TabIndex = 1;
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(38, 27);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(75, 23);
            this.bt_open.TabIndex = 3;
            this.bt_open.Text = "Open";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(143, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 238);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(342, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(228, 238);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(38, 115);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(75, 69);
            this.listBox2.TabIndex = 6;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(38, 190);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(75, 96);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 335);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.TextFileURL);
            this.Controls.Add(this.bt_proses);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_proses;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.TextBox TextFileURL;
        private System.Windows.Forms.FolderBrowserDialog openFolder;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

