using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeFutebol.Models;

namespace TimeFutebol.ViewComponents
{
    public class ListaJogadoresViewComponent : ViewComponent
    {
        //classe para pegar e listar os jogadores do banco (simula modelagem DAO)
        private readonly Contexto _contexto;
        public ListaJogadoresViewComponent(Contexto contexto){

            _contexto = contexto;
}
        public async Task<IViewComponentResult> InvokeAsync(TimesViewModel timesViewModel)
        {
            TimeJogadores timeJogadores = new TimeJogadores { 
                timesViewModel = timesViewModel,
                jogadores = await _contexto.Jogadores.Where(t => t.time == timesViewModel.time).OrderBy(t => t.idade).ToListAsync()
            };
            return View(timeJogadores); 
        }
    }
}
