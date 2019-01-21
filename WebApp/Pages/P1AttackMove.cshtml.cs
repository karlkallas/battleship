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

    public class Player1AttackModel : PageModel
    {
        private string VertCoord;
        private string HorizCoord;

        public IActionResult OnPost()
        {
            VertCoord = Request.Form["VertCoord"];
            HorizCoord = Request.Form["HorizCoord"];

            
            GameBoard.x_coord = Int32.Parse(VertCoord);
            GameBoard.y_coord = Int32.Parse(HorizCoord);
            GameBoard.Player1Turn();
            
            for (int i = 0; i < GameBoard.tableSize; i++)
            {
                for (int j = 0; j < GameBoard.tableSize; j++)
                {
                    if (GameBoard.Player2Board1[i][j] == BoardSquareState.Ship)
                    {
                        GameBoard.shipSquareCount++;
                    }
                }
            }
            
            return RedirectToPage("/P1AfterAttack");

            ;
        }
    }
}