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
    public partial class form_info : Form
    {
        public form_info(Reader reader)//Конструктор с созданием читателя
        {
            InitializeComponent();
            codeLabel.Text = "Номер читательского билета: " + Convert.ToString(reader.getCode());
            comboBox1.Items.AddRange(File.ReadAllLines("RegistrationFile.txt"));
        }

        public form_info()//Конструктор без создания читателя
        {
            InitializeComponent();
            comboBox1.Items.AddRange(File.ReadAllLines("RegistrationFile.txt"));
        }

        private void button1_Click(object sender, EventArgs e)//Переход на главную форму
        {
            form_registration form = new form_registration();
            form.Show();
            Hide();
        }

        private void form_info_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//Метод выбора читателя
        {
            var reader = comboBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Last();
            codeLabel.Text = "Номер читательского билета: " + Convert.ToString(reader);
            MessageBox.Show(reader);
            var booksReader = new List<string>();
            var list = File.ReadAllLines("BooksReadersFile.txt").ToList();
            foreach(string item in list)
            {
                
                if (item.Contains(reader))
                {
                    MessageBox.Show("мем");
                    booksReader.Add(item);
                }
            }
            var booksReturnReader = new List<string>();
            var listReturn = File.ReadAllLines("BooksReturnFile.txt").ToList();
            foreach (string item in listReturn)
            {

                if (item.Contains(reader))
                {
                    MessageBox.Show("мем");
                    booksReturnReader.Add(item);
                }
            }
            listBox1.Items.AddRange(booksReader.ToArray());
            listBox2.Items.AddRange(booksReturnReader.ToArray());
        }

        private void button5_Click(object sender, EventArgs e)//Переход на форму регистрации
        {
            form_registration form = new form_registration();
            form.Show();
            Hide();
        }
    }
}
