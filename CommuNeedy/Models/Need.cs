using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommuNeedy.Models
{
    public class Need
    {
        public int Id { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Category { get; set; }

        public string OwnerId { get; set; }
        public User Owner { get; set; }

        public int CatId { get; set; }
        public Category CategorySelect { get; set; }

        //public ICollection<Donation> Donations { get; set; }
        public ICollection<DonationNeed> DonationNeeds { get; set; }
    }
}
