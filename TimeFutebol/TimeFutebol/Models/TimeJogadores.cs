using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeFutebol.Models
{
    public class TimeJogadores
    {
        public TimesViewModel timesViewModel { get; set; }
        public IEnumerable<Jogador> jogadores {get; set;}
    }
}
