using InvoiceWebApi.Entities;

namespace InvoiceWebApi.Repository
{
    public interface IInvoiceRepo
    {
        Task<List<InvoiceItem>> GetInvoice();
    }
}
