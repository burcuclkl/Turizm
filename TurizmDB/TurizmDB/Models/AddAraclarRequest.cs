using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurizmDB.Models
{
    public class AddAraclarRequest
    {

        public string AracTipi { get; set; }

        public int MaxKisi { get; set; }

        public int MinKisi { get; set; }
    }
}