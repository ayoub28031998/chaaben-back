using API_SurveillenceCommerciale.ModdelsDto;
using API_SurveillenceCommerciale.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_SurveillenceCommerciale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionJourController : ControllerBase
    {
        private readonly ISessionJoursRepository _sessionJoursRepository;

        public SessionJourController(ISessionJoursRepository sessionJoursRepository)
        {
            _sessionJoursRepository = sessionJoursRepository;
        }

        [HttpPost]
        public async Task<ActionResult> GetSessionJour(DateDto date)
        {
            try
            {
                return Ok( await _sessionJoursRepository.GetSessionJour(date.Date));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

    }
}
