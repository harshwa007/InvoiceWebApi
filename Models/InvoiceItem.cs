using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceWebApi.Entities
{
    [Keyless]
    public class InvoiceItem
    {
        public int ItemID { get; set; }
        [ForeignKey("Invoice")]
        public int InvoiceID { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}
