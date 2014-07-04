using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tile_Engine
{
    //A single tile.
    public class Tile
    {
        public Rectangle tile;
        public Brush colour = Brushes.ForestGreen;

        public Tile(int x, int y, int TileWidth)
        {
            tile = new Rectangle(x, y, TileWidth, TileWidth);
        }

        public void Redraw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(colour, tile);
            e.Graphics.DrawRectangle(Pens.Black, tile);
        }
    }
}
