using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMazeLevelDesigner;

internal class Piece 
{
    private int _gridX;
    private int _gridY;
    private string _name;

    public int GridX
    {
        get { return _gridX; }
        set { _gridX = value; }
    }

    public int GridY
    {
        get { return _gridY; }
        set { _gridY = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Piece(int gridX, int gridY, string name)
    {
        _gridX = gridX;
        _gridY = gridY;
        _name = name;
    }
}
