using NajotTalimUoW.Domain.Commons;
using NajotTalimUoW.Domain.Enums;
using NajotTalimUoW.Domain.Localization;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NajotTalimUoW.Domain.Entities.Courses
{
    public class Course : IAuditable, ILocalizationName
    {
        public Guid Id { get; set; }

        [NotMapped]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }

        [JsonIgnore]
        public string NameUz { get; set; }
        [JsonIgnore]
        public string NameRu { get; set; }
        [JsonIgnore]
        public string NameEng { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? UpdatedBy { get; set; }
        public ItemState State { get; set; }
    }
}


