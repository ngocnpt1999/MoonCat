using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat.Model
{
    [Table("Bank")]
    public class Bank : BaseModel
    {
        private int id;
        private string name;
        private string logo;

        [Column("id")]
        public int ID
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        [Column("name")]
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        [Column("logo")]
        public string Logo
        {
            get => logo;
            set
            {
                logo = value;
                OnPropertyChanged();
            }
        }
    }
}