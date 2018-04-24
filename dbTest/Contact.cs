using System;
using SQLite;

namespace dbTest
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int id {
            get; set;
        }


        public string name { get; set; }

        public string phoneNumber { get; set; }

    }
}
