using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LuzyMart.Models.Domain
{
    public class Category
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("products")]
        public ICollection<Product> Products { get; set; }
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        [JsonProperty("updatedOn")]
        public DateTime? UpdatedOn { get; set; }
    }
}
