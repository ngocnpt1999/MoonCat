using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat.Model
{
    [Table("Seat")]
    public class Seat : BaseModel
    {
        private int id;
        private string row;
        private int number;
        private int status = 0;

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
        [Column("row")]
        public string Row
        {
            get => row;
            set
            {
                row = value;
                OnPropertyChanged();
            }
        }
        [Column("number")]
        public int Number
        {
            get => number;
            set
            {
                number = value;
                OnPropertyChanged();
            }
        }
        public int Status
        {
            get => status;
            set
            {
                status = value;
                OnPropertyChanged();
            }
        }
    }
}