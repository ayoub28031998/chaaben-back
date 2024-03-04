using System;
using System.Collections.Generic;

namespace API_SurveillenceCommerciale.Models
{
    public partial class VueListeImpaye
    {
        public string Nomcli { get; set; } = null!;
        public string NumeroLettre { get; set; } = null!;
        public decimal MontantLettre { get; set; }
        public string MatriculeClient { get; set; } = null!;
        public string DateLettre { get; set; } = null!;
        public string Echeance { get; set; } = null!;
        public string Impaye { get; set; } = null!;
        public DateTime? DateRdv { get; set; }
    }
}
