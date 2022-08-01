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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainColorButton = new System.Windows.Forms.Button();
            this.secondaryColorButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.thicknessCountDown = new System.Windows.Forms.NumericUpDown();
            this.gobackButton = new System.Windows.Forms.Button();
            this.goforwardButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.thicknessLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessCountDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mainColorButton
            // 
            this.mainColorButton.Location = new System.Drawing.Point(65, 12);
            this.mainColorButton.Name = "mainColorButton";
            this.mainColorButton.Size = new System.Drawing.Size(50, 50);
            this.mainColorButton.TabIndex = 0;
            this.mainColorButton.UseVisualStyleBackColor = true;
            this.mainColorButton.Click += new System.EventHandler(this.OnMainColorButtonClick);
            // 
            // secondaryColorButton
            // 
            this.secondaryColorButton.Location = new System.Drawing.Point(76, 24);
            this.secondaryColorButton.Name = "secondaryColorButton";
            this.secondaryColorButton.Size = new System.Drawing.Size(50, 50);
            this.secondaryColorButton.TabIndex = 0;
            this.secondaryColorButton.UseVisualStyleBackColor = true;
            this.secondaryColorButton.Click += new System.EventHandler(this.OnSecondaryColorButtonClick);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
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
            this.thicknessCountDown.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thicknessCountDown.Location = new System.Drawing.Point(237, 20);
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
            this.thicknessCountDown.Size = new System.Drawing.Size(123, 43);
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
            this.gobackButton.Location = new System.Drawing.Point(12, 11);
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
            this.goforwardButton.Location = new System.Drawing.Point(12, 37);
            this.goforwardButton.Name = "goforwardButton";
            this.goforwardButton.Size = new System.Drawing.Size(20, 20);
            this.goforwardButton.TabIndex = 4;
            this.goforwardButton.Text = ">";
            this.goforwardButton.UseVisualStyleBackColor = true;
            this.goforwardButton.Click += new System.EventHandler(this.OnGoforwardButtonClick);
            // 
            // listView1
            // 
            this.listView1.GroupImageList = this.imageList1;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(366, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 72);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 5;
            this.listView1.TileSize = new System.Drawing.Size(60, 60);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
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
            // 
            // thicknessLabel
            // 
            this.thicknessLabel.AutoSize = true;
            this.thicknessLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thicknessLabel.Location = new System.Drawing.Point(133, 30);
            this.thicknessLabel.Name = "thicknessLabel";
            this.thicknessLabel.Size = new System.Drawing.Size(98, 25);
            this.thicknessLabel.TabIndex = 6;
            this.thicknessLabel.Text = "thickness: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 729);
            this.Controls.Add(this.thicknessLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.goforwardButton);
            this.Controls.Add(this.gobackButton);
            this.Controls.Add(this.thicknessCountDown);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.mainColorButton);
            this.Controls.Add(this.secondaryColorButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessCountDown)).EndInit();
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
        private ListView listView1;
        private Label thicknessLabel;
        private ImageList imageList1;
    }
}