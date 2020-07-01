namespace ImageKernels
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.button1 = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.ComboBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kernel = new System.Windows.Forms.ComboBox();
            this.DefaultPictureBox = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.editKernel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // download
            // 
            this.download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download.Location = new System.Drawing.Point(16, 401);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(97, 35);
            this.download.TabIndex = 2;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // filter
            // 
            this.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "Original",
            "Blanco y Negro",
            "Sepia"});
            this.filter.Location = new System.Drawing.Point(16, 139);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(206, 28);
            this.filter.TabIndex = 3;
            this.filter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(12, 24);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(175, 20);
            this.fileLabel.TabIndex = 4;
            this.fileLabel.Text = "Seleccione un archivo...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione un filtro...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccione un kernel...";
            // 
            // kernel
            // 
            this.kernel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kernel.FormattingEnabled = true;
            this.kernel.Items.AddRange(new object[] {
            "Difuminado",
            "Realzar",
            "Sobel Inferior",
            "Sobel Superior",
            "Sobel Izquierdo",
            "Sobel Derecho",
            "Contorno",
            "Afilar",
            "Original",
            "Personalizado"});
            this.kernel.Location = new System.Drawing.Point(18, 232);
            this.kernel.Name = "kernel";
            this.kernel.Size = new System.Drawing.Size(204, 28);
            this.kernel.TabIndex = 7;
            this.kernel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // DefaultPictureBox
            // 
            this.DefaultPictureBox.Image = global::ImageKernels.Properties.Resources.Slide1;
            this.DefaultPictureBox.Location = new System.Drawing.Point(234, 12);
            this.DefaultPictureBox.Name = "DefaultPictureBox";
            this.DefaultPictureBox.Size = new System.Drawing.Size(874, 488);
            this.DefaultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DefaultPictureBox.TabIndex = 9;
            this.DefaultPictureBox.TabStop = false;
            // 
            // picture2
            // 
            this.picture2.Location = new System.Drawing.Point(674, 12);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(434, 488);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture2.TabIndex = 6;
            this.picture2.TabStop = false;
            // 
            // picture1
            // 
            this.picture1.Location = new System.Drawing.Point(234, 12);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(434, 488);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1.TabIndex = 0;
            this.picture1.TabStop = false;
            // 
            // editKernel
            // 
            this.editKernel.AutoSize = true;
            this.editKernel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editKernel.Location = new System.Drawing.Point(16, 295);
            this.editKernel.Name = "editKernel";
            this.editKernel.Size = new System.Drawing.Size(110, 20);
            this.editKernel.TabIndex = 10;
            this.editKernel.TabStop = true;
            this.editKernel.Text = "Editar kernel...";
            this.editKernel.VisitedLinkColor = System.Drawing.Color.Purple;
            this.editKernel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1124, 523);
            this.Controls.Add(this.editKernel);
            this.Controls.Add(this.DefaultPictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kernel);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.download);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picture1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Image Kernels";
            ((System.ComponentModel.ISupportInitialize)(this.DefaultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox DefaultPictureBox;
        private System.Windows.Forms.LinkLabel editKernel;
        public System.Windows.Forms.ComboBox kernel;
    }
}

