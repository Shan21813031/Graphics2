using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Graphics2
{
    public partial class Graphics2 : Form
    {
        /// Unit 6: Tasks 6.2
        /// Shan Ahmed
        /// </summary>

        public Graphics2()
        {
            InitializeComponent();
        }

        private void Graphic2(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        /// <summary>
        /// The block of code below creates rectangles, one inside the other
        /// in a blue colour pen
        /// </summary>

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int size = 30;
            int x = 80,  y = 0;     // position of rectangle
            int w = 300, h = 200;    // width and height of reactangle
            Graphics g = e.Graphics; // get a graphics object

            Pen myPen = new Pen(Color.Blue, 10);  // define a blue pen size 10
 
            g.DrawRectangle(myPen, x, y, w, h);         // draw a rectangle using pen

            for (int count = 1; count <= 6; count++)
            {
                g.DrawRectangle(myPen, x, y, w, h);

                x = x + size;
                y = y + size;
                w = w - 2 * size;
                h = h - 2 * size;
            }
        }

        }
    }
