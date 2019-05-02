using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat.Model
{
    [Table("ImageCinema")]
    public class ImageCinema
    {
        [Column("id")]
        public int ID { get; set; }
        [Column("id_cinema")]
        public int ID_Cinema { get; set; }
        [Column("source")]
        public string SourceURL { get; set; }
    }
}
