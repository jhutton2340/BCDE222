using LevelDesignNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LevelDesignNS
{
    public class Board
    {
        private int _width;
        private int _height;
        private Tile[,] _currentTiles;

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

        public Tile[,] CurrentTiles
        {
            get { return _currentTiles; }
            set { _currentTiles = value; }
        }

        public Board(int width, int height)
        {
            _width = width;
            _height = height;
            _currentTiles = new Tile[width, height];
        }

        public void AddTile(int gridX, int gridY, Tile tile)
        {
            CurrentTiles[gridX, gridY] = tile;
        }

        //This ideally would return the tile rather than the part but the interface requires it to return a part. Maybe overloading can be done again? 
        public Part GetPart(int gridX, int gridY)
        {
            return CurrentTiles[gridX, gridY].CurrentPart;
        }

        public PartColour GetPartColour(int gridX, int gridY)
        {
            return CurrentTiles[gridX, gridY].PartColour;
        }

        public void SetStart(int gridX, int gridY, bool startPiece)
        {
            CurrentTiles[gridX, gridY].IsStart = startPiece;
        }

        public void SetEnd(int gridX, int gridY, bool endPiece)
        {
            CurrentTiles[gridX, gridY].IsEndLocation = endPiece;
        }

        public void ClearStartTiles()
        {

            foreach (Tile tile in CurrentTiles)
            {
                if (tile.IsStart)
                {
                    tile.IsStart = false;
                }
            }
        }

        public void ClearEndTiles()
        {

            foreach (Tile tile in CurrentTiles)
            {
                if (tile.IsEndLocation)
                {
                    tile.IsEndLocation = false;
                }
            }
        }
    }
}
