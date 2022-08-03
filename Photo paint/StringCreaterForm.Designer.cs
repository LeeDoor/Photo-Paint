namespace Photo_paint
{
    partial class StringCreaterForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.fontSelectButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(14, 20);
            this.textBox.Margin = new System.Windows.Forms.Padding(5);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(286, 33);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "enter text here";
            // 
            // fontSelectButton
            // 
            this.fontSelectButton.Location = new System.Drawing.Point(14, 61);
            this.fontSelectButton.Name = "fontSelectButton";
            this.fontSelectButton.Size = new System.Drawing.Size(71, 43);
            this.fontSelectButton.TabIndex = 1;
            this.fontSelectButton.Text = "font";
            this.fontSelectButton.UseVisualStyleBackColor = true;
            this.fontSelectButton.Click += new System.EventHandler(this.OnFontSelectButtonClick);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(200, 61);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(100, 43);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "OK";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.OnCreateButtonClick);
            // 
            // StringCreaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 121);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.fontSelectButton);
            this.Controls.Add(this.textBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StringCreaterForm";
            this.Text = "create string";
            this.Load += new System.EventHandler(this.StringCreaterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox;
        private Button fontSelectButton;
        private Button createButton;
    }
}