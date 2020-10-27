using System;

namespace Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatingDate { get; set; }

        public DateTime ModificationDate { get; set; }
    }
}
