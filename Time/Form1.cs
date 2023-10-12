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
        string copy;
        public Form1()
        {
            
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void Form1_Load(object sender, EventArgs e)
        {
            string dirName = "C:\\";
            // если папка существует
            if (Directory.Exists(dirName))
            {
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    List.Text = (s);
                }
               
            }
        }
        async Task time()
        {
            for (int i = 0; i < 15; i++)
            {
                Task.Delay(1000);
                Time.Text = DateTime.Now.ToLongTimeString();
                //string dirName = "C:\\";
                //// если папка существует
                //if (Directory.Exists(dirName))
                //{
                //    string[] dirs = Directory.GetDirectories(dirName);
                //    foreach (string s in dirs)
                //    {
                //        List.Text = (s);
                //    }
                    
                //}
            }
            
        }
        async private void click(object sender, MouseEventArgs e)
        {
            await time();
        }

        private void val(object sender, EventArgs e)
        {

        }

        async private void size(object sender, EventArgs e)
        {
            
        }
        //async Task load()
        //{
        //    await Task.Delay(3000);     // имитация продолжительной работы
        //                           // или так
        //                                //await Task.Delay(TimeSpan.FromMilliseconds(3000));
        //}
    }
}
