using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tile_Engine
{
    #region Class Description
    //The State Manager. Handles the current state, feeds it update and redraw calls, and changes it when needed.
    #endregion
    class Manager
    {
        private BasicState currentState;

        public BasicState CurrentState
        {
            get { return currentState; }
            set { currentState = value; }
        }

        public Manager()
        {
            currentState = new GameState();
        }

        public void MouseMoved(MouseEventArgs e)
        {
            currentState.MouseMoved(e);
        }

        public void MouseClicked(MouseEventArgs e)
        {
            currentState.MouseClicked(e);
        }

        public void Update()
        {
            currentState.Update();
        }

        public void Redraw(PaintEventArgs e)
        {
            currentState.Redraw(e);
        }

    }
}

        
