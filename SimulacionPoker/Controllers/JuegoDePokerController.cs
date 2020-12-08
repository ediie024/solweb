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
            
      
         
            return View();
        }

        public IActionResult DetalleCartas(string Nombre1,string Nombre2,string Nombre3,string Nombre4,string Nombre5)
        {
            List<string> nueva = new List<string>();
            nueva.Add(Nombre1); nueva.Add(Nombre2); nueva.Add(Nombre3); nueva.Add(Nombre4); nueva.Add(Nombre5);
            var jugadores = Jugadores(nueva);
            
            
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
            Ganadores(Nombre1, Nombre2, Nombre3, Nombre4, Nombre5);
            jugadores[0].Puntaje = puntaje(jugador1);
            jugadores[1].Puntaje = puntaje(jugador2);
            jugadores[2].Puntaje = puntaje(jugador3);
            jugadores[3].Puntaje = puntaje(jugador4);
            jugadores[4].Puntaje = puntaje(jugador5);
            Console.WriteLine("Jugador ganador");
            int contador = 0;
            var ValorMaximoPuntaje = jugadores.Max(o => o.Puntaje);
            var JugadoresGanadores = _usuarioService.JugadorGanador(ValorMaximoPuntaje,jugadores);
            @ViewBag.JugadoresGanadores = JugadoresGanadores;
            if (JugadoresGanadores.Count>1)
            {
                ViewBag.Mensaje = "Felicitaciones a los ganadores: ";
            }
            else
            {
                ViewBag.Mensaje = "Felicitaciones al unico ganador: ";
            }
            
            @ViewBag.Jugadores = jugadores;
            return View();
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

        public List<Usuario> Ganadores(string Nombre1,string Nombre2,string Nombre3,string Nombre4,string Nombre5)
        {
            List<string> nueva = new List<string>();
            nueva.Add(Nombre1); nueva.Add(Nombre2); nueva.Add(Nombre3); nueva.Add(Nombre4); nueva.Add(Nombre5);
            var jugadores = Jugadores(nueva);
            
            
            var baraja = AsignarCartasJugadores();

            var JugadoresConPuntaje = _usuarioService.JugadoresConPuntaje(baraja,jugadores);
            
            Console.WriteLine("Jugador ganador");
            int contador = 0;
            var ValorMaximoPuntaje = _cartaService.Puntajemaximo(jugadores);
            var JugadoresGanadores = _usuarioService.JugadorGanador(ValorMaximoPuntaje,jugadores);
            
            return JugadoresGanadores;
        }
    }
}