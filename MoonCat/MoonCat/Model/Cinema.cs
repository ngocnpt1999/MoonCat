using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Collections.ObjectModel;

namespace MoonCat.Model
{
    [Table("Cinema")]
    public class Cinema : BaseModel
    {
        private int id;
        private string name;
        private string address;
        private string phone;
        private double x;
        private double y;

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
        [Column("address")]
        public string Address
        {
            get => address;
            set
            {
                address = value;
                OnPropertyChanged();
            }
        }
        [Column("phone")]
        public string Phone
        {
            get => phone;
            set
            {
                phone = value;
                OnPropertyChanged();
            }
        }
        [Column("x")]
        public double X
        {
            get => x;
            set
            {
                x = value;
                OnPropertyChanged();
            }
        }
        [Column("y")]
        public double Y
        {
            get => y;
            set
            {
                y = value;
                OnPropertyChanged();
            }
        }
    }
}
