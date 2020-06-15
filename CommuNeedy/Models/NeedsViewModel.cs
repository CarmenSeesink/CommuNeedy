using System;
using System.Collections.Generic;

namespace CommuNeedy.Models
{
    public class NeedsViewModel
    {
        public int CatId { get; set; }

        public ICollection<Need> GeneralNeeds { get; set; }
        public ICollection<Need> UserNeeds { get; set; }
        public ICollection<Need> NeedsWithDonations { get; set; }
    }
}
