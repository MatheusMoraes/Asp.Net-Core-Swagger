using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AspCoreApi.Models
{
    public class Product
    {
        [Key]
        public Guid Id{ get; set; }
        public string Name { get; set; }
        public int Quantity{ get; set; }
        public double Price{ get; set; }

        public Guid UserId{ get; set; }

        [JsonIgnore]
        public User User { get; set; }
    }
}
