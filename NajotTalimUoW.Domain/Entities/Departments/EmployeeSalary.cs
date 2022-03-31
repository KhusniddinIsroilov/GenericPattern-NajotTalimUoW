using NajotTalimUoW.Domain.Commons;
using NajotTalimUoW.Domain.Enums;
using System;

namespace NajotTalimUoW.Domain.Entities.Departments
{
    public class EmployeeSalary : IAuditable
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public decimal Salary { get; set; }
        public PaymentType PaymentType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? UpdatedBy { get; set; }
        public ItemState State { get; set; }
    }
}
