using System.Drawing;

namespace Photo_paint
{
    public partial class MainForm : Form
    {
        private Graphics g;
        private List<DrawingElement> drawingElements;
        private DrawingElement? curDrawingElement;
        private Color firstColor;
        private Color secondColor;
        private ElementType type = 0;

        public MainForm()
        {
            InitializeComponent();

            g = CreateGraphics();

            drawingElements = new List<DrawingElement>();

            firstColor = Color.Black;
            secondColor = Color.White;
            type = ElementType.Line;

            formTypeCombobox.Items.Clear();
            formTypeCombobox.Items.Add(ElementType.Line);
            formTypeCombobox.Items.Add(ElementType.Rectangle);
            formTypeCombobox.Items.Add(ElementType.FilledRectangle);
            formTypeCombobox.Items.Add(ElementType.Ellipse);
            formTypeCombobox.Items.Add(ElementType.FilledEllipse);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void OnPaint(object sender, PaintEventArgs e)
        {
            g.Clear(secondColor);
            foreach (DrawingElement drawingElement in drawingElements)
            {
                drawingElement.Draw(g);
            }
            curDrawingElement?.Draw(g);

            mainColorButton.BackColor = firstColor;
            secondaryColorButton.BackColor = secondColor;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            curDrawingElement = new DrawingElement(type, new SolidBrush(firstColor), 5, e.Location.X, e.Location.Y);
            Invalidate();
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (curDrawingElement != null)
            {
                curDrawingElement.SetCoords(e.Location.X, e.Location.Y);
                Invalidate();
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            OnMouseMove(this, e);
            if (curDrawingElement != null) 
                drawingElements.Add(curDrawingElement);
            curDrawingElement = null;
        }

        private void OnSecondaryColorButtonClick(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                secondColor = dlg.Color;
            }
            Invalidate();
        }

        private void OnMainColorButtonClick(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                firstColor = dlg.Color;
            }
            Invalidate();
        }

        private void OnformTypeComboboxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (formTypeCombobox.SelectedItem is not ElementType element) return;
            type = element;
        }
    }
}