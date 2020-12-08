namespace SimulacionPoker.Models
{
    public class ValorCarta
    {
        
        public int Id { get; set; }
        public int Cantidad { get; set; }

        public ValorCarta(int id, int cantidad)
        {
            Id = id;
            Cantidad = cantidad;
        }
    }
}