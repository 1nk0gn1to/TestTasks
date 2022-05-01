using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_Teacher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var listWord = new List<string>();
            listWord.AddRange(File.ReadAllLines("C:\\Program Files\\Новая папка\\English Teacher\\bin\\Release\\text.txt"));
            foreach (var item in listWord)
                listBox1.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));
            File.WriteAllLines("C:\\Program Files\\Новая папка\\English Teacher\\bin\\Release\\text.txt", 
                listBox1.Items.OfType<string>());
        }
    }
}
