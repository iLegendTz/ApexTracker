using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApexTracker.Model
{
    internal class ApexLegends
    {
        private string endPoint = "https://api.mozambiquehe.re/bridge";
        private string apiKey = "API KEY FROM https://apexlegendsapi.com/";

        private string platform;
        private string username;

        public ApexLegends(string platform, string username)
        {
            this.platform = platform;
            this.username = username;
        }

        public async Task<Player> SearchPlayer()
        {
            string query = $"{endPoint}?auth={apiKey}&platform={platform}&player={username}";
            Player player = null;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(query);

                if (response.IsSuccessStatusCode)
                {
                    string res = response.Content.ReadAsStringAsync().Result;
                    player = JsonConvert.DeserializeObject<Player>(res);
                }

            }
            return player;
        }
    }
}
