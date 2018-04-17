using School.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;

namespace School.Data
{
    public class GroupController
    {
        static object locker = new object();
        SQLiteConnection database;

        public GroupController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Group>();
        }


        public Group GetGroup()
        {
            lock (locker)
            {
                if (database.Table<Group>().Count() == 0)
                    return null;
                else
                    return database.Table<Group>().First();

            }
        }

        public int SaveGroup(Group Group)
        {
            lock (locker)
            {
                if (Group.id != 0)
                {
                    database.Update(Group);
                    return Group.id;
                }
                else
                    return database.Insert(Group);
            }
        }

        public int DeleteGroup(int id)
        {
            lock (locker)
            {
                return database.Delete<Group>(id);
            }
        }

        public List<Group> GetAll()
        {
            return database.Table<Group>().ToList();
        }


    }
}
