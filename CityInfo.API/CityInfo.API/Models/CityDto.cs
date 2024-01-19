namespace CityInfo.API.Models
{
    //this is the model
    //later on, we will use entities where databases and calculations on the go (not part of the city entity class)
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public int NumberOfPointsOfInterest
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }

        public ICollection<PointsOfInterestsDto> PointsOfInterest { get; set; } = new List<PointsOfInterestsDto>();

        //calculated field: number of points of interest
    }
}
