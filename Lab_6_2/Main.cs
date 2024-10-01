using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6_2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCalculateSquare_Click(object sender, EventArgs e)
        {
            double side = Convert.ToDouble(txtSquareSide.Text);
            IShape square = new Square(side);
            lblSquareArea.Text = square.GetArea().ToString("0.00");
        }

        private void btnCalculateCircle_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtCircleRadius.Text);
            IShape circle = new Circle(radius);
            lblCircleArea.Text = circle.GetArea().ToString("0.00");
        }
    }
}
