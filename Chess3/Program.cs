using System;

class Program
{
    static void Main()
    {
        string who = Console.ReadLine();
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(CanMove(who, x1, y1, x2, y2) ? "YES" : "NO");
    }

    public static bool CanMove(string who, int x1, int y1, int x2, int y2)
    {
        if (who == "K") return (new King(x1, y1).Move(x2, y2));
        else if (who == "Q") return (new Queen(x1, y1).Move(x2, y2));
        else if (who == "R") return (new Rook(x1, y1).Move(x2, y2));
        else if (who == "B") return (new Bishop(x1, y1).Move(x2, y2));
        else if (who == "N") return (new Knight(x1, y1).Move(x2, y2));
        else return false;
    }
}

class Figure
{
    protected int x1;
    protected int y1;

    public Figure(int newX, int newY)
    {
        x1 = newX;
        y1 = newY;
    }

    public virtual bool Move(int x2, int y2)
    {
        return false;
    }
}

class King : Figure
{
    public King(int newX, int newY) : base(newX, newY)
    {
    }

    public override bool Move(int x2, int y2)
    {
        if (Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1)
        {
            this.x1 = x2;
            this.y1 = y2;
            return true;
        }
        else
            return false;
    }
}

class Queen : Figure
{
    public Queen(int newX, int newY) : base(newX, newY)
    {
    }

    public override bool Move(int x2, int y2)
    {
        if (x1 == x2 || y1 == y2 || Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
        {
            this.x1 = x2;
            this.y1 = y2;
            return true;
        }
        else
            return false;
    }
}

class Rook : Figure
{
    public Rook(int newX, int newY) : base(newX, newY)
    {
    }

    public override bool Move(int x2, int y2)
    {
        if (x1 == x2 || y1 == y2)
        {
            this.x1 = x2;
            this.y1 = y2;
            return true;
        }
        else
            return false;
    }
}

class Bishop : Figure
{
    public Bishop(int newX, int newY) : base(newX, newY)
    {
    }

    public override bool Move(int x2, int y2)
    {
        if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
        {
            this.x1 = x2;
            this.y1 = y2;
            return true;
        }
        else
            return false;
    }
}

class Knight : Figure
{
    public Knight(int newX, int newY) : base(newX, newY)
    {
    }

    public override bool Move(int x2, int y2)
    {
        if ((Math.Abs(x1 - x2) * Math.Abs(x1 - x2) + Math.Abs(y1 - y2) * Math.Abs(y1 - y2)) == 5)
        {
            this.x1 = x2;
            this.y1 = y2;
            return true;
        }
        else
            return false;
    }
}