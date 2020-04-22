using TFTrackerData.Models;
using TFTrackerRepository.Utils;

namespace TFTrackerRepository.Repositorios
{
    public class PrepHistTFT : API
    {
        public PrepHistTFT( string region) : base (region)
        {

        }

        public TFTHist GetHistTFTByPuuid(string puuid)
        {
            string path = "/tft/match/v1/matches/by-puuid/"+ puuid +"/ids";

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<TFTHist>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
