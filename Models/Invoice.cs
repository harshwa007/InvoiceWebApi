using Microsoft.EntityFrameworkCore;

namespace InvoiceWebApi.Entities
{
    [Keyless]
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public string? CustomerName { get; set; }

    }
}
