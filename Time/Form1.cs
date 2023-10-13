using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class Form1 : Form
    {
        public string copy;

        public bool stopper = false;
        public string dirname = "C:\\";
        public int score = 0;
        public int scoreLine = 0;
        public string[] file = new string[100];
        public string[] dir = new string[100];
        public int g =0;
        public Form1()
        {
            
            InitializeComponent();
        }
        void Form1_Load(object sender, EventArgs e)
        {
          
        }
        async Task<string> timelocal()
        {    
            await Task.Delay(1000);
            return DateTime.Now.ToLongTimeString();
            
        }

        private async void Btn_Click(object sender, EventArgs e)
        {

            stopper = false;
            while (stopper==false)
            {   
                var time = await timelocal();
                Time.Text = time.ToString();


            }
            
            
            
        }
        //Забиваем массивы с папками и файлами
        public void ListDir()
        {
            if (Directory.Exists(dirname))
            {
                string[] dirs = Directory.GetDirectories(dirname);
                Array.Resize(ref dir, dirs.Length);
                foreach (string s in dirs)
                {
                    Field.Text += s + Environment.NewLine;
                    dir[g] = s;
                    g++;
                }
                score++;
            }
            g = 0;
        }
        public void ListFiles()
        {


            if (Directory.Exists(dirname))
            {
                string[] dirs = Directory.GetFiles(dirname);
                Array.Resize(ref file, dirs.Length);
                foreach (string s in dirs)
                {
                    Field.Text += s + Environment.NewLine;
                    file[g] = s;
                    g++;

                }
            }
            g = 0;
            
        }
        async public void Search()
        {
            ListDir();
            ListFiles();
            stopper = false;
            while (stopper == false)
            {
                string[] dirs = Directory.GetDirectories(dirname);
                string[] files = Directory.GetFiles(dirname);
                if (dir.Length!=dirs.Length||file.Length!=files.Length)
                {
                    Field.Clear();
                    ListDir();
                    ListFiles();
                }
                foreach (string s in dirs)
                {
                    if (dir[g] != s)
                    {
                        Field.Clear();
                        g=0;
                        ListDir();
                        ListFiles();
                        break;
                    }
                    g++;

                }
                g=0;
                foreach (string s in files)
                {
                    if (file[g] != s)
                    {
                        Field.Clear();
                        g = 0;
                        ListDir();
                        ListFiles();
                        break;
                    }
                    g++;

                }
                g = 0;
                await Task.Delay(1);
            }
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            Search();
        }

    }
}
