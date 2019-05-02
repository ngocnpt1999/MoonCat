using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Linq;

namespace MoonCat.Model
{
    public class CinemaInfo : Cinema
    {
        public ObservableCollection<ImageCinema> Images { get; set; }
    }
}
