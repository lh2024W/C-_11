using System;
using System.Collections;

namespace C__11
{
    class Group : IEnumerable
    {
        List<Student> group = new List<Student>();
        enum Specializations { Программирование, HTML, Кибербезопасность };
        public string name;
        public string Name
        {
            get { return name != null ? name : "Не задано"; }
            set { name = value; }
        }
        public string specialization;
        public string Specialization
        {
            get { return specialization != null ? specialization : "Не задано"; }
            set { specialization = value; }
        }
        public int course;
        public int Course
        {
            get { return course != 0 ? course : 0; }
            set { course = value; }
        }

        public Group() : this("ПВ312", "Программирование", 2)
        {
            //Console.WriteLine ("c-tor without params");
        }

        //main c-tor
        public Group(string name, string specialization, int course)
        {
            Name = name;
            Specialization = specialization;
            Course = course;
            //Console.WriteLine("main c-tor");
        }

        /* public Group() : this("ПВ312", "Программирование", 2)
         {
             //Console.WriteLine ("c-tor without params");
         }

         //main c-tor
        /* public Group(string name, string specialization, int course)
         {
             SetName(name);
             SetSpecialization(specialization);
             SetCourse(course);
             //Console.WriteLine("main c-tor");
         }

         /*public void SetName(string name)
         {
             this.name = name;
         }

         public void SetSpecialization(string specialization)
         {
             this.specialization = specialization;
         }

         public void SetCourse(int number)
         {
             course = number;
         }
         */
        public void AddStudent(Student student)
        {
            group.Add(student);
        }

        public override string ToString()
        {
            return name + " " + specialization + " " + course + " ";
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return group.GetEnumerator();
        }


        public static bool operator ==(Group left, Group right)
        {
            if ((object)left != null) return left.Equals(right);
            if ((object)right != null) return right.Equals(left);

            return left.specialization == right.specialization;
        }

        public static bool operator !=(Group left, Group right)
        {
            return !(left.specialization == right.specialization);
        }

        private Group[] groupArr;
        public Group(int size)
        {
            groupArr = new Group[size];
        }
        public int Length
        {
            get { return groupArr.Length; }
        }
        public Group this[uint index]
        {
            get
            {
                if (index >= 0 && index < groupArr.Length)
                {
                    return groupArr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                groupArr[index] = value;
            }
        }
        public Group this[string specialization]
        {
            get
            {
                if (Enum.IsDefined(typeof(Specializations), specialization))
                {
                    return groupArr[(int)Enum.Parse(typeof(Specializations), specialization)];
                }
                else
                {
                    return new Group();
                }
            }
            set
            {
                if (Enum.IsDefined(typeof(Specializations), specialization))
                {
                    groupArr[(int)Enum.Parse(typeof(Specializations), specialization)] = value;
                }
            }
        }
        public int FindByCourse(int course)
        {
            for (int i = 0; i < groupArr.Length; i++)
            {
                if (groupArr[i].course == course)
                {
                    return i;
                }
            }
            return -1;
        }

        public Group this[int course]
        {
            get
            {
                if (FindByCourse(course) >= 0)
                {
                    return this[FindByCourse(course)];
                }
                throw new Exception("Недопустимое значение курса.");
            }
            set
            {
                if (FindByCourse(course) >= 0)
                {
                    this[FindByCourse(course)] = value;
                }
            }
        }

        public int FindByName(string name)
        {
            for (int i = 0; i < groupArr.Length; i++)
            {
                if (groupArr[i].name == name)
                {
                    return i;
                }
            }
            return -1;
        }

        /*public Group this[string name]
        {
            get
            {
                if (FindByName(name) >= 0)
                {
                    return this[FindByName(name)];
                }
                throw new Exception("Недопустимое имя группы.");
            }
            set
            {
                if (FindByName(name) >= 0)
                {
                    this[FindByName(name)] = value;
                }
            }
        }*/

    }
    class Program
    {
        static void Main()
        {/*
            var g = new Group();
            Student s = new Student();
            Console.WriteLine(g.ToString());
            Console.WriteLine(s.ToString());
            Console.WriteLine();
            s = new Student("Федор", "Иванович", "Аврамов", "10.05.1999", "г.Одесса", "04825546", 9, 9, 8);
            s.AddStudent(s);
            Console.WriteLine(g.ToString());
            Console.WriteLine(s.ToString());

            Student s1 = new Student("Аркадий", "Борисович", "Максименко", "20.10.2001", "г.Николаев", "09765225445", 10, 9, 12);
            s1.AddStudent(s1);
            Console.WriteLine(g.ToString());

            Console.WriteLine(s == s1);//==
            Console.WriteLine(s != s1);//!=
            Console.WriteLine(s > s1);//>
            Console.WriteLine(s < s1);//<
            
            if (s)//true/false
            {
                Console.WriteLine("Студент есть!");
            }
            else { Console.WriteLine("Студент отсутствует!"); }
            
            Group g1 = new Group("ПВ313", "HTML", 1);
            Group g2 = new Group("ПВ314", "R ", 1);
            Console.WriteLine(g == g1);//==
            Console.WriteLine(g != g1);//!=

            //g.FindByName("Программирование");
            //g.FindByCourse(2);*/

            /* var g = new Group();
             g.Name = "Test";
             g.Specialization = "Test";
             g.Course = 2;
             Student s = new Student();
             Console.WriteLine(g.ToString());
             Console.WriteLine(s.ToString());
             Console.WriteLine();
             s = new Student("Федор", "Иванович", "Аврамов", "10.05.1999", "г.Одесса", "04825546", 9, 9, 8);
             s.AddStudent(s);
             Console.WriteLine(g.ToString());
             Console.WriteLine(s.ToString());

             g.FindByCourse(2);
             var g1 = new Group();
             g1.Name = "Test";
             g1.Specialization = "Test";
             g1.Course = 2;*/

            var g = new Group();
            Student s = new Student();
            s = new Student("Федор", "Иванович", "Аврамов", "10.05.1999", "г.Одесса", "04825546", 9, 9, 8);
            g.AddStudent(s);
            Student s1 = new Student("Аркадий", "Борисович", "Максименко", "20.10.2001", "г.Николаев", "09765225445", 10, 9, 12);
            g.AddStudent(s1);

            foreach (Student student in g)
            {
                Console.WriteLine(student.ToString());
            }
                
        }

    }
}
