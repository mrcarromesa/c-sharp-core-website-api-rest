using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContosoCrafts.WebSite.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public object Image { get; set; }
        
        public string Url { get; set; }

        [Required(ErrorMessage ="Url Obrigatória")]
        [MaxLength(10, ErrorMessage = "máximo 10")]
        [MinLength(2, ErrorMessage = "min2")]
        public string Title { get; set; }
        public string Description { get; set; }

        public int[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);

    }
}
