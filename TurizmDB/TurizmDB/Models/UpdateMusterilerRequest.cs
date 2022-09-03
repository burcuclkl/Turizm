using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurizmDB.Models
{
    public class UpdateMusterilerRequest
    {
        public int MusteriId { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Email { get; set; }

        public string EvTel { get; set; }

        public string CepTel { get; set; }

        public string EvAdres { get; set; }


    }
}