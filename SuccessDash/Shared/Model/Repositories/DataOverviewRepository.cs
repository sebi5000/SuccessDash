namespace SuccessDash.Shared.Model.Repositories
{
    public class DataOverviewRepository
    {
        public DataOverview Get(int id)
        {
            //Todo: Hier nicht nur Mock-Daten liefern
            return GetMocks().ToList()[0];
        }

        public IEnumerable<DataOverview> Select()
        {
            return GetMocks();
        }

        internal IEnumerable<DataOverview> GetMocks()
        {
            return new DataOverview[]
            {
                new DataOverview()
                {
                    Id = 1,
                    SortOrder = 1,
                    Title = "Demographie",
                    DetailPath = String.Empty,
                    Data = new DataRepository().Select().ToArray()
                },
                new DataOverview()
                {
                    Id = 2,
                    SortOrder = 2,
                    Title = "HeadCount",
                    DetailPath = String.Empty,
                    Data = new DataRepository().Select().ToArray()
                },
                new DataOverview()
                {
                    Id = 3,
                    SortOrder = 3,
                    Title = "Some other stuff",
                    DetailPath = String.Empty,
                    Data = new DataRepository().Select().ToArray()
                }
            };
        }
    }
}
