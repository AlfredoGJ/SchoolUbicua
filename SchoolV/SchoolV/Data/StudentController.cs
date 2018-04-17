using School.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace School.Data
{
    public class StudentController
    {
        static object locker = new object();
        SQLiteConnection database;

        public StudentController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Student>();
        }

        public List<Student> GetAll()
        {
            lock (locker)
            {
                return database.Table<Student>().ToList<Student>();
            }
        }

        public Student GetStudent()
        {
            lock (locker)
            {
                if (database.Table<Student>().Count() == 0)
                    return null;
                else
                    return database.Table<Student>().First();

            }
        }

        public int SaveStudent(Student student)
        {
            lock (locker)
            {
                if (student.id != 0)
                {
                    database.Update(student);
                    return student.id;
                }
                else
                    return database.Insert(student);
            }
        }

        public int DeleteStudent(int id)
        {
            lock (locker)
            {
                return database.Delete<Student>(id);
            }
        }


    }
}
