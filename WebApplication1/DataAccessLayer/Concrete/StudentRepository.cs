using DataAccessLayer.Base;
using DataAccessLayer.Behavior;
using DataAccessLayer.Persistence;
using Entity;

namespace DataAccessLayer.Concrete
{
    public class StudentRepository : BaseEntityRepository<StudentEntity>, IStudentRepository
    {
        public StudentRepository(DemoContext context) : base(context)
        {
        }
    }
}
