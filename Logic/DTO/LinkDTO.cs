namespace Logic.DTO
{
    public class LinkDTO
    {
        public Guid Id { get; set; }
        public string? LongURl { get; set; }
        public string? ShortURL { get; set; }
        public DateTime Date { get; set; }
        public int VisitsNumber { get; set; }
    }
}

