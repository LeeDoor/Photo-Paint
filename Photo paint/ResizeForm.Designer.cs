namespace Photo_paint
{
    partial class ResizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // widthUpDown
            // 
            this.widthUpDown.Location = new System.Drawing.Point(102, 7);
            this.widthUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(111, 29);
            this.widthUpDown.TabIndex = 0;
            this.widthUpDown.Maximum = 2000;
            this.widthUpDown.Minimum = 1;
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(102, 47);
            this.heightUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(111, 29);
            this.heightUpDown.TabIndex = 0;
            this.heightUpDown.Maximum = 2000;
            this.heightUpDown.Minimum = 1;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(13, 9);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(59, 21);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "Width: ";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(13, 49);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(63, 21);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height: ";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(13, 96);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(200, 35);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "OK";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.OnAcceptButtonClick);
            // 
            // ResizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 143);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.heightUpDown);
            this.Controls.Add(this.widthUpDown);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResizeForm";
            this.Text = "ResizeForm";
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown widthUpDown;
        private NumericUpDown heightUpDown;
        private Label WidthLabel;
        private Label heightLabel;
        private Button acceptButton;
    }
}