namespace ASCIIFormApp
{
    partial class ImageTakerForm
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
            this.buttonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.canvasBox1 = new System.Windows.Forms.PictureBox();
            this.filenamePanel = new System.Windows.Forms.Panel();
            this.convertImageButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonLayoutPanel.SuspendLayout();
            this.canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox1)).BeginInit();
            this.filenamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLayoutPanel
            // 
            this.buttonLayoutPanel.AutoSize = true;
            this.buttonLayoutPanel.ColumnCount = 2;
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.40541F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 417F));
            this.buttonLayoutPanel.Controls.Add(this.loadImageButton, 0, 0);
            this.buttonLayoutPanel.Controls.Add(this.canvasPanel, 0, 2);
            this.buttonLayoutPanel.Controls.Add(this.filenamePanel, 0, 1);
            this.buttonLayoutPanel.Controls.Add(this.convertImageButton, 1, 0);
            this.buttonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLayoutPanel.Name = "buttonLayoutPanel";
            this.buttonLayoutPanel.RowCount = 3;
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.buttonLayoutPanel.Size = new System.Drawing.Size(809, 902);
            this.buttonLayoutPanel.TabIndex = 0;
            // 
            // loadImageButton
            // 
            this.loadImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadImageButton.Location = new System.Drawing.Point(3, 2);
            this.loadImageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(386, 82);
            this.loadImageButton.TabIndex = 0;
            this.loadImageButton.Text = "LOAD IMAGE";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // canvasPanel
            // 
            this.canvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPanel.AutoSize = true;
            this.buttonLayoutPanel.SetColumnSpan(this.canvasPanel, 2);
            this.canvasPanel.Controls.Add(this.canvasBox1);
            this.canvasPanel.Location = new System.Drawing.Point(3, 123);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(803, 776);
            this.canvasPanel.TabIndex = 2;
            // 
            // canvasBox1
            // 
            this.canvasBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasBox1.Location = new System.Drawing.Point(0, 0);
            this.canvasBox1.Name = "canvasBox1";
            this.canvasBox1.Size = new System.Drawing.Size(803, 776);
            this.canvasBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.canvasBox1.TabIndex = 0;
            this.canvasBox1.TabStop = false;
            // 
            // filenamePanel
            // 
            this.buttonLayoutPanel.SetColumnSpan(this.filenamePanel, 2);
            this.filenamePanel.Controls.Add(this.textBox1);
            this.filenamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filenamePanel.Location = new System.Drawing.Point(3, 89);
            this.filenamePanel.Name = "filenamePanel";
            this.filenamePanel.Size = new System.Drawing.Size(803, 28);
            this.filenamePanel.TabIndex = 3;
            // 
            // convertImageButton
            // 
            this.convertImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convertImageButton.Location = new System.Drawing.Point(395, 3);
            this.convertImageButton.Name = "convertImageButton";
            this.convertImageButton.Size = new System.Drawing.Size(411, 80);
            this.convertImageButton.TabIndex = 4;
            this.convertImageButton.Text = "CONVERT IMAGE";
            this.convertImageButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(803, 23);
            this.textBox1.TabIndex = 0;
            // 
            // ImageTakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 902);
            this.Controls.Add(this.buttonLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(825, 941);
            this.Name = "ImageTakerForm";
            this.Text = "ImageTakerForm";
            this.Load += new System.EventHandler(this.ImageTakerForm_Load);
            this.buttonLayoutPanel.ResumeLayout(false);
            this.buttonLayoutPanel.PerformLayout();
            this.canvasPanel.ResumeLayout(false);
            this.canvasPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox1)).EndInit();
            this.filenamePanel.ResumeLayout(false);
            this.filenamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel buttonLayoutPanel;
        private Button loadImageButton;
        private Panel canvasPanel;
        private PictureBox canvasBox1;
        private Panel filenamePanel;
        private TextBox textBox1;
        private Button convertImageButton;
    }
}