using API_SurveillenceCommerciale.Context;
using API_SurveillenceCommerciale.ModdelsDto;
using API_SurveillenceCommerciale.Models;
using API_SurveillenceCommerciale.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API_SurveillenceCommerciale.Repository
{
    public class SessionJourRepository : ISessionJoursRepository
    {
        private readonly AppDBContext _context;
        public SessionJourRepository(AppDBContext context) { 
            _context = context;
        }
         

        public async Task<TraiteDto> GetSessionJour(DateTime date)
        {   TraiteDto traiteDtos = new TraiteDto();
            List<LettreDto> listLettreDto=new List<LettreDto>();
            List<Lettre> list = new List<Lettre>();
            decimal TT_Journalier = 0;
            list = await _context.Lettres.Where(e => e.DatePayement == date.ToShortDateString() || (e.DateAcompte1 == date.ToShortDateString() || e.DateAcompte2 == date.ToShortDateString() || e.DateAcompte3 == date.ToShortDateString() || e.DateAcompte4 == date.ToShortDateString() || e.DateAcompte5 == date.ToShortDateString())).ToListAsync();
            foreach(Lettre item in list)
            {   
                decimal TT_Avance = 0;
                 LettreDto lettreDto = new  LettreDto();

                if (((item.DateAcompte1.ToString() != "")) && (Convert.ToDateTime(item.DateAcompte1.ToString()) == Convert.ToDateTime(date.ToShortDateString())))
                {
                    TT_Avance = TT_Avance + Convert.ToDecimal(item.Acompte1.ToString());
                }
                if ((item.DateAcompte2.ToString() != "") && (Convert.ToDateTime(item.DateAcompte2.ToString()) == Convert.ToDateTime(date.ToShortDateString())))
                {
                    TT_Avance = TT_Avance + Convert.ToDecimal(item.Acompte2.ToString());
                }
                if ((item.DateAcompte3.ToString() != "") && (Convert.ToDateTime(item.DateAcompte1.ToString()) == Convert.ToDateTime(date.ToShortDateString())))
                {
                    TT_Avance = TT_Avance + Convert.ToDecimal(item.Acompte3.ToString());
                }
                if ((item.DateAcompte4.ToString() != "") && (Convert.ToDateTime(item.DateAcompte4.ToString()) == Convert.ToDateTime(date.ToShortDateString())))
                {
                    TT_Avance = TT_Avance + Convert.ToDecimal(item.Acompte4.ToString());
                }
                if ((item.DateAcompte5.ToString() != "") && (Convert.ToDateTime(item.DateAcompte5.ToString()) == Convert.ToDateTime(date.ToShortDateString())))
                {
                    TT_Avance = TT_Avance + Convert.ToDecimal(item.Acompte5.ToString());
                }
                if ((item.DatePayement.ToString() != "") && (Convert.ToDateTime(item.DatePayement.ToString()) == Convert.ToDateTime(date.ToShortDateString())) && (TT_Avance == 0))
                {
                    TT_Avance = TT_Avance + Convert.ToDecimal(item.MontantPayee.ToString());
                }
                if ((TT_Avance == 0) && (item.DatePayement.ToString() == ""))
                {
                    list.Remove(item);
                }
                else
                {
                    if ((TT_Avance != 0))// && (item.DatePayement.ToString()==""))
                    {
                        item.MontantLettre = TT_Avance;
                        lettreDto.NomClient = item.Nomcli;
                        lettreDto.NumeroLettre=item.NumeroLettre;
                        lettreDto.CodeClient = item.MatriculeClient;
                        lettreDto.DateLettre = item.DateLettre;
                        lettreDto.MontantLettre = TT_Avance;
                        TT_Journalier += TT_Avance;
                        listLettreDto.Add( lettreDto );
                    }
                }

            }
            traiteDtos.lettreDtos=listLettreDto;
            traiteDtos.TotalJournalier = TT_Journalier;
             return traiteDtos;
        }
    }
}
