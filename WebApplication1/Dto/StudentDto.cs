using System.ComponentModel.DataAnnotations;

namespace Dto
{
    public class StudentDto : BaseDto
    {
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
