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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library.forms
{
    public partial class form_issuance : Form
    {
        public form_issuance()//Конструктор формы оформления выдачи
        {
            InitializeComponent();
            readersComboBox.Items.AddRange(File.ReadAllLines("RegistrationFile.txt"));
            booksComboBox.Items.AddRange(File.ReadAllLines("BooksFile.txt"));
            readersComboBox.SelectedIndexChanged -= new EventHandler(readersComboBox_SelectedIndexChanged);
            button1.Click -= new EventHandler(button1_ClickPriem);
           
        }


        public form_issuance(bool reception)//Конструктор формы оформления приёма
        {
            InitializeComponent();
            label3.Text = "Оформить приём";
            readersComboBox.Items.AddRange(File.ReadAllLines("RegistrationFile.txt"));
            button1.Click += new EventHandler(button1_ClickPriem);
            button1.Click -= new EventHandler(button1_Click);

        }

        private void form_issuance_Load(object sender, EventArgs e)
        {
        }

        private void readersComboBox_SelectedIndexChanged(object sender, EventArgs e)//Метод получения книг читателя
        {
            string code = readersComboBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[3];
            var books = File.ReadAllLines("BooksReadersFile.txt").ToList();
            booksComboBox.Items.Clear();
            foreach (string book in books)
            {
                if (book.Contains(code + " "))
                {
                    booksComboBox.Items.Add(book);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//Метод оформления выдачи
        {
            string filename = "BooksReadersFile.txt";
            string path = Directory.GetCurrentDirectory();
            File.AppendAllText(path + '\\' + filename, readersComboBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[3] + " " + booksComboBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0] + "\n");
            form_employeer form = new form_employeer();
            form.Show();
            Hide();
        }

        private void button1_ClickPriem(object sender, EventArgs e)//Метод оформления приёма
        {
            string book = booksComboBox.Text;
            var lines = File.ReadAllLines("BooksReadersFile.txt").ToList();
            string filename = "BooksReturnFile.txt";
            string path = Directory.GetCurrentDirectory();
            string removeItem = "";
            foreach(string line in lines)
            {
                removeItem = line;
            }
            lines.Remove(removeItem);
            File.WriteAllLines("BooksReadersFile.txt", lines);
            File.AppendAllText(path + '\\' + filename, removeItem + "\n");
            var reports = File.ReadAllLines("ReportFile.txt").ToList();
            foreach(string line in reports)
            {
                if(line == removeItem.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1])
                {
                    MessageBox.Show("На данную книгу была заявка");
                    removeItem= line;
                }
            }
            reports.Remove(removeItem);
            File.WriteAllLines("ReportFile.txt", lines);
            form_employeer form = new form_employeer();
            form.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)//Переход на форму сотрудника
        {
            form_employeer form = new form_employeer();
            form.Show();
            Hide();
        }
    }
}
