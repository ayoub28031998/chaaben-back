using System;
using System.Collections.Generic;

namespace API_SurveillenceCommerciale.Models
{
    public partial class VueListeRdv
    {
        public string CodeConserner { get; set; } = null!;
        public string? LibelleVille { get; set; }
        public DateTime DateRdv { get; set; }
        public string MatriculeClient { get; set; } = null!;
        public string? RaisonSociale { get; set; }
        public string Sujet { get; set; } = null!;
        public string NomUtilisateur { get; set; } = null!;
        public string CodeNatureTraite { get; set; } = null!;
        public string? LibelleTypeRdv { get; set; }
        public string? Telephone { get; set; }
        public string? Telephone2 { get; set; }
    }
}
