using System;
using System.Collections.Generic;
using SimulacionPoker.Models;

namespace SimulacionPoker.Repository
{
    public interface IUsuarioService
    {
        public List<Usuario> Jugadores(List<string> nombres);

    }

    public class UsuarioRepository : IUsuarioService
    {
        public List<Usuario> Jugadores(List<string> nombres)
        {
            List<Usuario> jugadores = new List<Usuario>();
            int contador = 0;
            for (int i = 1; i < 6; i++)
            {
                Usuario Nuevojugardor = new Usuario();
                Nuevojugardor.Id = i;
                Nuevojugardor.Nombre = nombres[contador];
                
                jugadores.Add(Nuevojugardor);
                
                contador++;
            }

            foreach (var a in jugadores)
            {
                Console.WriteLine(a.Id+a.Nombre+a.Puntaje);
            }

            return jugadores;
        }
    }
}