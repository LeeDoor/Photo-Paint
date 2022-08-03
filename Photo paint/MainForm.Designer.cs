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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", 5);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("", 4);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("", 2);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("", 3);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("", 6);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("", 7);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainColorButton = new System.Windows.Forms.Button();
            this.secondaryColorButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.thicknessCountDown = new System.Windows.Forms.NumericUpDown();
            this.gobackButton = new System.Windows.Forms.Button();
            this.goforwardButton = new System.Windows.Forms.Button();
            this.toolboxListview = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.thicknessLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessCountDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainColorButton
            // 
            this.mainColorButton.Location = new System.Drawing.Point(12, 59);
            this.mainColorButton.Name = "mainColorButton";
            this.mainColorButton.Size = new System.Drawing.Size(50, 50);
            this.mainColorButton.TabIndex = 0;
            this.mainColorButton.UseVisualStyleBackColor = true;
            this.mainColorButton.Click += new System.EventHandler(this.OnMainColorButtonClick);
            // 
            // secondaryColorButton
            // 
            this.secondaryColorButton.Location = new System.Drawing.Point(23, 71);
            this.secondaryColorButton.Name = "secondaryColorButton";
            this.secondaryColorButton.Size = new System.Drawing.Size(50, 50);
            this.secondaryColorButton.TabIndex = 0;
            this.secondaryColorButton.UseVisualStyleBackColor = true;
            this.secondaryColorButton.Click += new System.EventHandler(this.OnSecondaryColorButtonClick);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(12, 137);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(960, 612);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // thicknessCountDown
            // 
            this.thicknessCountDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thicknessCountDown.Location = new System.Drawing.Point(79, 98);
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
            this.thicknessCountDown.Size = new System.Drawing.Size(95, 33);
            this.thicknessCountDown.TabIndex = 3;
            this.thicknessCountDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thicknessCountDown.ValueChanged += new System.EventHandler(this.OnThicknessCountDownValueChanged);
            // 
            // gobackButton
            // 
            this.gobackButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gobackButton.Location = new System.Drawing.Point(12, 34);
            this.gobackButton.Name = "gobackButton";
            this.gobackButton.Size = new System.Drawing.Size(20, 20);
            this.gobackButton.TabIndex = 4;
            this.gobackButton.Text = "<";
            this.gobackButton.UseVisualStyleBackColor = true;
            this.gobackButton.Click += new System.EventHandler(this.OnGobackButtonClick);
            // 
            // goforwardButton
            // 
            this.goforwardButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goforwardButton.Location = new System.Drawing.Point(38, 34);
            this.goforwardButton.Name = "goforwardButton";
            this.goforwardButton.Size = new System.Drawing.Size(20, 20);
            this.goforwardButton.TabIndex = 4;
            this.goforwardButton.Text = ">";
            this.goforwardButton.UseVisualStyleBackColor = true;
            this.goforwardButton.Click += new System.EventHandler(this.OnGoforwardButtonClick);
            // 
            // toolboxListview
            // 
            this.toolboxListview.GroupImageList = this.imageList1;
            this.toolboxListview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolboxListview.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.toolboxListview.LargeImageList = this.imageList1;
            this.toolboxListview.Location = new System.Drawing.Point(180, 59);
            this.toolboxListview.MultiSelect = false;
            this.toolboxListview.Name = "toolboxListview";
            this.toolboxListview.Size = new System.Drawing.Size(488, 72);
            this.toolboxListview.SmallImageList = this.imageList1;
            this.toolboxListview.TabIndex = 5;
            this.toolboxListview.TileSize = new System.Drawing.Size(60, 60);
            this.toolboxListview.UseCompatibleStateImageBehavior = false;
            this.toolboxListview.View = System.Windows.Forms.View.Tile;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "brush icon.png");
            this.imageList1.Images.SetKeyName(1, "filled circle icon.png");
            this.imageList1.Images.SetKeyName(2, "filled rectangle icon.png");
            this.imageList1.Images.SetKeyName(3, "line icon.png");
            this.imageList1.Images.SetKeyName(4, "rectangle icon.png");
            this.imageList1.Images.SetKeyName(5, "ellipse icon.png");
            this.imageList1.Images.SetKeyName(6, "eraser icon.png");
            this.imageList1.Images.SetKeyName(7, "text icon.png");
            // 
            // thicknessLabel
            // 
            this.thicknessLabel.AutoSize = true;
            this.thicknessLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thicknessLabel.Location = new System.Drawing.Point(79, 75);
            this.thicknessLabel.Name = "thicknessLabel";
            this.thicknessLabel.Size = new System.Drawing.Size(67, 17);
            this.thicknessLabel.TabIndex = 6;
            this.thicknessLabel.Text = "thickness: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.resizeWindowToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnSaveToolStripClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OnOpenToolStripClick);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.OnClearToolStripClick);
            // 
            // resizeWindowToolStripMenuItem
            // 
            this.resizeWindowToolStripMenuItem.Name = "resizeWindowToolStripMenuItem";
            this.resizeWindowToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.resizeWindowToolStripMenuItem.Text = "Resize window";
            this.resizeWindowToolStripMenuItem.Click += new System.EventHandler(this.OnResizeWindowToolStripClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.thicknessLabel);
            this.Controls.Add(this.toolboxListview);
            this.Controls.Add(this.goforwardButton);
            this.Controls.Add(this.gobackButton);
            this.Controls.Add(this.thicknessCountDown);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.mainColorButton);
            this.Controls.Add(this.secondaryColorButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(350, 250);
            this.Name = "MainForm";
            this.Text = "Photo Paint";
            this.Resize += new System.EventHandler(this.OnResize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessCountDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button mainColorButton;
        private Button secondaryColorButton;
        private PictureBox pictureBox;
        private NumericUpDown thicknessCountDown;
        private Button gobackButton;
        private Button goforwardButton;
        private ListView toolboxListview;
        private Label thicknessLabel;
        private ImageList imageList1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem resizeWindowToolStripMenuItem;
    }
}