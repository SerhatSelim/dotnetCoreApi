using Business.RestHelper;
using Dto;

namespace Business.Behavior
{
    public interface IStudentBusiness
    {
        ServiceResult<bool> CreateStudent(StudentDto dto);

        ServiceResult<StudentDto> GetStudentById(int id);
    }

}
