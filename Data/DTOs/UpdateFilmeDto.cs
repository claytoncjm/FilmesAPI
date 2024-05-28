using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.DTOs
{
    public class UpdateFilmeDto
    {
       
        [Required(ErrorMessage = "O Campo Titulo nao pode ficar Vazio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Campo Diretor nao pode ficar Vazio")]
        public string Diretor { get; set; }
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter no minimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
    }
}

