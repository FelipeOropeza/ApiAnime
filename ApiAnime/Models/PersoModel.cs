namespace ApiAnime.Models
{
    public class PersoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Origem { get; set; }
        public string? Apelido { get; set; }
        public string? Metas { get; set; }
        public int ?PoderId { get; set; }
        public virtual PoderModel ?Poder { get; set; }
        public int ?FuncId { get; set; }
        public virtual FuncModel ?Func { get; set; }
    }
}
