namespace SuccessDash.Shared.Model.Interfaces
{
    public interface IOverviewComponent : IEquatable<IOverviewComponent>, IComparable<IOverviewComponent>
    {
        public int Id { get; set; }

        public int SortOrder { get; set; }

        public OverviewComponentSize Size { get; set; }

        public string Title { get; set; }

        public string DetailPath { get; set; }
    }
}
