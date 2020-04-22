using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFTracker.Views.ViewModel
{
    public class ViewModelProfile
    {
        public string SummonerName { get; private set; }
        public string Icon { get; private set; }
        public long Level { get; private set; }
        public List<string> Data { get; set; }

        public ViewModelProfile(string summonerName, int icon, long level, List<string> hist)
        {
            SummonerName = summonerName;
            Icon = "http://opgg-static.akamaized.net/images/profile_icons/profileIcon" + icon + ".jpg";
            Level = level;
            Data = hist;
        }
    }
}
