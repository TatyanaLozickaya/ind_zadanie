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
    public partial class form_report : Form
    {
        public form_report()//Конструктор создания форму заявки
        {
            InitializeComponent();
            booksComboBox.Items.AddRange(File.ReadAllLines("BooksFile.txt"));
        }

        private void form_report_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Создание заявки
        {
            string filename = "ReportFile.txt";
            string path = Directory.GetCurrentDirectory();
            File.AppendAllText(path + '\\' + filename, booksComboBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0] + "\n");
            form_reader reader = new form_reader();
            reader.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)//Переход на форму читателя
        {
            form_reader form = new form_reader(); 
            form.Show();
            Hide();
        }
    }
}
