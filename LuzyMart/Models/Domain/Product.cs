using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LuzyMart.Models.Domain
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [JsonProperty("productName")]
        public string ProductName { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }

		[JsonProperty("category")]
        public Category Category { get; set; }
        [JsonProperty("images")]

        public ICollection<Image> Images{ get; set; }
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        [JsonProperty("updatedOn")]
        public DateTime? UpdatedOn { get; set; }
    }
}
