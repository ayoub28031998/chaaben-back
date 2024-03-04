using System;
using System.Collections.Generic;

namespace API_SurveillenceCommerciale.Models
{
    public partial class ParametreDiver
    {
        public string CodeSociete { get; set; } = null!;
        public decimal TauxMajoration { get; set; }
        public decimal TauxFodec { get; set; }
        public decimal TimbreFiscal { get; set; }
        public decimal TauxRetenu { get; set; }
        public decimal MargePerte { get; set; }
        public decimal MargeProfit { get; set; }
        public string DepotAchat { get; set; } = null!;
        public string DepotVente { get; set; } = null!;
        public string MotPasseModification { get; set; } = null!;
        public string MotPasseSuppression { get; set; } = null!;
        public string MotPasseAdministrateur { get; set; } = null!;
        public bool ChoixUniteAv { get; set; }
        public bool GestionLot { get; set; }
        public string ModeGestionStock { get; set; } = null!;
        public string ModeCalculPrix { get; set; } = null!;
        public string ValeurStock { get; set; } = null!;
        public decimal NombreDecimalAchat { get; set; }
        public decimal NombreDecimalVente { get; set; }
        public bool CalculAutoPrixVente { get; set; }
        public bool CalculAutoMarge { get; set; }
        public bool ControleReglement { get; set; }
        public bool? Assujetti { get; set; }
        public string CodeCompte { get; set; } = null!;
        public decimal TauxInteret { get; set; }
        public string? CodeClientPassager { get; set; }
        public string? CodeFournisseurPassager { get; set; }
        public DateTime? DateDebutExercice { get; set; }
        public DateTime? DateFinExercice { get; set; }
        public bool NumeroSerie { get; set; }
        public bool CodeBarre { get; set; }
        public bool PointVente { get; set; }
        public string CodeClientDetail { get; set; } = null!;
        public bool RegimeReel { get; set; }
        public decimal TauxAvanceImpot { get; set; }
        public bool? ImpressionMatricielle { get; set; }
    }
}
