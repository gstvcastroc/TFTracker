using System.IO;
using System.Net.Http;

namespace TFTrackerRepository.Utils
{
    public class API
    {
        private string Key { get; set; }
        public string Region { get; set; }

        public API(string region)
        {
            region = "br1";

            Region = region;
            Key = GetKey("API/Key.txt");
        }

        protected HttpResponseMessage GET(string URL)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(URL);
                result.Wait();

                return result.Result;
            }
        }

        protected string GetURI(string path)
        {
            string x = "https://" + Region + ".api.riotgames.com" + path + "?api_key=" + Key;
            return x;
        }

        public string GetKey(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }
    }
}
