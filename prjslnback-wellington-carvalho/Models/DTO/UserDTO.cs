using System;
using System.ComponentModel.DataAnnotations;

namespace prjslnback_wellington_carvalho.Models
{
    public class UserDTO
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [MaxLength(1000, ErrorMessage = "Este campo é obrigatorio")]
        [MinLength(3, ErrorMessage = "Este campo é obrigatorio")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [MaxLength(15, ErrorMessage = "Este campo é obrigatorio")]
        [MinLength(3, ErrorMessage = "Este campo é obrigatorio")]
        public string password { get; set; }

        public string Token { get; set; }
        public string expirationDate { get; set; }

    }
}
