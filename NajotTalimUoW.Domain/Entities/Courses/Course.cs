using NajotTalimUoW.Domain.Commons;
using NajotTalimUoW.Domain.Enums;
using NajotTalimUoW.Domain.Localization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? UpdateBy { get; set; }
        public ItemState State { get; set; }
    }
}


