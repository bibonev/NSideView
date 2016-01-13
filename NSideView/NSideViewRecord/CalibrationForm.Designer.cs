namespace NSideViewRecord
{
    partial class CalibrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalibrationForm));
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.roundRectShapeTitle = new Telerik.WinControls.RoundRectShape(this.components);
            this.roundRectShapeForm = new Telerik.WinControls.RoundRectShape(this.components);
            this.browseBtn = new Telerik.WinControls.UI.RadButton();
            this.pathCalibrationTxtBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.runBtn = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathCalibrationTxtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTitleBar1.Location = new System.Drawing.Point(1, 1);
            this.radTitleBar1.Name = "radTitleBar1";
            // 
            // 
            // 
            this.radTitleBar1.RootElement.ApplyShapeToControl = true;
            this.radTitleBar1.RootElement.Shape = this.roundRectShapeTitle;
            this.radTitleBar1.Size = new System.Drawing.Size(520, 23);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "NSideView - Calibration";
            // 
            // roundRectShapeTitle
            // 
            this.roundRectShapeTitle.BottomLeftRounded = false;
            this.roundRectShapeTitle.BottomRightRounded = false;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(21, 85);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(110, 24);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "Browse";
            this.browseBtn.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // pathCalibrationTxtBox
            // 
            this.pathCalibrationTxtBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathCalibrationTxtBox.IsReadOnly = true;
            this.pathCalibrationTxtBox.Location = new System.Drawing.Point(151, 85);
            this.pathCalibrationTxtBox.Name = "pathCalibrationTxtBox";
            this.pathCalibrationTxtBox.Size = new System.Drawing.Size(343, 24);
            this.pathCalibrationTxtBox.TabIndex = 0;
            this.pathCalibrationTxtBox.Text = "Choose calibration list path. (Ex. list.txt)";
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(188, 46);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(110, 24);
            this.runBtn.TabIndex = 2;
            this.runBtn.Text = "Run";
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // CalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 133);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.pathCalibrationTxtBox);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.radTitleBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalibrationForm";
            this.Shape = this.roundRectShapeForm;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NSideView - Calibration";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathCalibrationTxtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private Telerik.WinControls.RoundRectShape roundRectShapeTitle;
        private Telerik.WinControls.UI.RadButton browseBtn;
        private Telerik.WinControls.UI.RadTextBoxControl pathCalibrationTxtBox;
        private Telerik.WinControls.UI.RadButton runBtn;
    }
}
