using TicTacToe;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to TicTacToe Game");
        TicTacToeGame game = new TicTacToeGame();
        game.GameBoard();
        game.PlayerInput();
    }
}