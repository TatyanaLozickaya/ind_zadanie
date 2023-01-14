using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Library.forms
{
    public partial class form_reader : Form
    {
        public form_reader()
        {
            InitializeComponent();
        }

        private void form_reader_Load(object sender, EventArgs e)//Метод загрузки формы
        {
            bookListBox.Items.AddRange(File.ReadAllLines("BooksFile.txt"));
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Метод поиска
        {
            string[] books = File.ReadAllLines("BooksFile.txt");
            bookListBox.Items.Clear();
            foreach (string book in books)
            {
                if (book.ToLower().Contains(textBox1.Text.ToLower()))
                {
                    bookListBox.Items.Add(book);                   
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)//Метод перехода на главную форму
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void bookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Метод перехода на форму создания заявки
        {
            form_report report = new form_report();
            report.Show();
            Hide();
        }

     
    }
}
