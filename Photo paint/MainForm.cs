using System.Drawing;
using System.Windows.Input;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Photo_paint
{
	public partial class MainForm : Form
	{
        #region variables
        /// <summary>
        /// indentation on the sides of the form
        /// </summary>
        const int PADDING = 52;

		/// <summary>
		/// toolbar height
		/// </summary>
		const int TOOLBOX_SIZE = 137;

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
		/// current element we are drawing or editing
		/// </summary>
		public DrawingObject? CurDrawingElement
		{
			get => curDrawingElement;
			set
			{
				if (value != null)
				{
					curDrawingElement = value;
					drawingElements.Add(curDrawingElement);
				}
			}
		}

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

        #endregion

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

        #region history moving
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
        #endregion
        #region drawing screen update
        /// <summary>
        /// creates brushes
        /// </summary>
        /// <param name="isLeft">is left mouse button clicked</param>
        /// <returns>returns pens and brush</returns>
        private (Pen pen1, Pen pen2, SolidBrush brush1) BrushCreator(bool isLeft)
        {
			//if we press left mouse button, we use first color to draw
			//else we use second
			SolidBrush brush1;
			SolidBrush brush2;
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

			return (pen1, pen2, brush1);
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
        #endregion
        #region mouse events
        private void OnMouseDown(object sender, MouseEventArgs e)
		{
			if (toolboxListview.SelectedItems.Count <= 0) return;
			var type = (DrawingType)toolboxListview.SelectedItems[0].Index;
			CutTailElements();

			(Pen pen1, Pen pen2, SolidBrush brush1) = BrushCreator(e.Button == MouseButtons.Left);

			switch (type)
			{
				case DrawingType.Line:
					CurDrawingElement = new DrawingLine(e.Location.X, e.Location.Y, pen1);
					break;
				case DrawingType.Rectangle:
					CurDrawingElement = new DrawingRectangle(e.Location.X, e.Location.Y, pen1);
					break;
				case DrawingType.FilledRectangle:
					CurDrawingElement = new DrawingFilledRectangle(e.Location.X, e.Location.Y, brush1);
					break;
				case DrawingType.Ellipse:
					CurDrawingElement = new DrawingEllipse(e.Location.X, e.Location.Y, pen1);
					break;
				case DrawingType.FilledEllipse:
					CurDrawingElement = new DrawingFilledEllipse(e.Location.X, e.Location.Y, brush1);
					break;
				case DrawingType.Brush:
					CurDrawingElement = new DrawingBrush(e.Location.X, e.Location.Y, pen1);
					break;
				case DrawingType.Eraser:
					CurDrawingElement = new DrawingBrush(e.Location.X, e.Location.Y, pen2);
					break;
				case DrawingType.Text:
                    if (isDrawing)
                    {
						isDrawing = false;
						break;
                    }
					using(StringCreaterForm dialog = new StringCreaterForm())
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
							CurDrawingElement = new DrawingText(dialog.SetText, dialog.SetFont, e.Location.X, e.Location.Y, brush1);
						}
                    }
					break;
			}
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
        #endregion
        #region color buttons
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
			if(curDrawingElement != null)
				curDrawingElement.Color = firstColor;
			pictureBox.Invalidate();
		}
        #endregion
        #region toolbar buttons
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
        #endregion
        #region tool strips
        private void OnSaveToolStripClick(object sender, EventArgs e)
        {
			using (SaveFileDialog dialog = new())
			{
				dialog.InitialDirectory = "c:\\";
				dialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
				dialog.FilterIndex = 0;
				dialog.RestoreDirectory = true;
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					Bitmap map = new Bitmap(pictureBox.Width, pictureBox.Height);
					pictureBox.DrawToBitmap(map, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
					map.Save(dialog.FileName);
				}
			}
		}

        private void OnOpenToolStripClick(object sender, EventArgs e)
        {
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = "c:\\";
				dialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
				dialog.FilterIndex = 0;
				dialog.RestoreDirectory = true;
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					CurDrawingElement = new DrawingImage(dialog.FileName, 0, 0);
				}
				pictureBox.Invalidate();
			}
		}

        private void OnClearToolStripClick(object sender, EventArgs e)
        {
			drawingElements.Clear();
			pictureBox.Invalidate();
		}
        #endregion
        #region resizing
        private void OnResize(object sender, EventArgs e)
        {
			//pictureBox.Width = Width - PADDING;
			//pictureBox.Height = Height - PADDING - TOOLBOX_SIZE;

			toolboxListview.Width = Width - PADDING - 192;
		}

        private void OnResizeWindowToolStripClick(object sender, EventArgs e)
        {
			ResizeForm resize = new ResizeForm(pictureBox.Width, pictureBox.Height);
			if(resize.ShowDialog() == DialogResult.OK)
            {
				Width =  resize.SetSize.Width;
				Height = resize.SetSize.Height;
                if (resize.SetSize.Width < MinimumSize.Width)
                {
					pictureBox.Width = resize.SetSize.Width;
				}
				if (resize.SetSize.Height < MinimumSize.Height)
				{
					pictureBox.Height = resize.SetSize.Height;
				}
			}
        }
        #endregion
    }
}