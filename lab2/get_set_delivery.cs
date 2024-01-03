using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface get_set_delivery
    {
        string Id { get; set; }
        DateTime OperationDate { get; set; }
        double PackageWeight { get; set; }
        decimal PriceToPay { get; set; }
        string SenderName { get; set; }
        string SenderPhoneNumber { get; set; }
        bool IsPaidBySender { get; set; }
        string RecipientName { get; set; }
        bool IsCompleted { get; set; }
    }
}
