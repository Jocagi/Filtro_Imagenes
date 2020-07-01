namespace ImageKernels
{
    partial class CustomKernel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomKernel));
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new ImageKernels.CustomTextBox();
            this.d = new ImageKernels.CustomTextBox();
            this.g = new ImageKernels.CustomTextBox();
            this.h = new ImageKernels.CustomTextBox();
            this.e = new ImageKernels.CustomTextBox();
            this.b = new ImageKernels.CustomTextBox();
            this.i = new ImageKernels.CustomTextBox();
            this.f = new ImageKernels.CustomTextBox();
            this.c = new ImageKernels.CustomTextBox();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(493, 147);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(109, 46);
            this.save.TabIndex = 1;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese los valores de su matriz personalizada...";
            // 
            // a
            // 
            this.a.ForeColor = System.Drawing.Color.Red;
            this.a.Location = new System.Drawing.Point(16, 81);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(122, 26);
            this.a.TabIndex = 3;
            // 
            // d
            // 
            this.d.ForeColor = System.Drawing.Color.Red;
            this.d.Location = new System.Drawing.Point(16, 123);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(122, 26);
            this.d.TabIndex = 4;
            // 
            // g
            // 
            this.g.ForeColor = System.Drawing.Color.Red;
            this.g.Location = new System.Drawing.Point(16, 167);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(122, 26);
            this.g.TabIndex = 5;
            // 
            // h
            // 
            this.h.ForeColor = System.Drawing.Color.Red;
            this.h.Location = new System.Drawing.Point(161, 167);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(122, 26);
            this.h.TabIndex = 8;
            // 
            // e
            // 
            this.e.ForeColor = System.Drawing.Color.Red;
            this.e.Location = new System.Drawing.Point(161, 123);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(122, 26);
            this.e.TabIndex = 7;
            // 
            // b
            // 
            this.b.ForeColor = System.Drawing.Color.Red;
            this.b.Location = new System.Drawing.Point(161, 81);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(122, 26);
            this.b.TabIndex = 6;
            // 
            // i
            // 
            this.i.ForeColor = System.Drawing.Color.Red;
            this.i.Location = new System.Drawing.Point(307, 167);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(122, 26);
            this.i.TabIndex = 11;
            // 
            // f
            // 
            this.f.ForeColor = System.Drawing.Color.Red;
            this.f.Location = new System.Drawing.Point(307, 123);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(122, 26);
            this.f.TabIndex = 10;
            // 
            // c
            // 
            this.c.ForeColor = System.Drawing.Color.Red;
            this.c.Location = new System.Drawing.Point(307, 81);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(122, 26);
            this.c.TabIndex = 9;
            // 
            // CustomKernel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 259);
            this.Controls.Add(this.i);
            this.Controls.Add(this.f);
            this.Controls.Add(this.c);
            this.Controls.Add(this.h);
            this.Controls.Add(this.e);
            this.Controls.Add(this.b);
            this.Controls.Add(this.g);
            this.Controls.Add(this.d);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomKernel";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CustomKernel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button save;
        private CustomTextBox a;
        private CustomTextBox d;
        private CustomTextBox g;
        private CustomTextBox h;
        private CustomTextBox e;
        private CustomTextBox b;
        private CustomTextBox i;
        private CustomTextBox f;
        private CustomTextBox c;
    }
}