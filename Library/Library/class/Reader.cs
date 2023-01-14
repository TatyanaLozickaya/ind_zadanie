using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Reader
    {
        private string FIO; //Фамилия, имя, отчество
        private string birthdate; //Дата рождения
        private string phone; //Телефон
        private int code;//Номер читательского билета
        
        public string getFIO()//Метод получения ФИО
        {
            return this.FIO;
        }

        public int getCode()//Метод получения кода
        {
            return this.code;
        }

        public void setCode(int code)//Метод присвоения кода
        {
            this.code = code;
        }

        public void setFIO(string FIO)//Метод присвоения ФИО
        {
            this.FIO = FIO;
        }

        public string getBirthdate()//Метод получения даты рождения
        {
            return this.birthdate;
        }

        public void setBirthdate(string dateTime)//Метод присвоения дата рождения
        {
            this.birthdate = dateTime;
        }

        public string getPhone()//Метод получения номера телефона
        {
            return this.phone;
        }

        public void setPhone(string phone)//Метод присвоения номера телефона
        {
            this.phone = phone;
        }

        public Reader(string FIO, string birthdate, string phone)//Конструктор создания читателя без номера читательского билета
        {
            this.FIO = FIO;
            this.birthdate = birthdate;
            this.phone = phone;
        }

        public Reader(string FIO, string birthdate, string phone, int code)//Конструктор создания читателя с номером читательского билета
        {
            this.FIO = FIO;
            this.birthdate = birthdate;
            this.phone = phone;
            this.code = code;
        }


        public string toString()//Метод, возвращающий текстовую информацию о читателе
        {
            return this.getFIO() + " " + this.getBirthdate() + " " + this.getPhone() + " " + this.getCode() + "\n";
        }
    }
}
