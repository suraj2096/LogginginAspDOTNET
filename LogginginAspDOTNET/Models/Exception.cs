using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogginginAspDOTNET.Models
{
    public class Exception
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
        public string Exceptions { get; set; }
        public string stackTrace { get; set; }
    }
}