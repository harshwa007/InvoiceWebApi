
using InvoiceWebApi.Repository;

namespace InvoiceWebApi.Services
{
    public class InvoiceService : IInvoiceService
    {
        public readonly IInvoiceRepo _invoiceRepo;
        public InvoiceService(IInvoiceRepo invoiceRepo)
        {
            _invoiceRepo = invoiceRepo;
        }
        public async Task<List<InvoiceItemDTO>> GetInvoice()
        {
            var invoice = await _invoiceRepo.GetInvoice();
            return invoice.Select(i => new InvoiceItemDTO
            {
                name = i.Name,
                price = i.Price,
            }).ToList();
        }
    }
}
