using NajotTalimUoW.Domain.Commons;
using NajotTalimUoW.Domain.Entities.Courses;
using NajotTalimUoW.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotTalimUoW.Domain.Entities.Teachers
{
    public class Teacher : IAuditable
    {  
        public  Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? UpdateBy { get; set; }
        public ItemState State { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
