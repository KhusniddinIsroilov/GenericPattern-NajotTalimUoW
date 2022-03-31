using NajotTalimUoW.Domain.Common;
using NajotTalimUoW.Domain.Configurations;
using NajotTalimUoW.Domain.Entities.Students;
using NajotTalimUoW.Service.DTOs.Students;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NajotTalimUoW.Service.Interfaces
{
    public interface IStudentService
    {
        Task<BaseResponse<Student>> CreateAsync(StudentForCreationDto studentDto);

        Task<BaseResponse<Student>> GetAsync(Expression<Func<Student, bool>> expression);

        Task<BaseResponse<IEnumerable<Student>>> GetAllAsync(PaginationParams @params, Expression<Func<Student, bool>> expression = null);

        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Student, bool>> expression);

        Task<BaseResponse<Student>> UpdateAsync(Guid id, StudentForCreationDto studentDto);



    }
}
