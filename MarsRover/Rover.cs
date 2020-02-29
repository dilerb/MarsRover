using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {
        public int x { get; set; }
        public int y { get; set; }
        public string direction { get; set; }

        public void Move(string directions, Plateau plateau)
        {
            for(int i=0;i<directions.Length;i++)
            {
                switch (directions[i])
                {
                    case 'L':
                        {
                            if (direction == "N") direction = "W";
                            else if (direction == "W") direction = "S";
                            else if (direction == "S") direction = "E";
                            else if (direction == "E") direction = "N";
                            break;
                        }
                    case 'R':
                        {
                            if (direction == "N") direction = "E";
                            else if (direction == "W") direction = "N";
                            else if (direction == "S") direction = "E";
                            else if (direction == "E") direction = "S";
                            break;
                        }
                    case 'M':
                        {
                            if (direction == "N")
                            {
                                if (y < plateau.yMax) y++;
                            }
                            else if (direction == "W")
                            {
                                if (x > plateau.xMin) x--;
                            }
                            else if (direction == "S")
                            {
                                if (y > plateau.yMin) y--;
                            }
                            else if (direction == "E")
                            {
                                if (x < plateau.xMax) x++;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
