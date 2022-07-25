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
            this.formTypeCombobox.Location = new System.Drawing.Point(89, 12);
            this.formTypeCombobox.Name = "formTypeCombobox";
            this.formTypeCombobox.Size = new System.Drawing.Size(114, 23);
            this.formTypeCombobox.TabIndex = 1;
            this.formTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.OnformTypeComboboxSelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 729);
            this.Controls.Add(this.formTypeCombobox);
            this.Controls.Add(this.mainColorButton);
            this.Controls.Add(this.secondaryColorButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private Button mainColorButton;
        private Button secondaryColorButton;
        private ComboBox formTypeCombobox;
    }
}