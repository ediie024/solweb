namespace SimulacionPoker.Models
{
    public class Carta
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string tipoCarta { get; set; }
        
        public int IdUsuario { get; set; }

        public Carta(int id, int numero, string tipoCarta, int idUsuario)
        {
            Id = id;
            Numero = numero;
            this.tipoCarta = tipoCarta;
            IdUsuario = idUsuario;
        }

        public Carta()
        {
        }
    }
}