using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tile_Engine
{
    #region Class Description
    //A State precursor, anything which would apply to all states should go in here.
    #endregion
    abstract class BasicState
    {

        public BasicState()
        {
        }

        public virtual void Update()
        {
        }

        public virtual void Redraw(PaintEventArgs e)
        {
        }

        public virtual void MouseMoved(MouseEventArgs e)
        {
        }

        public virtual void MouseClicked(MouseEventArgs e)
        {
        }

    }
}
