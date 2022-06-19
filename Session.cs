using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualSenseAT
{
    internal class Session
    {
        public static FileInfo[] langList = { };

        public struct SteamData
        {
            public static string vanityUrl;
            public static string webApiKey;
            public struct UserData
            {
                public static string SteamID64;
            }
        }
    }
}
