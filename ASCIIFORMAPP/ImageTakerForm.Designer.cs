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
            this.buttonLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLayoutPanel
            // 
            this.buttonLayoutPanel.AutoSize = true;
            this.buttonLayoutPanel.ColumnCount = 2;
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.40541F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.59459F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.buttonLayoutPanel.Controls.Add(this.loadImageButton, 0, 0);
            this.buttonLayoutPanel.Controls.Add(this.openWebcamButton, 1, 0);
            this.buttonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonLayoutPanel.Name = "buttonLayoutPanel";
            this.buttonLayoutPanel.RowCount = 1;
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.2293F));
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.7707F));
            this.buttonLayoutPanel.Size = new System.Drawing.Size(397, 214);
            this.buttonLayoutPanel.TabIndex = 0;
            // 
            // loadImageButton
            // 
            this.loadImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadImageButton.Location = new System.Drawing.Point(3, 3);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(174, 208);
            this.loadImageButton.TabIndex = 0;
            this.loadImageButton.Text = "LOAD IMAGE";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // openWebcamButton
            // 
            this.openWebcamButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openWebcamButton.Location = new System.Drawing.Point(183, 3);
            this.openWebcamButton.Name = "openWebcamButton";
            this.openWebcamButton.Size = new System.Drawing.Size(211, 208);
            this.openWebcamButton.TabIndex = 1;
            this.openWebcamButton.Text = "OPEN ASCII WEBCAM";
            this.openWebcamButton.UseVisualStyleBackColor = true;
            this.openWebcamButton.Click += new System.EventHandler(this.openWebcamButton_Click);
            // 
            // ImageTakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 214);
            this.Controls.Add(this.buttonLayoutPanel);
            this.Name = "ImageTakerForm";
            this.Text = "ImageTakerForm";
            this.Load += new System.EventHandler(this.ImageTakerForm_Load);
            this.buttonLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel buttonLayoutPanel;
        private Button loadImageButton;
        private Button openWebcamButton;
    }
}