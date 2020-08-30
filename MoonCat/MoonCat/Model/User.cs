using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat.Model
{
    [Table("User")]
    public class User : BaseModel
    {
        private string username;
        private string password;
        private string name;
        private string avatar;
        private string phone;

        [Column("username")]
        public string UserName
        {
            get => username;
            set
            {
                username = value;
                OnPropertyChanged();
            }
        }
        [Column("password")]
        public string PassWord
        {
            get => password;
            set
            {
                password = value;
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
        [Column("avatar")]
        public string Avatar
        {
            get => avatar;
            set
            {
                avatar = value;
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
    }
}