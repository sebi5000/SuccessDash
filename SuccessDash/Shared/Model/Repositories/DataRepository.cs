namespace SuccessDash.Shared.Model.Repositories
{
    public class DataRepository
    {
        public Data Get(int id)
        {
            //Todo: Hier nicht nur Mock-Daten liefern
            if (id == 0)
            {
                return GetMock1();
            }

            return GetMock2();
        }

        public IEnumerable<Data> Select()
        {
            return new[] { GetMock1(), GetMock2() };
        }

        internal Data GetMock1()
        {
            var rand = new Random();

            return new Data()
            {
                Id = 1,
                Title = "Personalservice",
                RawData = new RawData[]
                {
                    new RawData(){
                        Category = DateTime.Parse("2015-12-31").ToString(),
                        Value = rand.Next(29, 60)
                    },
                    new RawData(){
                        Category = DateTime.Parse("2016-12-31").ToString(),
                        Value = rand.Next(29, 60)
                    },
                    new RawData(){
                        Category = DateTime.Parse("2017-12-31").ToString(),
                        Value = rand.Next(29, 60)
                    },
                    new RawData(){
                        Category = DateTime.Parse("2018-12-31").ToString(),
                        Value = rand.Next(29, 60)
                    },
                    new RawData(){
                        Category = DateTime.Parse("2019-12-31").ToString(),
                        Value = rand.Next(29, 60)
                    },
                    new RawData(){
                        Category = DateTime.Parse("2020-12-31").ToString(),
                        Value = rand.Next(29, 60)
                    },
                    new RawData(){
                        Category = DateTime.Parse("2021-12-31").ToString(),
                        Value = rand.Next(29, 60)
                    }
                }
            };
        }

        internal Data GetMock2()
        {
            var rand = new Random();

            return new Data()
            {
                Id = 2,
                Title = "Sales",
                RawData = new RawData[]
                {
                    new RawData(){
                        Category = DateTime.Parse("2015-12-31").ToString(),
                        Value = rand.Next(29, 60)
                    },
                    new RawData(){
                        Category = DateTime.Parse("2016-12-31").ToString(),
                        Value = rand.Next(29, 60)
                    },
                    new RawData(){
                        Category = DateTime.Parse("2017-12-31").ToString(),
                        Value = rand.Next(29, 60)
                    },
                    new RawData(){
                        Category = DateTime.Parse("2018-12-31").ToString(),
                        Value = rand.Next(29, 60)
                    },
                    new RawData(){
                        Category = DateTime.Parse("2019-12-31").ToString(),
                        Value = rand.Next(29, 60)
                    },
                    new RawData(){
                        Category = DateTime.Parse("2020-12-31").ToString(),
                        Value = rand.Next(29, 60)
                    },
                    new RawData(){
                        Category = DateTime.Parse("2021-12-31").ToString(),
                        Value = rand.Next(29, 60)
                    }
                }
            };
        }
    }
}
