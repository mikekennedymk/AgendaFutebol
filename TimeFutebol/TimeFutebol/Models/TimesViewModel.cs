using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeFutebol.Models
{
    public class TimesViewModel
    {
        public string time { get; set; }
        //identificador para manipular os "collapses" da tela
        public string identificadores { get { return time; }}
        public string corPrimaria { get; set; }
        public string corSecundaria { get; set; }
        public string imagem { get; set; }
    }
}
