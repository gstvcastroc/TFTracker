using Newtonsoft.Json;

namespace TFTrackerRepository.Repositorios
{
    public class PrepSummoner : TFTrackerRepository.Utils.API
    {
        public PrepSummoner(string region) : base(region)
        {

        }
        public TFTrackerData.Models.Summoner GetSummonerByName(string summonerName)
        {
            string path = "/tft/summoner/v1/summoners/by-name/" + summonerName;

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<TFTrackerData.Models.Summoner>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
