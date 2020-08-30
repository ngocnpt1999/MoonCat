using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat.Model
{
    [Table("MovieShowing")]
    public class MovieShowing : BaseModel
    {
        private int id;
        private int id_movie;
        private int id_cinema;
        private string date;
        private string begin;
        private double price;

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
        [Column("id_movie")]
        public int ID_Movie
        {
            get => id_movie;
            set
            {
                id_movie = value;
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
        [Column("date")]
        public string Date
        {
            get => date;
            set
            {
                date = value;
                OnPropertyChanged();
            }
        }
        [Column("begin")]
        public string Begin
        {
            get => begin;
            set
            {
                begin = value;
                OnPropertyChanged();
            }
        }
        [Column("price_ticket")]
        public double Price
        {
            get => price;
            set
            {
                price = value;
                OnPropertyChanged();
            }
        }
    }
}