using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoansApp.Api.Controllers
{
    public class LoanController : BaseApiController
    {
        private readonly ILoanService _loanService;

        public LoanController(ILoanService loanService)
        {
            _loanService = loanService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ViewLoan>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> List([FromQuery] string? parameter, [FromQuery] string? parameterValue)
        {
            try
            {
                if (!string.IsNullOrEmpty(parameter) && !string.IsNullOrEmpty(parameterValue))
                {
                    var filteredLoans = await _loanService.GetAllWithFilterAsync(parameter, parameterValue);
                    return Ok(filteredLoans);
                }

                var loans = await _loanService.GetAllAsync();
                return Ok(loans);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id:int}", Name = "GetLoanById")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ViewLoan))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var loan = await _loanService.GetByIdAsync(id);
                if (loan is null)
                {
                    return NotFound($"Loan with ID: {id} could not be found.");
                }

                return Ok(loan);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] SaveLoan createdLoan)
        {
            try
            {
                await _loanService.AddAsync(createdLoan);
                return CreatedAtRoute("GetLoanById", new { id = createdLoan.Id },createdLoan);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SaveLoan))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update([FromBody] SaveLoan saveLoan, int id)
        {
            try
            {
                if (id != saveLoan.Id)
                {
                    return BadRequest("The ID provided in the URL does not match the id in the body");
                }

                await _loanService.UpdateAsync(saveLoan, id);
                return Ok(saveLoan);
            }
            catch (KeyNotFoundException)
            {
                return NotFound($"Loan with ID: {id} coult not be found.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var loan = await _loanService.GetByIdAsync(id);
                if (loan == null)
                {
                    return NotFound();
                }
                await _loanService.DeleteAsync(loan.Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}