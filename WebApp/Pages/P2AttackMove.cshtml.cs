using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{

    public class Player2AttackModel : PageModel
    {
        private string VertCoord;
        private string HorizCoord;

        public IActionResult OnPost()
        {
            VertCoord = Request.Form["VertCoord"];
            HorizCoord = Request.Form["HorizCoord"];

            
            Domain.GameBoard.x_coord = Int32.Parse(VertCoord);
            Domain.GameBoard.y_coord = Int32.Parse(HorizCoord);
            Domain.GameBoard.Player2Turn();
            
            for (int i = 0; i < Domain.GameBoard.tableSize; i++)
            {
                for (int j = 0; j < Domain.GameBoard.tableSize; j++)
                {
                    if (Domain.GameBoard.Player1Board1[i][j] == BoardSquareState.Ship)
                    {
                        Domain.GameBoard.shipSquareCount++;
                    }
                }
            }
            
            return RedirectToPage("/P2AfterAttack");

            ;
        }
    }
}