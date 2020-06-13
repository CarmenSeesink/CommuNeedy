using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommuNeedy.Models
{
    public class DonationViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleasedDate { get; set; }
        public string Category { get; set; }

        public string OwnerId { get; set; }
        public User Owner { get; set; }

        public ICollection<DonationNeed> DonationNeed { get; set; }
        public List<int> NeedIds { get; set; }
    }
}
