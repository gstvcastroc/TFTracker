using Microsoft.AspNetCore.Mvc;
using TFTrackerRepository.Repositorios;

namespace TFTracker.Controllers
{
    public class BaseController : Controller
    {
        public bool GetSummoner(string summonerName)
        {
            PrepSummoner summonerPrep = new PrepSummoner(TFTrackerRepository.Utils.Constantes.Region);

            var summoner = summonerPrep.GetSummonerByName(summonerName);

            TFTrackerRepository.Utils.Constantes.Summoner = summoner;

            return summoner != null;
        }
    }
}