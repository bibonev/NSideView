namespace NSideViewEditing
{
    partial class Editing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editing));
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.reconstructionBtn = new Telerik.WinControls.UI.RadButton();
            this.browseBtn = new Telerik.WinControls.UI.RadButton();
            this.stereoGcBtn = new Telerik.WinControls.UI.RadButton();
            this.leftImagePicBox = new System.Windows.Forms.PictureBox();
            this.rightImagePicBox = new System.Windows.Forms.PictureBox();
            this.depthImagePicBox = new System.Windows.Forms.PictureBox();
            this.progressBarProcess = new System.Windows.Forms.ProgressBar();
            this.depthImageBMPicBox = new System.Windows.Forms.PictureBox();
            this.preFilterSizeBtn = new Telerik.WinControls.UI.RadTextBoxControl();
            this.preFilterCapBtn = new Telerik.WinControls.UI.RadTextBoxControl();
            this.SADWindowSizeBtn = new Telerik.WinControls.UI.RadTextBoxControl();
            this.minDisparityBtn = new Telerik.WinControls.UI.RadTextBoxControl();
            this.numberOfDisparitiesBtn = new Telerik.WinControls.UI.RadTextBoxControl();
            this.textureThresholdBtn = new Telerik.WinControls.UI.RadTextBoxControl();
            this.uniquenessRatioBtn = new Telerik.WinControls.UI.RadTextBoxControl();
            this.speckleWindowSizeBtn = new Telerik.WinControls.UI.RadTextBoxControl();
            this.speckleRangeBtn = new Telerik.WinControls.UI.RadTextBoxControl();
            this.preFilterSizeLbl = new System.Windows.Forms.Label();
            this.preFilterCapLbl = new System.Windows.Forms.Label();
            this.SADWindowSizeLbl = new System.Windows.Forms.Label();
            this.minDisparityLbl = new System.Windows.Forms.Label();
            this.numberOfDisparitiesLbl = new System.Windows.Forms.Label();
            this.textureThresholdLbl = new System.Windows.Forms.Label();
            this.uniquenessRatioLbl = new System.Windows.Forms.Label();
            this.speckleWindowSizeLbl = new System.Windows.Forms.Label();
            this.speckleRangeLbl = new System.Windows.Forms.Label();
            this.stereoBmBtn = new Telerik.WinControls.UI.RadButton();
            this.saveBtn = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.reconstructionBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stereoGcBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftImagePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightImagePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthImagePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthImageBMPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preFilterSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preFilterCapBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SADWindowSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDisparityBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDisparitiesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textureThresholdBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniquenessRatioBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speckleWindowSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speckleRangeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stereoBmBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reconstructionBtn
            // 
            this.reconstructionBtn.Location = new System.Drawing.Point(880, 684);
            this.reconstructionBtn.Name = "reconstructionBtn";
            this.reconstructionBtn.Size = new System.Drawing.Size(123, 37);
            this.reconstructionBtn.TabIndex = 0;
            this.reconstructionBtn.Text = "Reconstruction";
            this.reconstructionBtn.Click += new System.EventHandler(this.reconstructionBtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(12, 684);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(123, 37);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "Choose Pictures";
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // stereoGcBtn
            // 
            this.stereoGcBtn.Location = new System.Drawing.Point(229, 684);
            this.stereoGcBtn.Name = "stereoGcBtn";
            this.stereoGcBtn.Size = new System.Drawing.Size(123, 37);
            this.stereoGcBtn.TabIndex = 2;
            this.stereoGcBtn.Text = "StereoGC";
            this.stereoGcBtn.Click += new System.EventHandler(this.stereoGcBtn_Click);
            // 
            // leftImagePicBox
            // 
            this.leftImagePicBox.Location = new System.Drawing.Point(12, 12);
            this.leftImagePicBox.Name = "leftImagePicBox";
            this.leftImagePicBox.Size = new System.Drawing.Size(384, 288);
            this.leftImagePicBox.TabIndex = 0;
            this.leftImagePicBox.TabStop = false;
            // 
            // rightImagePicBox
            // 
            this.rightImagePicBox.Location = new System.Drawing.Point(620, 9);
            this.rightImagePicBox.Name = "rightImagePicBox";
            this.rightImagePicBox.Size = new System.Drawing.Size(384, 288);
            this.rightImagePicBox.TabIndex = 4;
            this.rightImagePicBox.TabStop = false;
            // 
            // depthImagePicBox
            // 
            this.depthImagePicBox.Location = new System.Drawing.Point(319, 336);
            this.depthImagePicBox.Name = "depthImagePicBox";
            this.depthImagePicBox.Size = new System.Drawing.Size(384, 288);
            this.depthImagePicBox.TabIndex = 5;
            this.depthImagePicBox.TabStop = false;
            // 
            // progressBarProcess
            // 
            this.progressBarProcess.Location = new System.Drawing.Point(229, 655);
            this.progressBarProcess.Name = "progressBarProcess";
            this.progressBarProcess.Size = new System.Drawing.Size(123, 23);
            this.progressBarProcess.Step = 1;
            this.progressBarProcess.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarProcess.TabIndex = 10;
            this.progressBarProcess.Visible = false;
            // 
            // depthImageBMPicBox
            // 
            this.depthImageBMPicBox.Location = new System.Drawing.Point(620, 336);
            this.depthImageBMPicBox.Name = "depthImageBMPicBox";
            this.depthImageBMPicBox.Size = new System.Drawing.Size(384, 288);
            this.depthImageBMPicBox.TabIndex = 11;
            this.depthImageBMPicBox.TabStop = false;
            this.depthImageBMPicBox.Visible = false;
            // 
            // preFilterSizeBtn
            // 
            this.preFilterSizeBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preFilterSizeBtn.Location = new System.Drawing.Point(271, 337);
            this.preFilterSizeBtn.Name = "preFilterSizeBtn";
            this.preFilterSizeBtn.Size = new System.Drawing.Size(125, 20);
            this.preFilterSizeBtn.TabIndex = 12;
            this.preFilterSizeBtn.Text = "5";
            this.preFilterSizeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.preFilterSizeBtn.Visible = false;
            // 
            // preFilterCapBtn
            // 
            this.preFilterCapBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preFilterCapBtn.Location = new System.Drawing.Point(271, 370);
            this.preFilterCapBtn.Name = "preFilterCapBtn";
            this.preFilterCapBtn.Size = new System.Drawing.Size(125, 20);
            this.preFilterCapBtn.TabIndex = 13;
            this.preFilterCapBtn.Text = "1";
            this.preFilterCapBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.preFilterCapBtn.Visible = false;
            // 
            // SADWindowSizeBtn
            // 
            this.SADWindowSizeBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SADWindowSizeBtn.Location = new System.Drawing.Point(271, 403);
            this.SADWindowSizeBtn.Name = "SADWindowSizeBtn";
            this.SADWindowSizeBtn.Size = new System.Drawing.Size(125, 20);
            this.SADWindowSizeBtn.TabIndex = 14;
            this.SADWindowSizeBtn.Text = "5";
            this.SADWindowSizeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SADWindowSizeBtn.Visible = false;
            // 
            // minDisparityBtn
            // 
            this.minDisparityBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minDisparityBtn.Location = new System.Drawing.Point(271, 436);
            this.minDisparityBtn.Name = "minDisparityBtn";
            this.minDisparityBtn.Size = new System.Drawing.Size(125, 20);
            this.minDisparityBtn.TabIndex = 15;
            this.minDisparityBtn.Text = "0";
            this.minDisparityBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minDisparityBtn.Visible = false;
            // 
            // numberOfDisparitiesBtn
            // 
            this.numberOfDisparitiesBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDisparitiesBtn.Location = new System.Drawing.Point(271, 469);
            this.numberOfDisparitiesBtn.Name = "numberOfDisparitiesBtn";
            this.numberOfDisparitiesBtn.Size = new System.Drawing.Size(125, 20);
            this.numberOfDisparitiesBtn.TabIndex = 16;
            this.numberOfDisparitiesBtn.Text = "64";
            this.numberOfDisparitiesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberOfDisparitiesBtn.Visible = false;
            // 
            // textureThresholdBtn
            // 
            this.textureThresholdBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textureThresholdBtn.Location = new System.Drawing.Point(271, 502);
            this.textureThresholdBtn.Name = "textureThresholdBtn";
            this.textureThresholdBtn.Size = new System.Drawing.Size(125, 20);
            this.textureThresholdBtn.TabIndex = 17;
            this.textureThresholdBtn.Text = "0";
            this.textureThresholdBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textureThresholdBtn.Visible = false;
            // 
            // uniquenessRatioBtn
            // 
            this.uniquenessRatioBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniquenessRatioBtn.Location = new System.Drawing.Point(271, 535);
            this.uniquenessRatioBtn.Name = "uniquenessRatioBtn";
            this.uniquenessRatioBtn.Size = new System.Drawing.Size(125, 20);
            this.uniquenessRatioBtn.TabIndex = 18;
            this.uniquenessRatioBtn.Text = "0";
            this.uniquenessRatioBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uniquenessRatioBtn.Visible = false;
            // 
            // speckleWindowSizeBtn
            // 
            this.speckleWindowSizeBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speckleWindowSizeBtn.Location = new System.Drawing.Point(271, 568);
            this.speckleWindowSizeBtn.Name = "speckleWindowSizeBtn";
            this.speckleWindowSizeBtn.Size = new System.Drawing.Size(125, 20);
            this.speckleWindowSizeBtn.TabIndex = 19;
            this.speckleWindowSizeBtn.Text = "0";
            this.speckleWindowSizeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speckleWindowSizeBtn.Visible = false;
            // 
            // speckleRangeBtn
            // 
            this.speckleRangeBtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speckleRangeBtn.Location = new System.Drawing.Point(271, 601);
            this.speckleRangeBtn.Name = "speckleRangeBtn";
            this.speckleRangeBtn.Size = new System.Drawing.Size(125, 20);
            this.speckleRangeBtn.TabIndex = 20;
            this.speckleRangeBtn.Text = "0";
            this.speckleRangeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speckleRangeBtn.Visible = false;
            // 
            // preFilterSizeLbl
            // 
            this.preFilterSizeLbl.AutoSize = true;
            this.preFilterSizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preFilterSizeLbl.Location = new System.Drawing.Point(47, 336);
            this.preFilterSizeLbl.Name = "preFilterSizeLbl";
            this.preFilterSizeLbl.Size = new System.Drawing.Size(174, 20);
            this.preFilterSizeLbl.TabIndex = 0;
            this.preFilterSizeLbl.Text = "Pre Filter Size (5 - 255):";
            this.preFilterSizeLbl.Visible = false;
            // 
            // preFilterCapLbl
            // 
            this.preFilterCapLbl.AutoSize = true;
            this.preFilterCapLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preFilterCapLbl.Location = new System.Drawing.Point(47, 370);
            this.preFilterCapLbl.Name = "preFilterCapLbl";
            this.preFilterCapLbl.Size = new System.Drawing.Size(155, 20);
            this.preFilterCapLbl.TabIndex = 21;
            this.preFilterCapLbl.Text = "Pre Filter Cap (1-64):";
            this.preFilterCapLbl.Visible = false;
            // 
            // SADWindowSizeLbl
            // 
            this.SADWindowSizeLbl.AutoSize = true;
            this.SADWindowSizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SADWindowSizeLbl.Location = new System.Drawing.Point(47, 403);
            this.SADWindowSizeLbl.Name = "SADWindowSizeLbl";
            this.SADWindowSizeLbl.Size = new System.Drawing.Size(142, 20);
            this.SADWindowSizeLbl.TabIndex = 22;
            this.SADWindowSizeLbl.Text = "SAD Window Size:";
            this.SADWindowSizeLbl.Visible = false;
            // 
            // minDisparityLbl
            // 
            this.minDisparityLbl.AutoSize = true;
            this.minDisparityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minDisparityLbl.Location = new System.Drawing.Point(47, 436);
            this.minDisparityLbl.Name = "minDisparityLbl";
            this.minDisparityLbl.Size = new System.Drawing.Size(141, 20);
            this.minDisparityLbl.TabIndex = 23;
            this.minDisparityLbl.Text = "Minimum Disparity:";
            this.minDisparityLbl.Visible = false;
            // 
            // numberOfDisparitiesLbl
            // 
            this.numberOfDisparitiesLbl.AutoSize = true;
            this.numberOfDisparitiesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDisparitiesLbl.Location = new System.Drawing.Point(47, 469);
            this.numberOfDisparitiesLbl.Name = "numberOfDisparitiesLbl";
            this.numberOfDisparitiesLbl.Size = new System.Drawing.Size(165, 20);
            this.numberOfDisparitiesLbl.TabIndex = 24;
            this.numberOfDisparitiesLbl.Text = "Number of Disparities:";
            this.numberOfDisparitiesLbl.Visible = false;
            // 
            // textureThresholdLbl
            // 
            this.textureThresholdLbl.AutoSize = true;
            this.textureThresholdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textureThresholdLbl.Location = new System.Drawing.Point(47, 502);
            this.textureThresholdLbl.Name = "textureThresholdLbl";
            this.textureThresholdLbl.Size = new System.Drawing.Size(140, 20);
            this.textureThresholdLbl.TabIndex = 25;
            this.textureThresholdLbl.Text = "Texture Threshold:";
            this.textureThresholdLbl.Visible = false;
            // 
            // uniquenessRatioLbl
            // 
            this.uniquenessRatioLbl.AutoSize = true;
            this.uniquenessRatioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniquenessRatioLbl.Location = new System.Drawing.Point(47, 535);
            this.uniquenessRatioLbl.Name = "uniquenessRatioLbl";
            this.uniquenessRatioLbl.Size = new System.Drawing.Size(140, 20);
            this.uniquenessRatioLbl.TabIndex = 26;
            this.uniquenessRatioLbl.Text = "Uniqueness Ratio:";
            this.uniquenessRatioLbl.Visible = false;
            // 
            // speckleWindowSizeLbl
            // 
            this.speckleWindowSizeLbl.AutoSize = true;
            this.speckleWindowSizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speckleWindowSizeLbl.Location = new System.Drawing.Point(47, 568);
            this.speckleWindowSizeLbl.Name = "speckleWindowSizeLbl";
            this.speckleWindowSizeLbl.Size = new System.Drawing.Size(165, 20);
            this.speckleWindowSizeLbl.TabIndex = 27;
            this.speckleWindowSizeLbl.Text = "Speckle Window Size:";
            this.speckleWindowSizeLbl.Visible = false;
            // 
            // speckleRangeLbl
            // 
            this.speckleRangeLbl.AutoSize = true;
            this.speckleRangeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speckleRangeLbl.Location = new System.Drawing.Point(47, 601);
            this.speckleRangeLbl.Name = "speckleRangeLbl";
            this.speckleRangeLbl.Size = new System.Drawing.Size(122, 20);
            this.speckleRangeLbl.TabIndex = 28;
            this.speckleRangeLbl.Text = "Speckle Range:";
            this.speckleRangeLbl.Visible = false;
            // 
            // stereoBmBtn
            // 
            this.stereoBmBtn.Location = new System.Drawing.Point(446, 684);
            this.stereoBmBtn.Name = "stereoBmBtn";
            this.stereoBmBtn.Size = new System.Drawing.Size(123, 37);
            this.stereoBmBtn.TabIndex = 3;
            this.stereoBmBtn.Text = "StereoBM";
            this.stereoBmBtn.Click += new System.EventHandler(this.stereoBmBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(663, 684);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(123, 37);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Editing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 733);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.stereoBmBtn);
            this.Controls.Add(this.speckleRangeLbl);
            this.Controls.Add(this.speckleWindowSizeLbl);
            this.Controls.Add(this.uniquenessRatioLbl);
            this.Controls.Add(this.textureThresholdLbl);
            this.Controls.Add(this.numberOfDisparitiesLbl);
            this.Controls.Add(this.minDisparityLbl);
            this.Controls.Add(this.SADWindowSizeLbl);
            this.Controls.Add(this.preFilterCapLbl);
            this.Controls.Add(this.preFilterSizeLbl);
            this.Controls.Add(this.speckleRangeBtn);
            this.Controls.Add(this.speckleWindowSizeBtn);
            this.Controls.Add(this.uniquenessRatioBtn);
            this.Controls.Add(this.textureThresholdBtn);
            this.Controls.Add(this.numberOfDisparitiesBtn);
            this.Controls.Add(this.minDisparityBtn);
            this.Controls.Add(this.SADWindowSizeBtn);
            this.Controls.Add(this.preFilterCapBtn);
            this.Controls.Add(this.preFilterSizeBtn);
            this.Controls.Add(this.depthImageBMPicBox);
            this.Controls.Add(this.progressBarProcess);
            this.Controls.Add(this.depthImagePicBox);
            this.Controls.Add(this.rightImagePicBox);
            this.Controls.Add(this.leftImagePicBox);
            this.Controls.Add(this.stereoGcBtn);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.reconstructionBtn);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Editing";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(1024, 768);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NSideView - Editing";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.reconstructionBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stereoGcBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftImagePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightImagePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthImagePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthImageBMPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preFilterSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preFilterCapBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SADWindowSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDisparityBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDisparitiesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textureThresholdBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniquenessRatioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speckleWindowSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speckleRangeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stereoBmBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadButton reconstructionBtn;
        private Telerik.WinControls.UI.RadButton browseBtn;
        private Telerik.WinControls.UI.RadButton stereoGcBtn;
        private System.Windows.Forms.PictureBox leftImagePicBox;
        private System.Windows.Forms.PictureBox rightImagePicBox;
        private System.Windows.Forms.PictureBox depthImagePicBox;
        private System.Windows.Forms.ProgressBar progressBarProcess;
        private System.Windows.Forms.PictureBox depthImageBMPicBox;
        private Telerik.WinControls.UI.RadTextBoxControl preFilterSizeBtn;
        private Telerik.WinControls.UI.RadTextBoxControl preFilterCapBtn;
        private Telerik.WinControls.UI.RadTextBoxControl SADWindowSizeBtn;
        private Telerik.WinControls.UI.RadTextBoxControl minDisparityBtn;
        private Telerik.WinControls.UI.RadTextBoxControl numberOfDisparitiesBtn;
        private Telerik.WinControls.UI.RadTextBoxControl textureThresholdBtn;
        private Telerik.WinControls.UI.RadTextBoxControl uniquenessRatioBtn;
        private Telerik.WinControls.UI.RadTextBoxControl speckleWindowSizeBtn;
        private Telerik.WinControls.UI.RadTextBoxControl speckleRangeBtn;
        private System.Windows.Forms.Label preFilterSizeLbl;
        private System.Windows.Forms.Label preFilterCapLbl;
        private System.Windows.Forms.Label SADWindowSizeLbl;
        private System.Windows.Forms.Label minDisparityLbl;
        private System.Windows.Forms.Label numberOfDisparitiesLbl;
        private System.Windows.Forms.Label textureThresholdLbl;
        private System.Windows.Forms.Label uniquenessRatioLbl;
        private System.Windows.Forms.Label speckleWindowSizeLbl;
        private System.Windows.Forms.Label speckleRangeLbl;
        private Telerik.WinControls.UI.RadButton stereoBmBtn;
        private Telerik.WinControls.UI.RadButton saveBtn;
    }
}
