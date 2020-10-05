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
    public new static int KeepInBounds(int cord, int max)
        {
            if (cord > max)
            {
                return 0; // If the player went to the left or top edge, teleport them on the opposite side
            }
            else if (cord < 0)
            {
                return max; // If the player went to the right or bottom edge, teleport them to the opposite side
            }
            else
            {
                return cord; // If the player isn't touching any edges just carry on as normal
            }
        }

    }
  }
}