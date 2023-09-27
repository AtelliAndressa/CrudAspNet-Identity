using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudTest.Models
{
    public class Premium
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o título do Premium")]
        [StringLength(80, ErrorMessage = "O título deve conter até 80 caracteres")]
        [MinLength(5, ErrorMessage = "O título deve conter pelo menos 5 caracteres")]
        [DisplayName("Título")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        // [GreaterThanToday]
        [DisplayName("Início")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Término")]
        public DateTime EndDate { get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage = "Aluno inválido")]
        public int StudentId { get; set; }

        public Student? Student { get; set; }
    }
}


