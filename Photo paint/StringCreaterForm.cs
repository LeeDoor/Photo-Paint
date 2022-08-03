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
    public partial class StringCreaterForm : Form
    {
        public Font SetFont { get; set; }
        public string SetText { get; set; }
        public StringCreaterForm()
        {
            InitializeComponent();

            SetFont = new Font(new FontFamily("Arial"), 16);
        }

        private void OnFontSelectButtonClick(object sender, EventArgs e)
        {
            using (FontDialog dialog = new FontDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    SetFont = dialog.Font;
                }
            }
        }

        private void OnCreateButtonClick(object sender, EventArgs e)
        {
            SetText = textBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void StringCreaterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
