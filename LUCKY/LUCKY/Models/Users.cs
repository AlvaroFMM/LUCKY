using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace LUCKY.Models
{
     public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int IDUser { get; set; }
        public string nombre { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
    }

}
