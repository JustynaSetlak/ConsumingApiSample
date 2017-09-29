using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSample
{
    public class Post
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }
    }
}
