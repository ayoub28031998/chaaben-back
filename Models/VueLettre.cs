using System;
using System.Collections.Generic;

namespace API_SurveillenceCommerciale.Models
{
    public partial class VueLettre
    {
        public string NumeroLettre { get; set; } = null!;
        public string Mois { get; set; } = null!;
        public string NumeroFacture { get; set; } = null!;
        public string MatriculeClient { get; set; } = null!;
        public decimal MontantLettre { get; set; }
        public string DateLettre { get; set; } = null!;
        public string Echeance { get; set; } = null!;
        public string MatriculeBanque { get; set; } = null!;
        public string CompteBanquaire { get; set; } = null!;
        public string MatriculeVille { get; set; } = null!;
        public string Numreg { get; set; } = null!;
        public string Nomcli { get; set; } = null!;
        public string CodeAval1 { get; set; } = null!;
        public string CodeAval2 { get; set; } = null!;
        public string CodeAval3 { get; set; } = null!;
        public string CodeAval4 { get; set; } = null!;
        public string Dhamen { get; set; } = null!;
        public decimal MontantFacture { get; set; }
        public string Verse { get; set; } = null!;
        public string Juridique { get; set; } = null!;
        public decimal MontantPayee { get; set; }
        public decimal Acompte1 { get; set; }
        public decimal Acompte2 { get; set; }
        public decimal Acompte3 { get; set; }
        public string DateAcompte1 { get; set; } = null!;
        public string DateAcompte2 { get; set; } = null!;
        public string DateAcompte3 { get; set; } = null!;
        public string BordRet1 { get; set; } = null!;
        public string BordRet2 { get; set; } = null!;
        public string BordRet3 { get; set; } = null!;
        public string DatePayement { get; set; } = null!;
        public string Regle { get; set; } = null!;
        public string Impaye { get; set; } = null!;
        public string NumeroLettreGenerer { get; set; } = null!;
        public string NumeroBorderau { get; set; } = null!;
        public string DateBorderau { get; set; } = null!;
        public string NumeroBorderauRetour { get; set; } = null!;
        public string DateBorderauRetour { get; set; } = null!;
        public string MatriculeVilleAller { get; set; } = null!;
        public decimal MntInt { get; set; }
        public string Echea { get; set; } = null!;
        public string Numclit { get; set; } = null!;
        public string MatriculeVilleClient { get; set; } = null!;
        public string Hist { get; set; } = null!;
        public string ErrSonia { get; set; } = null!;
        public string Numborerr { get; set; } = null!;
        public string RaisonSociale { get; set; } = null!;
    }
}
