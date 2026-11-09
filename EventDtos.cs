using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace TestingPart2_Official.DTOs
{
    public class EventCreateDto
    {
        public string EventName { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string Location { get; set; } = string.Empty;
        public string? Description { get; set; }
        public IFormFile? BannerImage { get; set; }
    }

    public class EventUpdateDto
    {
        public string EventName { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string Location { get; set; } = string.Empty;
        public string? Description { get; set; }
    }

    public class EventResponseDto
    {
        public int EventID { get; set; }
        public int OrganiserID { get; set; }
        public string EventName { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string Location { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? BannerImageUrl { get; set; }

        public List<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
    }

    public class CategoryDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public decimal DistanceKm { get; set; }
        public decimal EntryFee { get; set; }
    }
}