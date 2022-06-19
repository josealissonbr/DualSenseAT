using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualSenseAT.Functions
{
    internal class apiFunctions
    {
        private static JObject gamesJson = null;
        public static JObject getGames()
        {
            if (gamesJson == null)
            {
                WebClient client = new WebClient();
                var json = client.DownloadString("https://raw.githubusercontent.com/josealissonbr/DSAT-api-repo/main/games/gameList.json");
                gamesJson = JObject.Parse(json);
            }

            return gamesJson;
        }

        public static JObject getUpdates()
        {
            WebClient client = new WebClient();
            var json = client.DownloadString(Constants.BASE_URL + "/updater/updateSettings.json");
            JObject o = JObject.Parse(json);

            return o;
        }

        public static void loadSteamData()
        {
            using (WebClient wc = new WebClient())
            {
                string raw_json = wc.DownloadString("https://api.steampowered.com/ISteamUser/ResolveVanityURL/v0001/?key=" + Session.SteamData.webApiKey + "&vanityurl=" + Session.SteamData.vanityUrl);
                dynamic dynObj = JsonConvert.DeserializeObject(raw_json);
                Session.SteamData.UserData.SteamID64 = dynObj.response.steamid;
                

            }
        }
    }
}
