using Newtonsoft.Json;
using System.Collections.Generic;

namespace AxeCore.Net
{
    public class AxeResultRelatedNode
    {
        public string Html { get; set; }

        [JsonProperty("target", ItemConverterType = typeof(AxeResultTargetConverter), NullValueHandling = NullValueHandling.Ignore)]
        public List<AxeResultTarget> Target { get; set; }
    }
}
