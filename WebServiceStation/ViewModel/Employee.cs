using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service_Station.Models
{
    public class Employee : BaseUser
    {
        public string Position { get; set; }
    }
}