using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button_follows_cursor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            var point = new Point(
                e.Location.X - (buttonMoveMe.Width / 2), 
                e.Location.Y - (buttonMoveMe.Height / 2));
            buttonMoveMe.Location = point;
        }
    }
}
