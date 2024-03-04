using System;
using System.Collections.Generic;

namespace API_SurveillenceCommerciale.Models
{
    public partial class VueSuivieClient
    {
        public string NumeroLettre { get; set; } = null!;
        public string NumeroFacture { get; set; } = null!;
        public string MatriculeClient { get; set; } = null!;
        public decimal MontantLettre { get; set; }
        public string Echeance { get; set; } = null!;
        public string NumeroLettreGenerer { get; set; } = null!;
        public string Regle { get; set; } = null!;
        public string Impaye { get; set; } = null!;
        public string NumeroBorderau { get; set; } = null!;
        public string Mois { get; set; } = null!;
        public string Juridique { get; set; } = null!;
        public decimal MontantPayee { get; set; }
        public decimal Acompte1 { get; set; }
        public decimal Acompte2 { get; set; }
        public decimal Acompte3 { get; set; }
        public string CodeNature { get; set; } = null!;
        public string DatePayement { get; set; } = null!;
    }
}
