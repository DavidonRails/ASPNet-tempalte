using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExquisiteSoftware.Vision.Models
{
    public class ClientContacts
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
    }
}