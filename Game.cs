using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string KeyPressed, out int x, out int y)
        {
            x = 0;
            y = 0;
            switch (KeyPressed)
            {
                case "LeftArrow":
                    x -= 1;
                    break;
                case "RightArrow":
                    x += 1;
                    break;
                case "UpArrow":
                    y -= 1;
                    break;
                case "DownArrow":
                    y += 1;
                    break;
  
            }
        }
    public new static char UpdateCursor(string KeyPressed)
        {
            char di = '0';
            switch (KeyPressed)
            {
                case "DownArrow":
                    di = 'V';
                    break;
                case "UpArrow":
                    di = '^';
                    break;
                case "LeftArrow":
                    di = '<';
                    break;
                case "RightArrow":
                    di = '>';
                    break;
            }
            return di;
        }
  }
}