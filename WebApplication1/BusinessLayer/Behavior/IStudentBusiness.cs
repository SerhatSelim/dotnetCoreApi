using BusinessLayer.RestHelper;
using Dto;

namespace BusinessLayer.Behavior
{
    public interface IStudentBusiness
    {
        ServiceResult<bool> CreateStudent(StudentDto dto);
    }
}
