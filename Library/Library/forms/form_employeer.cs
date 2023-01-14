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

namespace Library.forms
{
    public partial class form_employeer : Form
    {
        public form_employeer()
        {
            InitializeComponent();
        }

        private void form_employeer_Load(object sender, EventArgs e)//Метод загрузки формы
        {
            bookListBox.Items.AddRange(File.ReadAllLines("BooksFile.txt"));
        }

        private void button2_Click(object sender, EventArgs e)//Метод редактирования книги
        {
            int index = bookListBox.SelectedIndex;
            form_add_book book = new form_add_book(index);
            book.Show();
            
        }

        private void bookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Метод создания книги
        {
            form_add_book book = new form_add_book();
            book.Show();
        }

        private void form_employeer_Activated(object sender, EventArgs e)//Метод, при активации формы, загружаются книги
        {
            bookListBox.Items.Clear();
            bookListBox.Items.AddRange(File.ReadAllLines("BooksFile.txt"));
        }

        private void deleteButton_Click(object sender, EventArgs e)//Метод удаления книги
        {
            try
            {
                int index = bookListBox.SelectedIndex;
                var lines = File.ReadAllLines("BooksFile.txt").ToList();
                lines.RemoveAt(index);
                File.WriteAllLines("BooksFile.txt", lines);
                bookListBox.Items.Clear();
                bookListBox.Items.AddRange(File.ReadAllLines("BooksFile.txt"));
            }
            catch
            {
                MessageBox.Show("Вы не выбрали книгу");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//Переход на форму "Оформление выдачи"
        {
            form_issuance form = new form_issuance();
            form.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)//Переход на форму "Оформление приёма"
        {
            form_issuance form = new form_issuance(true);
            form.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)//Переход на главную форму
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }
    }
}
