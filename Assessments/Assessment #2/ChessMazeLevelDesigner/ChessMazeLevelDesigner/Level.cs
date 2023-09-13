using LevelDesignNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelDesignNS
{

    public class Level : LevelEditor
    {
        private string _name;
        private int _width;
        private int _height;
        private Board _currentBoard;


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

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Board CurrentBoard
        {
            get { return _currentBoard; }
            set { _currentBoard = value; }
        }

       public Level(string name, int width, int height)
        {
            _name = name;
            _width = width;
            _height = height;
            _currentBoard = new Board(width, height);
        
        }

    
        public void InitializeBoard()
        {
            for (int row = 0; row < Width; row++)
            {
                for (int column = 0; column < Height; column++)
                {
                    CurrentBoard.AddTile(row, column, CreateTile(Part.Empty, PartColour.Null));
                }
            }
        }

       
    }
}

