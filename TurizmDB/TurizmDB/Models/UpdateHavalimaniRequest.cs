using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurizmDB.Models
{
    public class UpdateHavalimaniRequest
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public string Sehir { get; set; }
    }
}