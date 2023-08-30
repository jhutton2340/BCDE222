using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMazeLevelDesigner;

public class Tile
{
    private Part _part = Part.Empty;
    private PartColour _colour;

    public Part CurrentPart
    {
        get { return _part; }
        set { _part = value; }
    }

    public PartColour PartColour
    {
        get { return _colour; }
        set { _colour = value; }
    }


}
