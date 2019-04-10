using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAndHttpClient.Service.Model
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

