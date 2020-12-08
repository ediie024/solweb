using System;
using System.Collections.Generic;
using System.Linq;
using SimulacionPoker.Models;

namespace SimulacionPoker.Repository
{
    public interface IUsuarioService
    {
        public List<Usuario> Jugadores(List<string> nueva);
        public List<Usuario> JugadorGanador(int puntaje,List<Usuario> jugadores);
        public List<Usuario> JugadoresConPuntaje(List<Carta> baraja,List<Usuario> jugadores);
    }

    public class UsuarioRepository : IUsuarioService
    {
        
        public List<Usuario> Jugadores(List<string> nueva)
        {
            List<Usuario> jugadores = new List<Usuario>();
            int contador = 0;
            for (int i = 1; i < 6; i++)
            {
                Usuario Nuevojugardor = new Usuario();
                Nuevojugardor.Id = i;
                Nuevojugardor.Nombre = nueva[contador];
                
                jugadores.Add(Nuevojugardor);
                
                contador++;
            }
            
            return jugadores;
        }

        public List<Usuario> JugadorGanador(int puntaje,List<Usuario> jugadores)
        {
           
           var ganadores = jugadores.Where(o => o.Puntaje == puntaje).ToList();
           return ganadores;
        }

        public List<Usuario> JugadoresConPuntaje(List<Carta> baraja,List<Usuario> jugadores)
        {
            
            var jugador1 = baraja.Where(o => o.IdUsuario == 1).ToList();
            var jugador2 = baraja.Where(o => o.IdUsuario == 2).ToList();
            var jugador3 = baraja.Where(o => o.IdUsuario == 3).ToList();
            var jugador4 = baraja.Where(o => o.IdUsuario == 4).ToList();
            var jugador5 = baraja.Where(o => o.IdUsuario == 5).ToList();

            ICartaService cartas = new CartaRepository();
         
            jugadores[0].Puntaje = cartas.Puntaje(jugador1);
            jugadores[1].Puntaje = cartas.Puntaje(jugador2);
            jugadores[2].Puntaje = cartas.Puntaje(jugador3);
            jugadores[3].Puntaje = cartas.Puntaje(jugador4);
            jugadores[4].Puntaje = cartas.Puntaje(jugador5);
            return jugadores;
        }
    }
}