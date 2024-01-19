namespace CityInfo.API.Models
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        //this is a singleton, there can only be one version instance of it
        public static CitiesDataStore Current { get;} = new CitiesDataStore();

        //this is the construct of the dummy data
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            { 
                new CityDto()
                {
                    Id = 1,
                    Name = "Brussels",
                    Description = "The best city",
                    PointsOfInterest = new List<PointsOfInterestsDto>()
                    {
                        new PointsOfInterestsDto()
                        {
                            Id = 1,
                            Name = "Interface3",
                            Description = "The queerest coding school",
                        },
                        new PointsOfInterestsDto()
                        {
                            Id = 2,
                            Name = "Beerka",
                            Description = "The queerest bar even when there are no queers",
                        }

                    }

                },
                new CityDto()
                {
                    Id = 2,
                    Name = "New york",
                    Description = "A pretty cool city",
                    PointsOfInterest = new List<PointsOfInterestsDto>()
                    {
                        new PointsOfInterestsDto()
                        {
                            Id = 1,
                            Name = "GreenPoint",
                            Description = "Where I lived for one month",
                        },
                        new PointsOfInterestsDto()
                        {
                            Id = 2,
                            Name = "Cubby Hole",
                            Description = "The lesbian bar!",
                        }

                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Warsaw",
                    Description = "A very old, yet very new city",
                    PointsOfInterest = new List<PointsOfInterestsDto>()
                    {
                        new PointsOfInterestsDto()
                        {
                            Id = 1,
                            Name = "Planetarum",
                            Description = "Because they show a trippy movie with Pink Floyd music",
                        },
                        new PointsOfInterestsDto()
                        {
                            Id = 2,
                            Name = "Culture Palace",
                            Description = "Huge building that people refer to as Stalin's private parts",
                        }

                    }
                }
            };
        }
    }
}
