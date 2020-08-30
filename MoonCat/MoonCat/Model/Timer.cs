using System;
using System.Collections.Generic;
using System.Text;

namespace MoonCat.Model
{
    public class Timer : BaseModel
    {
        private string time;

        public string Time
        {
            get => time;
            set
            {
                time = value;
                OnPropertyChanged();
            }
        }
    }
}