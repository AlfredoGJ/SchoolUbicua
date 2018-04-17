using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Models
{
    public class Group
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        private List<long> studentkeys = new List<long>();
        public string profesor { get; set; }

        
        
        public Group()
        {
        }

        public Group(string nombre, string profesor,List<long> students)
        {
            this.nombre = nombre;
            this.profesor = profesor;
            this.studentkeys = students;
            
        }

    }
}
