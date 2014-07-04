using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tile_Engine
{
    public sealed class TileManager
    {
        //Creates an instance of this class, means only one can be created!
        //This is a Singleton Class?
        static readonly TileManager instance = new TileManager();

        public static Tile[,] tileArray;
        public static Rectangle arrayDimensions;
        public static int tileWidth;

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static TileManager()
        {
        }

        #region Function Description
        //Creates a new Tile Array by taking the pixel dimensions and finding how many whole tiles of tileside
        //tileLength fit into it.
        #endregion
        public void NewTileArray(int arrayHeight, int arrayWidth)
        {
            int screenWidth = Screen.WIDTH, screenHeight = Screen.HEIGHT;

            tileWidth = Screen.WIDTH / arrayWidth;

            arrayDimensions = new Rectangle(0, 0, Screen.WIDTH, Screen.HEIGHT);
            tileArray = new Tile[arrayWidth, arrayHeight];
            
            //Starting Pixel Position of the tiles.
            int x = 0;
            int y = 0;

            for (int i = 0; i < tileArray.GetLength(0); i++)
            {
                for (int j = 0; j < tileArray.GetLength(1); j++)
                {
                    tileArray[i, j] = new Tile(x, y, tileWidth);

                    x += tileWidth;
                }

            y += tileWidth;
            x = 0;
            }
        }


        //Property to get the TileManager reference.
        public static TileManager Instance
        {
            get
            {
                return instance;
            }
        }

        public void MouseClicked(MouseEventArgs e)
        {
            //If mouse is within the tile array..
            if (arrayDimensions.Contains(e.Location))
            {     
                //Find the tile which the mouse is within and change it's colour.
                tileArray[(int)Math.Floor((double)(e.Y - arrayDimensions.Y) / tileWidth), 
                    (int)Math.Floor((double)(e.X - arrayDimensions.X) / tileWidth)].colour = Brushes.Red; 
             }
        }

        //Draw Code
        public void Redraw(PaintEventArgs e)
        {
            foreach (Tile t in tileArray)
            {
                t.Redraw(e);
            }
        }

    }
}
