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
            this.openFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_jumAcc = new System.Windows.Forms.Label();
            this.lb_jumCocok = new System.Windows.Forms.Label();
            this.lb_jumTest = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextFileURL_test = new System.Windows.Forms.TextBox();
            this.bt_proses = new System.Windows.Forms.Button();
            this.bt_browseTest = new System.Windows.Forms.Button();
            this.tabControl_test = new System.Windows.Forms.TabControl();
            this.pg_isiteksTest = new System.Windows.Forms.TabPage();
            this.rbt_teksTest = new System.Windows.Forms.RichTextBox();
            this.lb_teksTest = new System.Windows.Forms.ListBox();
            this.pg_frekTest = new System.Windows.Forms.TabPage();
            this.rbt_frekTest = new System.Windows.Forms.RichTextBox();
            this.lb_frekTest = new System.Windows.Forms.ListBox();
            this.pg_result = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_teks = new System.Windows.Forms.ListBox();
            this.rbt_teks = new System.Windows.Forms.RichTextBox();
            this.bt_browseTrain = new System.Windows.Forms.Button();
            this.bt_training = new System.Windows.Forms.Button();
            this.TextFileURL = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_jumSpam = new System.Windows.Forms.Label();
            this.lb_jumHam = new System.Windows.Forms.Label();
            this.lb_jumTrain = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_train = new System.Windows.Forms.TabControl();
            this.pg_isiteks = new System.Windows.Forms.TabPage();
            this.pg_frek = new System.Windows.Forms.TabPage();
            this.rbt_frek = new System.Windows.Forms.RichTextBox();
            this.lb_frek = new System.Windows.Forms.ListBox();
            this.pg_dataGenTrain = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pg_decTree = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1.SuspendLayout();
            this.tabControl_test.SuspendLayout();
            this.pg_isiteksTest.SuspendLayout();
            this.pg_frekTest.SuspendLayout();
            this.pg_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl_train.SuspendLayout();
            this.pg_isiteks.SuspendLayout();
            this.pg_frek.SuspendLayout();
            this.pg_dataGenTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pg_decTree.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFile";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 115);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(15, 69);
            this.listBox2.TabIndex = 6;
            this.listBox2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_jumAcc);
            this.groupBox1.Controls.Add(this.lb_jumCocok);
            this.groupBox1.Controls.Add(this.lb_jumTest);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextFileURL_test);
            this.groupBox1.Controls.Add(this.bt_proses);
            this.groupBox1.Controls.Add(this.bt_browseTest);
            this.groupBox1.Controls.Add(this.tabControl_test);
            this.groupBox1.Location = new System.Drawing.Point(451, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 496);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TESTING";
            // 
            // lb_jumAcc
            // 
            this.lb_jumAcc.AutoSize = true;
            this.lb_jumAcc.Location = new System.Drawing.Point(164, 474);
            this.lb_jumAcc.Name = "lb_jumAcc";
            this.lb_jumAcc.Size = new System.Drawing.Size(0, 13);
            this.lb_jumAcc.TabIndex = 31;
            // 
            // lb_jumCocok
            // 
            this.lb_jumCocok.AutoSize = true;
            this.lb_jumCocok.Location = new System.Drawing.Point(164, 454);
            this.lb_jumCocok.Name = "lb_jumCocok";
            this.lb_jumCocok.Size = new System.Drawing.Size(0, 13);
            this.lb_jumCocok.TabIndex = 30;
            // 
            // lb_jumTest
            // 
            this.lb_jumTest.AutoSize = true;
            this.lb_jumTest.Location = new System.Drawing.Point(164, 436);
            this.lb_jumTest.Name = "lb_jumTest";
            this.lb_jumTest.Size = new System.Drawing.Size(0, 13);
            this.lb_jumTest.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Akurasi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Jumlah Email yang Cocok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Jumlah Data Testing";
            // 
            // TextFileURL_test
            // 
            this.TextFileURL_test.Location = new System.Drawing.Point(105, 38);
            this.TextFileURL_test.Name = "TextFileURL_test";
            this.TextFileURL_test.Size = new System.Drawing.Size(282, 20);
            this.TextFileURL_test.TabIndex = 15;
            // 
            // bt_proses
            // 
            this.bt_proses.Location = new System.Drawing.Point(316, 449);
            this.bt_proses.Name = "bt_proses";
            this.bt_proses.Size = new System.Drawing.Size(75, 23);
            this.bt_proses.TabIndex = 14;
            this.bt_proses.Text = "Proses";
            this.bt_proses.UseVisualStyleBackColor = true;
            this.bt_proses.Click += new System.EventHandler(this.bt_proses_Click_1);
            // 
            // bt_browseTest
            // 
            this.bt_browseTest.Location = new System.Drawing.Point(20, 36);
            this.bt_browseTest.Name = "bt_browseTest";
            this.bt_browseTest.Size = new System.Drawing.Size(75, 23);
            this.bt_browseTest.TabIndex = 13;
            this.bt_browseTest.Text = "Browse";
            this.bt_browseTest.UseVisualStyleBackColor = true;
            this.bt_browseTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl_test
            // 
            this.tabControl_test.Controls.Add(this.pg_isiteksTest);
            this.tabControl_test.Controls.Add(this.pg_frekTest);
            this.tabControl_test.Controls.Add(this.pg_result);
            this.tabControl_test.Location = new System.Drawing.Point(20, 77);
            this.tabControl_test.Name = "tabControl_test";
            this.tabControl_test.SelectedIndex = 0;
            this.tabControl_test.ShowToolTips = true;
            this.tabControl_test.Size = new System.Drawing.Size(371, 350);
            this.tabControl_test.TabIndex = 12;
            // 
            // pg_isiteksTest
            // 
            this.pg_isiteksTest.Controls.Add(this.rbt_teksTest);
            this.pg_isiteksTest.Controls.Add(this.lb_teksTest);
            this.pg_isiteksTest.Location = new System.Drawing.Point(4, 22);
            this.pg_isiteksTest.Name = "pg_isiteksTest";
            this.pg_isiteksTest.Padding = new System.Windows.Forms.Padding(3);
            this.pg_isiteksTest.Size = new System.Drawing.Size(363, 324);
            this.pg_isiteksTest.TabIndex = 2;
            this.pg_isiteksTest.Text = "Isi Teks";
            this.pg_isiteksTest.UseVisualStyleBackColor = true;
            // 
            // rbt_teksTest
            // 
            this.rbt_teksTest.Location = new System.Drawing.Point(156, 4);
            this.rbt_teksTest.Name = "rbt_teksTest";
            this.rbt_teksTest.Size = new System.Drawing.Size(206, 316);
            this.rbt_teksTest.TabIndex = 7;
            this.rbt_teksTest.Text = "";
            // 
            // lb_teksTest
            // 
            this.lb_teksTest.FormattingEnabled = true;
            this.lb_teksTest.Location = new System.Drawing.Point(0, 4);
            this.lb_teksTest.Name = "lb_teksTest";
            this.lb_teksTest.Size = new System.Drawing.Size(150, 316);
            this.lb_teksTest.TabIndex = 6;
            this.lb_teksTest.SelectedIndexChanged += new System.EventHandler(this.lb_teksTest_SelectedIndexChanged);
            // 
            // pg_frekTest
            // 
            this.pg_frekTest.Controls.Add(this.rbt_frekTest);
            this.pg_frekTest.Controls.Add(this.lb_frekTest);
            this.pg_frekTest.Location = new System.Drawing.Point(4, 22);
            this.pg_frekTest.Name = "pg_frekTest";
            this.pg_frekTest.Padding = new System.Windows.Forms.Padding(3);
            this.pg_frekTest.Size = new System.Drawing.Size(363, 324);
            this.pg_frekTest.TabIndex = 3;
            this.pg_frekTest.Text = "Frekuensi";
            this.pg_frekTest.UseVisualStyleBackColor = true;
            // 
            // rbt_frekTest
            // 
            this.rbt_frekTest.Location = new System.Drawing.Point(155, 4);
            this.rbt_frekTest.Name = "rbt_frekTest";
            this.rbt_frekTest.Size = new System.Drawing.Size(205, 316);
            this.rbt_frekTest.TabIndex = 8;
            this.rbt_frekTest.Text = "";
            // 
            // lb_frekTest
            // 
            this.lb_frekTest.FormattingEnabled = true;
            this.lb_frekTest.Location = new System.Drawing.Point(0, 4);
            this.lb_frekTest.Name = "lb_frekTest";
            this.lb_frekTest.Size = new System.Drawing.Size(149, 316);
            this.lb_frekTest.TabIndex = 7;
            this.lb_frekTest.SelectedIndexChanged += new System.EventHandler(this.lb_frekTest_SelectedIndexChanged);
            // 
            // pg_result
            // 
            this.pg_result.Controls.Add(this.dataGridView1);
            this.pg_result.Location = new System.Drawing.Point(4, 22);
            this.pg_result.Name = "pg_result";
            this.pg_result.Padding = new System.Windows.Forms.Padding(3);
            this.pg_result.Size = new System.Drawing.Size(363, 324);
            this.pg_result.TabIndex = 0;
            this.pg_result.Text = "Hasil";
            this.pg_result.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // lb_teks
            // 
            this.lb_teks.FormattingEnabled = true;
            this.lb_teks.Location = new System.Drawing.Point(1, 3);
            this.lb_teks.Name = "lb_teks";
            this.lb_teks.Size = new System.Drawing.Size(150, 316);
            this.lb_teks.TabIndex = 4;
            this.lb_teks.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rbt_teks
            // 
            this.rbt_teks.Location = new System.Drawing.Point(157, 3);
            this.rbt_teks.Name = "rbt_teks";
            this.rbt_teks.Size = new System.Drawing.Size(208, 316);
            this.rbt_teks.TabIndex = 5;
            this.rbt_teks.Text = "";
            // 
            // bt_browseTrain
            // 
            this.bt_browseTrain.Location = new System.Drawing.Point(18, 34);
            this.bt_browseTrain.Name = "bt_browseTrain";
            this.bt_browseTrain.Size = new System.Drawing.Size(75, 23);
            this.bt_browseTrain.TabIndex = 3;
            this.bt_browseTrain.Text = "Browse";
            this.bt_browseTrain.UseVisualStyleBackColor = true;
            this.bt_browseTrain.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // bt_training
            // 
            this.bt_training.Location = new System.Drawing.Point(308, 449);
            this.bt_training.Name = "bt_training";
            this.bt_training.Size = new System.Drawing.Size(75, 23);
            this.bt_training.TabIndex = 0;
            this.bt_training.Text = "Training";
            this.bt_training.UseVisualStyleBackColor = true;
            this.bt_training.Click += new System.EventHandler(this.bt_proses_Click);
            // 
            // TextFileURL
            // 
            this.TextFileURL.Location = new System.Drawing.Point(99, 36);
            this.TextFileURL.Name = "TextFileURL";
            this.TextFileURL.Size = new System.Drawing.Size(295, 20);
            this.TextFileURL.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_jumSpam);
            this.groupBox2.Controls.Add(this.lb_jumHam);
            this.groupBox2.Controls.Add(this.lb_jumTrain);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tabControl_train);
            this.groupBox2.Controls.Add(this.TextFileURL);
            this.groupBox2.Controls.Add(this.bt_training);
            this.groupBox2.Controls.Add(this.bt_browseTrain);
            this.groupBox2.Location = new System.Drawing.Point(33, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 496);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TRAINING";
            // 
            // lb_jumSpam
            // 
            this.lb_jumSpam.AutoSize = true;
            this.lb_jumSpam.Location = new System.Drawing.Point(142, 474);
            this.lb_jumSpam.Name = "lb_jumSpam";
            this.lb_jumSpam.Size = new System.Drawing.Size(0, 13);
            this.lb_jumSpam.TabIndex = 28;
            // 
            // lb_jumHam
            // 
            this.lb_jumHam.AutoSize = true;
            this.lb_jumHam.Location = new System.Drawing.Point(142, 457);
            this.lb_jumHam.Name = "lb_jumHam";
            this.lb_jumHam.Size = new System.Drawing.Size(0, 13);
            this.lb_jumHam.TabIndex = 27;
            // 
            // lb_jumTrain
            // 
            this.lb_jumTrain.AutoSize = true;
            this.lb_jumTrain.Location = new System.Drawing.Point(142, 439);
            this.lb_jumTrain.Name = "lb_jumTrain";
            this.lb_jumTrain.Size = new System.Drawing.Size(0, 13);
            this.lb_jumTrain.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 474);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Jumlah Email Spam";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Jumlah Email Ham";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Jumlah Data Training";
            // 
            // tabControl_train
            // 
            this.tabControl_train.Controls.Add(this.pg_isiteks);
            this.tabControl_train.Controls.Add(this.pg_frek);
            this.tabControl_train.Controls.Add(this.pg_dataGenTrain);
            this.tabControl_train.Controls.Add(this.pg_decTree);
            this.tabControl_train.Location = new System.Drawing.Point(18, 77);
            this.tabControl_train.Name = "tabControl_train";
            this.tabControl_train.SelectedIndex = 0;
            this.tabControl_train.Size = new System.Drawing.Size(376, 350);
            this.tabControl_train.TabIndex = 10;
            // 
            // pg_isiteks
            // 
            this.pg_isiteks.Controls.Add(this.rbt_teks);
            this.pg_isiteks.Controls.Add(this.lb_teks);
            this.pg_isiteks.Location = new System.Drawing.Point(4, 22);
            this.pg_isiteks.Name = "pg_isiteks";
            this.pg_isiteks.Padding = new System.Windows.Forms.Padding(3);
            this.pg_isiteks.Size = new System.Drawing.Size(368, 324);
            this.pg_isiteks.TabIndex = 0;
            this.pg_isiteks.Text = "Isi Teks";
            this.pg_isiteks.UseVisualStyleBackColor = true;
            // 
            // pg_frek
            // 
            this.pg_frek.Controls.Add(this.rbt_frek);
            this.pg_frek.Controls.Add(this.lb_frek);
            this.pg_frek.Location = new System.Drawing.Point(4, 22);
            this.pg_frek.Name = "pg_frek";
            this.pg_frek.Padding = new System.Windows.Forms.Padding(3);
            this.pg_frek.Size = new System.Drawing.Size(368, 324);
            this.pg_frek.TabIndex = 1;
            this.pg_frek.Text = "Frekuensi";
            this.pg_frek.UseVisualStyleBackColor = true;
            // 
            // rbt_frek
            // 
            this.rbt_frek.Location = new System.Drawing.Point(156, 3);
            this.rbt_frek.Name = "rbt_frek";
            this.rbt_frek.Size = new System.Drawing.Size(209, 316);
            this.rbt_frek.TabIndex = 6;
            this.rbt_frek.Text = "";
            // 
            // lb_frek
            // 
            this.lb_frek.FormattingEnabled = true;
            this.lb_frek.Location = new System.Drawing.Point(0, 3);
            this.lb_frek.Name = "lb_frek";
            this.lb_frek.Size = new System.Drawing.Size(150, 316);
            this.lb_frek.TabIndex = 5;
            this.lb_frek.SelectedIndexChanged += new System.EventHandler(this.lb_frek_SelectedIndexChanged);
            // 
            // pg_dataGenTrain
            // 
            this.pg_dataGenTrain.Controls.Add(this.dataGridView2);
            this.pg_dataGenTrain.Location = new System.Drawing.Point(4, 22);
            this.pg_dataGenTrain.Name = "pg_dataGenTrain";
            this.pg_dataGenTrain.Padding = new System.Windows.Forms.Padding(3);
            this.pg_dataGenTrain.Size = new System.Drawing.Size(368, 324);
            this.pg_dataGenTrain.TabIndex = 2;
            this.pg_dataGenTrain.Text = "Data Generalisasi";
            this.pg_dataGenTrain.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(362, 318);
            this.dataGridView2.TabIndex = 0;
            // 
            // pg_decTree
            // 
            this.pg_decTree.Controls.Add(this.treeView1);
            this.pg_decTree.Location = new System.Drawing.Point(4, 22);
            this.pg_decTree.Name = "pg_decTree";
            this.pg_decTree.Padding = new System.Windows.Forms.Padding(3);
            this.pg_decTree.Size = new System.Drawing.Size(368, 324);
            this.pg_decTree.TabIndex = 3;
            this.pg_decTree.Text = "Decision Tree";
            this.pg_decTree.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(362, 318);
            this.treeView1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 276);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(15, 69);
            this.listBox1.TabIndex = 14;
            this.listBox1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(894, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 557);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox2);
            this.Name = "MainForm";
            this.Text = "MailSpamID3 - 0610963066";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl_test.ResumeLayout(false);
            this.pg_isiteksTest.ResumeLayout(false);
            this.pg_frekTest.ResumeLayout(false);
            this.pg_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl_train.ResumeLayout(false);
            this.pg_isiteks.ResumeLayout(false);
            this.pg_frek.ResumeLayout(false);
            this.pg_dataGenTrain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pg_decTree.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.FolderBrowserDialog openFolder;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextFileURL_test;
        private System.Windows.Forms.Button bt_proses;
        private System.Windows.Forms.Button bt_browseTest;
        private System.Windows.Forms.TabControl tabControl_test;
        private System.Windows.Forms.TabPage pg_result;
        private System.Windows.Forms.ListBox lb_teks;
        private System.Windows.Forms.RichTextBox rbt_teks;
        private System.Windows.Forms.Button bt_browseTrain;
        private System.Windows.Forms.Button bt_training;
        private System.Windows.Forms.TextBox TextFileURL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl_train;
        private System.Windows.Forms.TabPage pg_frek;
        private System.Windows.Forms.TabPage pg_dataGenTrain;
        private System.Windows.Forms.TabPage pg_decTree;
        private System.Windows.Forms.TabPage pg_isiteks;
        private System.Windows.Forms.ListBox lb_frek;
        private System.Windows.Forms.RichTextBox rbt_frek;
        private System.Windows.Forms.TabPage pg_frekTest;
        private System.Windows.Forms.RichTextBox rbt_frekTest;
        private System.Windows.Forms.ListBox lb_frekTest;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage pg_isiteksTest;
        private System.Windows.Forms.RichTextBox rbt_teksTest;
        private System.Windows.Forms.ListBox lb_teksTest;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_jumAcc;
        private System.Windows.Forms.Label lb_jumCocok;
        private System.Windows.Forms.Label lb_jumTest;
        private System.Windows.Forms.Label lb_jumSpam;
        private System.Windows.Forms.Label lb_jumHam;
        private System.Windows.Forms.Label lb_jumTrain;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

