using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LuzyMart.Models.Domain
{
    public class Image
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [JsonProperty("link")]
        public string Link { get; set; }
		[JsonProperty("product")]

        public Product Product { get; set; }
        [JsonProperty("createdOn")]

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        [JsonProperty("updatedOn")]
        public DateTime? UpdatedOn { get; set; }
    }
}
