using System.Drawing;

namespace Photo_paint
{
    public partial class MainForm : Form
    {
        private Graphics g;

        public MainForm()
        {
            InitializeComponent();

            g = CreateGraphics();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void OnMainFormMouseDown(object sender, MouseEventArgs e)
        {
            g.Clear(Color.White);
            g.DrawEllipse(Pens.Aqua, new Rectangle(e.Location, new Size(200, 200)));
        }

        private void OnMainFormPaint(object sender, PaintEventArgs e)
        {

        }
    }
}