namespace SimulacionPoker.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Puntaje { get; set; }

        public Usuario(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
          
        }

        public Usuario()
        {
        }

        public Usuario(int id, string nombre, int puntaje)
        {
            Id = id;
            Nombre = nombre;
            Puntaje = puntaje;
        }
    }
}