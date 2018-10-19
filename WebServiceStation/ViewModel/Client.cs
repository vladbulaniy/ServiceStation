using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service_Station.Models
{
    public class Client: BaseUser
    {
        public bool isRegular { get; set; }
    }
}