using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeFutebol.Models
{
    public class Jogador
    {
        public int id { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public String nome { get; set; }       
        public String apelido { get; set; }
        public int idade { get; set; }
        public String posicaoCampo { get; set; }
        public String time { get; set; }
        public int nParticipacoesCampeonado { get; set; }
        

    }
}
