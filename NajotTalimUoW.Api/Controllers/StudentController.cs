using Microsoft.AspNetCore.Mvc;
using NajotTalimUoW.Domain.Common;
using NajotTalimUoW.Domain.Configurations;
using NajotTalimUoW.Domain.Entities.Students;
using NajotTalimUoW.Domain.Enums;
using NajotTalimUoW.Service.DTOs.Students;
using NajotTalimUoW.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NajotTalimUoW.Api.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpPost]
        public async Task<ActionResult<BaseResponse<Student>>> Create(StudentForCreationDto studentDto)
        {
            var result = await studentService.CreateAsync(studentDto);

            return StatusCode(result.Code ?? result.Error.Code.Value, result);
        }

        [HttpGet]
        public async Task<ActionResult<BaseResponse<IEnumerable<Student>>>> GetAll([FromQuery] PaginationParams @params)
        {
            var result  = await studentService.GetAllAsync(@params);

            return StatusCode(result.Code ?? result.Error.Code.Value, result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BaseResponse<Student>>> Get(Guid id)
        {

            var result =await studentService.GetAsync(p => p.Id == id);

             return StatusCode(result.Code ?? result.Error.Code.Value, result);
        }

        [HttpPut("{id")]
        public async Task<ActionResult<BaseResponse<Student>>>  Update(Guid id, StudentForCreationDto studentDto)
        {
            var result = await studentService.UpdateAsync(id, studentDto);

            return StatusCode(result.Code ?? result.Error.Code.Value, result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<BaseResponse<bool>>> Delete(Guid id)
        {
            var result = await studentService.DeleteAsync(p => p.Id == id && p.State != ItemState.Deleted);

            return StatusCode(result.Code ?? result.Error.Code.Value, result);
        }
    }
}
