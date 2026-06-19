
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController( IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetInvoice()
        {
            List<InvoiceItemDTO> items = await _invoiceService.GetInvoice();
            if (items.Count > 0) // NullReferenceException
            {
                return Ok(new { items });
            }
            return NotFound("No invoice found");
        }

        public class Item
        {
            public string name { get; set; }
            public decimal price { get; set; }
        }
    }
}
