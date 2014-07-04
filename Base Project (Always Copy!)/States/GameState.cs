using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tile_Engine
{
    class GameState : BasicState
    {
        public GameState()
        {
            TileManager.Instance.NewTileArray(10, 10);
        }
        public override void Update()
        {
        }

        public override void Redraw(PaintEventArgs e)
        {
            TileManager.Instance.Redraw(e);
        }

        public override void MouseMoved(MouseEventArgs e)
        {
            
        }

        public override void MouseClicked(MouseEventArgs e)
        {
            TileManager.Instance.MouseClicked(e);
        }
    }
}
