using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{

    public class Player1AttackResultModel : PageModel
    {
        public IActionResult OnPost()
        {

            if (Domain.GameBoard.gameOn)
            {
                Domain.GameBoard.shipSquareCount = 0;
                return RedirectToPage("/P2AttackMove");
            }

            return RedirectToPage("/Index");            
        }
    }
}