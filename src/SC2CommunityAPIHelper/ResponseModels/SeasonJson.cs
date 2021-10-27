using Newtonsoft.Json;
using SC2CommunityAPI.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.ResponseModels
{
    public struct SeasonJson
    {
        [JsonProperty("seasonId")]
        public int SeasonId { get; private set; }
        [JsonProperty("number")]
        public int Number { get; private set; }
        [JsonProperty("year")]
        public int Year { get; private set; }
        [JsonProperty("startDate")]
        public string DateStartTimespan { get; private set; }
        [JsonProperty("endDate")]
        public string DateEndTimespan { get; private set; }

        public DateTime DateStart
        {
            get => DateHelper.FormatFromStandardSeconds(DateStartTimespan);
        }
        public DateTime EndDate
        {
            get => DateHelper.FormatFromStandardSeconds(DateEndTimespan);
        }
    }
}
