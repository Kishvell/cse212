using System;
using System.Collections.Generic;

public class Maze
{
    private readonly Dictionary<(int, int), bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<(int, int), bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    public void MoveLeft()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions))
        {
            if (directions[0]) // left
            {
                _currX--;
            }
            else
            {
                throw new InvalidOperationException("Can't go that way!");
            }
        }
        else
        {
            throw new InvalidOperationException("Current position not found in maze map.");
        }
    }

    public void MoveRight()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions))
        {
            if (directions[1]) // right
            {
                _currX++;
            }
            else
            {
                throw new InvalidOperationException("Can't go that way!");
            }
        }
        else
        {
            throw new InvalidOperationException("Current position not found in maze map.");
        }
    }

    public void MoveUp()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions))
        {
            if (directions[2]) // up
            {
                _currY--;
            }
            else
            {
                throw new InvalidOperationException("Can't go that way!");
            }
        }
        else
        {
            throw new InvalidOperationException("Current position not found in maze map.");
        }
    }

    public void MoveDown()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions))
        {
            if (directions[3]) // down
            {
                _currY++;
            }
            else
            {
                throw new InvalidOperationException("Can't go that way!");
            }
        }
        else
        {
            throw new InvalidOperationException("Current position not found in maze map.");
        }
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}