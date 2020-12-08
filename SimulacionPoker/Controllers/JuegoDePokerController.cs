using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using SimulacionPoker.Models;
using SimulacionPoker.Repository;

namespace SimulacionPoker.Controllers
{
    public class JuegoDePokerController : Controller
    {
        private ICartaService _cartaService;
        private IUsuarioService _usuarioService;

        public JuegoDePokerController(ICartaService _cartaService,IUsuarioService _usuarioService)
        {
            this._cartaService = _cartaService;
            this._usuarioService = _usuarioService;
        }

        public IActionResult Index()
        {
            List<string> nueva = new List<string>();
            nueva.Add("juan1");
            nueva.Add("juan2");
            nueva.Add("juan3");
            nueva.Add("juan4");
            nueva.Add("juan5");
            var baraja = AsignarCartasJugadores();
            var jugador1 = baraja.Where(o => o.IdUsuario == 1).ToList();
            var jugador2 = baraja.Where(o => o.IdUsuario == 2).ToList();
            var jugador3 = baraja.Where(o => o.IdUsuario == 3).ToList();
            var jugador4 = baraja.Where(o => o.IdUsuario == 4).ToList();
            var jugador5 = baraja.Where(o => o.IdUsuario == 5).ToList();

            ViewBag.Jugador1 = jugador1;
            ViewBag.Jugador2 = jugador2;
            ViewBag.Jugador3 = jugador3;
            ViewBag.Jugador4 = jugador4;
            ViewBag.Jugador5 = jugador5;
            var respuesta1= puntaje(jugador1);
            var respuesta2=puntaje(jugador2);
            var respuesta3=puntaje(jugador3);
            var respuesta4=puntaje(jugador4);
            var respuesta5=puntaje(jugador5);
            Console.WriteLine("puntaje del jugador uno es "+respuesta1);
            Console.WriteLine("puntaje del jugador uno es "+respuesta2);
            Console.WriteLine("puntaje del jugador uno es "+respuesta3);
            Console.WriteLine("puntaje del jugador uno es "+respuesta4);
            Console.WriteLine("puntaje del jugador uno es "+respuesta5);
            var jugadores = Jugadores(nueva);
            jugadores[0].Puntaje = respuesta1;
            jugadores[1].Puntaje = respuesta2;
            jugadores[2].Puntaje = respuesta3;
            jugadores[3].Puntaje = respuesta4;
            jugadores[4].Puntaje = respuesta5;
            Console.WriteLine("Jugador ganador");
            int contador = 0;
            var ValorMaximoPuntaje = jugadores.Max(o => o.Puntaje);
            var JugadoresGanadores = jugadores.Where(o => o.Puntaje == ValorMaximoPuntaje).ToList();
            if (JugadoresGanadores.Count>1)
            {
                Console.WriteLine("Existe un empate de los siguientes jugadores ");
            }
            foreach (var item in JugadoresGanadores)
            {
                Console.WriteLine(item.Nombre+" con el puntaje de "+item.Puntaje);
            }
         
            return View(baraja);
        }

        public List<Carta> AsignarBaraja()
        {
            var baraja = _cartaService.CrearBaraja();
            return baraja;
        }

        public List<string> TipoCarta()
        {
            var tipoDeCarta = _cartaService.TipoCarta();
            return tipoDeCarta;
        }

        public List<Carta> AsignarCartasJugadores()
        {
            var baraja = _cartaService.AsignarBarajaJugador();
            return baraja;
        }

        public List<Usuario> Jugadores(List<string> nombres)
        {

            var jugadores = _usuarioService.Jugadores(nombres);
            return jugadores;
        }

        public int puntaje(List<Carta> mano)
        {
            var puntaje = _cartaService.Puntaje(mano);
            return puntaje;
           
        }
    }
}