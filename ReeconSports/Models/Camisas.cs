namespace ReeconSports.Models
{
    public class Camisas
    {
        public int CamisasId { get; set; }
        public decimal Preco { get; set; }
        public string Tamanho { get; set; }
        public bool Disponibilidade { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
