using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.IO;
using MoonCat.Droid;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabaseConnection_Android))]
namespace MoonCat.Droid
{
    public class DatabaseConnection_Android : ISQLiteDatabase
    {
        public string localDBPath()
        {
            string dbName = "dbBookMovieTicket.db";
            string documentsDirectoryPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsDirectoryPath, dbName);
            return path;
        }

        public SQLiteConnection CreateConnection()
        {
            string path = localDBPath();
            return new SQLiteConnection(path);
        }

        public void CopyDatabaseIfNotExists()
        {
            string path = localDBPath();
            if (!File.Exists(path))
            {
                using (var br = new BinaryReader(Android.App.Application.Context.Assets.Open("dbBookMovieTicket.db")))
                {
                    using (var bw = new BinaryWriter(new FileStream(path, FileMode.Create)))
                    {
                        byte[] buffer = new byte[2048];
                        int length = 0;
                        while ((length = br.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            bw.Write(buffer, 0, length);
                        }
                    }
                }
            }
        }
    }
}