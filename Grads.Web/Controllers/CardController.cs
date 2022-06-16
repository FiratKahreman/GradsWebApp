using Grads.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Grads.Web.Controllers
{
    public class CardController : Controller
    {
        private readonly CardAPIService _cardAPIService;

        public CardController(CardAPIService cardAPIService)
        {
            _cardAPIService = cardAPIService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var response = await _cardAPIService.GetCard(id);
            if (response == null)
            {
                return RedirectToAction("Index", "Social");
            }
            return View(response);
        }
    }
}
