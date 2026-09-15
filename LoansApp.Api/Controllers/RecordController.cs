using LoansApp.Core.Application.DTOs.Record;
using LoansApp.Core.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoansApp.Api.Controllers
{
    public class RecordController : BaseApiController
    {
        private readonly IRecordService _recordService;

        public RecordController(IRecordService recordService)
        {
            _recordService = recordService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ViewRecord>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> List()
        {
            try
            {
                var records = await _recordService.GetAllAsync();
                return Ok(records);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
