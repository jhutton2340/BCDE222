﻿using ChessMazeLevelDesigner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelDesignNS;

public class Level 
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

    

  
}


// levelEditor => level => board => tile 