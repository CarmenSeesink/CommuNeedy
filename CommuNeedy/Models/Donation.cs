using System;
using System.ComponentModel.DataAnnotations;

namespace CommuNeedy.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleasedDate { get; set; }
        public string Category { get; set; }

        public string OwnerId { get; set; }
        public User Owner { get; set; }
    }
}
