using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSample
{
    public class Comment
    {
        public int Id { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Owner { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Title { get; set; }

        public string Body { get; set; }
    }
}
