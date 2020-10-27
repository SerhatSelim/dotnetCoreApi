using AutoMapper;
using Business.Abstract;
using Business.Behavior;
using Business.RestHelper;
using DataAccessLayer.Behavior;
using Dto;
using Entity;
using System;

namespace Business.Concrete
{
    public class StudentBusiness : BaseBusiness, IStudentBusiness
    {
        private readonly IStudentRepository studentRepository;

        public StudentBusiness(IMapper mapper, IStudentRepository studentRepository) : base(mapper)
        {
            this.studentRepository = studentRepository;
        }

        public ServiceResult<bool> CreateStudent(StudentDto dto)
        {

            var entity = base.mapper.Map<StudentDto, StudentEntity>(dto);

            this.studentRepository.Add(entity);

            return new ServiceResult<bool>(true, "Student Created!");

            
        }

        public ServiceResult<StudentDto> GetStudentById(int id)
        {
            var entity = this.studentRepository.GetById(id);

            var dto = base.mapper.Map<StudentEntity, StudentDto>(entity);

            return new ServiceResult<StudentDto>(dto);
        }
    }
}
