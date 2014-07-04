using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Tile_Engine
{
    public partial class DBPanel : Panel
    {
        public DBPanel()
        {
            this.Height = 3;
            InitializeComponent();
            //Changing some properties:
            this.DoubleBuffered = true;
          //  this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}