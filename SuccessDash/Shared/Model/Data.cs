namespace SuccessDash.Shared.Model
{
    public class Data
    {
        public int Id { get; set; }

        public string Title { get; set; } = "Titel";

        public IEnumerable<RawData>? RawData { get; set; }
    }
}
