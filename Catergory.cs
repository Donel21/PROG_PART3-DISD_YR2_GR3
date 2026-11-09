using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestingPart2_Official.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public int EventID { get; set; }

        [Required, MaxLength(100)]
        public string CategoryName { get; set; } = string.Empty;

        public decimal DistanceKm { get; set; }
        public decimal EntryFee { get; set; }

        public Event Event { get; set; }

        // ADD THIS LINE:
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}