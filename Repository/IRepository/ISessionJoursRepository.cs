using API_SurveillenceCommerciale.ModdelsDto;
using API_SurveillenceCommerciale.Models;

namespace API_SurveillenceCommerciale.Repository.IRepository
{
    public interface ISessionJoursRepository
    {
        public  Task<TraiteDto> GetSessionJour(DateTime date);
    }
}
