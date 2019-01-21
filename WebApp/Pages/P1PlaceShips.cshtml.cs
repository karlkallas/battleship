using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class Player1PlaceShipsModel : PageModel
    {    
        private string CarrierVertCoord;
        private string CarrierHorizCoord;
        private string CarrierDirection;
        
        private string BattleshipVertCoord;
        private string BattleshipHorizCoord;
        private string BattleshipDirection;
        
        private string SubVertCoord;
        private string SubHorizCoord;
        private string SubDirection;
        
        private string CruiserVertCoord;
        private string CruiserHorizCoord;
        private string CruiserDirection;
        
        private string PatrolVertCoord;
        private string PatrolHorizCoord;
        private string PatrolDirection;
        

        public IActionResult OnPost()
        {
            CarrierVertCoord = Request.Form["CarrierVertCoord"];
            CarrierHorizCoord = Request.Form["CarrierHorizCoord"];
            CarrierDirection = Request.Form["CarrierDirection"];
            
            BattleshipVertCoord = Request.Form["BattleshipVertCoord"];
            BattleshipHorizCoord = Request.Form["BattleshipHorizCoord"];
            BattleshipDirection = Request.Form["BattleshipDirection"];
                
            SubVertCoord = Request.Form["SubVertCoord"];
            SubHorizCoord = Request.Form["SubHorizCoord"];
            SubDirection = Request.Form["SubDirection"];
            
            CruiserVertCoord = Request.Form["CruiserVertCoord"];
            CruiserHorizCoord = Request.Form["CruiserHorizCoord"];
            CruiserDirection = Request.Form["CruiserDirection"];
                
            PatrolVertCoord = Request.Form["PatrolVertCoord"];
            PatrolHorizCoord = Request.Form["PatrolHorizCoord"];
            PatrolDirection = Request.Form["PatrolDirection"];
            
            GameBoard.x_coord = Int32.Parse(CarrierVertCoord);
            GameBoard.y_coord = GameBoard.letterToNumber[CarrierHorizCoord];
            GameBoard.direction = CarrierDirection.ToUpper();
            GameBoard.shipLength = 4;
            if (GameBoard.ShipLocationCheck1(GameBoard.x_coord, GameBoard.y_coord,
                GameBoard.StringToEnum(GameBoard.direction), Ships.Carrier))
            {
                GameBoard.Player1ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
                GameBoard.Player1ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));
                GameBoard.PlaceOneShip(GameBoard.Player1Board1);
            }
            else
            {
                GameBoard.EmptyTable1();
                GameBoard.isRerun = true;
                return RedirectToPage("/P1PlaceShips");
            }
            
            GameBoard.x_coord = Int32.Parse(BattleshipVertCoord);
            GameBoard.y_coord = GameBoard.letterToNumber[BattleshipHorizCoord];
            GameBoard.direction = BattleshipDirection.ToUpper();
            GameBoard.shipLength = 3;
            if (GameBoard.ShipLocationCheck1(GameBoard.x_coord, GameBoard.y_coord,
                GameBoard.StringToEnum(GameBoard.direction), Ships.Battleship))
            {
                GameBoard.Player1ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
                GameBoard.Player1ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));
                GameBoard.PlaceOneShip(GameBoard.Player1Board1);
            }
            else
            {
                GameBoard.EmptyTable1();
                GameBoard.isRerun = true;
                return RedirectToPage("/P1PlaceShips");
            }

            GameBoard.x_coord = Int32.Parse(SubVertCoord);
            GameBoard.y_coord = GameBoard.letterToNumber[SubHorizCoord];
            GameBoard.direction = SubDirection.ToUpper();
            GameBoard.shipLength = 2;
            if (GameBoard.ShipLocationCheck1(GameBoard.x_coord, GameBoard.y_coord,
                GameBoard.StringToEnum(GameBoard.direction), Ships.Submarine))
            {
                GameBoard.Player1ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
                GameBoard.Player1ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));
                GameBoard.PlaceOneShip(GameBoard.Player1Board1);
            }
            else
            {
                GameBoard.EmptyTable1();
                GameBoard.isRerun = true;
                return RedirectToPage("/P1PlaceShips");
            }

            GameBoard.x_coord = Int32.Parse(CruiserVertCoord);
            GameBoard.y_coord = GameBoard.letterToNumber[CruiserHorizCoord];
            GameBoard.direction = CruiserDirection.ToUpper();
            GameBoard.shipLength = 1;
            if (GameBoard.ShipLocationCheck1(GameBoard.x_coord, GameBoard.y_coord,
                GameBoard.StringToEnum(GameBoard.direction), Ships.Cruiser))
            {
                GameBoard.Player1ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
                GameBoard.Player1ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));
                GameBoard.PlaceOneShip(GameBoard.Player1Board1);
            }
            else
            {
                GameBoard.EmptyTable1();
                GameBoard.isRerun = true;
                return RedirectToPage("/P1PlaceShips");
            }

            GameBoard.x_coord = Int32.Parse(PatrolVertCoord);
            GameBoard.y_coord = GameBoard.letterToNumber[PatrolHorizCoord];
            GameBoard.direction = PatrolDirection.ToUpper();
            GameBoard.shipLength = 0;
            if (GameBoard.ShipLocationCheck1(GameBoard.x_coord, GameBoard.y_coord,
                GameBoard.StringToEnum(GameBoard.direction), Ships.Patrol))
            {
                GameBoard.Player1ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
                GameBoard.Player1ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));
                GameBoard.PlaceOneShip(GameBoard.Player1Board1);
            }
            else
            {
                GameBoard.EmptyTable1();
                GameBoard.isRerun = true;
                return RedirectToPage("/P1PlaceShips");
            }
            
            GameBoard.isRerun = false;
            return RedirectToPage("/P2PlaceShips");
        }
    }
}