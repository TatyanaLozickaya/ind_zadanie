using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string name; //Название книги
        private string author; //Автор
        private string code; //Код издания
        private string description; //Текстовое описание книги
        private string status; //Поле статус "На руках" или "Библиотека"

        public Book(string name, string author, string code, string description) //Конструктор создания книги 
        {
            this.name = name;
            this.author = author;
            this.code = code;
            this.description = description;
            this.status = "Библиотека";
        }

        public string getName()//Метод получения названия книги
        {
            return this.name;
        }

        public string getAuthor()//Метод получения автора книги
        {
            return this.author;
        }

        public string getCode()//Метод получения кода издания
        {
            return this.code;
        }

        public string getDescription()//Метод получения текстового описания
        {
            return this.description;
        }

        public void setName(string name)//Метод присвоения названия книги
        {
            this.name = name;
        }

        public void setAuthor(string author)//Метод присвоения автора книги
        {
            this.author = author;
        }

        public void setCode(string code)//Метод присвоения кода издания книги
        {
            this.code = code;
        }
        
        public void setDescription(string description)//Метод присвоения текстового описания книги
        {
             this.description = description;
        }

        public string toString()//Метод, возвращающий информацию о книге
        {
            return this.name + " " + this.author + " " + this.code+ " " + this.description + "\n";
        }

        public void setStatus(string status)//Метод присвоения статуса книги
        {
            this.status = status;
        }

        public string getStatus()//Метод получения статуса книги
        {
            return this.status;
        }

    }
}
