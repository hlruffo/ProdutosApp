namespace ProdutosApp.Domain.Dtos
{
    public class ProdutosLogDto
    {
        public Guid Id { get; set; }
        public DateTime? DataHora { get; set; }
        public TipoLog? Tipo { get; set; }
        public ProdutosResponseDto? Produto { get; set; }
    }

    public enum TipoLog
    {
        CREATE = 1,
        UPDATE = 2,
        DELETE = 3
    }
}
