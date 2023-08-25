using LevelDesignNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMazeLevelDesigner;

public class LevelEditor : ILevel
{
    private Level _CurrentLevel;

    public Level CurrentLevel
    {
        get { return _CurrentLevel; }
        set { _CurrentLevel = value; }
    }

    public void CreateLevel(string name, int width, int height)
    {
        if(width < 3 || height < 3)
        {
            throw new ArgumentException("Width and height must be positive");
        }else if(width != height)
        {
            throw new ArgumentException("Width and height must be equal");
        }
        else
        {
            CurrentLevel = new Level(name, width, height);
            CurrentLevel.InitializeBoard();
        }
    }

    public int GetLevelWidth()
    {
        return CurrentLevel.Width;
    }

    public int GetLevelHeight()
    {
        return CurrentLevel.Height;
    }

    public void AddEmpty(int gridX, int gridY)
    {
        CurrentLevel.CurrentBoard.AddTile(gridX, gridY, (int)Part.Empty);
    }

    public void AddKing(int gridX, int gridY)
    {
        CurrentLevel.CurrentBoard.AddTile(gridX, gridY, (int)Part.King);
    }

    public void AddRook(int gridX, int gridY)
    {
        CurrentLevel.CurrentBoard.AddTile(gridX, gridY, (int)Part.Rook);
    }

    public void AddBishop(int gridX, int gridY)
    {
       CurrentLevel.CurrentBoard.AddTile(gridX, gridY, (int)Part.Bishop);
    }

    public void AddKnight(int gridX, int gridY)
    {
        CurrentLevel.CurrentBoard.AddTile(gridX, gridY, (int)Part.Knight);
    }

    public void AddPlayerOnEmpty(int gridX, int gridY)
    {
        CurrentLevel.CurrentBoard.AddTile(gridX, gridY, (int)Part.PlayerOnEmpty);
    }

    public void AddPlayerOnKing(int gridX, int gridY)
    {
        CurrentLevel.CurrentBoard.AddTile(gridX, gridY, (int)Part.PlayerOnKing);
    }

    public void AddPlayerOnRook(int gridX, int gridY)
    {
        CurrentLevel.CurrentBoard.AddTile(gridX, gridY, (int)Part.PlayerOnRook);
    }

    public void AddPlayerOnBishop(int gridX, int gridY)
    {
        CurrentLevel.CurrentBoard.AddTile(gridX, gridY, (int)Part.PlayerOnBishop);
    }

    public void AddPlayerOnKnight(int gridX, int gridY)
    {
        CurrentLevel.CurrentBoard.AddTile(gridX, gridY, (int)Part.PlayerOnKnight);
    }

    public Part GetPartAtIndex(int gridX, int gridY)
    {
        throw new NotImplementedException();
    }

    public void SaveMe()
    {
        throw new NotImplementedException();
    }

    public bool CheckValid()
    {
        throw new NotImplementedException();
    }

    public void ChangeLevelName(string name)
    {
        CurrentLevel.Name = name;
    }
}

