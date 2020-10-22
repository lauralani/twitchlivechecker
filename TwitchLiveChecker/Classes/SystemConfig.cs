﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchConfig
{
    class SystemConfig
    {
        public static Dictionary<string, string> Application = new Dictionary<string, string>
        {
            { "clientid", "asdsad" },
            { "clientsecret", "asdsadasd" }
        };

        public static Dictionary<string, string> Environment = new Dictionary<string, string>
        {
            { "configfile", $"{Directory.GetCurrentDirectory()}/config.json" },
            { "redirect_uri", "http://localhost:58214" }
        };

        public static Dictionary<string, string> Twitch = new Dictionary<string, string>
        {
            { "oauth_loginurl",       "https://id.twitch.tv/oauth2/authorize" },
            { "oauth_tokenurl",       "https://id.twitch.tv/oauth2/token" },
            { "oauth_revocationurl",  "https://id.twitch.tv/oauth2/revoke" },
            { "api_channelurl", "https://api.twitch.tv/helix/streams" }
        };
    }
}