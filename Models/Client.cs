using System;
using System.Collections.Generic;

namespace API_SurveillenceCommerciale.Models
{
    public partial class Client
    {
        public string MatriculeClient { get; set; } = null!;
        public string RaisonSociale { get; set; } = null!;
        public string RaisonSociale1 { get; set; } = null!;
        public string Adresse { get; set; } = null!;
        public string Adresse2 { get; set; } = null!;
        public string Adresse3 { get; set; } = null!;
        public string AdresseTravail { get; set; } = null!;
        public string AdresseTravail2 { get; set; } = null!;
        public string Telephone { get; set; } = null!;
        public string Telephone2 { get; set; } = null!;
        public string Reglement { get; set; } = null!;
        public string DateReglement { get; set; } = null!;
        public string TypeClient { get; set; } = null!;
        public string NumeroCin { get; set; } = null!;
        public string MatriculeBanque { get; set; } = null!;
        public string Ribbancaire { get; set; } = null!;
        public string VilleCompte { get; set; } = null!;
        public string Region { get; set; } = null!;
        public string MatriculeVille { get; set; } = null!;
        public string Cadrtrv { get; set; } = null!;
        public string Cadrtrv1 { get; set; } = null!;
        public string DateCin { get; set; } = null!;
        public string DateCreation { get; set; } = null!;
        public string NumeroCnss { get; set; } = null!;
        public string Observation { get; set; } = null!;
        public string Matdom { get; set; } = null!;
        public string Hist { get; set; } = null!;
        public bool Comptensieux { get; set; }
    }
}
