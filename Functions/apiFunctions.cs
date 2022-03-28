using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DualSenseAT.Functions
{
    internal class apiFunctions
    {
        public static JObject getGames()
        {
            WebClient client = new WebClient();
            var json = client.DownloadString("https://raw.githubusercontent.com/josealissonbr/DSAT-api-repo/main/games/gameList.json");
            JObject o = JObject.Parse(json);

            return o;
        }

        public static JObject getUpdates()
        {
            WebClient client = new WebClient();
            var json = client.DownloadString(Constants.BASE_URL + "/updater/updateSettings.json");
            JObject o = JObject.Parse(json);

            return o;
        }
    }
}
