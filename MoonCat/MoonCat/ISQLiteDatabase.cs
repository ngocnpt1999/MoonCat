using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat
{
    public interface ISQLiteDatabase
    {
        SQLiteConnection CreateConnection();
        void CopyDatabaseIfNotExists();
    }
}
