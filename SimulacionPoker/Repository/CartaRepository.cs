using System;
using System.Collections.Generic;
using System.Linq;
using SimulacionPoker.Models;

namespace SimulacionPoker.Repository
{
    public interface ICartaService
    {
        public int Puntaje(List<Carta> mano);
        public List<Carta> AsignarBarajaJugador();
        public List<Carta> CrearBaraja();
        public List<string> TipoCarta();
    }

    public class CartaRepository : ICartaService
    {
        public int Puntaje(List<Carta> mano)
        {
              int numero1 = 0,
                numero2 = 0,
                numero3 = 0,
                numero4 = 0,
                numero5 = 0,
                numero6 = 0,
                numero7 = 0,
                numero8 = 0,
                numero9 = 0,
                numero10 = 0,
                numero11 = 0,
                numero12 = 0,
                numero13 = 0,
                corazones = 0,
                espadas = 0,
                diamantes = 0,
                treboles = 0,
                escalera = 0,
                puntaje = 0;

            foreach (var item in mano)
            {
                if (1 == item.Numero)
                {
                    numero1++;
                }

                if (2 == item.Numero)
                {
                    numero2++;
                }

                if (3 == item.Numero)
                {
                    numero3++;
                }

                if (4 == item.Numero)
                {
                    numero4++;
                }

                if (5 == item.Numero)
                {
                    numero5++;
                }

                if (6 == item.Numero)
                {
                    numero6++;
                }

                if (7 == item.Numero)
                {
                    numero7++;
                }

                if (8 == item.Numero)
                {
                    numero8++;
                }

                if (9 == item.Numero)
                {
                    numero9++;
                }

                if (10 == item.Numero)
                {
                    numero10++;
                }

                if (11 == item.Numero)
                {
                    numero11++;
                }

                if (12 == item.Numero)
                {
                    numero12++;
                }

                if (13 == item.Numero)
                {
                    numero13++;
                }

                if ("♥" == item.tipoCarta)
                {
                    corazones++;
                }

                if ("♦" == item.tipoCarta)
                {
                    diamantes++;
                }

                if ("♠" == item.tipoCarta)
                {
                    espadas++;
                }

                if ("♣" == item.tipoCarta)
                {
                    treboles++;
                }
            }

            if ((numero1 == 1 && numero2 == 1 && numero3 == 1 && numero4 == 1 && numero5 == 1) ||
                (numero2 == 1 && numero3 == 1 && numero4 == 1 && numero5 == 1 && numero6 == 1)
                || (numero3 == 1 && numero4 == 1 && numero5 == 1 && numero6 == 1 && numero7 == 1) ||
                (numero4 == 1 && numero5 == 1 && numero6 == 1 && numero7 == 1 && numero8 == 1)
                || (numero5 == 1 && numero6 == 1 && numero7 == 1 && numero8 == 1 && numero9 == 1) ||
                (numero6 == 1 && numero7 == 1 && numero8 == 1 && numero9 == 1 && numero10 == 1)
                || (numero7 == 1 && numero8 == 1 && numero9 == 1 && numero10 == 1 && numero11 == 1) ||
                (numero8 == 1 && numero9 == 1 && numero10 == 1 && numero11 == 1 && numero12 == 1)
                || (numero9 == 1 && numero10 == 1 && numero11 == 1 && numero12 == 1 && numero13 == 1) ||
                (numero9 == 1 && numero10 == 1 && numero11 == 1 && numero12 == 1 && numero13 == 1)
                || (numero10 == 1 && numero11 == 1 && numero12 == 1 && numero13 == 1 && numero1 == 1))
            {
                escalera++;
            }

            Console.WriteLine("numero 1: " + numero1);
            Console.WriteLine("numero 2: " + numero2);
            Console.WriteLine("numero 3: " + numero3);
            Console.WriteLine("numero 4: " + numero4);
            Console.WriteLine("numero 5: " + numero5);
            Console.WriteLine("numero 6: " + numero6);
            Console.WriteLine("numero 7: " + numero7);
            Console.WriteLine("numero 8: " + numero8);
            Console.WriteLine("numero 9: " + numero9);
            Console.WriteLine("numero 10: " + numero10);
            Console.WriteLine("numero 11: " + numero11);
            Console.WriteLine("numero 12: " + numero12);
            Console.WriteLine("numero 13: " + numero13);
            Console.WriteLine("corazones ♥: " + corazones);
            Console.WriteLine("diamantes ♦: " + diamantes);
            Console.WriteLine("treboles ♣: " + treboles);
            Console.WriteLine("espadas ♠: " + espadas);
            Console.WriteLine("escalera : " + escalera);
            List<ValorCarta> cartasCasino = new List<ValorCarta>();
            ValorCarta carta1 = new ValorCarta(1, numero1);
            ValorCarta carta2 = new ValorCarta(2, numero2);
            ValorCarta carta3 = new ValorCarta(3, numero3);
            ValorCarta carta4 = new ValorCarta(4, numero4);
            ValorCarta carta5 = new ValorCarta(5, numero5);
            ValorCarta carta6 = new ValorCarta(6, numero6);
            ValorCarta carta7 = new ValorCarta(7, numero7);
            ValorCarta carta8 = new ValorCarta(8, numero8);
            ValorCarta carta9 = new ValorCarta(9, numero9);
            ValorCarta carta10 = new ValorCarta(10, numero10);
            ValorCarta carta11 = new ValorCarta(11, numero11);
            ValorCarta carta12 = new ValorCarta(12, numero12);
            ValorCarta carta13 = new ValorCarta(13, numero13);
            cartasCasino.Add(carta1);
            cartasCasino.Add(carta2);
            cartasCasino.Add(carta3);
            cartasCasino.Add(carta4);
            cartasCasino.Add(carta5);
            cartasCasino.Add(carta6);
            cartasCasino.Add(carta7);
            cartasCasino.Add(carta8);
            cartasCasino.Add(carta9);
            cartasCasino.Add(carta10);
            cartasCasino.Add(carta11);
            cartasCasino.Add(carta12);
            cartasCasino.Add(carta13);

            List<ValorCarta> misCartas = new List<ValorCarta>();
            foreach (var item in cartasCasino)
            {
                if (item.Cantidad > 0)
                {
                    misCartas.Add(item);
                }
            }

            int CantidadPares = 0, CantidadTrios = 0, CantidadPoker = 0, SinPares = 0;
            foreach (var item in misCartas)
            {
                // Console.WriteLine("el numero " + item.Id + " repetido " + item.Cantidad);
                if (item.Cantidad == 1)
                {
                    SinPares++;
                }

                if (item.Cantidad == 2)
                {
                    CantidadPares++;
                }

                if (item.Cantidad == 3)
                {
                    CantidadTrios++;
                }

                if (item.Cantidad == 4)
                {
                    CantidadPoker++;
                }
            }

            Console.WriteLine("el numero de pares " + CantidadPares);
            Console.WriteLine("tiene trio " + CantidadTrios);
            Console.WriteLine("tiene poker " + CantidadPoker);
            if (escalera == 1)
            {
                if (numero1 == 1 && numero13 == 1)
                {
                    puntaje += 4500 + misCartas.Max(o => o.Id);
                }
                else
                {
                    puntaje += 4000 + misCartas.Max(o => o.Id);
                }
            }

            if (diamantes == 5 || corazones == 5 || treboles == 5 || espadas == 5)
            {
                puntaje += 5000 + misCartas.Max(o => o.Id);
                ;
            }

            if (escalera == 1 && (diamantes == 5 || corazones == 5 || treboles == 5 || espadas == 5))
            {
                if (numero1 == 1 && numero13 == 1)
                {
                    puntaje += 500000 + misCartas.Max(o => o.Id);
                }

                puntaje += 50000 + misCartas.Max(o => o.Id);
                ;
            }

            if (SinPares == 5)
            {
                puntaje += misCartas.Max(o => o.Id);
            }

            if (CantidadPares == 1 && CantidadTrios == 0)
            {
                var carta = misCartas.FirstOrDefault(o => o.Cantidad == 2);
                var cartamayor = misCartas.Where(o => o.Cantidad == 1).ToList();
                var Mayor = cartamayor.Max(o => o.Id);
                if (carta.Id == 1)
                {
                    puntaje += 1000 + (14 * 15) + Mayor;
                }
                else
                {
                    puntaje += 1000 + (carta.Id * 15) + Mayor;
                }
            }

            if (CantidadPares == 2)
            {
                var carta = misCartas.Where(o => o.Cantidad == 2).ToList();
                var CartaMayorDelPar = carta.Max(o => o.Id);
                var cartamayor = misCartas.Where(o => o.Cantidad == 1).ToList();
                var Mayor = cartamayor.Max(o => o.Id);
                if (CartaMayorDelPar == 1)
                {
                    puntaje += 2000 + (14 * 15) + Mayor;
                }
                else
                {
                    puntaje += 2000 + (CartaMayorDelPar * 15) + Mayor;
                }
            }

            if (CantidadPares == 0 && CantidadTrios == 1)
            {
                var carta = misCartas.Where(o => o.Cantidad == 3).ToList();
                var CartaMayorDelPar = carta.Max(o => o.Id);
                var cartamayor = misCartas.Where(o => o.Cantidad == 1).ToList();
                var Mayor = cartamayor.Max(o => o.Id);
                if (CartaMayorDelPar == 1)
                {
                    puntaje += 3000 + (14 * 15) + Mayor;
                }
                else
                {
                    puntaje += 3000 + (CartaMayorDelPar * 15) + Mayor;
                }
            }

            if (CantidadPares == 1 && CantidadTrios == 1)
            {
                var carta = misCartas.Where(o => o.Cantidad == 3).ToList();
                var CartaMayorDelPar = carta.Max(o => o.Id);
                var cartamayor = misCartas.Where(o => o.Cantidad == 1).ToList();
                var Mayor = cartamayor.Max(o => o.Id);
                if (CartaMayorDelPar == 1)
                {
                    puntaje += 6000 + (14 * 15) + Mayor;
                }
                else
                {
                    puntaje += 6000 + (CartaMayorDelPar * 15) + Mayor;
                }
            }

            if (CantidadPoker == 1)
            {
                var carta = misCartas.Where(o => o.Cantidad == 4).ToList();
                var CartaMayorDelPar = carta.Max(o => o.Id);
                var cartamayor = misCartas.Where(o => o.Cantidad == 1).ToList();
                var Mayor = cartamayor.Max(o => o.Id);
                if (CartaMayorDelPar == 1)
                {
                    puntaje += 7000 + (14 * 15) + Mayor;
                }
                else
                {
                    puntaje += 7000 + (CartaMayorDelPar * 15) + Mayor;
                }
            }

            Console.WriteLine("Puntaje total : " + puntaje);
            return puntaje;
        }

        public List<Carta> AsignarBarajaJugador()
        {
            var baraja = CrearBaraja();
            
            List<int> indices = new List<int>();
            Random aleatorio = new Random();
            int contador1 = 0;


            for (int i = 1; i < 6; i++)
            {
                do
                {
                    var numero = aleatorio.Next(0, 52);
                    if (!indices.Contains(numero))
                    {
                        indices.Add(numero);
                        baraja[numero].IdUsuario = i;
                        contador1++;
                    }
                } while (contador1 < 5);

                contador1 = 0;
            }

            return baraja;

        }

        public List<Carta> CrearBaraja()
        {
            List<Carta> Baraja = new List<Carta>();
            var tipoDeCarta = TipoCarta();
            int contadorA = 1, contadorB = 0;
            for (int i = 1; i < 53; i++)
            {
                Carta nuevaCarta = new Carta();

                if (contadorA > 13)
                {
                    contadorB++;
                    contadorA = 1;
                }

                nuevaCarta.Id = i;
                nuevaCarta.Numero = contadorA;
                nuevaCarta.tipoCarta = tipoDeCarta[contadorB];
                contadorA++;
                Baraja.Add(nuevaCarta);
            }

            return Baraja;
        }

        public List<string> TipoCarta()
        {
            List<string> tipoDeCarta = new List<string>();
            tipoDeCarta.Add("♥");
            tipoDeCarta.Add("♦");
            tipoDeCarta.Add("♠");
            tipoDeCarta.Add("♣");
            return tipoDeCarta;
        }
    }
}