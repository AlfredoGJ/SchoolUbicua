using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Models
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public string FullName { get=> nombre + " " + apPaterno + " " + apMaterno; }

        public Student()
        {
        }
        public Student(string nombre, string appaterno, string apmaterno)
        {
            this.nombre = nombre;
            this.apPaterno = appaterno;
            this.apMaterno = apmaterno;
        }

    }
}
