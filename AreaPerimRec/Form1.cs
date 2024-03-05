namespace AreaPerimRec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public abstract class Figure
        {
            public abstract double CalculateArea();

            public abstract double CalculatePerimeter();
        }

        public class Rectangle : Figure
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double CalculateArea()
            {
                return Width * Height;
            }

            public override double CalculatePerimeter()
            {
                return 2 * (Width + Height);
            }
        }


        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            double width = double.Parse(txtWidth.Text);
            double height = double.Parse(txtHeight.Text);

            Rectangle rectangle = new Rectangle(width, height);

            double area = rectangle.CalculateArea();
            double perimeter = rectangle.CalculatePerimeter();

            txtArea.Text = area.ToString();
            txtPerimeter.Text = perimeter.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      
    }
}
