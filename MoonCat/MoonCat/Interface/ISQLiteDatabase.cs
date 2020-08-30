using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat.Interface
{
    public interface ISQLiteDatabase
    {
        SQLiteConnection CreateConnection();
        void CopyDatabaseIfNotExists();
    }
}
