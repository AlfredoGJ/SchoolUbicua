using School.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace School.Data
{
    public class ProfesorController
    {
        static object locker = new object();
        SQLiteConnection database;

        public ProfesorController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Profesor>();
        }


        public Profesor GetProfesor()
        {
            lock (locker)
            {
                if (database.Table<Profesor>().Count() == 0)
                    return null;
                else
                    return database.Table<Profesor>().First();

            }
        }

        public int SaveProfesor(Profesor Profesor)
        {
            lock (locker)
            {
                if (Profesor.id != 0)
                {
                    database.Update(Profesor);
                    return Profesor.id;
                }
                else
                    return database.Insert(Profesor);
            }
        }

        public int DeleteProfesor(int id)
        {
            lock (locker)
            {
                return database.Delete<Profesor>(id);
            }
        }

        public List<Profesor> GetAll()
        {
            lock (locker)
            {
                return database.Table<Profesor>().ToList();
            }
        }


    }
}
