using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Domain;

namespace GameUI
{
    public class BattleshipUI
    {
        public GameBoard GameBoard { get; set; } = null;
        private int boardSize;
        private bool isAutomatic;


        private string userInput = null;
        private Random rnd = new Random();

        private bool askCoordinates = true;
        //public List<List<BoardSquareState>> Player1Board1;

        public BattleshipUI()
        {
            Console.WriteLine(Banner.banner1);
            Console.WriteLine(Banner.banner2);
            Console.WriteLine(Banner.banner3);
            Console.WriteLine(Banner.banner4);
            Console.WriteLine(Banner.banner5);
            Console.WriteLine(Banner.banner6);
            Console.WriteLine(Banner.banner7);
            Console.WriteLine("Wanna start playing? Press any key!");
            Console.ReadLine();

            while (true)
            {   
                Console.WriteLine("Enter the size of the table (5-9): ");
                string input = Console.ReadLine();
                if (input.Any(char.IsDigit) && Int32.Parse(input) <= 9 && Int32.Parse(input) >= 5)
                {
                    boardSize = Int32.Parse(input);
                    break;
                }
            }

            Console.WriteLine("Place ships yourself? M and press Enter");
            Console.WriteLine("Randomly? R and Enter: ");
            var automatic = Console.ReadLine().ToUpper();
            switch (automatic)
            {
                case "R":
                    isAutomatic = true;
                    break;
                case "M":
                    isAutomatic = false;
                    break;
                default:
                    Console.WriteLine("Unrecognized input. Please try again.");
                    break;
            }

            GameBoard = new GameBoard(boardSize, isAutomatic);
            if (!isAutomatic)
            {
                while (askCoordinates)
                {
                    if (ManualShipCoordinates1())
                    {
                        askCoordinates = false;
                        break;
                    }

                    GameBoard.EmptyTable1();
                }

                askCoordinates = true;
                while (askCoordinates)
                {
                    if (ManualShipCoordinates2())
                    {
                        askCoordinates = false;
                        break;
                    }

                    GameBoard.EmptyTable2();
                }
            }
            else
            {
                while (askCoordinates)
                {
                    if (AutomaticShipCoordinates(GameBoard.Player1ShipCoordinates, GameBoard.Player1ShipDirections, GameBoard.Player1Board1))
                    {
                        askCoordinates = false;
                        break;
                    }

                    GameBoard.EmptyTable1();
                }

                askCoordinates = true;
                while (askCoordinates)
                {
                    if (AutomaticShipCoordinates(GameBoard.Player2ShipCoordinates, GameBoard.Player2ShipDirections, GameBoard.Player2Board1))
                    {
                        askCoordinates = false;
                        break;
                    }

                    GameBoard.EmptyTable2();
                }
            }
            GameBoard.FillEnemyShipTables();
            GamePlay();
        }

        public void GamePlay()
        {
            
            while (GameBoard.gameOn == true)
            {
                Console.WriteLine("Exit: X and press Enter! Continue?/Player 1 turn press Enter: ");
                userInput = Console.ReadLine();
                if (userInput == "X")
                {
                    GameBoard.gameOn = false;
                    break;
                }
                
                Console.Clear();
                Console.WriteLine("Player 1 ships: ");
                Console.WriteLine(GameBoard.GetBoardString(GameBoard.Player1Board1));
                Console.WriteLine("Enemy ships: ");
                Console.WriteLine(GameBoard.GetBoardString(GameBoard.Player1Board2));

                var insert = "";
                while (true)
                {
                    Console.WriteLine("Enter coordinates to BOMB (E.g. 1b): ");
                    insert = Console.ReadLine();
                    if (insert.Length == 2 && 
                        insert.Substring(1, insert.Length - 1).Any(x => char.IsLetter(x)) &&
                        insert.Substring(0,1).Any(char.IsDigit) &&
                        GameBoard.letterToNumber[insert.Substring(1, insert.Length - 1)] <= boardSize &&
                        Int32.Parse(insert.Substring(0, 1)) - 1 <= boardSize
                        )
                    {
                        break;
                    }
                }
                
                
                GameBoard.x_coord = Int32.Parse(insert.Substring(0, 1)) - 1;
                GameBoard.y_coord = GameBoard.letterToNumber[insert.Substring(1, insert.Length - 1)];

                
               
                GameBoard.Player1ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
                GameBoard.Player1Turn();
                
                Console.Clear();
                Console.WriteLine("Enemy ships: ");
                Console.WriteLine(GameBoard.GetBoardString(GameBoard.Player1Board2));
                if (GameBoard.hitMiss == BoardSquareState.Hit)
                {
                    Console.WriteLine("BOOM");
                }
                else
                {
                    Console.WriteLine("Missed!");
                }

                // Count player 1 ships (if 0 opponent wins)
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

                if (GameBoard.shipSquareCount == 0)
                {
                    Console.WriteLine("Congratulations! Player 1 won!");
                    break;
                }

                GameBoard.shipSquareCount = 0;


                
                Console.WriteLine("Exit: X and press Enter! Continue?/Player 2 turn press Enter: ");
                userInput = Console.ReadLine().ToUpper();
                if (userInput == "X")
                {
                    GameBoard.gameOn = false;
                    break;
                }

                Console.Clear();
                Console.WriteLine("Player 2 ships: ");
                Console.WriteLine(GameBoard.GetBoardString(GameBoard.Player2Board1));
                Console.WriteLine("Enemy ships: ");
                Console.WriteLine(GameBoard.GetBoardString(GameBoard.Player2Board2));
                
                var insert2 = "";
                while (true)
                {
                    Console.WriteLine("Enter coordinates to BOMB (E.g. 1b): ");
                    insert2 = Console.ReadLine();
                    if (insert2.Length == 2 && 
                        insert2.Substring(1, insert2.Length - 1).Any(x => char.IsLetter(x)) &&
                        insert2.Substring(0,1).Any(char.IsDigit) &&
                        GameBoard.letterToNumber[insert2.Substring(1, insert2.Length - 1)] <= boardSize &&
                        Int32.Parse(insert2.Substring(0, 1)) - 1 <= boardSize
                    )
                    {
                        break;
                    }
                }
                
                GameBoard.x_coord = Int32.Parse(insert2.Substring(0, 1)) - 1;
                GameBoard.y_coord = GameBoard.letterToNumber[insert2.Substring(1, insert2.Length - 1)];
                GameBoard.Player2Turn();
                
                Console.Clear();
                Console.WriteLine("Enemy ships: ");
                Console.WriteLine(GameBoard.GetBoardString(GameBoard.Player2Board2));
                if (GameBoard.hitMiss == BoardSquareState.Hit)
                {
                    Console.WriteLine("BOOM");
                }
                else
                {
                    Console.WriteLine("Missed!");
                }

                // Count player 2 ships (if 0 opponent wins)
                for (int i = 0; i < GameBoard.tableSize; i++)
                {
                    for (int j = 0; j < GameBoard.tableSize; j++)
                    {
                        if (GameBoard.Player1Board1[i][j] == BoardSquareState.Ship)
                        {
                            GameBoard.shipSquareCount++;
                        }
                    }
                }

                if (GameBoard.shipSquareCount == 0)
                {
                    Console.WriteLine("Congratulations! Player 2 won!");
                    break;
                }

                GameBoard.shipSquareCount = 0;
            }
        }

        public bool ManualShipCoordinates1()
        {
            int shipCount = 0;
            Ships shipType = (Ships) shipCount;
            string text = "Enter coordinates for your " + shipType + " (E.g. 1b): ";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("PLAYER 1");
                //ask player 1 for ship coordinates
                
                Console.WriteLine(GameBoard.GetBoardString(GameBoard.Player1Board1));
                
                Console.WriteLine(text);
                string insert = Console.ReadLine();
                if (insert.Length < 2 || insert.Substring(1, insert.Length -1).Any(x => !char.IsLetter(x)) || insert.Substring(0,1).Any(char.IsDigit) == false)
                {
                    return false;
                }

                GameBoard.x_coord = Int32.Parse(insert.Substring(0, 1));
                    GameBoard.y_coord = GameBoard.letterToNumber[insert.Substring(1, insert.Length - 1)];
    
                    GameBoard.Player1ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
                    Console.WriteLine("Please enter the direction of the ship:  R - right, D - down");
                    GameBoard.direction = Console.ReadLine().ToUpper();
                    GameBoard.shipLength = shipCount;
                    if (GameBoard.ShipLocationCheck1(GameBoard.x_coord, GameBoard.y_coord,
                        GameBoard.StringToEnum(GameBoard.direction), shipType))
                    {
                        GameBoard.Player1ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
                        GameBoard.Player1ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));
                        GameBoard.PlaceOneShip(GameBoard.Player1Board1);
                        shipCount++;
                        if (shipCount == 5)
                        {
                            Console.Clear();
                            Console.WriteLine(GameBoard.GetBoardString(GameBoard.Player1Board1));
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately, the ship could not be based on this location. Please try again.");
                        return false;
                    }
                

        }
            return true;
        }

        public bool ManualShipCoordinates2()
        {                
            int shipCount = 0;
            while (true)
            {
                //ask player 2 for ship coordinates
                Console.Clear();
                Console.WriteLine("PLAYER 2");
                Ships shipType = (Ships) shipCount;
                Console.WriteLine(GameBoard.GetBoardString(GameBoard.Player2Board1));
                Console.WriteLine("Enter coordinates for your " + shipType + " (E.g. 1b): ");
                string insert = Console.ReadLine();
                if (insert.Length < 2 || insert.Substring(1, insert.Length -1).Any(x => !char.IsLetter(x)) || insert.Substring(0,1).Any(char.IsDigit) == false)
                {
                    return false;
                }
                
                GameBoard.x_coord = Int32.Parse(insert.Substring(0, 1));
                GameBoard.y_coord = GameBoard.letterToNumber[insert.Substring(1, insert.Length - 1)];
                Console.WriteLine("Please enter the direction of the ship:  R - right, D - down");
                GameBoard.direction = Console.ReadLine().ToUpper();
                GameBoard.shipLength = shipCount;
                if (GameBoard.ShipLocationCheck2(GameBoard.x_coord, GameBoard.y_coord,
                    GameBoard.StringToEnum(GameBoard.direction), shipType))
                {
                    GameBoard.Player2ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
                    GameBoard.Player2ShipDirections.Add(GameBoard.StringToEnum(GameBoard.direction));
                    GameBoard.PlaceOneShip(GameBoard.Player2Board1);
                    shipCount++;
                    if (shipCount == 5)
                    {
                        Console.Clear();
                        Console.WriteLine(GameBoard.GetBoardString(GameBoard.Player2Board1));
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Unfortunately, the ship could not be based on this location. Please try again.");
                    return false;
                }
            }

            return true;
        }

        public bool AutomaticShipCoordinates(List<string> cor, List<Directions> dir, List<List<BoardSquareState>> board)
        {
            int shipCount = 0;
            while (true)
            {
                Ships shipType = (Ships) shipCount;
                GameBoard.x_coord = rnd.Next(1, boardSize + 1);
                GameBoard.y_coord = rnd.Next(1, boardSize + 1);
                GameBoard.Player1ShipCoordinates.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
                GameBoard.direction = GameBoard.directionNumberToString[rnd.Next(0, 2)];
                GameBoard.shipLength = shipCount;
                if (GameBoard.ShipLocationCheck1(GameBoard.x_coord, GameBoard.y_coord,
                    GameBoard.StringToEnum(GameBoard.direction), shipType))
                {
                    cor.Add(GameBoard.x_coord.ToString() + GameBoard.y_coord.ToString());
                    dir.Add(GameBoard.StringToEnum(GameBoard.direction));
                    GameBoard.PlaceOneShip(board);
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

    }

}
