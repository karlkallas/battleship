using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{

    public class Player2AttackResultModel : PageModel
    {
        public IActionResult OnPost()
        {

            if (Domain.GameBoard.gameOn)
            {
                Domain.GameBoard.shipSquareCount = 0;
                return RedirectToPage("/P1AttackMove");
            }

            return RedirectToPage("/Index");            
        }
    }
}