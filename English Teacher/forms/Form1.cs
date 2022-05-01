using EnglishTeacher.common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_Teacher
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.ForeColor = Color.Green;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                label1.Text = "Не все необходимые поля заполнены";
            }
            if(int.TryParse(textBox1.Text, out int digit) || int.TryParse(textBox2.Text, out int digit2) ||
                char.TryParse(textBox1.Text, out char symbol) || char.TryParse(textBox2.Text, out char symbol1))
            {
                label1.Text = "Некорректно введены данные";
            }
            if (Regex.IsMatch(textBox1.Text, "^[А-Яа-я0-9]+$") || Regex.IsMatch(textBox2.Text, "^[A-Za-z0-9]+$"))
            {
                label1.Text = "Введены неверные символы";
            }
            else
            {
                File.AppendAllText("C:\\Program Files\\Новая папка\\English Teacher\\bin\\Release\\text.txt", 
                    $"{textBox1.Text}\t{textBox2.Text}\n");
                label1.Text = "Новое слово добавлено";
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 mode1 = new Form2();
            mode1.Show();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}