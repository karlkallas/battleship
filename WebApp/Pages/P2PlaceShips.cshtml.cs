using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class Player2PlaceShipsModel : PageModel
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
            
            Domain.GameBoard.x_coord = Int32.Parse(CarrierVertCoord);
            Domain.GameBoard.y_coord = Domain.GameBoard.letterToNumber[CarrierHorizCoord];
            Domain.GameBoard.direction = CarrierDirection.ToUpper();
            Domain.GameBoard.shipLength = 4;
            if (Domain.GameBoard.ShipLocationCheck2(Domain.GameBoard.x_coord, Domain.GameBoard.y_coord,
                Domain.GameBoard.StringToEnum(Domain.GameBoard.direction), Ships.Carrier))
            {
                Domain.GameBoard.Player2ShipCoordinates.Add(Domain.GameBoard.x_coord.ToString() + Domain.GameBoard.y_coord.ToString());
                Domain.GameBoard.Player2ShipDirections.Add(Domain.GameBoard.StringToEnum(Domain.GameBoard.direction));
                Domain.GameBoard.PlaceOneShip(GameBoard.Player2Board1);
            }
            else
            {
                Domain.GameBoard.EmptyTable2();
                Domain.GameBoard.isRerun = true;
                return RedirectToPage("/P2PlaceShips");
            }
            
            Domain.GameBoard.x_coord = Int32.Parse(BattleshipVertCoord);
            Domain.GameBoard.y_coord = Domain.GameBoard.letterToNumber[BattleshipHorizCoord];
            Domain.GameBoard.direction = BattleshipDirection.ToUpper();
            Domain.GameBoard.shipLength = 3;
            if (Domain.GameBoard.ShipLocationCheck2(Domain.GameBoard.x_coord, Domain.GameBoard.y_coord,
                Domain.GameBoard.StringToEnum(Domain.GameBoard.direction), Ships.Battleship))
            {
                Domain.GameBoard.Player2ShipCoordinates.Add(Domain.GameBoard.x_coord.ToString() + Domain.GameBoard.y_coord.ToString());
                Domain.GameBoard.Player2ShipDirections.Add(Domain.GameBoard.StringToEnum(Domain.GameBoard.direction));
                Domain.GameBoard.PlaceOneShip(GameBoard.Player2Board1);
            }
            else
            {
                Domain.GameBoard.EmptyTable2();
                Domain.GameBoard.isRerun = true;
                return RedirectToPage("/P2PlaceShips");
            }


            Domain.GameBoard.x_coord = Int32.Parse(SubVertCoord);
            Domain.GameBoard.y_coord = Domain.GameBoard.letterToNumber[SubHorizCoord];
            Domain.GameBoard.direction = SubDirection.ToUpper();
            Domain.GameBoard.shipLength = 2;
            if (Domain.GameBoard.ShipLocationCheck2(Domain.GameBoard.x_coord, Domain.GameBoard.y_coord,
                Domain.GameBoard.StringToEnum(Domain.GameBoard.direction), Ships.Submarine))
            {
                Domain.GameBoard.Player2ShipCoordinates.Add(Domain.GameBoard.x_coord.ToString() + Domain.GameBoard.y_coord.ToString());
                Domain.GameBoard.Player2ShipDirections.Add(Domain.GameBoard.StringToEnum(Domain.GameBoard.direction));
                Domain.GameBoard.PlaceOneShip(GameBoard.Player2Board1);
            }
            else
            {
                Domain.GameBoard.EmptyTable2();
                Domain.GameBoard.isRerun = true;
                return RedirectToPage("/P2PlaceShips");
            }


            Domain.GameBoard.x_coord = Int32.Parse(CruiserVertCoord);
            Domain.GameBoard.y_coord = Domain.GameBoard.letterToNumber[CruiserHorizCoord];
            Domain.GameBoard.direction = CruiserDirection.ToUpper();
            Domain.GameBoard.shipLength = 1;
            if (Domain.GameBoard.ShipLocationCheck2(Domain.GameBoard.x_coord, Domain.GameBoard.y_coord,
                Domain.GameBoard.StringToEnum(Domain.GameBoard.direction), Ships.Cruiser))
            {
                Domain.GameBoard.Player2ShipCoordinates.Add(Domain.GameBoard.x_coord.ToString() + Domain.GameBoard.y_coord.ToString());
                Domain.GameBoard.Player2ShipDirections.Add(Domain.GameBoard.StringToEnum(Domain.GameBoard.direction));
                Domain.GameBoard.PlaceOneShip(GameBoard.Player2Board1);
            }
            else
            {
                Domain.GameBoard.EmptyTable2();
                Domain.GameBoard.isRerun = true;
                return RedirectToPage("/P2PlaceShips");
            }


            Domain.GameBoard.x_coord = Int32.Parse(PatrolVertCoord);
            Domain.GameBoard.y_coord = Domain.GameBoard.letterToNumber[PatrolHorizCoord];
            Domain.GameBoard.direction = PatrolDirection.ToUpper();
            Domain.GameBoard.shipLength = 0;
            if (Domain.GameBoard.ShipLocationCheck2(Domain.GameBoard.x_coord, Domain.GameBoard.y_coord,
                Domain.GameBoard.StringToEnum(Domain.GameBoard.direction), Ships.Patrol))
            {
                Domain.GameBoard.Player2ShipCoordinates.Add(Domain.GameBoard.x_coord.ToString() + Domain.GameBoard.y_coord.ToString());
                Domain.GameBoard.Player2ShipDirections.Add(Domain.GameBoard.StringToEnum(Domain.GameBoard.direction));
                Domain.GameBoard.PlaceOneShip(GameBoard.Player2Board1);
            }
            else
            {
                Domain.GameBoard.EmptyTable2();
                Domain.GameBoard.isRerun = true;
                return RedirectToPage("/P2PlaceShips");
            }

            Domain.GameBoard.FillEnemyShipTables();
            Domain.GameBoard.isRerun = false;
            return RedirectToPage("/P1AttackMove");
        }
    }
}