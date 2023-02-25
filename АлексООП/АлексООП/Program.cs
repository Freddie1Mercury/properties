using System;
using System.Collections;
using System.Collections.Generic;
class Player
{
    private string _player;
    private int _x, _y;

    public Player(string player, int x, int y)
    {
        _player = player;
        _x = x;
        _y = y;
    }

    public string Test
    {
        get
        {
            return _player;
        }
    }

    public int Test1
    {
        get
        {
            return _x;
        }
    }

    public int Test2
    {
        get
        {
            return _y;
        }
    }
}
class PrintPlayer
{
    public void Print()
    {
        Player player = new Player("Вася", 4, 6);
        string name = player.Test;
        int x = player.Test1;
        int y = player.Test2;
        Console.SetCursorPosition(x,y);
        Console.WriteLine(name);
        
    }

}
class Program
{
    static void Main(string[] args)
    {
        PrintPlayer printPlayer = new PrintPlayer();
        printPlayer.Print();
    }

}


