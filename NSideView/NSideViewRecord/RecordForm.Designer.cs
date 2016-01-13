namespace NSideViewRecord
{
    partial class RecordForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordForm));
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.controlCamsBtn = new Telerik.WinControls.UI.RadButton();
            this.cam1Cmb = new System.Windows.Forms.ComboBox();
            this.cam2Cmb = new System.Windows.Forms.ComboBox();
            this.captureBtn = new Telerik.WinControls.UI.RadButton();
            this.cam1Lbl = new System.Windows.Forms.Label();
            this.cam2Lbl = new System.Windows.Forms.Label();
            this.statusCamsLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.refreshCamsBtn = new Telerik.WinControls.UI.RadButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.browseBtn = new Telerik.WinControls.UI.RadButton();
            this.pathTxtBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.calibrationBtn = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.controlCamsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshCamsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathTxtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calibrationBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // controlCamsBtn
            // 
            this.controlCamsBtn.Location = new System.Drawing.Point(890, 699);
            this.controlCamsBtn.Name = "controlCamsBtn";
            this.controlCamsBtn.Size = new System.Drawing.Size(110, 34);
            this.controlCamsBtn.TabIndex = 0;
            this.controlCamsBtn.Text = "Start";
            this.controlCamsBtn.Click += new System.EventHandler(this.controlCamsBtn_Click);
            // 
            // cam1Cmb
            // 
            this.cam1Cmb.FormattingEnabled = true;
            this.cam1Cmb.Location = new System.Drawing.Point(883, 30);
            this.cam1Cmb.Name = "cam1Cmb";
            this.cam1Cmb.Size = new System.Drawing.Size(121, 21);
            this.cam1Cmb.TabIndex = 1;
            // 
            // cam2Cmb
            // 
            this.cam2Cmb.FormattingEnabled = true;
            this.cam2Cmb.Location = new System.Drawing.Point(883, 57);
            this.cam2Cmb.Name = "cam2Cmb";
            this.cam2Cmb.Size = new System.Drawing.Size(121, 21);
            this.cam2Cmb.TabIndex = 2;
            // 
            // captureBtn
            // 
            this.captureBtn.Location = new System.Drawing.Point(755, 699);
            this.captureBtn.Name = "captureBtn";
            this.captureBtn.Size = new System.Drawing.Size(110, 34);
            this.captureBtn.TabIndex = 1;
            this.captureBtn.Text = "Capture";
            this.captureBtn.Click += new System.EventHandler(this.captureBtn_Click);
            // 
            // cam1Lbl
            // 
            this.cam1Lbl.AutoSize = true;
            this.cam1Lbl.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cam1Lbl.Location = new System.Drawing.Point(790, 28);
            this.cam1Lbl.Name = "cam1Lbl";
            this.cam1Lbl.Size = new System.Drawing.Size(75, 20);
            this.cam1Lbl.TabIndex = 3;
            this.cam1Lbl.Text = "Camera 1:";
            // 
            // cam2Lbl
            // 
            this.cam2Lbl.AutoSize = true;
            this.cam2Lbl.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cam2Lbl.Location = new System.Drawing.Point(790, 55);
            this.cam2Lbl.Name = "cam2Lbl";
            this.cam2Lbl.Size = new System.Drawing.Size(77, 20);
            this.cam2Lbl.TabIndex = 4;
            this.cam2Lbl.Text = "Camera 2:";
            // 
            // statusCamsLbl
            // 
            this.statusCamsLbl.AutoSize = true;
            this.statusCamsLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCamsLbl.Location = new System.Drawing.Point(143, 664);
            this.statusCamsLbl.Name = "statusCamsLbl";
            this.statusCamsLbl.Size = new System.Drawing.Size(58, 23);
            this.statusCamsLbl.TabIndex = 5;
            this.statusCamsLbl.Text = "Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(55, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 416);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // refreshCamsBtn
            // 
            this.refreshCamsBtn.Location = new System.Drawing.Point(890, 91);
            this.refreshCamsBtn.Name = "refreshCamsBtn";
            this.refreshCamsBtn.Size = new System.Drawing.Size(110, 34);
            this.refreshCamsBtn.TabIndex = 2;
            this.refreshCamsBtn.Text = "Refresh";
            this.refreshCamsBtn.Click += new System.EventHandler(this.refreshCamsBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(516, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(420, 416);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(12, 699);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(110, 34);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Browse";
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // pathTxtBox
            // 
            this.pathTxtBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathTxtBox.IsReadOnly = true;
            this.pathTxtBox.Location = new System.Drawing.Point(147, 699);
            this.pathTxtBox.Name = "pathTxtBox";
            this.pathTxtBox.Size = new System.Drawing.Size(577, 34);
            this.pathTxtBox.TabIndex = 8;
            // 
            // calibrationBtn
            // 
            this.calibrationBtn.Location = new System.Drawing.Point(890, 653);
            this.calibrationBtn.Name = "calibrationBtn";
            this.calibrationBtn.Size = new System.Drawing.Size(110, 34);
            this.calibrationBtn.TabIndex = 1;
            this.calibrationBtn.Text = "Calibration";
            this.calibrationBtn.Click += new System.EventHandler(this.calibrationBtn_Click);
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 745);
            this.Controls.Add(this.calibrationBtn);
            this.Controls.Add(this.pathTxtBox);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.refreshCamsBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusCamsLbl);
            this.Controls.Add(this.cam2Lbl);
            this.Controls.Add(this.cam1Lbl);
            this.Controls.Add(this.captureBtn);
            this.Controls.Add(this.cam2Cmb);
            this.Controls.Add(this.cam1Cmb);
            this.Controls.Add(this.controlCamsBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 780);
            this.MinimumSize = new System.Drawing.Size(1024, 780);
            this.Name = "RecordForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(1024, 780);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NSideView - Record";
            this.ThemeName = "TelerikMetroBlue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecordForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.controlCamsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshCamsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathTxtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calibrationBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadButton controlCamsBtn;
        private System.Windows.Forms.ComboBox cam1Cmb;
        private System.Windows.Forms.ComboBox cam2Cmb;
        private Telerik.WinControls.UI.RadButton captureBtn;
        private System.Windows.Forms.Label cam1Lbl;
        private System.Windows.Forms.Label cam2Lbl;
        private System.Windows.Forms.Label statusCamsLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadButton refreshCamsBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Telerik.WinControls.UI.RadButton browseBtn;
        private Telerik.WinControls.UI.RadTextBoxControl pathTxtBox;
        private Telerik.WinControls.UI.RadButton calibrationBtn;
    }
}
