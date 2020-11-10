using Business.Behavior;
using Business.RestHelper;
using Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.ActionFilters;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentBusiness studentBusiness;

        public StudentController(IStudentBusiness studentBusiness)
        {
            this.studentBusiness = studentBusiness;
        }



        [HttpPost]
        [Route("CreateStudent")]
        [Validation]
        [Authorize]
        public ServiceResult<bool> CreateStudent(StudentDto dto)
        {
            return this.studentBusiness.CreateStudent(dto);
        }


        [HttpGet]
        [Route("GetStudent")]
        [LogFilter]
        public ServiceResult<StudentDto> GetStudentById(int id)
        {

            return this.studentBusiness.GetStudentById(id);
        }
    }
}
