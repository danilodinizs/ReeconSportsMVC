namespace ReeconSports.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Time { get; set; }

        public List<Camisas> Camisas { get; set; }
    }
}
