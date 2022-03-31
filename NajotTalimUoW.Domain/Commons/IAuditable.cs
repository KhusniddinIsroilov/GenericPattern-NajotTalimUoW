using NajotTalimUoW.Domain.Enums;
using System;

namespace NajotTalimUoW.Domain.Commons
{
    public interface IAuditable
    {
        Guid Id { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        DateTime? UpdatedBy { get; set; }
        ItemState State { get; set; }
    }


}
