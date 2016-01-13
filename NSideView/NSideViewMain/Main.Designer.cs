namespace NSideViewMain
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.recordBtn = new Telerik.WinControls.UI.RadButton();
            this.edittingBtn = new Telerik.WinControls.UI.RadButton();
            this.visualizeBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edittingBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(103, 480);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(81, 34);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Record";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(353, 480);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(81, 34);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Editing";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(609, 480);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(100, 34);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Visualize";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recordBtn
            // 
            this.recordBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.recordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.recordBtn.Image = global::NSideViewMain.Properties.Resources._1398954773_photo_24;
            this.recordBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.recordBtn.Location = new System.Drawing.Point(43, 274);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(200, 200);
            this.recordBtn.TabIndex = 0;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // edittingBtn
            // 
            this.edittingBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.edittingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.edittingBtn.Image = global::NSideViewMain.Properties.Resources._1398954785_new_24;
            this.edittingBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.edittingBtn.Location = new System.Drawing.Point(291, 274);
            this.edittingBtn.Name = "edittingBtn";
            this.edittingBtn.Size = new System.Drawing.Size(200, 200);
            this.edittingBtn.TabIndex = 1;
            this.edittingBtn.Click += new System.EventHandler(this.edittingBtn_Click);
            // 
            // visualizeBtn
            // 
            this.visualizeBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.visualizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.visualizeBtn.Image = global::NSideViewMain.Properties.Resources._1398954760_export;
            this.visualizeBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.visualizeBtn.Location = new System.Drawing.Point(544, 274);
            this.visualizeBtn.Name = "visualizeBtn";
            this.visualizeBtn.Size = new System.Drawing.Size(200, 200);
            this.visualizeBtn.TabIndex = 2;
            this.visualizeBtn.Click += new System.EventHandler(this.visualizeBtn_Click);
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Comic Sans MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(220, 95);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(362, 99);
            this.radLabel4.TabIndex = 4;
            this.radLabel4.Text = "NSideView";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 645);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.visualizeBtn);
            this.Controls.Add(this.edittingBtn);
            this.Controls.Add(this.recordBtn);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 680);
            this.MinimumSize = new System.Drawing.Size(800, 680);
            this.Name = "Main";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(800, 680);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NSideView";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edittingBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton recordBtn;
        private Telerik.WinControls.UI.RadButton edittingBtn;
        private Telerik.WinControls.UI.RadButton visualizeBtn;
        private Telerik.WinControls.UI.RadLabel radLabel4;
    }
}
