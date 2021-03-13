using System;

namespace Tic_Tac_Toe_Console_App
{
    class Tic_Tac_Toe_Console_App
    {
        private static int threeInARow(char[,] game_field)
        {
            int state = 0, crosses = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    switch (game_field[i, j])
                    {
                        case 'X':
                            if (game_field[0, j] == 'X' && game_field[1, j] == 'X' && game_field[2, j] == 'X')
                            {
                                state = 1;
                            }
                            else if (game_field[i, 0] == 'X' && game_field[i, 1] == 'X' && game_field[i, 2] == 'X')
                            {
                                state = 1;
                            }
                            else if (i == 1 && j == 1)
                            {
                                if (game_field[0, 0] == 'X' && game_field[1, 1] == 'X' && game_field[2, 2] == 'X')
                                {
                                    state = 1;
                                }
                                else if (game_field[0, 2] == 'X' && game_field[1, 1] == 'X' && game_field[2, 0] == 'X')
                                {
                                    state = 1;
                                }
                            }
                            crosses++;
                            break;
                        case 'O':
                            if (game_field[0, j] == 'O' && game_field[1, j] == 'O' && game_field[2, j] == 'O')
                            {
                                state = 2;
                            }
                            else if (game_field[i, 0] == 'O' && game_field[i, 1] == 'O' && game_field[i, 2] == 'O')
                            {
                                state = 2;
                            }
                            else if (i == 1 && j == 1)
                            {
                                if (game_field[0, 0] == 'O' && game_field[1, 1] == 'O' && game_field[2, 2] == 'O')
                                {
                                    state = 2;
                                }
                                else if (game_field[0, 2] == 'O' && game_field[1, 1] == 'O' && game_field[2, 0] == 'O')
                                {
                                    state = 2;
                                }
                            }
                            crosses++;
                            break;
                    }
                }
            }
            if (crosses == 9 && state == 0)
            {
                state = -1;
            }

            return state;
        }

        private static bool fieldAvailable(int field_row, int field_col, char[,] game_field)
        {
            if (game_field[field_row, field_col] == 'X' || game_field[field_row, field_col] == 'O')
            {
                Console.WriteLine("Feld bereits vergeben!");
                return false;
            }
            return true;
        }

        private static void drawField(char[,] game_field)
        {
            Console.WriteLine("_______");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("|" + game_field[i, j]);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("_______");

        }
        static void Main(string[] args)
        {
            char[,] game_field =
            {
                {'0','1','2'},
                {'3','4','5'},
                {'6','7','8'}
            };
            int field_num = 9;

            Console.WriteLine("_______");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("|" + game_field[i, j]);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("_______");

            bool isXTurn = true;
            do
            {
                if (isXTurn)
                {
                    do
                    {
                        do
                        {
                            Console.WriteLine("Spieler 1(X), geben Sie die gewünschte Feldnummer ein: ");
                            try
                            {
                                field_num = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(field_num);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Input kann nicht zu Zahlenwert konvertiert werden!");
                            }
                        } while(!(field_num >= 0 && field_num <= 8));
                    } while (!fieldAvailable((field_num / 3), (field_num % 3), game_field));
                    game_field[(field_num / 3), (field_num % 3)] = 'X';
                    isXTurn = false;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Spieler 2(O), geben Sie die gewünschte Feldnummer ein: ");
                        try
                        {
                            field_num = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Input kann nicht zu Zahlenwert konvertiert werden!");
                        }
                    } while (!fieldAvailable(field_num / 3, field_num % 3, game_field));
                    game_field[field_num / 3, field_num % 3] = 'O';
                    isXTurn = true;
                }
                drawField(game_field);
            } while (threeInARow(game_field) == 0);

            switch (threeInARow(game_field))
            {
                case 1:
                    Console.WriteLine("Spielende: Spieler 1(X) hat drei in einer Reihe!");
                    break;
                case 2:
                    Console.WriteLine("Spielende: Spieler 2(O) hat drei in einer Reihe!");
                    break;
                case -1:
                    Console.WriteLine("Spielende: Unentschieden. Alle Felder belegt!");
                    break;
            }
        }
    }
}
