namespace drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics=panel1.CreateGraphics();
            Pen pen = new Pen(Color.Crimson);
            //  graphics.DrawLine(pen,new Point(0,0),new Point(panel1.Width,200));
            //  graphics.DrawLine(pen,new Point(panel1.Width,200),new Point(0,400));

            /*graphics.DrawArc(pen, new Rectangle(10, 10, 200, 300), 50, 250);
            graphics.DrawArc(pen, new Rectangle(30, 10, 200, 300), 50, 250);
            graphics.DrawArc(pen, new Rectangle(50, 10, 200, 300), 50, 250);
            graphics.DrawArc(pen, new Rectangle(70, 10, 200, 300), 50, 250);
            graphics.DrawArc(pen, new Rectangle(90, 10, 200, 300), 50, 250);*/

            graphics.DrawBezier(pen, new Point(0, 0), new Point(30, 30), new Point(90, 40), new Point(120, 300));
        }
    }
}
