using System;

namespace Onxy.models
{
    public class User
    {
        public int RecordId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public bool Isactive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Date { get; set; }




    }
}
