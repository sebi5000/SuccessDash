using SuccessDash.Shared.Model.Interfaces;

namespace SuccessDash.Shared.Model
{
    public class DataOverview : IOverviewComponent
    {
        public int Id { get; set; }

        public int SortOrder { get; set; }

        public OverviewComponentSize Size { get; set; }

        public string Title { get; set; } = "Titel";

        public string DetailPath { get; set; } = string.Empty;

        public IEnumerable<Data>? Data { get; set; }

        public int CompareTo(IOverviewComponent? other)
        {
            if (other == null) return 1;

            return SortOrder.CompareTo(other.SortOrder);
        }

        public bool Equals(IOverviewComponent? other)
        {
            if (other == null) return false;
            return Id == other.Id;
        }
    }
}
