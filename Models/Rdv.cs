using System;
using System.Collections.Generic;

namespace API_SurveillenceCommerciale.Models
{
    public partial class Rdv
    {
        public string CodeConserner { get; set; } = null!;
        public DateTime DateRdv { get; set; }
        public string MatriculeClient { get; set; } = null!;
        public string CodeNatureTraite { get; set; } = null!;
        public string Sujet { get; set; } = null!;
        public string NomUtilisateur { get; set; } = null!;
        public DateTime? DateCreation { get; set; }
        public DateTime? HeureCreation { get; set; }
    }
}
