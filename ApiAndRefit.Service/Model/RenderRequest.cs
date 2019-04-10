using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAndRefit.Service.Model
{
    public class RenderRequest
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }
    }
}
