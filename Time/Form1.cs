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
        bool stopper = false;
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

        async void Form1_Load(object sender, EventArgs e)
        {
          
        }
        async Task<string> timelocal()
        {
                
                
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
            await Task.Delay(1000);
            return DateTime.Now.ToLongTimeString();
        }
        async private void click(object sender, MouseEventArgs e)
        {
           
        }

        private void val(object sender, EventArgs e)
        {

        }

        async private void size(object sender, EventArgs e)
        {
            
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
        //async Task load()
        //{
        //    await Task.Delay(3000);     // имитация продолжительной работы
        //                           // или так
        //                                //await Task.Delay(TimeSpan.FromMilliseconds(3000));
        //}
    }
}
