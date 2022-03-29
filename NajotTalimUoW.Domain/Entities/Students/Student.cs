using NajotTalimUoW.Domain.Commons;
using NajotTalimUoW.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotTalimUoW.Domain.Entities.Students
{
    public class Student : IAuditable
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid GroupId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set ; }
        public DateTime? UpdateBy { get ; set ; }
        public ItemState State { get; set; }
    }
}
