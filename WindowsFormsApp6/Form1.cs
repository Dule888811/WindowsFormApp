using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public IComparer<FileInfo> FileNname { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.Description = "  ..Select folder  ..";
            fbd.ShowNewFolderButton = false;

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.Clear();

                string[] dirs = Directory.GetDirectories(fbd.SelectedPath);
                string[] files = Directory.GetFiles(fbd.SelectedPath, "*.txt", SearchOption.AllDirectories);
                int i = 0;
                textBox1.Text = fbd.SelectedPath;
                foreach (string file in files)
                {
                   
                    string text;
                   
                    using (var streamReader = new StreamReader(file, Encoding.UTF8))
                    {
                      
                        text = streamReader.ReadToEnd();
                        if (text.Contains(textBox2.Text))
                        {
                            int count = 0;
                            foreach (Match match in Regex.Matches(text, textBox2.Text, RegexOptions.Compiled))
                            {
                                count++;
                            }
                            listBox1.Items.Add(file);
                            listBox1.Items.Add(count);

                        }
                    }

                }


            }





        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach( var Item in listBox1.SelectedItems)
            {
                if(Item.ToString().Length > 10)
                {
                    string path = Item.ToString();
                    Process.Start(path);
                }
               
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
        }
    

