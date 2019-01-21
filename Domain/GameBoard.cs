using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;


namespace Domain
{
    public class GameBoard
    {
        public static int tableSize;
        private static int counter1 = 0;
        public static int x_coord = 0;
        public static int y_coord = 0;
        public static BoardSquareState hitMiss;
        public static int shipSquareCount = 0;
        private int rowCounter = 1;
        public static string direction;
        private bool automaticYes = false;
        public static int shipLength;
        public static bool isRerun = false;
        public static bool gameOn = true;
        public static List<List<BoardSquareState>> Player1Board1 { get; set; } = new List<List<BoardSquareState>>();
        public static List<List<BoardSquareState>> Player1Board2 { get; set; } = new List<List<BoardSquareState>>();
        public static List<List<BoardSquareState>> Player2Board1 { get; set; } = new List<List<BoardSquareState>>();
        public static List<List<BoardSquareState>> Player2Board2 { get; set; } = new List<List<BoardSquareState>>();
        public static List<string> Player1ShipCoordinates { get; set; } = new List<string>();
        public static List<Directions> Player1ShipDirections { get; set; } = new List<Directions>();
        public static List<string> Player2ShipCoordinates { get; set; } = new List<string>();
        public static List<Directions> Player2ShipDirections { get; set; } = new List<Directions>();
        public static List<string> Alphabet { get; set; } = new List<string>
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
            "v", "w", "x", "y", "z"
        };
        public static Dictionary<string, int> letterToNumber = new Dictionary<string, int>
        {
            {"a", 0}, {"b", 1}, {"c", 2}, {"d", 3}, {"e", 4}, {"f", 5}, {"g", 6}, {"h", 7}, {"i", 8}, {"j", 9}
        };
        public Dictionary<int, string> directionNumberToString = new Dictionary<int, string>
        {
            {0, "R"}, {1, "D"}
        };

        
        public static bool ValidateInput(int x, int y)
        {
            

            if (x > tableSize && x < 0 && y > tableSize && x < 0)
            {
                return false;
            }

            return true;
        }
        
        
        public GameBoard(int tableSize, bool automaticYes)

        {

            GameBoard.tableSize = tableSize;
            this.automaticYes = automaticYes;

            //init player 1 own ships table with emptiness

            for (int i = 0; i < GameBoard.tableSize; i++)
            {
                Player1Board1.Add(new List<BoardSquareState>());
                for (int j = 0; j < GameBoard.tableSize; j++)
                {
                    Player1Board1[i].Add(BoardSquareState.Empty);
                }
            }

            //init player 2 own ships table with emptiness
  
            for (int i = 0; i < GameBoard.tableSize; i++)
            {
                Player2Board1.Add(new List<BoardSquareState>());
                for (int j = 0; j < GameBoard.tableSize; j++)
                {
                    Player2Board1[i].Add(BoardSquareState.Empty);
                }
            }


        }

        public static void PlaceOneShip(List<List<BoardSquareState>> PlayerBoard)
        {
            //place player 1 single ship on table
            PlayerBoard[x_coord - 1][y_coord] =
                BoardSquareState.Ship;

            if (StringToEnum(direction) == Directions.R)
            {
                for (int i = shipLength; i >= 0; i--)
                {
                    PlayerBoard[x_coord - 1][y_coord + i] = BoardSquareState.Ship;
                }
            }
            else if (StringToEnum(direction) == Directions.D)
            {
                for (int i = shipLength; i >= 0; i--)
                {
                    PlayerBoard[x_coord - 1 + i][y_coord] = BoardSquareState.Ship;
                }
            }


        }

        public static void FillEnemyShipTables()
        {
            //init player 1 enemy ships table with unknown(empty)

            for (int i = 0; i < tableSize; i++)
            {
                Player1Board2.Add(new List<BoardSquareState>());
                for (int j = 0; j < tableSize; j++)
                {
                    Player1Board2[i].Add(BoardSquareState.Unknown);
                }
            }

            //player 2 enemy ships table with unknown(empty)

            for (int i = 0; i < tableSize; i++)
            {
                Player2Board2.Add(new List<BoardSquareState>());
                for (int j = 0; j < tableSize; j++)
                {
                    Player2Board2[i].Add(BoardSquareState.Unknown);
                }
            }
        }

        public static void EmptyTable1()
        {
            Player1Board1 = new List<List<BoardSquareState>>();
            for (int i = 0; i < tableSize; i++)
            {
                Player1Board1.Add(new List<BoardSquareState>());
                for (int j = 0; j < tableSize; j++)
                {
                    Player1Board1[i].Add(BoardSquareState.Empty);
                }
            }
        }
        
        public static void EmptyTable2()
        {
            Player2Board1 = new List<List<BoardSquareState>>();
            for (int i = 0; i < tableSize; i++)
            {
                Player2Board1.Add(new List<BoardSquareState>());
                for (int j = 0; j < tableSize; j++)
                {
                    Player2Board1[i].Add(BoardSquareState.Empty);
                }
            }
        }

        public static void Player1Turn()
        {

            if (Player2Board1[x_coord][y_coord] == BoardSquareState.Ship)
            {
                Player1Board2[x_coord][y_coord] = BoardSquareState.Hit;
                Player2Board1[x_coord][y_coord] = BoardSquareState.Hit;
                hitMiss = BoardSquareState.Hit;
            }
            else if (Player2Board1[x_coord][y_coord] == BoardSquareState.Empty)
            {
                Player1Board2[x_coord][y_coord] = BoardSquareState.Miss;
                Player2Board1[x_coord][y_coord] = BoardSquareState.Miss;
                hitMiss = BoardSquareState.Miss;
            }
        }

        public static void Player2Turn()
        {

            if (Player1Board1[x_coord][y_coord] == BoardSquareState.Ship)
            {
                Player2Board2[x_coord][y_coord] = BoardSquareState.Hit;
                Player1Board1[x_coord][y_coord] = BoardSquareState.Hit;
                hitMiss = BoardSquareState.Hit;
            }
            else if (Player1Board1[x_coord][y_coord] == BoardSquareState.Empty)
            {
                Player2Board2[x_coord][y_coord] = BoardSquareState.Miss;
                Player1Board1[x_coord][y_coord] = BoardSquareState.Miss;
                hitMiss = BoardSquareState.Miss;
            }
        }

       
        public string GetBoardString(List<List<BoardSquareState>> board)
        {
            var sb = new StringBuilder();
            sb.Append(GetHorizontalCoordinates(tableSize) + "\n");
            foreach (var boardRow in board)
            {
                sb.Append(GetRowWithData(boardRow) + "\n");
            }

            rowCounter = 1;
            return sb.ToString();
        }


        public string GetHorizontalCoordinates(int elemCountInRow)
        {
            var sb = new StringBuilder();
            sb.Append("     a");
            for (int i = 1; i < elemCountInRow; i++)
            {
                sb.Append("   " + Alphabet[i]);
            }

            return sb.ToString();
        }

        public string GetRowWithData(List<BoardSquareState> boardRow)
        {
            var sb = new StringBuilder();
            if (rowCounter >= 10)
            {
                sb.Append(rowCounter + "");
            }
            else
            {
                sb.Append(rowCounter + " ");
            }

            foreach (var boardSquareState in boardRow)
            {
                sb.Append("| " + GetBoardSquareStateSymbol(boardSquareState) + " ");
            }

            sb.Append("|");
            rowCounter++;
            return sb.ToString();
        }

        public string GetBoardSquareStateSymbol(BoardSquareState state)
        {
            switch (state)
            {
                case BoardSquareState.Empty: return "~";
                case BoardSquareState.Unknown: return "~";
                case BoardSquareState.Ship: return "S";
                case BoardSquareState.Hit: return "X";
                case BoardSquareState.Miss: return "0";


                default:
                    throw new ArgumentOutOfRangeException(nameof(state), state, null);
            }
        }

        public static Directions StringToEnum(string direction)
        {
            switch (direction)
            {
                case "R":
                    return Directions.R;
                case "D":
                    return Directions.D;
                default:
                    return Directions.error;
            }
        }

        public static bool ShipLocationCheck1(int x_coordinate, int y_coordinate, Domain.Directions direction, Ships shipType)
        {
            if (shipType == Ships.Carrier)
            {
                counter1 = 4;
            }
            else if (shipType == Ships.Battleship)
            {
                counter1 = 3;
            }
            else if (shipType == Ships.Submarine)
            {
                counter1 = 2;
            }
            else if (shipType == Ships.Cruiser)
            {
                counter1 = 1;
            }
            else if (shipType == Ships.Patrol)
            {
                counter1 = 0;
            }


            if (x_coordinate - 1 >= tableSize || y_coordinate >= tableSize || x_coordinate - 1 < 0 ||
                y_coordinate < 0)
            {
                counter1 = 0;
                return false;
            }
            else if (Player1Board1[x_coordinate - 1][y_coordinate] ==
                     BoardSquareState.Ship)
            {
                counter1 = 0;
                return false;
            }

            if (direction == Directions.R)
            {
                for (int i = counter1; i >= 0; i--)
                {
                    if (y_coordinate + i >= tableSize || y_coordinate + i < 0)
                    {
                        counter1 = 0;
                        return false;
                    }
                    else if (Player1Board1[x_coordinate - 1][y_coordinate + i] ==
                             BoardSquareState.Ship)
                    {
                        counter1 = 0;
                        return false;
                    }
                }
            }
            else if (direction == Directions.D)
            {
                for (int i = counter1; i >= 0; i--)
                {
                    if (x_coordinate - 1 + i >= tableSize || x_coordinate - 1 + i < 0)
                    {
                        counter1 = 0;
                        return false;
                    }
                    else if (Player1Board1[x_coordinate - 1 + i][y_coordinate] ==
                             BoardSquareState.Ship)
                    {
                        counter1 = 0;
                        return false;
                    }
                }
            }

            
            
            
            counter1 = 0;
            return true;
        }
        
        public static bool ShipLocationCheck2(int x_coordinate, int y_coordinate, Domain.Directions direction, Ships shipType)
        {
            if (shipType == Ships.Carrier)
            {
                counter1 = 4;
            }
            else if (shipType == Ships.Battleship)
            {
                counter1 = 3;
            }
            else if (shipType == Ships.Submarine)
            {
                counter1 = 2;
            }
            else if (shipType == Ships.Cruiser)
            {
                counter1 = 1;
            }
            else if (shipType == Ships.Patrol)
            {
                counter1 = 0;
            }


            if (x_coordinate - 1 >= tableSize || y_coordinate >= tableSize || x_coordinate - 1 < 0 ||
                y_coordinate < 0)
            {
                counter1 = 0;
                return false;
            }
            else if (Player2Board1[x_coordinate - 1][y_coordinate] ==
                     BoardSquareState.Ship)
            {
                counter1 = 0;
                return false;
            }

            if (direction == Directions.R)
            {
                for (int i = counter1; i >= 0; i--)
                {
                    if (y_coordinate + i >= tableSize || y_coordinate + i < 0)
                    {
                        counter1 = 0;
                        return false;
                    }
                    else if (Player2Board1[x_coordinate - 1][y_coordinate + i] ==
                             BoardSquareState.Ship)
                    {
                        counter1 = 0;
                        return false;
                    }
                }
            }
            else if (direction == Directions.D)
            {
                for (int i = counter1; i >= 0; i--)
                {
                    if (x_coordinate - 1 + i >= tableSize || x_coordinate - 1 + i < 0)
                    {
                        counter1 = 0;
                        return false;
                    }
                    else if (Player2Board1[x_coordinate - 1 + i][y_coordinate] ==
                             BoardSquareState.Ship)
                    {
                        counter1 = 0;
                        return false;
                    }
                }
            }
           
            counter1 = 0;
            return true;
        }
    }
}
