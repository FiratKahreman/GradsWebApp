using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Core.DTOs
{
    public class CardDTO
    {
        public DateTime OrderDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int UsedDiscountsOnMonth { get; set; }
        public int UsedDiscountsOnAll { get; set; }
        public int RemainingDiscounts { get; set; }
    }
}
