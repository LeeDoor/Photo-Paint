using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_paint
{
    public partial class ResizeForm : Form
    {
        public Size SetSize { get; set; }
        public ResizeForm(int width, int height)
        {
            SetSize = new Size(width,height);
            InitializeComponent();
            widthUpDown.Value = width;
            heightUpDown.Value = height;
        }

        private void OnAcceptButtonClick(object sender, EventArgs e)
        {
            SetSize = new Size((int)widthUpDown.Value, (int)heightUpDown.Value);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
