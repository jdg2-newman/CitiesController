using System;
using CityInfo3.API.Models;

namespace CityInfo3.API
{
	public class CitiesDataStore
	{
		public List<CityDto> Cities {get; set;}
		//public static CitiesDataStore Current { get; } = new CitiesDataStore();

		public CitiesDataStore()
        {
			Cities = new List<CityDto>()
			{
				new CityDto()
				{
					Id = 1,
					Name = "New York City",
					Description = "The one with the big park",
					PointsOfInterest = new List<PointOfInterestDto>()
                    {
						new PointOfInterestDto()
                        {
							Id = 1,
							Name = "Central Park",
							Description = "Big green park"
                        },
						new PointOfInterestDto()
                        {
							Id = 2,
							Name = "Empire State Building",
							Description = "Big building"
                        }
                    }
				},
				new CityDto()
				{
					Id = 2,
					Name = "Ram Ranch City",
					Description = " The one with the cowboys",
					PointsOfInterest = new List<PointOfInterestDto>()
					{
						new PointOfInterestDto()
						{
							Id = 3,
							Name = "Shower",
							Description = "Where the cowboys congregate"
						},
						new PointOfInterestDto()
						{
							Id = 4,
							Name = "Yard",
							Description = "Where the cowboys also congregate"
						}
					}
				},
				new CityDto()
				{
					Id = 3,
					Name = "Paris",
					Description = "The one with the french people",
					PointsOfInterest = new List<PointOfInterestDto>()
					{
						new PointOfInterestDto()
						{
							Id = 5,
							Name = "Eiffel Tower",
							Description = "Big tower in the centre of france"
						},
						new PointOfInterestDto()
						{
							Id = 6,
							Name = "The Louvre",
							Description = "Worlds largest museum"
						}
					}
				}

			};
        }
	}
}

