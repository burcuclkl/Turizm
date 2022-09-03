using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurizmDB.Models
{
    public class UpdateVarisNoktalariRequest
    {

        public string VarisNokta { get; set; }

        public int HavalimaniId { get; set; }

        public int VarisNoktaId { get; set; }
    }
}