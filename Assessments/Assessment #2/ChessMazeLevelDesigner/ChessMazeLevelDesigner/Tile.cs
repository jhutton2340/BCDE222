using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMazeLevelDesigner
{
    public class Tile
    {
        private Part _part = Part.Empty;
        private PartColour _colour;
        private bool _isStart = false;
        private bool _isEndLocation = false;

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
    
        public bool IsStart
        {
            get { return _isStart; }
            set { _isStart = value; }
        }

        public bool IsEndLocation
        {
            get { return _isEndLocation; }
            set { _isEndLocation = value; }
        }

    }
}