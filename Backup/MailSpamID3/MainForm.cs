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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string isifile = File.ReadAllText(listBox2.Items[listBox1.SelectedIndex].ToString());
            richTextBox1.Text = isifile;
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            DialogResult folder = openFolder.ShowDialog();
            //List<string> list_file = new List<string>();
            if (folder == DialogResult.OK)
            {
                listBox1.Refresh();
                string[] files = Directory.GetFiles(openFolder.SelectedPath);
                string foldername = this.openFolder.SelectedPath;
                foreach (string f in Directory.GetFiles(foldername))
                {
                    string judul = f;
                    int id_bslash = judul.LastIndexOf("\\");
                    judul = judul.Remove(0, id_bslash + 1);
                    //list_judul_file.Add(judul);

                    listBox1.Items.Add(judul);
                    //string isifile = File.ReadAllText(f);
                    //richTextBox1.Text = isifile;
                    listBox2.Items.Add(f);
                }              
            }
        }
        

        private void bt_proses_Click(object sender, EventArgs e)
        {
            TextFileURL.Text = listBox1.Items.Count.ToString();
            double[,] dataTraining = new double[1000,10000];
            int nTerm = 0;
            string[] term = new string[10000];
            for (int i = 0; i < listBox1.Items.Count;i++ )
            {
                string isifile = File.ReadAllText(listBox2.Items[i].ToString());
                string proses_htmlcleaner = html_cleaner(isifile);
                List<string> proses_tokenizing = tokenizing(proses_htmlcleaner);
                List<string> proses_stopword = stopword(proses_tokenizing);
                List<string> proses_stemming = stemming(proses_stopword);
                List<string> proses_wordsSingle = wordSingle(proses_stemming); 
                List<int> proses_frekuensi = frekuensi(proses_wordsSingle,proses_stemming);
                for (int j = 0; j < proses_wordsSingle.Count; j++){
                    
                    //richTextBox1.AppendText(proses_wordsSingle[j]+"\n");
                    richTextBox1.AppendText(proses_wordsSingle[j]+" "+proses_frekuensi[j]+"\n");
                    if (proses_frekuensi[j] > 2)
                    {       
                        for (int k=0; k < nTerm; k++)
                        {
                            if (!term[k].Equals(proses_wordsSingle[j]))
                            {
                                term[nTerm] = proses_wordsSingle[j];
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
                            term[nTerm] = proses_wordsSingle[j];
                            dataTraining[i, nTerm] = proses_frekuensi[j];
                            nTerm++;
                        }
                    }
                }
                richTextBox1.AppendText("====================\n");                
            }

            for (int i = 0; i <= listBox1.Items.Count; i++)
            {
                for (int j = 0; j <= nTerm; j++)
                {
                    if (i == 0)
                    {
                        if (j == nTerm)
                            richTextBox1.AppendText("result");
                        else
                            richTextBox1.AppendText(term[j] + ",");
                    }
                    else
                    {
                        if (j == nTerm)
                        {
                            if (listBox1.Items[i-1].ToString().Contains("ham"))
                                richTextBox1.AppendText("ham");
                            if (listBox1.Items[i-1].ToString().Contains("spam"))
                                richTextBox1.AppendText("spam");
                        }
                        else
                        {
                            richTextBox1.AppendText(dataTraining[i - 1, j] + ",");
                        }
                    }
                }
                richTextBox1.AppendText("\n");
            }
            //TF-IDF
            int df = 0;
            double[,] dataPembobotan = new double[listBox1.Items.Count,nTerm];
            for (int i = 0; i < nTerm; i++)
            {
                for (int j = 0; j < listBox1.Items.Count; j++)
                {
                    if (dataTraining[j,i]!=0){
                        df++;
                    }
                }
                dataTraining[listBox1.Items.Count, i] = df;
                df = 0;
                dataTraining[(listBox1.Items.Count + 1), i] = Math.Round(Math.Log10(listBox1.Items.Count / dataTraining[listBox1.Items.Count, i]),4,MidpointRounding.AwayFromZero);
                for (int k = 0; k < listBox1.Items.Count; k++)
                {
                    dataPembobotan[k, i] = dataTraining[k, i] * dataTraining[(listBox1.Items.Count + 1), i];
                    richTextBox1.AppendText(dataPembobotan[k,i] + " ");
                }
                //richTextBox1.AppendText(dataTraining[listBox1.Items.Count, i] + ",");
                //richTextBox1.AppendText(dataTraining[(listBox1.Items.Count+1), i] + ",");
                richTextBox1.AppendText("\n");
            }
            //ekstraksi data
            double max = dataPembobotan.Cast<double>().Max();
            double min = dataPembobotan.Cast<double>().Min();
            double range = max - min;
            double kelas = 1 + (3.3 * Math.Log10(dataPembobotan.Cast<double>().Count()));
            kelas = Math.Ceiling(kelas);
            double pInterval = Math.Round(range / kelas,4,MidpointRounding.AwayFromZero);
            inv _interval = new inv();
            List<inv> interval = new List<inv>();
            for (int i = 0; i <= kelas; i++){
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
                richTextBox1.AppendText("\n" +interval[i].a+ " -- " +interval[i].b);
            }
            //distribusi frekuensi
            string[,] dataKategorisasi = new string[listBox1.Items.Count,nTerm]; 
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for (int j = 0; j < nTerm; j++)
                {
                    for (int k = 0; k <= kelas; k++)
                    {
                        if ((dataPembobotan[i, j] >= interval[k].a) && (dataPembobotan[i, j] <= interval[k].b) && (k != kelas))
                        { dataKategorisasi[i, j] = (string)("int" + (k + 1)); }
                        if ((dataPembobotan[i, j] >= interval[k].a) && (k == kelas))
                        { dataKategorisasi[i, j] = (string)("int" + (k + 1)); }
                    }
                    richTextBox1.AppendText(dataKategorisasi[i, j]+" ");
                }
                richTextBox1.AppendText("\n");
            }
            richTextBox1.AppendText(interval[1].a+" "+dataPembobotan[1,1]);
        }

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
            FileStream sr = new FileStream(@"C:\\stopwords.txt", FileMode.Open);
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
    }
}
