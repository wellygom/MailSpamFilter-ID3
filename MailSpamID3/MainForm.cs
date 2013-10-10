using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        struct inv
        {
            double _a;
            public double a
            {
                get { return _a; }
                set { _a = value; }
            }
            double _b;
            public double b
            {
                get { return _b; }
                set { _b = value; }
            }
        }

        private string[,] _DataKategorisasi;
        List<inv> interval = new List<inv>();
        List<double> idf = new List<double>();
        List<string> term = new List<string>();
        StringBuilder sb_csv = new StringBuilder();
        int nTerm = 0;
        double kelas = 0;

        //page isi teks
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string isifile = File.ReadAllText(listBox2.Items[lb_teks.SelectedIndex].ToString());
            rbt_teks.Text = isifile;
        }

        //page frekuensi
        private void lb_frek_SelectedIndexChanged(object sender, EventArgs e)
        {
            string isifile = File.ReadAllText(listBox2.Items[lb_frek.SelectedIndex].ToString());
            string proses_htmlcleaner = html_cleaner(isifile);
            List<string> proses_tokenizing = tokenizing(proses_htmlcleaner);
            List<string> proses_stopword = stopword(proses_tokenizing);
            List<string> proses_stemming = stemming(proses_stopword);
            List<string> proses_wordsSingle = wordSingle(proses_stemming);
            List<int> proses_frekuensi = frekuensi(proses_wordsSingle, proses_stemming);
            rbt_frek.Clear();
            for (int i = 0; i < proses_wordsSingle.Count; i++)
            {
                rbt_frek.AppendText(proses_wordsSingle[i] + "\t\t" + proses_frekuensi[i] + "\n");
            }
        }

        //browse file
        private void bt_open_Click(object sender, EventArgs e)
        {
            DialogResult folder = openFolder.ShowDialog();
            if (folder == DialogResult.OK)
            {
                lb_teks.Refresh();
                lb_frek.Refresh();
                
                string[] files = Directory.GetFiles(openFolder.SelectedPath);
                string foldername = this.openFolder.SelectedPath;
                TextFileURL.Text = openFolder.SelectedPath;
                foreach (string f in Directory.GetFiles(foldername))
                {
                    string judul = f;
                    int id_bslash = judul.LastIndexOf("\\");
                    judul = judul.Remove(0, id_bslash + 1);
                    lb_teks.Items.Add(judul);
                    lb_frek.Items.Add(judul);
                    listBox2.Items.Add(f);
                }
            }
            int ham = 0, spam = 0;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (lb_teks.Items[i].ToString().Contains("ham"))
                    ham++;
                if (lb_teks.Items[i].ToString().Contains("spam"))
                    spam++;
            }
            lb_jumTrain.Text = listBox2.Items.Count.ToString();
            lb_jumHam.Text = ham.ToString();
            lb_jumSpam.Text = spam.ToString();
        }

        private StringBuilder sb = new StringBuilder();
        //proses training
        private void bt_proses_Click(object sender, EventArgs e)
        {
            sb.Clear();
            double[,] dataTraining = new double[1000, 10000];
            for (int i = 0; i < lb_teks.Items.Count; i++)
            {
                string isifile = File.ReadAllText(listBox2.Items[i].ToString());
                string proses_htmlcleaner = html_cleaner(isifile);
                //preprocessing
                List<string> proses_tokenizing = tokenizing(proses_htmlcleaner);
                List<string> proses_stopword = stopword(proses_tokenizing);
                List<string> proses_stemming = stemming(proses_stopword);
                List<string> proses_wordsSingle = wordSingle(proses_stemming);
                List<int> proses_frekuensi = frekuensi(proses_wordsSingle, proses_stemming);

                for (int j = 0; j < proses_wordsSingle.Count; j++)
                {
                    if (proses_frekuensi[j] > 2)
                    {
                        for (int k = 0; k < nTerm; k++)
                        {
                            if (!term.Contains(proses_wordsSingle[j]))
                            {
                                term.Add(proses_wordsSingle[j]);
                                dataTraining[i, nTerm] = proses_frekuensi[j];
                                nTerm++;
                                break;
                            }
                            if (term[k].Equals(proses_wordsSingle[j]))
                            {
                                dataTraining[i, k] = proses_frekuensi[j];
                            }
                        }
                        if (nTerm == 0)
                        {
                            term.Add(proses_wordsSingle[j]);
                            dataTraining[i, nTerm] = proses_frekuensi[j];
                            nTerm++;
                        }
                    }
                }             
            }
            toolStripProgressBar1.Value += 20;
            for (int j = 0; j <= nTerm; j++)
            {
                if (j == nTerm)
                {
                    sb.Append("result");
                }
                else
                {
                    sb.Append(term[j] + ",");
                }
            }
            sb.AppendLine();

            //TF-IDF
            int df = 0;
            double[,] dataPembobotan = new double[lb_teks.Items.Count, nTerm];
            for (int i = 0; i < nTerm; i++)
            {
                for (int j = 0; j < lb_teks.Items.Count; j++)
                {
                    if (dataTraining[j, i] != 0)
                    {
                        df++;
                    }
                }
                dataTraining[lb_teks.Items.Count, i] = df;
                df = 0;
                dataTraining[(lb_teks.Items.Count + 1), i] = Math.Round(Math.Log10(lb_teks.Items.Count / dataTraining[lb_teks.Items.Count, i]), 4, MidpointRounding.AwayFromZero);
                idf.Add(dataTraining[(lb_teks.Items.Count + 1), i]);
                for (int k = 0; k < lb_teks.Items.Count; k++)
                {
                    dataPembobotan[k, i] = dataTraining[k, i] * dataTraining[(lb_teks.Items.Count + 1), i];
                }
            }
            //ekstraksi data
            toolStripProgressBar1.Value += 20;
            double max = dataPembobotan.Cast<double>().Max();
            double min = dataPembobotan.Cast<double>().Min();
            double range = max - min;
            kelas = 1 + (3.3 * Math.Log10(dataPembobotan.Cast<double>().Count()));
            kelas = Math.Ceiling(kelas);
            double pInterval = Math.Round(range / kelas, 4, MidpointRounding.AwayFromZero);
            inv _interval = new inv();

            for (int i = 0; i <= kelas; i++)
            {
                if (i == 0)
                {
                    _interval.a = min;
                    _interval.b = _interval.a + pInterval;
                    interval.Add(_interval);
                }
                else
                {
                    _interval.a = interval[i - 1].b + 0.0001;
                    _interval.b = _interval.a + pInterval;
                    interval.Add(_interval);
                }
            }
            //distribusi frekuensi
            string[,] dataKategorisasi = new string[lb_teks.Items.Count, nTerm];
            var hasil = new List<bool>();
            for (int i = 0; i < lb_teks.Items.Count; i++)
            {
                for (int j = 0; j <= nTerm; j++)
                {

                    if (j == nTerm)
                    {
                        hasil.Add(lb_teks.Items[i].ToString().Contains("spam"));
                        sb.Append(hasil[i] ? "spam" : "ham");
                    }
                    else
                    {
                        for (int k = 0; k <= kelas; k++)
                        {
                            if ((dataPembobotan[i, j] >= interval[k].a) && (dataPembobotan[i, j] <= interval[k].b) && (k != kelas))
                            { dataKategorisasi[i, j] = (string)("int" + (k + 1)); }
                            if ((dataPembobotan[i, j] >= interval[k].a) && (k == kelas))
                            { dataKategorisasi[i, j] = (string)("int" + (k + 1)); }
                        }
                        sb.Append(dataKategorisasi[i, j] + ",");
                    }
                }
                if (i < (lb_teks.Items.Count - 1))
                    sb.Append("\n");
            }
            toolStripProgressBar1.Value += 20;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            foreach (var kata in term)
            {
                dataGridView2.Columns.Add(kata, kata);
            }
            dataGridView2.Columns.Add("Result", "Result");
            for (int i = 0; i < lb_teks.Items.Count; i++)
            {
                dataGridView2.Rows.Add(Enumerable.Range(0, term.Count).Select(j => dataKategorisasi[i, j]).ToArray());
                dataGridView2["Result", i].Value = hasil[i] ? "Spam" : "Ham";
            }
            toolStripProgressBar1.Value += 20;

            DecisionTreeImplementation sam = new DecisionTreeImplementation();
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(sam.GetTree(sb.ToString()));
            toolStripProgressBar1.Value = 100;
        }

        //method non event
        private string html_cleaner(string isifile)
        {
            isifile = htmlCleaner.StripTagsRegex(isifile);
            isifile = htmlCleaner.StripTagsRegexCompiled(isifile);
            isifile = htmlCleaner.StripTagsCharArray(isifile);
            return isifile;
        }

        private List<string> tokenizing(string isifile)
        {
            isifile = isifile.ToLower();
            char[] pemisah = new char[] { '~', '}', '{', '|', '*', ':', '\\', '_', '[', ']', '/', ';', '<', '>', ' ', '-', '=', '+', '.', ',', ',', '"', '!', '?', '@', '#', '$', '%', '^', '&', '(', ')', '\r', '\n', '\t', '\v', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            List<string> token = isifile.Split(pemisah, StringSplitOptions.RemoveEmptyEntries).ToList();
            return token;
        }

        private List<string> stopword(List<string> token)
        {
            string[] stopword = new string[1000];
            int m = stopword.GetLength(0);
            int n = token.Count();
            string[] _ceksplit = new string[n];
            bool sama = true;
            int jmlh = 0;
            FileStream sr = new FileStream("stopwords.txt", FileMode.Open);
            StreamReader str = new StreamReader(sr);
            int a = 0;
            while (!str.EndOfStream)
            {
                stopword[a] = str.ReadLine();
                a++;
            }
            sr.Close();
            str.Close();
            for (int j = 0; j < n; j++)
            {
                sama = true;
                for (int k = 0; k < m; k++)
                {
                    if (token[j] == stopword[k])
                        sama = false;
                }
                if (sama != false)
                {
                    _ceksplit[j] = token[j];
                    jmlh++;
                }
            }
            List<string> words = new List<string>();
            for (int l = 0; l < n; l++)
            {
                if (_ceksplit[l] != null)
                {
                    words.Add(_ceksplit[l]);
                }
            }
            return words;
        }

        private List<string> stemming(List<string> term)
        {
            List<string> stem_term = new List<string>();
            Stemmer stem = new Stemmer();
            for (int i = 0; i < term.Count; i++)
            {
                stem_term.Add(stem.Porter.stemTerm(term[i]));
            }
            return stem_term;
        }

        private List<string> wordSingle(List<string> words)
        {
            var sList = new ArrayList();
            for (int i = 0; i < words.Count; i++)
            {
                if (sList.Contains(words[i]) == false)
                {
                    sList.Add(words[i]);
                }
            }
            var wordsNew_ = sList.ToArray();
            string[] wordsNew = new string[wordsNew_.Length];
            for (int i = 0; i < wordsNew_.Length; i++)
            {
                wordsNew[i] = (string)wordsNew_[i];
            }
            return wordsNew.ToList();
        }

        private List<int> frekuensi(List<string> wordsNew, List<string> words)
        {
            int[] wordsFrek = new int[wordsNew.Count];
            for (int i = 0; i < wordsNew.Count; i++)
            {
                for (int j = 0; j < words.Count; j++)
                {
                    if (words[j].Equals((string)wordsNew[i]))
                    {
                        wordsFrek[i]++;
                    }
                }
            }
            return wordsFrek.ToList();
        }


        /* 
         *     TESTING
         */
        int jumCocok = 0;
        //browse file
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult folder = openFolder.ShowDialog();
            if (folder == DialogResult.OK)
            {
                TextFileURL_test.Text = openFolder.SelectedPath;
                lb_teksTest.Refresh();
                lb_frekTest.Refresh();
                string[] files = Directory.GetFiles(openFolder.SelectedPath);
                string foldername = this.openFolder.SelectedPath;
                foreach (string f in Directory.GetFiles(foldername))
                {
                    string judul = f;
                    int id_bslash = judul.LastIndexOf("\\");
                    judul = judul.Remove(0, id_bslash + 1);
                    lb_teksTest.Items.Add(judul);
                    lb_frekTest.Items.Add(judul);
                    listBox1.Items.Add(f);
                }
            }
            lb_jumTest.Text = listBox1.Items.Count.ToString();
        }

        //page isi teks
        private void lb_teksTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            string isifile = File.ReadAllText(listBox1.Items[lb_teksTest.SelectedIndex].ToString());
            rbt_teksTest.Text = isifile;
        }

        //page frekuensi
        private void lb_frekTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            string isifile = File.ReadAllText(listBox1.Items[lb_frekTest.SelectedIndex].ToString());
            string proses_htmlcleaner = html_cleaner(isifile);
            List<string> proses_tokenizing = tokenizing(proses_htmlcleaner);
            List<string> proses_stopword = stopword(proses_tokenizing);
            List<string> proses_stemming = stemming(proses_stopword);
            List<string> proses_wordsSingle = wordSingle(proses_stemming);
            List<int> proses_frekuensi = frekuensi(proses_wordsSingle, proses_stemming);
            rbt_frekTest.Clear();
            for (int i = 0; i < proses_wordsSingle.Count; i++)
            {
                rbt_frekTest.AppendText(proses_wordsSingle[i] + "\t\t" + proses_frekuensi[i] + "\n");
            }
        }

        //button proses testing
        private void bt_proses_Click_1(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("No", "No");
            dataGridView1.Columns.Add("Result", "Result");
            int jumHamCocok = 0, jumSpamCocok = 0;
            foreach (var kata in term)
            {
                dataGridView1.Columns.Add(kata, kata);
            }
            for (int i = 0; i < lb_frekTest.Items.Count; i++)
            {
                toolStripProgressBar1.Value += 100 / lb_frekTest.Items.Count;
                
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = i + 1;

                var disFrekTesting = DisFrekTesting(i);

                for (int j = 0; j < disFrekTesting.Count; j++)
                {
                    dataGridView1[2 + j, i].Value = disFrekTesting[j];
                }
                if (lb_frekTest.Items[i].ToString().Contains(dataGridView1["Result", i].Value.ToString()))
                    jumCocok++;
                if (lb_frekTest.Items[i].ToString().Contains("ham") && lb_frekTest.Items[i].ToString().Contains(dataGridView1["Result", i].Value.ToString()))
                    jumHamCocok++;
                if (lb_frekTest.Items[i].ToString().Contains("spam") && lb_frekTest.Items[i].ToString().Contains(dataGridView1["Result", i].Value.ToString()))
                    jumSpamCocok++;
            }
            lb_jumCocok.Text = jumCocok.ToString();
            lb_jumAcc.Text = ((double)jumCocok / (double)lb_frekTest.Items.Count) * 100 + "% (" + ((double)jumHamCocok / (double)lb_frekTest.Items.Count) * 100 + "% :" + ((double)jumSpamCocok / (double)lb_frekTest.Items.Count) * 100 + "%)";
            toolStripProgressBar1.Value = 100;
        }

        private List<string> DisFrekTesting(int i)
        {
            List<double> BobotTesting = new List<double>();
            List<string> disFrekTesting = new List<string>();
            string isifile = File.ReadAllText(listBox1.Items[i].ToString());
            string proses_htmlcleaner = html_cleaner(isifile);
            List<string> proses_tokenizing = tokenizing(proses_htmlcleaner);
            List<string> proses_stopword = stopword(proses_tokenizing);
            List<string> proses_stemming = stemming(proses_stopword);
            List<string> proses_wordsSingle = wordSingle(proses_stemming);
            List<int> proses_frekuensi = frekuensi(proses_wordsSingle, proses_stemming);

            // bobot dan dist. frekuensi
            for (int j = 0; j < term.Count; j++)
            {
                int xt = 0;
                for (int k = 0; k < proses_wordsSingle.Count; k++)
                {
                    if ((term[j].Equals(proses_wordsSingle[k])) && (proses_frekuensi[k] > 2))
                    {
                        BobotTesting.Add(proses_frekuensi[k]*idf[j]);
                        xt = 1;
                    }
                }
                if (xt == 0)
                    BobotTesting.Add(0);
                for (int l = 0; l <= kelas; l++)
                {
                    if ((BobotTesting[j] >= interval[l].a) && (BobotTesting[j] <= interval[l].b) && (l != kelas))
                    {
                        disFrekTesting.Add((string) ("int" + (l + 1)));
                    }
                    if ((BobotTesting[j] >= interval[l].a) && (l == kelas))
                    {
                        disFrekTesting.Add((string) ("int" + (l + 1)));
                    }
                }
            }

            // DT test
            DecisionTreeTesting dtTest = new DecisionTreeTesting();
            dataGridView1[1, i].Value = dtTest.GetResult(sb.ToString(), disFrekTesting, term);
            return disFrekTesting;
        }
    }
}
