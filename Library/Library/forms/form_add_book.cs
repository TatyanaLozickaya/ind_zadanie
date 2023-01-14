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
    public partial class form_add_book : Form
    {
        private int index;
        
        public form_add_book()//Конструктор формы "Добавлениe книги"
        {
            InitializeComponent();
            button1.Click -= new EventHandler(button1_ClickEdit);
            
        }
        
        public form_add_book(int index)//Конструктор формы "Редактированиe книги"
        {
            InitializeComponent();
            label1.Text = "Редактирование книги";
            button1.Text = "Сохранить";
            button1.Click -= new EventHandler(button1_Click);
            button1.Click += new EventHandler(button1_ClickEdit);
            string[] books = File.ReadAllLines("BooksFile.txt");
            try
            {
                string[] words = books[index].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Book oldBook = new Book(words[0], words[1], words[2], words[3]);
                this.index = index;
                nameTextBox.Text = oldBook.getName();
                authorTextBox.Text = oldBook.getAuthor();
                codeTextBox.Text = oldBook.getCode();
                descriptionTextBox.Text = oldBook.getDescription();
            }
            catch(Exception ex) 
            { 
            MessageBox.Show("Вы не выбрали книгу");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)//Метод добавления книги
        {
            Book book = new Book(nameTextBox.Text, authorTextBox.Text, codeTextBox.Text, descriptionTextBox.Text);
            string filename = "BooksFile.txt";
            string path = Directory.GetCurrentDirectory();
            File.AppendAllText(path + '\\' + filename, book.toString());
            Hide();
        }

        private void button1_ClickEdit(object sender, EventArgs e)//Метод редактирования книги
        {
            string[] books = File.ReadAllLines("BooksFile.txt");
            Book editBook = new Book(nameTextBox.Text, authorTextBox.Text, codeTextBox.Text, descriptionTextBox.Text);
            books[index] = editBook.toString();
            
            File.WriteAllText("BooksFile.txt", "");
            StreamWriter sw = File.AppendText("BooksFile.txt");
            foreach (string book in books)
            {
                sw.WriteLine(book);
            }
            sw.Close();
            Hide();
        }

        private void form_add_book_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
     
            Hide();
        }
    }
}
