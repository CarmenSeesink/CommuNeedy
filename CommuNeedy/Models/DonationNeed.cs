using System;
namespace CommuNeedy.Models
{
    public class DonationNeed
    {
        public int NeedId { get; set; }
        public Need Need { get; set; }

        public int DonationId { get; set; }
        public Donation Donation { get; set; }
    }
}
