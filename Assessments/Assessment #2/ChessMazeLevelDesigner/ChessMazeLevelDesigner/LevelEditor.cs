using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChessMazeLevelDesigner
{
    public class LevelEditor : ILevel
    {
        private Level _CurrentLevel;

        public Level CurrentLevel
        {
            get { return _CurrentLevel; }
            set { _CurrentLevel = value; }
        }


        public void CreateLevel(int width, int height)
        {
            if (width < 3 || height < 3)
            {
                throw new ArgumentException("Width and height must be above 3");
            }
            else if (width > 10 || height > 10)
            {
                throw new ArgumentException("Width and height must be less than 10");
            }
            else if (width != height)
            {
                throw new ArgumentException("Width and height must be equal");
            }
            else
            {
                const string name = "";

                CurrentLevel = new Level(name ,width, height);
                CurrentLevel.InitializeBoard();
            }
        }
        public void CreateLevel(string name, int width, int height)
        {
            if(width < 3 || height < 3)
            {
                throw new ArgumentException("Width and height must be above 3");
            }
            else if (width > 10 || height > 10)
            {
                throw new ArgumentException("Width and height must be less than 10");
            }
            else if(width != height)
            {
                throw new ArgumentException("Width and height must be equal");
            }
            else
            {
                CurrentLevel = new Level(name, width, height);
                CurrentLevel.InitializeBoard();
            }
        }
        public Tile CreateTile(Part part, PartColour colour)
        {
            Tile tile = new()
            {
                CurrentPart = part,
                PartColour = colour
            };
            return tile;
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
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new ArgumentException("GridX and GridY must be within the level");
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.Empty, PartColour.Null));
            }
        
        }

        public void AddKing(int gridX, int gridY)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.King, PartColour.Null));
            }
       
        }

        public void AddKing(int gridX, int gridY, PartColour colour)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new ArgumentException("GridX and GridY must be within the level");
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.King, colour));
            }
       
        }


        public void AddRook(int gridX, int gridY)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.Rook, PartColour.Null));
            }
        
        }

        public void AddRook(int gridX, int gridY, PartColour colour)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.Rook, colour));
            }
        
        }

        public void AddBishop(int gridX, int gridY)
        { 
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.Bishop, PartColour.Null));
            }
        
        }

        public void AddBishop(int gridX, int gridY, PartColour colour)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.Bishop, colour));
            }
       
        }

        public void AddKnight(int gridX, int gridY)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.Knight, PartColour.Null));
            }
        
        }

        public void AddKnight(int gridX, int gridY, PartColour colour)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.Knight, colour));
            }
        
        }

        public void AddPlayerOnEmpty(int gridX, int gridY)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.PlayerOnEmpty, PartColour.Null));
            }
        
        }

        public void AddPlayerOnEmpty(int gridX, int gridY, PartColour colour)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.PlayerOnEmpty, colour));
            }
       
        }

        public void AddPlayerOnKing(int gridX, int gridY)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.PlayerOnKing, PartColour.Null));
            }
        
        }

        public void AddPlayerOnKing(int gridX, int gridY, PartColour colour)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.PlayerOnKing, colour));
            }
        
        }

        public void AddPlayerOnRook(int gridX, int gridY)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else 
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.PlayerOnRook, PartColour.Null)); 
            }
        
        }

        public void AddPlayerOnRook(int gridX, int gridY, PartColour colour)
        {
            if (gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.PlayerOnRook, colour));
            }
            
        }

        public void AddPlayerOnBishop(int gridX, int gridY)
        {
            if (gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.PlayerOnBishop, PartColour.Null));
            }
       
        }

        public void AddPlayerOnBishop(int gridX, int gridY, PartColour colour)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.PlayerOnBishop, colour));
            }
       
        }

        public void AddPlayerOnKnight(int gridX, int gridY)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }

            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.PlayerOnKnight, PartColour.Null));
            }
        
        }

        public void AddPlayerOnKnight(int gridX, int gridY, PartColour colour)
        {   
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                CurrentLevel.CurrentBoard.AddTile(gridX, gridY, CreateTile(Part.PlayerOnKnight, colour));
            }
        
        }

        public Part GetPartAtIndex(int gridX, int gridY)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }

            else
            {
                return CurrentLevel.CurrentBoard.GetPart(gridX, gridY);
            }
      
        }
        public PartColour GetPartColourAtIndex(int gridX, int gridY)
        {
            if(gridX < 0 || gridX > CurrentLevel.Width || gridY < 0 || gridY > CurrentLevel.Height)
            {
                throw new IndexOutOfRangeException();
            }

            else
            {
                return CurrentLevel.CurrentBoard.GetPartColour(gridX, gridY);
            }
        
        }

        public void SaveMe()
        {
            if (CheckValid())
            {
                
            }
        }

        public bool CheckValid()
        {
            if(CurrentLevel.Name == "")
            {
                return false;
            }
            else if(CurrentLevel.Width < 3 || CurrentLevel.Height < 3)
            {
                return false;
            }
            else if (CurrentLevel.Width > 10 || CurrentLevel.Height > 10)
            {
                return false;
            }
            else if(CurrentLevel.Width != CurrentLevel.Height)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void SetStartLocation(int gridX, int gridY)
        {
            CurrentLevel.CurrentBoard.ClearStartTiles();
            CurrentLevel.CurrentBoard.SetStart(gridX, gridY, true);
            
        }

        public void SetEndLocation(int gridX, int gridY)
        {
            CurrentLevel.CurrentBoard.ClearEndTiles();
            CurrentLevel.CurrentBoard.SetEnd(gridX, gridY, true);

        }

        public void ResetBoard()
        {
            CurrentLevel.InitializeBoard();
        }

        public void ChangeLevelName(string name)
        {
            CurrentLevel.Name = name;
        }
    }
}
