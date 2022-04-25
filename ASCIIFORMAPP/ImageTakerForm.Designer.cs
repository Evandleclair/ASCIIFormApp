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
            this.openWebcamButton = new System.Windows.Forms.Button();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.canvasBox1 = new System.Windows.Forms.PictureBox();
            this.testdraw = new System.Windows.Forms.Button();
            this.buttonLayoutPanel.SuspendLayout();
            this.canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLayoutPanel
            // 
            this.buttonLayoutPanel.AutoSize = true;
            this.buttonLayoutPanel.ColumnCount = 3;
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.40541F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.59459F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.buttonLayoutPanel.Controls.Add(this.loadImageButton, 0, 0);
            this.buttonLayoutPanel.Controls.Add(this.openWebcamButton, 1, 0);
            this.buttonLayoutPanel.Controls.Add(this.canvasPanel, 0, 1);
            this.buttonLayoutPanel.Controls.Add(this.testdraw, 2, 0);
            this.buttonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLayoutPanel.Name = "buttonLayoutPanel";
            this.buttonLayoutPanel.RowCount = 2;
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.buttonLayoutPanel.Size = new System.Drawing.Size(806, 902);
            this.buttonLayoutPanel.TabIndex = 0;
            // 
            // loadImageButton
            // 
            this.loadImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadImageButton.Location = new System.Drawing.Point(3, 2);
            this.loadImageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(265, 86);
            this.loadImageButton.TabIndex = 0;
            this.loadImageButton.Text = "LOAD IMAGE";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // openWebcamButton
            // 
            this.openWebcamButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openWebcamButton.Location = new System.Drawing.Point(274, 2);
            this.openWebcamButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openWebcamButton.Name = "openWebcamButton";
            this.openWebcamButton.Size = new System.Drawing.Size(320, 86);
            this.openWebcamButton.TabIndex = 1;
            this.openWebcamButton.Text = "OPEN ASCII WEBCAM";
            this.openWebcamButton.UseVisualStyleBackColor = true;
            this.openWebcamButton.Click += new System.EventHandler(this.OpenWebcamButton_Click);
            // 
            // canvasPanel
            // 
            this.canvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPanel.AutoSize = true;
            this.buttonLayoutPanel.SetColumnSpan(this.canvasPanel, 3);
            this.canvasPanel.Controls.Add(this.canvasBox1);
            this.canvasPanel.Location = new System.Drawing.Point(3, 93);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(800, 806);
            this.canvasPanel.TabIndex = 2;
            // 
            // canvasBox1
            // 
            this.canvasBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasBox1.Location = new System.Drawing.Point(0, 0);
            this.canvasBox1.Name = "canvasBox1";
            this.canvasBox1.Size = new System.Drawing.Size(800, 806);
            this.canvasBox1.TabIndex = 0;
            this.canvasBox1.TabStop = false;
            // 
            // testdraw
            // 
            this.testdraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testdraw.Location = new System.Drawing.Point(600, 3);
            this.testdraw.Name = "testdraw";
            this.testdraw.Size = new System.Drawing.Size(203, 84);
            this.testdraw.TabIndex = 3;
            this.testdraw.Text = "button1";
            this.testdraw.UseVisualStyleBackColor = true;
            
            // 
            // ImageTakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 902);
            this.Controls.Add(this.buttonLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ImageTakerForm";
            this.Text = "ImageTakerForm";
            this.Load += new System.EventHandler(this.ImageTakerForm_Load);
            this.buttonLayoutPanel.ResumeLayout(false);
            this.buttonLayoutPanel.PerformLayout();
            this.canvasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel buttonLayoutPanel;
        private Button loadImageButton;
        private Button openWebcamButton;
        private Panel canvasPanel;
        private Button testdraw;
        private PictureBox canvasBox1;
    }
}