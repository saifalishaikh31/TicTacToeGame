class TicTacToeGame
{
    char[] board = new char[10];
    public void Game()
    {
        for(int i=1; i < 10; i++)
        {
            board[i] = ' ';            
        }
    }
    public const char x = 'X';
    public const char o = 'O';
    public char player;
    public char computer;
    public void Choose()
    {
        Console.WriteLine("Choose your character : X or O");
        char playerChoice = Convert.ToChar(Console.ReadLine());
        if(playerChoice == 'X')
        {
            Console.WriteLine("You Chose : "+ playerChoice);
            player=playerChoice;
            Console.WriteLine("Computer Chose : "+ o);
            computer=o;
        }
        if(playerChoice == 'O')
        {
            Console.WriteLine("You Chose : "+ playerChoice);
            player=playerChoice;
            Console.WriteLine("Computer Chose : "+ x);
            computer=o;
        }
        else
        {
            Console.WriteLine("Enter correct character!!!");
        }
    }
}

