using LoansApp.Core.Application.DTOs.Payment;
using LoansApp.Core.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoansApp.Api.Controllers
{
    public class PaymentController : BaseApiController
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddPayment([FromBody] SavePayment savePayment)
        {
            try
            {
                var lastPayment = await _paymentService.ApplyPaymentAsync(savePayment);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
