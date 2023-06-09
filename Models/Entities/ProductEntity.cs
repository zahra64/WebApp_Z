﻿
using System.ComponentModel.DataAnnotations.Schema;
using static WebApp.Models.Entities.TagEntity;

namespace WebApp.Models.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public ICollection<ProductTagEntity> ProductTags { get; set; } = new HashSet<ProductTagEntity>();
    }
}
