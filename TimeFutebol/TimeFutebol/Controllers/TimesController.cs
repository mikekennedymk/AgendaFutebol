using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeFutebol.Models;

namespace TimeFutebol.Controllers
{
    public class TimesController : Controller
    {
       
        private readonly Contexto _contexto;

        //Construtor chamando a conexão do banco simulando a modelagem DAO
        public TimesController(Contexto contexto)
        {
            _contexto = contexto;

        }
        public IActionResult Index()
        {
            return View(PegarTimes());
        }

        //Métodos Get e Post da criação de Jogador
        [HttpGet]
        public IActionResult CriarJogador(string time)
        {

            Jogador jogador = new Jogador
            { time = time };

            return View(jogador);
        }
        [HttpPost]

        public async Task<IActionResult> CriarJogador(Jogador jogador)
        {

            if (ModelState.IsValid)
            {
                _contexto.Jogadores.Add(jogador);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(jogador);
        }


        //Métodos Get e Post da Atualização de Jogador

        [HttpGet]
        public async Task<IActionResult> AtualizarJogador(int jogadorId) {

            Jogador jogador = await _contexto.Jogadores.FindAsync(jogadorId);

            if (jogador == null) {

                return NotFound();
            }
            return View(jogador);
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarJogador(Jogador jogador)
        {

            if(ModelState.IsValid){
                _contexto.Update(jogador);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            }
            return View(jogador);
        }

        //Método Post da Exclusão de Jogador

        [HttpPost]
        public async Task<JsonResult> ExcluirJogador(int id) {

            Jogador jogador = await _contexto.Jogadores.FindAsync(id);
            _contexto.Jogadores.Remove(jogador);
            await _contexto.SaveChangesAsync();
            return Json(true); 
        }
        //Método de criação dos 12 principais times do Brasil (Será feito com conexão ao banco na próxima versão )
        private List<TimesViewModel> PegarTimes()
        {

            List<TimesViewModel> listaTimes = new List<TimesViewModel>();
            listaTimes.Add(new TimesViewModel { time = "Bahia", corPrimaria = "#077ae6", corSecundaria = "#f24646", imagem = "https://i.pinimg.com/originals/37/32/9c/37329c6eecc208b36e5b9fd8574c4d76.png" });
            listaTimes.Add(new TimesViewModel { time = "Botafogo", corPrimaria = "#242222", corSecundaria = "#ffffff", imagem = "https://logodownload.org/wp-content/uploads/2016/11/botafogo-logo-escudo.png" });
            listaTimes.Add(new TimesViewModel { time = "Cruzeiro", corPrimaria = "#1367ed", corSecundaria = "#ffffff", imagem = "https://cdn.freebiesupply.com/logos/large/2x/cruzeiro-esporte-clube-sc-logo-svg-vector.svg" });
            listaTimes.Add(new TimesViewModel { time = "Corinthians", corPrimaria = "#242222", corSecundaria = "#f24646", imagem = "https://i.pinimg.com/originals/47/36/4d/47364d004bdf64f78d736a8cbedde9aa.png" });
            listaTimes.Add(new TimesViewModel { time = "Flamengo", corPrimaria = "#f24646", corSecundaria = "#242222", imagem = "https://cdn.worldvectorlogo.com/logos/flamengo.svg" });
            listaTimes.Add(new TimesViewModel { time = "Fluminense", corPrimaria = "#05780b", corSecundaria = "#f24646", imagem = "https://logodownload.org/wp-content/uploads/2016/09/fluminense-logo-escudo-1.png" });
            listaTimes.Add(new TimesViewModel { time = "Grêmio", corPrimaria = "#0895c4", corSecundaria = "#404242", imagem = "https://logodownload.org/wp-content/uploads/2017/02/gremio-logo-escudo.png" });
            listaTimes.Add(new TimesViewModel { time = "Internacional", corPrimaria = "#f24646", corSecundaria = "#ffffff", imagem = "https://logodownload.org/wp-content/uploads/2015/05/internacional-porto-alegre-logo-escudo-4.png" });
            listaTimes.Add(new TimesViewModel { time = "Palmeiras", corPrimaria = "#176300", corSecundaria = "#ffffff", imagem = "https://icons.iconarchive.com/icons/giannis-zographos/south-american-football-club/256/Palmeiras-icon.png" });
            listaTimes.Add(new TimesViewModel { time = "Sport", corPrimaria = "#f02424", corSecundaria = "#fcba03", imagem = "https://upload.wikimedia.org/wikipedia/en/thumb/4/45/Sport_Club_Recife.svg/1200px-Sport_Club_Recife.svg.png" });
            listaTimes.Add(new TimesViewModel { time = "Santos", corPrimaria = "#242222", corSecundaria = "#ffffff", imagem = "https://i.pinimg.com/originals/2c/07/8c/2c078c673f6ec2b98116b90ebe14a81f.png" });
            listaTimes.Add(new TimesViewModel { time = "Vasco", corPrimaria = "#242222", corSecundaria = "#ffffff", imagem = "http://as00.epimg.net/img/comunes/fotos/fichas/equipos/large/228.png" });


            return listaTimes;
        }
    }
    }




