using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TFTracker.Views.ViewModel;
using TFTrackerData.Models;
using TFTrackerRepository.Repositorios;
using TFTrackerRepository.Utils;
using static TFTrackerData.Models.EnumServers;

namespace TFTracker.Controllers
{
    public class HistController : BaseController
    {       
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ViewModelSummoner summoner)
        {
            if (!ModelState.IsValid) return View(summoner);

            GetSummoner(summoner.userName);

            //GetContext();

            return PartialView("_HistPartialView");
        }

        public object GetContext()
        {
            var summoner = Constantes.Summoner;

            var position = GetHistTFT(summoner);

            return new ViewModelProfile(summoner.name, summoner.profileIconId, summoner.summonerLevel, position.data);
        }

        private TFTHist GetHistTFT(Summoner summoner)
        {
            PrepHistTFT prep = new PrepHistTFT(Constantes.Region);
            
            var position = prep.GetHistTFTByPuuid(summoner.puuid);

            return position ?? new TFTHist();
        }
    }
}