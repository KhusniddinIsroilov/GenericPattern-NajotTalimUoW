using NajotTalimUoW.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotTalimUoW.Domain.Commons
{
    public interface IAuditable
    {
        Guid Id { get; set; }
        DateTime CreateAt { get; set; }
        DateTime? UpdateAt { get; set; }
        DateTime? UpdateBy { get; set; }
        ItemState State { get; set; }
    }


}
