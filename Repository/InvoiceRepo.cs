using InvoiceWebApi.Data;
using InvoiceWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvoiceWebApi.Repository
{
    public class InvoiceRepo : IInvoiceRepo
    {
        private readonly AppDbContext _appDbContext;
        public InvoiceRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<InvoiceItem>> GetInvoice()
        {
            var invoice = await _appDbContext.InvoiceItems.ToListAsync();
            return invoice;
        }
    }
}
