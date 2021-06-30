namespace Lab2
{
    partial class Form1
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
            this.pictureBoxEditor = new System.Windows.Forms.PictureBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonContrast = new System.Windows.Forms.RadioButton();
            this.radioButtonBW = new System.Windows.Forms.RadioButton();
            this.radioButtonTint = new System.Windows.Forms.RadioButton();
            this.radioButtonNoise = new System.Windows.Forms.RadioButton();
            this.trackBarRGB = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRGB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEditor
            // 
            this.pictureBoxEditor.Location = new System.Drawing.Point(16, 15);
            this.pictureBoxEditor.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxEditor.Name = "pictureBoxEditor";
            this.pictureBoxEditor.Size = new System.Drawing.Size(1035, 417);
            this.pictureBoxEditor.TabIndex = 0;
            this.pictureBoxEditor.TabStop = false;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(16, 459);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 28);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load Picture";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(16, 439);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1035, 12);
            this.progressBar1.TabIndex = 2;
            // 
            // buttonTransform
            // 
            this.buttonTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTransform.Enabled = false;
            this.buttonTransform.Location = new System.Drawing.Point(928, 459);
            this.buttonTransform.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(100, 28);
            this.buttonTransform.TabIndex = 3;
            this.buttonTransform.Text = "Transform";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.ButtonTransform_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButtonContrast);
            this.groupBox1.Controls.Add(this.radioButtonBW);
            this.groupBox1.Controls.Add(this.radioButtonTint);
            this.groupBox1.Controls.Add(this.radioButtonNoise);
            this.groupBox1.Location = new System.Drawing.Point(136, 476);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(269, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification Type";
            // 
            // radioButtonContrast
            // 
            this.radioButtonContrast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonContrast.AutoSize = true;
            this.radioButtonContrast.Checked = true;
            this.radioButtonContrast.Location = new System.Drawing.Point(8, 17);
            this.radioButtonContrast.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonContrast.Name = "radioButtonContrast";
            this.radioButtonContrast.Size = new System.Drawing.Size(82, 21);
            this.radioButtonContrast.TabIndex = 5;
            this.radioButtonContrast.TabStop = true;
            this.radioButtonContrast.Text = "Contrast";
            this.radioButtonContrast.UseVisualStyleBackColor = true;
            this.radioButtonContrast.CheckedChanged += new System.EventHandler(this.RadioButtonContrast_CheckedChanged);
            // 
            // radioButtonBW
            // 
            this.radioButtonBW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonBW.AutoSize = true;
            this.radioButtonBW.Location = new System.Drawing.Point(8, 46);
            this.radioButtonBW.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonBW.Name = "radioButtonBW";
            this.radioButtonBW.Size = new System.Drawing.Size(107, 21);
            this.radioButtonBW.TabIndex = 6;
            this.radioButtonBW.Text = "Black & White";
            this.radioButtonBW.UseVisualStyleBackColor = true;
            this.radioButtonBW.CheckedChanged += new System.EventHandler(this.RadioButtonBW_CheckedChanged);
            // 
            // radioButtonTint
            // 
            this.radioButtonTint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonTint.AutoSize = true;
            this.radioButtonTint.Location = new System.Drawing.Point(148, 17);
            this.radioButtonTint.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonTint.Name = "radioButtonTint";
            this.radioButtonTint.Size = new System.Drawing.Size(53, 21);
            this.radioButtonTint.TabIndex = 7;
            this.radioButtonTint.Text = "Tint";
            this.radioButtonTint.UseVisualStyleBackColor = true;
            this.radioButtonTint.CheckedChanged += new System.EventHandler(this.RadioButtonTint_CheckedChanged);
            // 
            // radioButtonNoise
            // 
            this.radioButtonNoise.AutoSize = true;
            this.radioButtonNoise.Location = new System.Drawing.Point(148, 46);
            this.radioButtonNoise.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonNoise.Name = "radioButtonNoise";
            this.radioButtonNoise.Size = new System.Drawing.Size(65, 21);
            this.radioButtonNoise.TabIndex = 8;
            this.radioButtonNoise.Text = "Noise";
            this.radioButtonNoise.UseVisualStyleBackColor = true;
            this.radioButtonNoise.CheckedChanged += new System.EventHandler(this.RadioButtonNoise_CheckedChanged);
            // 
            // trackBarRGB
            // 
            this.trackBarRGB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trackBarRGB.Location = new System.Drawing.Point(413, 459);
            this.trackBarRGB.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarRGB.Maximum = 100;
            this.trackBarRGB.Name = "trackBarRGB";
            this.trackBarRGB.Size = new System.Drawing.Size(476, 56);
            this.trackBarRGB.SmallChange = 5;
            this.trackBarRGB.TabIndex = 5;
            this.trackBarRGB.TickFrequency = 5;
            this.trackBarRGB.Scroll += new System.EventHandler(this.trackBarRGB_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(859, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 570);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarRGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonTransform);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.pictureBoxEditor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "FotoShoppe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRGB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEditor;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNoise;
        private System.Windows.Forms.RadioButton radioButtonContrast;
        private System.Windows.Forms.RadioButton radioButtonBW;
        private System.Windows.Forms.RadioButton radioButtonTint;
        private System.Windows.Forms.TrackBar trackBarRGB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

