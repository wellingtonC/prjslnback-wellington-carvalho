using System.ComponentModel.DataAnnotations;

namespace prjslnback_wellington_carvalho.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [MaxLength(1000, ErrorMessage = "Este campo é obrigatorio")]
        [MinLength(3, ErrorMessage = "Este campo é obrigatorio")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [MaxLength(100, ErrorMessage = "Este campo é obrigatorio")]
        [MinLength(3, ErrorMessage = "Este campo é obrigatorio")]
        public string password { get; set; }

        public string Token { get; set; }

    }
}
