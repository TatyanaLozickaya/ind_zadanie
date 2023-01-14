using Library.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Переход на форму читателя
        {
            form_reader form = new form_reader();
            form.Show();
            Hide();
        }

        private void registrationButton_Click(object sender, EventArgs e)//Переход на форму регистрации
        {
            form_registration  form= new form_registration();
            form.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)//Переход на форму сотрудника библиотеки
        {
            form_employeer form = new form_employeer();
            form.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
