using System.Drawing;
using System.Windows.Forms;

namespace ApexTracker
{
    public partial class Card : Form
    {
        bool mouseDown;
        Point offset;

        public Card()
        {
            InitializeComponent();
        }

        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
