using Domain.Common;

namespace Domain.Models
{
    public class Teacher : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
