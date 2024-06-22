using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace C__11
{
    class Student
    {
        public string firstname;//имя
        public string Firstname { get; set; }
        public string secondname;//отчество
        public string Secondname { get; set; }
        public string lastname;//фамилия
        public string Lastname { get; set; }
        public string birthday;//дата рождения
        public string address;//домашний адрес
        public string phone;//телефон
        List<int> tests;//зачеты
        List<int> termPapers;//курсовые работы
        List<int> exams;//экзамены
        List<Student> group = new List<Student>();

        public Student() : this(10, 11, 11)
        {
            //Console.WriteLine("C-tor without params");
        }

        public Student(int test, int term, int exam) : this("Иван", "Иванович", "Иванов", "12.01.2003", "г.Одесса ул.Пушкинская 10", "069635422", 12, 12, 12)
        {
            tests = new List<int>();
            SetTests(test);
            termPapers = new List<int>();
            SetTermPapers(term);
            exams = new List<int>();
            SetExams(exam);

            //Console.WriteLine("C-tor with params");
        }
        public Student(string firstname, string secondname, string lastname)
        {
            Firstname = firstname;
            Secondname = secondname;
            Lastname = lastname;

            //Console.WriteLine("C-tor with 3 params");
        }
        public Student(string firstname, string secondname, string lastname, string birthday, string address, string phone, int test, int term, int exam)//main c-tor
        {
            SetFirstname(firstname);
            SetSecondname(secondname);
            SetLastname(lastname);
            SetBirthday(birthday);
            SetAddress(address);
            SetPhone(phone);
            tests = new List<int>();
            SetTests(test);
            termPapers = new List<int>();
            SetTermPapers(term);
            exams = new List<int>();
            SetExams(exam);

            //Console.WriteLine("Main c-tor");
        }

        public void SetFirstname(string firstname)
        {
            this.firstname = firstname;
        }

        public void SetSecondname(string secondname)
        {
            this.secondname = secondname;
        }

        public void SetLastname(string lastname)
        {
            this.lastname = lastname;
        }

        public void SetBirthday(string birthday)
        {
            this.birthday = birthday;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void SetPhone(string phone)
        {
            this.phone = phone;
        }

        public void SetTests(int test)
        {
            tests.Add(test);
        }

        public void SetTermPapers(int term)
        {
            termPapers.Add(term);
        }

        public void SetExams(int exam)
        {
            exams.Add(exam);
        }

        public string GetFirstname()
        {
            return firstname != null ? firstname : "Не задано";
        }

        public string GetSecondname()
        {
            return secondname != null ? secondname : "Не задано";
        }

        public string GetLastname()
        {
            return lastname != null ? lastname : "Не задано";
        }

        public string GetBirthday()
        {
            return birthday != null ? birthday : "Не задано";
        }

        public string GetAddress()
        {
            return address != null ? address : "Не задано";
        }

        public string GetPhone()
        {
            return phone != null ? phone : "Не задано";
        }

        public List<int> GetTests()
        {
            return tests;
        }

        public List<int> GetTermPapers()
        {
            return termPapers;
        }

        public List<int> GetExams()
        {
            return exams;
        }

        public void Print()
        {
            Console.WriteLine("Имя: " + firstname);
            Console.WriteLine("Отчество: " + secondname);
            Console.WriteLine("Фамилия: " + lastname);
            Console.WriteLine("Дата рождения: " + birthday);
            Console.WriteLine("Адрес проживания: " + address);
            Console.WriteLine("Телефон: " + phone);
            foreach (int test in tests)
            {
                Console.WriteLine("Оценки за зачеты: " + test);
            }
            foreach (int term in termPapers)
            {
                Console.WriteLine("Оценки за зачеты: " + term);
            }
            foreach (int exam in exams)
            {
                Console.WriteLine("Оценки за зачеты: " + exam);
            }
            Console.WriteLine();
        }

        public void AddStudent(Student student)
        {
            group.Add(student);
        }
        public override string ToString()
        {
            return firstname + " " + secondname + " " + lastname + " " + birthday + " " + address + " " + phone + " ";
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator true(Student student)
        {
            return student.firstname != null;
        }
        public static bool operator false(Student student)
        {
            return student.firstname == null;
        }
        public static bool operator ==(Student left, Student right)
        {
            if ((object)left != null) return left.Equals(right);
            if ((object)right != null) return right.Equals(left);

            return left.birthday == right.birthday;
        }

        public static bool operator !=(Student left, Student right)
        {
            return !(left.birthday == right.birthday);
        }

        public static bool operator >(Student left, Student right)
        {
            string a = left.lastname;
            string b = right.lastname;

            return a.Length > b.Length;
        }
        public static bool operator <(Student left, Student right)
        {
            string a = left.lastname;
            string b = right.lastname;

            return a.Length < b.Length;
        }
    }
}
