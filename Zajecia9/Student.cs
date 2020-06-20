using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia9
{
    public class Student
    {
        public int id { get; set; }

        public string name { get; set; }
        public string surName { get; set; }
        public DateTime birthday { get; set; }
    }

    public class StudentList
    {
        public ObservableCollection<Student> Students { get; set; }
    }

    public class StudentView
    {
        public StudentList List { get; set; }

        public StudentView()
        {
            List = new StudentList()
            {
                Students = new ObservableCollection<Student>()
                {
                    new Student
                    {
                    id = 1,
                    name = "Adam",
                    surName = "Abacki",
                    birthday = new DateTime(1996, 04, 10),
                    },
                    new Student
                    {
                    id = 2,
                    name = "Barbara",
                    surName = "Babacka",
                    birthday = new DateTime(1966, 06, 16),
                    },
                    new Student
                    {
                    id = 3,
                    name = "Cyprian",
                    surName = "Cabacki",
                    birthday = new DateTime(2002, 12, 12),
                    },
                    new Student
                    {
                    id = 4,
                    name = "Dawid",
                    surName = "Dabacki",
                    birthday = new DateTime(2012, 10, 10),
                    }

                }
            };
        }
    }


}
