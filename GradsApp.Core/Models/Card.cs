using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Core.Models
{
    public class Card : BaseEntity
    {
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime ExpiryDate { get; set; } = DateTime.Now.AddYears(2);
        public int UsedDiscountsOnMonth { get; set; } = 0;
        public int UsedDiscountsOnAll { get; set; } = 0;
        public int RemainingDiscounts { get; set; } = 5;
        public int CardProfileId { get; set; }
        public UserProfile CardProfile { get; set; }
    }
}
