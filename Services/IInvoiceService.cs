using InvoiceWebApi.Entities;

public interface IInvoiceService
{
    Task<List<InvoiceItemDTO>> GetInvoice();
}