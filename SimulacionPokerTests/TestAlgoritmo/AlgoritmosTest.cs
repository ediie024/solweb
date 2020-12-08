using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using SimulacionPoker.Controllers;
using SimulacionPoker.Models;
using SimulacionPoker.Repository;

namespace SimulacionPokerTests.TestAlgoritmo
{
    public class AlgoritmosTest
    {
        [Test]
        public void JuanGana()
        {
         
            List<string> a = new List<string>();
            var userMock = new Mock<IUsuarioService>();
           
            
            var baraja = new List<Carta>();
            Carta nueva1 = new Carta(1, 1, "♥", 1);
            baraja.Add(nueva1);
            Carta nueva2 = new Carta(2, 2, "♥", 0);
            baraja.Add(nueva2);
            Carta nueva3 = new Carta(3, 3, "♥", 0);
            baraja.Add(nueva3);
            Carta nueva4 = new Carta(4, 4, "♥", 0);
            baraja.Add(nueva4);
            Carta nueva5 = new Carta(5, 5, "♥", 0);
            baraja.Add(nueva5);
            Carta nueva6 = new Carta(6, 6, "♥", 0);
            baraja.Add(nueva6);
            Carta nueva7 = new Carta(7, 7, "♥", 0);
            baraja.Add(nueva7);
            Carta nueva8 = new Carta(8, 8, "♥", 0);
            baraja.Add(nueva8);
            Carta nueva9 = new Carta(9, 9, "♥", 0);
            baraja.Add(nueva9);
            Carta nueva10 = new Carta(10, 10, "♥", 1);
            baraja.Add(nueva10);

            Carta nueva11 = new Carta(11, 11, "♥", 1);
            baraja.Add(nueva11);
            Carta nueva12 = new Carta(12, 12, "♥", 1);
            baraja.Add(nueva12);
            Carta nueva13 = new Carta(13, 13, "♥", 1);
            baraja.Add(nueva13);
            Carta nueva14 = new Carta(14, 1, "♦", 0);
            baraja.Add(nueva14);
            Carta nueva15 = new Carta(15, 2, "♦", 0);
            baraja.Add(nueva15);
            Carta nueva16 = new Carta(16, 3, "♦", 0);
            baraja.Add(nueva16);
            Carta nueva17 = new Carta(17, 4, "♦", 0);
            baraja.Add(nueva17);
            Carta nueva18 = new Carta(18, 5, "♦", 0);
            baraja.Add(nueva18);
            Carta nueva19 = new Carta(19, 6, "♦", 0);
            baraja.Add(nueva19);
            Carta nueva20 = new Carta(20, 7, "♦", 0);
            baraja.Add(nueva20);

            Carta nueva21 = new Carta(21, 8, "♦", 0);
            baraja.Add(nueva21);
            Carta nueva22 = new Carta(22, 9, "♦", 0);
            baraja.Add(nueva22);
            Carta nueva23 = new Carta(23, 10, "♦", 0);
            baraja.Add(nueva23);
            Carta nueva24 = new Carta(24, 11, "♦", 0);
            baraja.Add(nueva24);
            Carta nueva25 = new Carta(25, 12, "♦", 0);
            baraja.Add(nueva25);
            Carta nueva26 = new Carta(26, 13, "♦", 0);
            baraja.Add(nueva26);
            Carta nueva27 = new Carta(27, 1, "♠", 0);
            baraja.Add(nueva27);
            Carta nueva28 = new Carta(28, 2, "♠", 0);
            baraja.Add(nueva28);
            Carta nueva29 = new Carta(29, 3, "♠", 0);
            baraja.Add(nueva29);
            Carta nueva30 = new Carta(30, 4, "♠", 0);
            baraja.Add(nueva30);

            Carta nueva31 = new Carta(31, 5, "♠", 0);
            baraja.Add(nueva31);
            Carta nueva32 = new Carta(32, 6, "♠", 0);
            baraja.Add(nueva32);
            Carta nueva33 = new Carta(33, 7, "♠", 0);
            baraja.Add(nueva33);
            Carta nueva34 = new Carta(34, 8, "♠", 0);
            baraja.Add(nueva34);
            Carta nueva35 = new Carta(35, 9, "♠", 0);
            baraja.Add(nueva35);
            Carta nueva36 = new Carta(36, 10, "♠", 0);
            baraja.Add(nueva36);
            Carta nueva37 = new Carta(37, 11, "♠", 0);
            baraja.Add(nueva37);
            Carta nueva38 = new Carta(38, 12, "♠", 0);
            baraja.Add(nueva38);
            Carta nueva39 = new Carta(39, 13, "♠", 0);
            baraja.Add(nueva39);
            Carta nueva40 = new Carta(40, 1, "♣", 0);
            baraja.Add(nueva40);

            Carta nueva41 = new Carta(41, 2, "♣", 0);
            baraja.Add(nueva41);
            Carta nueva42 = new Carta(42, 3, "♣", 0);
            baraja.Add(nueva42);
            Carta nueva43 = new Carta(43, 4, "♣", 0);
            baraja.Add(nueva43);
            Carta nueva44 = new Carta(44, 5, "♣", 0);
            baraja.Add(nueva44);
            Carta nueva45 = new Carta(45, 6, "♣", 0);
            baraja.Add(nueva45);
            Carta nueva46 = new Carta(46, 7, "♣", 0);
            baraja.Add(nueva46);
            Carta nueva47 = new Carta(47, 8, "♣", 0);
            baraja.Add(nueva47);
            Carta nueva48 = new Carta(48, 9, "♣", 0);
            baraja.Add(nueva48);
            Carta nueva49 = new Carta(49, 10, "♣", 0);
            baraja.Add(nueva49);
            Carta nueva50 = new Carta(50, 11, "♣", 0);
            baraja.Add(nueva50);

            Carta nueva51 = new Carta(51, 12, "♣", 0);
            baraja.Add(nueva51);
            Carta nueva52 = new Carta(52, 13, "♣", 0);
            baraja.Add(nueva52);

            var cartaMock = new Mock<ICartaService>();
            cartaMock.Setup(o => o.AsignarBarajaJugador()).Returns(baraja);
            cartaMock.Setup(o => o.Puntaje(baraja)).Returns(3000);
            List<Usuario> jugadores= new List<Usuario>();
            jugadores.Add(new Usuario(1,"Juan",1323123));
            jugadores.Add(new Usuario(2,"Jorge",1323123));
            jugadores.Add(new Usuario(3,"Luis",1323123));
            jugadores.Add(new Usuario(4,"Jose",1323123));
            jugadores.Add(new Usuario(5,"a",1323123));

            var cartas = baraja.Where(o => o.Id == 1).ToList();
            cartaMock.Setup(o => o.Puntaje(cartas));
            string Nombre1 = "Juan";
            string Nombre2 = "x";
            string Nombre3 = "y";
            string Nombre4 = "z";
            string Nombre5 = "c";
            List<string> abc = new List<string>();
            List<Usuario> ganador = new List<Usuario>();
            Usuario nuevo = new Usuario();
            nuevo.Id = 1;
            nuevo.Nombre = "Juan";
            nuevo.Puntaje = 1323123;
            abc.Add(Nombre1);abc.Add(Nombre2);abc.Add(Nombre3);abc.Add(Nombre4);abc.Add(Nombre5);
            userMock.Setup(o => o.JugadorGanador(1323123,jugadores)).Returns(ganador);
            userMock.Setup(o => o.JugadoresConPuntaje(baraja,jugadores)).Returns(jugadores);
            userMock.Setup(o => o.Jugadores(abc)).Returns(jugadores);
            cartaMock.Setup(o => o.Puntajemaximo(jugadores)).Returns(1323123);
  
            
            JuegoDePokerController jugegoPoker = new JuegoDePokerController(cartaMock.Object,userMock.Object);
            var ganadores = jugegoPoker.Ganadores(Nombre1, Nombre2, Nombre3, Nombre4, Nombre5);
          
          ganador.Add(nuevo);
         
          var ResultadoEsperado = ganador;
             Assert.AreEqual(ResultadoEsperado, ganadores);
        }
        
          [Test]
        public void MariaGana()
        {
         
            List<string> a = new List<string>();
            var userMock = new Mock<IUsuarioService>();
           
            
            var baraja = new List<Carta>();
            Carta nueva1 = new Carta(1, 1, "♥", 1);
            baraja.Add(nueva1);
            Carta nueva2 = new Carta(2, 2, "♥", 0);
            baraja.Add(nueva2);
            Carta nueva3 = new Carta(3, 3, "♥", 0);
            baraja.Add(nueva3);
            Carta nueva4 = new Carta(4, 4, "♥", 0);
            baraja.Add(nueva4);
            Carta nueva5 = new Carta(5, 5, "♥", 0);
            baraja.Add(nueva5);
            Carta nueva6 = new Carta(6, 6, "♥", 0);
            baraja.Add(nueva6);
            Carta nueva7 = new Carta(7, 7, "♥", 0);
            baraja.Add(nueva7);
            Carta nueva8 = new Carta(8, 8, "♥", 0);
            baraja.Add(nueva8);
            Carta nueva9 = new Carta(9, 9, "♥", 0);
            baraja.Add(nueva9);
            Carta nueva10 = new Carta(10, 10, "♥", 0);
            baraja.Add(nueva10);

            Carta nueva11 = new Carta(11, 11, "♥", 1);
            baraja.Add(nueva11);
            Carta nueva12 = new Carta(12, 12, "♥", 1);
            baraja.Add(nueva12);
            Carta nueva13 = new Carta(13, 13, "♥", 1);
            baraja.Add(nueva13);
            Carta nueva14 = new Carta(14, 1, "♦", 0);
            baraja.Add(nueva14);
            Carta nueva15 = new Carta(15, 2, "♦", 0);
            baraja.Add(nueva15);
            Carta nueva16 = new Carta(16, 3, "♦", 0);
            baraja.Add(nueva16);
            Carta nueva17 = new Carta(17, 4, "♦", 2);
            baraja.Add(nueva17);
            Carta nueva18 = new Carta(18, 5, "♦", 2);
            baraja.Add(nueva18);
            Carta nueva19 = new Carta(19, 6, "♦", 2);
            baraja.Add(nueva19);
            Carta nueva20 = new Carta(20, 7, "♦", 2);
            baraja.Add(nueva20);

            Carta nueva21 = new Carta(21, 8, "♦", 0);
            baraja.Add(nueva21);
            Carta nueva22 = new Carta(22, 9, "♦", 0);
            baraja.Add(nueva22);
            Carta nueva23 = new Carta(23, 10, "♦", 0);
            baraja.Add(nueva23);
            Carta nueva24 = new Carta(24, 11, "♦", 0);
            baraja.Add(nueva24);
            Carta nueva25 = new Carta(25, 12, "♦", 0);
            baraja.Add(nueva25);
            Carta nueva26 = new Carta(26, 13, "♦", 0);
            baraja.Add(nueva26);
            Carta nueva27 = new Carta(27, 1, "♠", 0);
            baraja.Add(nueva27);
            Carta nueva28 = new Carta(28, 2, "♠", 0);
            baraja.Add(nueva28);
            Carta nueva29 = new Carta(29, 3, "♠", 0);
            baraja.Add(nueva29);
            Carta nueva30 = new Carta(30, 4, "♠", 0);
            baraja.Add(nueva30);

            Carta nueva31 = new Carta(31, 5, "♠", 0);
            baraja.Add(nueva31);
            Carta nueva32 = new Carta(32, 6, "♠", 0);
            baraja.Add(nueva32);
            Carta nueva33 = new Carta(33, 7, "♠", 0);
            baraja.Add(nueva33);
            Carta nueva34 = new Carta(34, 8, "♠", 0);
            baraja.Add(nueva34);
            Carta nueva35 = new Carta(35, 9, "♠", 0);
            baraja.Add(nueva35);
            Carta nueva36 = new Carta(36, 10, "♠", 0);
            baraja.Add(nueva36);
            Carta nueva37 = new Carta(37, 11, "♠", 0);
            baraja.Add(nueva37);
            Carta nueva38 = new Carta(38, 12, "♠", 0);
            baraja.Add(nueva38);
            Carta nueva39 = new Carta(39, 13, "♠", 0);
            baraja.Add(nueva39);
            Carta nueva40 = new Carta(40, 1, "♣", 0);
            baraja.Add(nueva40);

            Carta nueva41 = new Carta(41, 2, "♣", 0);
            baraja.Add(nueva41);
            Carta nueva42 = new Carta(42, 3, "♣", 0);
            baraja.Add(nueva42);
            Carta nueva43 = new Carta(43, 4, "♣", 0);
            baraja.Add(nueva43);
            Carta nueva44 = new Carta(44, 5, "♣", 0);
            baraja.Add(nueva44);
            Carta nueva45 = new Carta(45, 6, "♣", 0);
            baraja.Add(nueva45);
            Carta nueva46 = new Carta(46, 7, "♣", 0);
            baraja.Add(nueva46);
            Carta nueva47 = new Carta(47, 8, "♣", 0);
            baraja.Add(nueva47);
            Carta nueva48 = new Carta(48, 9, "♣", 0);
            baraja.Add(nueva48);
            Carta nueva49 = new Carta(49, 10, "♣", 0);
            baraja.Add(nueva49);
            Carta nueva50 = new Carta(50, 11, "♣", 0);
            baraja.Add(nueva50);

            Carta nueva51 = new Carta(51, 12, "♣", 0);
            baraja.Add(nueva51);
            Carta nueva52 = new Carta(52, 13, "♣", 0);
            baraja.Add(nueva52);

            var cartaMock = new Mock<ICartaService>();
            cartaMock.Setup(o => o.AsignarBarajaJugador()).Returns(baraja);
            cartaMock.Setup(o => o.Puntaje(baraja)).Returns(3000);
            List<Usuario> jugadores= new List<Usuario>();
            jugadores.Add(new Usuario(1,"Juan",1323123));
            jugadores.Add(new Usuario(2,"Jorge",1323123));
            jugadores.Add(new Usuario(3,"Luis",1323123));
            jugadores.Add(new Usuario(4,"Maria",1323123));
            jugadores.Add(new Usuario(5,"a",1323123));

            var cartas = baraja.Where(o => o.Id == 1).ToList();
            cartaMock.Setup(o => o.Puntaje(cartas));
            string Nombre1 = "Juan";
            string Nombre2 = "x";
            string Nombre3 = "y";
            string Nombre4 = "z";
            string Nombre5 = "c";
            List<string> abc = new List<string>();
            List<Usuario> ganador = new List<Usuario>();
            Usuario nuevo = new Usuario();
            nuevo.Id = 1;
            nuevo.Nombre = "maria";
            nuevo.Puntaje = 155555;
            abc.Add(Nombre1);abc.Add(Nombre2);abc.Add(Nombre3);abc.Add(Nombre4);abc.Add(Nombre5);
            userMock.Setup(o => o.JugadorGanador(155555,jugadores)).Returns(ganador);
            userMock.Setup(o => o.JugadoresConPuntaje(baraja,jugadores)).Returns(jugadores);
            userMock.Setup(o => o.Jugadores(abc)).Returns(jugadores);
            cartaMock.Setup(o => o.Puntajemaximo(jugadores)).Returns(155555);
  
            
            JuegoDePokerController jugegoPoker = new JuegoDePokerController(cartaMock.Object,userMock.Object);
            var ganadores = jugegoPoker.Ganadores(Nombre1, Nombre2, Nombre3, Nombre4, Nombre5);
          
          ganador.Add(nuevo);
         
          var ResultadoEsperado = ganador;
             Assert.AreEqual(ResultadoEsperado, ganadores);
        }
        
        
    }
}
      
