using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat.Model
{
    [Table("Movie")]
    public class Movie : BaseModel
    {
        private int id;
        private string name;
        private string image;
        private string producer;
        private string director;
        private string premiere;
        private string duration;
        private string detail;
        private string trailerURL;

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
        [Column("image")]
        public string Image
        {
            get => image;
            set
            {
                image = value;
                OnPropertyChanged();
            }
        }
        [Column("producer")]
        public string Producer
        {
            get => producer;
            set
            {
                producer = value;
                OnPropertyChanged();
            }
        }
        [Column("director")]
        public string Director
        {
            get => director;
            set
            {
                director = value;
                OnPropertyChanged();
            }
        }
        [Column("premiere")]
        public string Premiere
        {
            get => premiere;
            set
            {
                premiere = value;
                OnPropertyChanged();
            }
        }
        [Column("duration")]
        public string Duration
        {
            get => duration;
            set
            {
                duration = value;
                OnPropertyChanged();
            }
        }
        [Column("detail")]
        public string Detail
        {
            get => detail;
            set
            {
                detail = value;
                OnPropertyChanged();
            }
        }
        [Column("trailer")]
        public string TrailerURL
        {
            get => trailerURL;
            set
            {
                trailerURL = value;
                OnPropertyChanged();
            }
        }
    }
}