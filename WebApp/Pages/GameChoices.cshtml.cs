using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Domain.GameBoard;

namespace WebApp.Pages
{
    public class GameChoices : PageModel
    {
        
        public string Message { get; set; }
        private int boardSize;
        private bool isAutomatic;
        private string automatic;
        private bool askCoordinates = true;
        Random rnd = new Random();
        public static GameBoard GameBoard { get; set; } = null;
        
        public bool AutomaticShipCoordinates1()
        {
            int shipCount = 0;
            while (true)
            {
                Ships shipType = (Ships) shipCount;
                x_coord = rnd.Next(1, boardSize + 1);
                y_coord = rnd.Next(1, boardSize + 1);
                Player1ShipCoordinates.Add(x_coord.ToString() + y_coord.ToString());
                direction = GameBoard.directionNumberToString[rnd.Next(0, 2)];
                shipLength = shipCount;
                if (ShipLocationCheck1(x_coord, y_coord,
                    StringToEnum(direction), shipType))
                {
                    Player1ShipCoordinates.Add(x_coord.ToString() + y_coord.ToString());
                    Player1ShipDirections.Add(StringToEnum(direction));
                    PlaceOneShip(Player1Board1);
                    shipCount++;
                    if (shipCount == 5)
                    {
                        break;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool AutomaticShipCoordinates2()
        {
            int shipCount = 0;
            while(true)
            {
                Ships shipType = (Ships) shipCount;
                x_coord = rnd.Next(1, boardSize + 1);
                y_coord = rnd.Next(1, boardSize + 1);
                Player2ShipCoordinates.Add(x_coord.ToString() + y_coord.ToString());
                direction = GameBoard.directionNumberToString[rnd.Next(0, 2)];
                shipLength = shipCount;
                if (ShipLocationCheck2(x_coord, y_coord,
                    StringToEnum(direction), shipType))
                {
                    Player2ShipCoordinates.Add(x_coord.ToString() + y_coord.ToString());
                    Player2ShipDirections.Add(StringToEnum(direction));
                    PlaceOneShip(Player2Board1);
                    shipCount++;
                    if (shipCount == 5)
                    {
                        break;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        
        

        public IActionResult OnPost()
        {
            boardSize = Int32.Parse(Request.Form["TableSize"]);
            automatic = Request.Form["GameMode"].ToString().ToUpper();         
            switch (automatic)
            {
                case "M":
                    isAutomatic = false;
                    break;
                case "R":
                    isAutomatic = true;
                    break;
                default:
                    Console.WriteLine("Unrecognized input. Please try again.");
                    break;
            }
            
            GameBoard = new GameBoard(boardSize, isAutomatic);
                
            if (!isAutomatic)
            {
                return RedirectToPage("/P1PlaceShips");
            }

            else if(isAutomatic) {

                while (askCoordinates)
                {
                    if (AutomaticShipCoordinates1())
                    {
                        askCoordinates = false;
                        break;
                    }

                    EmptyTable1();
                }

                askCoordinates = true;
                while (askCoordinates)
                {
                    if (AutomaticShipCoordinates2())
                    {
                        askCoordinates = false;
                        break;
                    }

                    EmptyTable2();
                }
                
                FillEnemyShipTables();
                return RedirectToPage("/P1AttackMove");
            }
            else
            {
                return RedirectToPage("/Index");
            }


            
        }
    }
}