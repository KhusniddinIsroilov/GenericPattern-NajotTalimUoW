using NajotTalimUoW.Domain.Commons;
using NajotTalimUoW.Domain.Entities.Courses;
using NajotTalimUoW.Domain.Enums;
using System;
using System.Collections.Generic;

namespace NajotTalimUoW.Domain.Entities.Teachers
{
    public class Teacher : IAuditable
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? UpdatedBy { get; set; }
        public ItemState State { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
