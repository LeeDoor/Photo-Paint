using System.Drawing;

namespace Photo_paint
{
	public partial class MainForm : Form
	{
		private List<DrawingElement> drawingElements;
		private DrawingElement? curDrawingElement;
		private bool isDrawing;
		private Color firstColor;
		private Color secondColor;
		private float thickness;
		public MainForm()
		{
			InitializeComponent();

			drawingElements = new List<DrawingElement>();
			isDrawing = false;
			thickness = 4;

			firstColor = Color.Black;
			secondColor = Color.White;

			formTypeCombobox.Items.Clear();
			formTypeCombobox.Items.Add(DrawingType.Line);
			formTypeCombobox.Items.Add(DrawingType.Rectangle);
			formTypeCombobox.Items.Add(DrawingType.FilledRectangle);
			formTypeCombobox.Items.Add(DrawingType.Ellipse);
			formTypeCombobox.Items.Add(DrawingType.FilledEllipse);
			formTypeCombobox.Items.Add(DrawingType.Brush);
		}

		private void OnPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			foreach (DrawingElement drawingElement in drawingElements)
			{
				drawingElement.Draw(g);
			}
			mainColorButton.BackColor = firstColor;
			secondaryColorButton.BackColor = secondColor;
		}

		private void OnMouseDown(object sender, MouseEventArgs e)
		{
			if (formTypeCombobox.SelectedItem is not DrawingType type) return;

			Brush brush = new SolidBrush(firstColor);
			Pen pen = new Pen(brush, thickness);
			switch (type)
			{
				case DrawingType.Line:
					curDrawingElement = new DrawingLine(e.Location.X, e.Location.Y, pen);
					break;
				case DrawingType.Rectangle:
					curDrawingElement = new DrawingRectangle(e.Location.X, e.Location.Y, pen);
					break;
				case DrawingType.FilledRectangle:
					curDrawingElement = new DrawingFilledRectangle(e.Location.X, e.Location.Y, brush);
					break;
				case DrawingType.Ellipse:
					curDrawingElement = new DrawingEllipse(e.Location.X, e.Location.Y, pen);
					break;
				case DrawingType.FilledEllipse:
					curDrawingElement = new DrawingFilledEllipse(e.Location.X, e.Location.Y, brush);
					break;
				case DrawingType.Brush:
					curDrawingElement = new DrawingBrush (e.Location.X, e.Location.Y, pen);
					break;
			}
			if (curDrawingElement != null)
				drawingElements.Add(curDrawingElement);
			isDrawing = true;
			pictureBox.Invalidate();
		}

        private void ResetCurElementCoords(int x, int y)
        {
			if(curDrawingElement != null)
				curDrawingElement.SetCoords(x, y);
		}

		private void OnMouseMove(object sender, MouseEventArgs e)
		{
			if (isDrawing)
			{
				ResetCurElementCoords(e.Location.X, e.Location.Y);
				pictureBox.Invalidate();
			}
		}

		private void OnMouseUp(object sender, MouseEventArgs e)
		{
			if (isDrawing)
			{
				ResetCurElementCoords(e.Location.X, e.Location.Y);
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
	}
}