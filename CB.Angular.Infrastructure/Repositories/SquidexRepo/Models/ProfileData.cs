﻿using Newtonsoft.Json;
using Squidex.ClientLibrary;
using System.Collections.Generic;

namespace CB.Angular.Infrastructure.Repositories.SquidexRepo.Models
{
    public class ProfileData
    {
        [JsonConverter(typeof(InvariantConverter))]
        public List<string> Portrait { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public string Name { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public string Title { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public string Body { get; set; }
    }
}
