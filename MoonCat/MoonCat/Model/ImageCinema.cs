using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat.Model
{
    [Table("ImageCinema")]
    public class ImageCinema : BaseModel
    {
        private int id;
        private int id_cinema;
        private string url;

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
        [Column("id_cinema")]
        public int ID_Cinema
        {
            get => id_cinema;
            set
            {
                id_cinema = value;
                OnPropertyChanged();
            }
        }
        [Column("source")]
        public string SourceURL
        {
            get => url;
            set
            {
                url = value;
                OnPropertyChanged();
            }
        }
    }
}