using System.Drawing;
using System.Windows.Input;

namespace Photo_paint
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// list of elements we need to draw
		/// </summary>
		private List<DrawingObject> drawingElements;

		/// <summary>
		/// the number of canceled elements at the 
		/// end of the array that will not be drawn. 
		/// when drawing a new object, the array 
		/// cuts off these elements
		/// </summary>
		private int borderIndex = 0;

		/// <summary>
		/// current element we are drawing or editing
		/// </summary>
		private DrawingObject? curDrawingElement;

		/// <summary>
		/// true if we are drawing curDrawingElement rn
		/// </summary>
		private bool isDrawing;

		/// <summary>
		/// primary color. needed to draw smth
		/// </summary>
		private Color firstColor;

		/// <summary>
		/// secondary color. needed to erase
		/// </summary>
		private Color secondColor;

		/// <summary>
		/// thickness of pens we use
		/// </summary>
		private float thickness;

		/// <summary>
		/// constructor
		/// </summary>
		public MainForm()
		{
			InitializeComponent();

			drawingElements = new List<DrawingObject>();
			isDrawing = false;
			thickness = 4;

			firstColor = Color.Black;
			secondColor = Color.White;
		}

		/// <summary>
		/// adds 1 to border index
		/// </summary>
		private void StepBack()
		{
			if (borderIndex < drawingElements.Count)
			{
				borderIndex++;
			}
		}

		/// <summary>
		/// removes 1 from border index
		/// </summary>
		private void StepForward()
		{
			if (borderIndex > 0)
			{
				borderIndex--;
			}
		}

		/// <summary>
		/// cuts off from the tail the number of elements equal to borderIndex
		/// </summary>
		private void CutTailElements()
        {
			for(int i = 0; i < borderIndex; i++)
            {
				drawingElements.Remove(drawingElements.Last());
            }
			borderIndex = 0; 
		}

		/// <summary>
		/// screen update
		/// </summary>
		private void OnPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			for(int i = 0; i < drawingElements.Count - borderIndex; i++)
			{
                drawingElements[i].Draw(g);
			}
			mainColorButton.BackColor = firstColor;
			secondaryColorButton.BackColor = secondColor;
		}

		private void OnMouseDown(object sender, MouseEventArgs e)
		{
			if (listView1.SelectedItems.Count <= 0) return;
			var type = (DrawingType)listView1.SelectedItems[0].Index;
			CutTailElements();
			bool isLeft = e.Button == MouseButtons.Left;

			//if we press left mouse button, we use first color to draw
			//else we use second
			Brush brush1;
			Brush brush2;
			if (isLeft)
            {
				brush1 = new SolidBrush(firstColor);
				brush2 = new SolidBrush(secondColor);
			}
            else
            {
				brush1 = new SolidBrush(secondColor);
				brush2 = new SolidBrush(firstColor);
			}

			Pen pen1 = new Pen(brush1, thickness);
			Pen pen2 = new Pen(brush2, thickness);
			switch (type)
			{
				case DrawingType.Line:
					curDrawingElement = new DrawingLine(e.Location.X, e.Location.Y, pen1);
					break;
				case DrawingType.Rectangle:
					curDrawingElement = new DrawingRectangle(e.Location.X, e.Location.Y, pen1);
					break;
				case DrawingType.FilledRectangle:
					curDrawingElement = new DrawingFilledRectangle(e.Location.X, e.Location.Y, brush1);
					break;
				case DrawingType.Ellipse:
					curDrawingElement = new DrawingEllipse(e.Location.X, e.Location.Y, pen1);
					break;
				case DrawingType.FilledEllipse:
					curDrawingElement = new DrawingFilledEllipse(e.Location.X, e.Location.Y, brush1);
					break;
				case DrawingType.Brush:
					curDrawingElement = new DrawingBrush(e.Location.X, e.Location.Y, pen1);
					break;
				case DrawingType.Eraser:
					curDrawingElement = new DrawingBrush(e.Location.X, e.Location.Y, pen2);
					break;
			}
			if (curDrawingElement != null)
				drawingElements.Add(curDrawingElement);
			isDrawing = true;
			pictureBox.Invalidate();
		}

		private void OnMouseMove(object sender, MouseEventArgs e)
		{
			if (isDrawing)
			{
				curDrawingElement?.SetCoords(e.Location.X, e.Location.Y);
				pictureBox.Invalidate();
			}
		}

		private void OnMouseUp(object sender, MouseEventArgs e)
		{
			if (isDrawing)
			{
				curDrawingElement?.SetCoords(e.Location.X, e.Location.Y);
				isDrawing = false;
				pictureBox.Invalidate();
			}
		}

		private void OnSecondaryColorButtonClick(object sender, EventArgs e)
		{
			ColorDialog dlg = new ColorDialog();
			if(dlg.ShowDialog() == DialogResult.OK)
			{
				secondColor = dlg.Color;
			}
			pictureBox.Invalidate();
		}

		private void OnMainColorButtonClick(object sender, EventArgs e)
		{
			ColorDialog dlg = new ColorDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				firstColor = dlg.Color;
			}
			pictureBox.Invalidate();
		}

        private void OnThicknessCountDownValueChanged(object sender, EventArgs e)
        {
			thickness = (float)thicknessCountDown.Value;
        }

        private void OnGobackButtonClick(object sender, EventArgs e)
        {
			StepBack();
			pictureBox.Invalidate();
		}

        private void OnGoforwardButtonClick(object sender, EventArgs e)
        {
			StepForward();
			pictureBox.Invalidate();
		}

        private void OnClearButtonClick(object sender, EventArgs e)
        {
			drawingElements.Clear();
			pictureBox.Invalidate();
        }
    }
}