using LevelDesignNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMazeLevelDesigner;

public class Board 
{
    private int _width;
    private int _height;
    private Tile[,] _tiles;

    public int Width
    {
        get { return _width; }
        set { _width = value; }
    }

    public int Height
    {
        get { return _height; }
        set { _height = value; }
    }

    public Board(int width, int height)
    {
        _width = width;
        _height = height;
        _tiles = new Tile[width, height];
    }

    public void AddTile(int gridX, int gridY, int part)
    {

    }
}
