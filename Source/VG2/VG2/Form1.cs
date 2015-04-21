using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VG2
{
    public partial class Form1 : Form
    {
        private BufferedGraphicsContext context;
        private BufferedGraphics grafx;

        private Point loc = new Point(10,10);
        

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

            this.Width = 640;
            this.Height = 480;
            pnlRenderArea.Top = 0;
            pnlRenderArea.Left = 0;
            pnlRenderArea.Width = ClientRectangle.Width;
            pnlRenderArea.Height = ClientRectangle.Height;


            // Retrieves the BufferedGraphicsContext for the  
            // current application domain.
            context = BufferedGraphicsManager.Current;

            // Sets the maximum size for the primary graphics buffer 
            // of the buffered graphics context for the application 
            // domain.  Any allocation requests for a buffer larger  
            // than this will create a temporary buffered graphics  
            // context to host the graphics buffer.
            context.MaximumBuffer = new Size(this.Width + 1, this.Height + 1);

            // Allocates a graphics buffer the size of this form 
            // using the pixel format of the Graphics created by  
            // the Form.CreateGraphics() method, which returns a  
            // Graphics object that matches the pixel format of the form.
            grafx = GetGraphics(pnlRenderArea);

        }

        private BufferedGraphics GetGraphics(Control c)
        {
           return  context.Allocate(Graphics.FromHwnd(c.Handle),
                 new Rectangle(0, 0, this.Width, this.Height));
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            gTimer.Enabled = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (context != null)
            {
                pnlRenderArea.Width = ClientRectangle.Width;
                pnlRenderArea.Height = ClientRectangle.Height;
                // Re-create the graphics buffer for a new window size.
                context.MaximumBuffer = new Size(this.Width + 1, this.Height + 1);
                if (grafx != null)
                {
                    grafx.Dispose();
                    grafx = null;
                }
                grafx = GetGraphics(pnlRenderArea);
            }
        }

        private void Clear(Graphics g)
        {
            g.Clear(Color.PowderBlue);
        }

        private void gTimer_Tick(object sender, EventArgs e)
        {
            Clear(grafx.Graphics);
            //draw player
            grafx.Graphics.FillRectangle(Brushes.Yellow, loc.X, loc.Y, 10,10  );


            grafx.Render();
        }

        private void pnlRenderArea_MouseDown(object sender, MouseEventArgs e)
        {
            gTimer.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                loc.X--;
            if (e.KeyCode == Keys.D)
                loc.X++;
            if (e.KeyCode == Keys.W)
                loc.Y--;
            if (e.KeyCode == Keys.S)
                loc.Y++;
            e.Handled = true;
        }
 
    }
}
