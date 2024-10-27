using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignallR.BusinessLayer.Abstract;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MoneyCasesController : ControllerBase
	{
		public readonly IMoneyCaseService _moneyCaseService;

		public MoneyCasesController(IMoneyCaseService moneyCaseService)
		{
			_moneyCaseService = moneyCaseService;
		}

		[HttpGet]
		public IActionResult TotalMoneyCaseAmount()
		{
			return Ok(_moneyCaseService.TTotalMoneyCaseAmount());
		}
	}
}
