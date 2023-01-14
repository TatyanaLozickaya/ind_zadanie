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
using static System.Net.Mime.MediaTypeNames;

namespace Library.forms
{
    public partial class form_registration : Form
    {
        public form_registration()//Конструктор создания формы
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Регистрация читателя
        {
            string filename = "RegistrationFile.txt";
            string path = Directory.GetCurrentDirectory();
            string[] readers = File.ReadAllLines("RegistrationFile.txt");
            Reader reader = new Reader(fioTextBox.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), NumberTextBox.Text, readers.Length + 1);
            File.AppendAllText(path + '\\' + filename, reader.toString());
            form_info form = new form_info(reader);
            form.Show();
            Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//Переход на главную форму
        {
            Form1 form  = new Form1();
            form.Show();
            Hide();
        }

        private void form_registration_Load(object sender, EventArgs e)
        {

        }
    }
}
