using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_API.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [MaxLength(50)]
        [MinLength(3)]
        public string FullName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public bool Sex { get; set; }
        public string NativeVillage { get; set; }
        [MaxLength(10)]
        [MinLength(7)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
    }
}
