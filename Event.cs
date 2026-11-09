
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestingPart2_Official.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [Required]
        public int OrganiserID { get; set; }

        [Required, MaxLength(150)]
        public string EventName { get; set; } = string.Empty;

        [Required]
        public DateTime EventDate { get; set; }

        [Required, MaxLength(150)]
        public string Location { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Description { get; set; }

        // Azure Blob Storage image URL
        [MaxLength(500)]
        public string? BannerImageUrl { get; set; }

        // Relationship with User
        public User Organiser { get; set; } = null!;

        // Relationship with Categories
        public ICollection<Category> Categories { get; set; }
            = new List<Category>();

        // Relationship with Event Routes
        public ICollection<EventRoute> Routes { get; set; }
            = new List<EventRoute>();
    }
}
