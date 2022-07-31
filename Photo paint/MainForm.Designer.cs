namespace Photo_paint
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainColorButton = new System.Windows.Forms.Button();
            this.secondaryColorButton = new System.Windows.Forms.Button();
            this.formTypeCombobox = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.thicknessCountDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessCountDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mainColorButton
            // 
            this.mainColorButton.Location = new System.Drawing.Point(12, 12);
            this.mainColorButton.Name = "mainColorButton";
            this.mainColorButton.Size = new System.Drawing.Size(50, 50);
            this.mainColorButton.TabIndex = 0;
            this.mainColorButton.UseVisualStyleBackColor = true;
            this.mainColorButton.Click += new System.EventHandler(this.OnMainColorButtonClick);
            // 
            // secondaryColorButton
            // 
            this.secondaryColorButton.Location = new System.Drawing.Point(23, 24);
            this.secondaryColorButton.Name = "secondaryColorButton";
            this.secondaryColorButton.Size = new System.Drawing.Size(50, 50);
            this.secondaryColorButton.TabIndex = 0;
            this.secondaryColorButton.UseVisualStyleBackColor = true;
            this.secondaryColorButton.Click += new System.EventHandler(this.OnSecondaryColorButtonClick);
            // 
            // formTypeCombobox
            // 
            this.formTypeCombobox.FormattingEnabled = true;
            this.formTypeCombobox.Items.AddRange(new object[] {
            "rectangle",
            "filled rectangle",
            "ellipse",
            "filled ellipse",
            "line"});
            this.formTypeCombobox.Location = new System.Drawing.Point(89, 51);
            this.formTypeCombobox.Name = "formTypeCombobox";
            this.formTypeCombobox.Size = new System.Drawing.Size(216, 23);
            this.formTypeCombobox.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 80);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(954, 637);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // thicknessCountDown
            // 
            this.thicknessCountDown.Location = new System.Drawing.Point(89, 22);
            this.thicknessCountDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.thicknessCountDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thicknessCountDown.Name = "thicknessCountDown";
            this.thicknessCountDown.Size = new System.Drawing.Size(52, 23);
            this.thicknessCountDown.TabIndex = 3;
            this.thicknessCountDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thicknessCountDown.ValueChanged += new System.EventHandler(this.OnThicknessCountDownValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 729);
            this.Controls.Add(this.thicknessCountDown);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.formTypeCombobox);
            this.Controls.Add(this.mainColorButton);
            this.Controls.Add(this.secondaryColorButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessCountDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button mainColorButton;
        private Button secondaryColorButton;
        private ComboBox formTypeCombobox;
        private PictureBox pictureBox;
        private NumericUpDown thicknessCountDown;
    }
}