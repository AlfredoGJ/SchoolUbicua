using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Models
{
     public class Profesor
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public string titulo { get; set; }
        public string FullName { get => nombre + " " + apPaterno + " " + apMaterno; }

        public Profesor()
        {
        }

        public Profesor(string nombre, string appaterno, string apmaterno,string titulo)
        {
            this.nombre = nombre;
            this.apPaterno = appaterno;
            this.apMaterno = apmaterno;
            this.titulo = titulo;
        }
        public override string ToString()
        {
            return id.ToString() + " " + FullName;
        }

    }
}
