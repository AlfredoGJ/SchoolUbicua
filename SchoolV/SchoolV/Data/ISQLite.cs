using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace School.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
