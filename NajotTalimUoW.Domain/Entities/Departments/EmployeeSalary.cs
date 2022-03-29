using NajotTalimUoW.Domain.Commons;
using NajotTalimUoW.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotTalimUoW.Domain.Entities.Departments
{
    public class EmployeeSalary : IAuditable
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public decimal Salary { get; set; }
        public PaymentType PaymentType { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? UpdateBy { get; set; }
        public ItemState State { get; set; }
    }
}
