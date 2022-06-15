using GradsApp.Core.DTOs;
using GradsApp.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GradsApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCard(int id)
        {
            var result = await _cardService.GetCardById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> NewCard(NewCardDTO newCardDto)
        {
            var result = await _cardService.NewCard(newCardDto);
            return Ok(result);
        }
    }
}
