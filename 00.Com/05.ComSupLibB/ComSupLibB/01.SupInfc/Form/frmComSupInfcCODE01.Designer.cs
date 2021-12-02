﻿namespace ComSupLibB.SupInfc
{
    partial class frmComSupInfcCODE01
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
            FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer enhancedFocusIndicatorRenderer1 = new FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer();
            FarPoint.Win.Spread.EnhancedScrollBarRenderer enhancedScrollBarRenderer1 = new FarPoint.Win.Spread.EnhancedScrollBarRenderer();
            FarPoint.Win.Spread.EnhancedScrollBarRenderer enhancedScrollBarRenderer2 = new FarPoint.Win.Spread.EnhancedScrollBarRenderer();
            this.panTitle = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panTitleSub0 = new System.Windows.Forms.Panel();
            this.lblTitleSub0 = new System.Windows.Forms.Label();
            this.panMain = new System.Windows.Forms.Panel();
            this.circProgress = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.ssMain = new FarPoint.Win.Spread.FpSpread();
            this.ssMain_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panTitleSub0.SuspendLayout();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssMain_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.Color.White;
            this.panTitle.Controls.Add(this.btnExit);
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitle.Location = new System.Drawing.Point(0, 0);
            this.panTitle.Name = "panTitle";
            this.panTitle.Padding = new System.Windows.Forms.Padding(1);
            this.panTitle.Size = new System.Drawing.Size(1260, 34);
            this.panTitle.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(1187, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "닫기";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 16);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "감염관리코드";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(1260, 37);
            this.panel1.TabIndex = 89;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.Location = new System.Drawing.Point(975, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 35);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "셀추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Location = new System.Drawing.Point(1046, 1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(71, 35);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "출력";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(1117, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 35);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(1188, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 35);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panTitleSub0
            // 
            this.panTitleSub0.BackColor = System.Drawing.Color.RoyalBlue;
            this.panTitleSub0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panTitleSub0.Controls.Add(this.lblTitleSub0);
            this.panTitleSub0.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitleSub0.Location = new System.Drawing.Point(0, 71);
            this.panTitleSub0.Name = "panTitleSub0";
            this.panTitleSub0.Size = new System.Drawing.Size(1260, 28);
            this.panTitleSub0.TabIndex = 90;
            // 
            // lblTitleSub0
            // 
            this.lblTitleSub0.AutoSize = true;
            this.lblTitleSub0.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleSub0.ForeColor = System.Drawing.Color.White;
            this.lblTitleSub0.Location = new System.Drawing.Point(8, 6);
            this.lblTitleSub0.Name = "lblTitleSub0";
            this.lblTitleSub0.Size = new System.Drawing.Size(57, 12);
            this.lblTitleSub0.TabIndex = 0;
            this.lblTitleSub0.Text = "코드내역";
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.circProgress);
            this.panMain.Controls.Add(this.ssMain);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 99);
            this.panMain.Name = "panMain";
            this.panMain.Padding = new System.Windows.Forms.Padding(1);
            this.panMain.Size = new System.Drawing.Size(1260, 442);
            this.panMain.TabIndex = 91;
            // 
            // circProgress
            // 
            this.circProgress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.circProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circProgress.Location = new System.Drawing.Point(501, 93);
            this.circProgress.Name = "circProgress";
            this.circProgress.Size = new System.Drawing.Size(259, 256);
            this.circProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circProgress.TabIndex = 4;
            this.circProgress.Visible = false;
            // 
            // ssMain
            // 
            this.ssMain.AccessibleDescription = "ssMain, Sheet1, Row 0, Column 0, ";
            this.ssMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssMain.FocusRenderer = enhancedFocusIndicatorRenderer1;
            this.ssMain.HorizontalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.ssMain.HorizontalScrollBar.Name = "";
            this.ssMain.HorizontalScrollBar.Renderer = enhancedScrollBarRenderer1;
            this.ssMain.HorizontalScrollBar.TabIndex = 23;
            this.ssMain.Location = new System.Drawing.Point(1, 1);
            this.ssMain.Name = "ssMain";
            this.ssMain.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ssMain_Sheet1});
            this.ssMain.Size = new System.Drawing.Size(1258, 440);
            this.ssMain.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Office2007;
            this.ssMain.TabIndex = 0;
            this.ssMain.VerticalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.ssMain.VerticalScrollBar.Name = "";
            this.ssMain.VerticalScrollBar.Renderer = enhancedScrollBarRenderer2;
            this.ssMain.VerticalScrollBar.TabIndex = 24;
            // 
            // ssMain_Sheet1
            // 
            this.ssMain_Sheet1.Reset();
            this.ssMain_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.ssMain_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.ssMain_Sheet1.ColumnCount = 6;
            this.ssMain_Sheet1.RowCount = 3;
            this.ssMain_Sheet1.ColumnFooter.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssMain_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssMain_Sheet1.ColumnFooter.DefaultStyle.Parent = "ColumnFooterEnhanced";
            this.ssMain_Sheet1.ColumnFooter.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssMain_Sheet1.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssMain_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssMain_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerEnhanced";
            this.ssMain_Sheet1.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssMain_Sheet1.ColumnHeader.AutoText = FarPoint.Win.Spread.HeaderAutoText.Numbers;
            this.ssMain_Sheet1.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssMain_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssMain_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.ssMain_Sheet1.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssMain_Sheet1.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssMain_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssMain_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarEnhanced";
            this.ssMain_Sheet1.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssMain_Sheet1.FilterBarHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.ssMain_Sheet1.FilterBarHeaderStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ssMain_Sheet1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssMain_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssMain_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderEnhanced";
            this.ssMain_Sheet1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssMain_Sheet1.FilterBarHeaderStyle.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.ssMain_Sheet1.GrayAreaBackColor = System.Drawing.Color.White;
            this.ssMain_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.ssMain_Sheet1.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssMain_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssMain_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.ssMain_Sheet1.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssMain_Sheet1.SheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssMain_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssMain_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.ssMain_Sheet1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssMain_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // frmComSupInfcCODE01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 541);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panTitleSub0);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panTitle);
            this.Name = "frmComSupInfcCODE01";
            this.Text = "frmComSupInfcCODE01";
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panTitleSub0.ResumeLayout(false);
            this.panTitleSub0.PerformLayout();
            this.panMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ssMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssMain_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panTitleSub0;
        private System.Windows.Forms.Label lblTitleSub0;
        private System.Windows.Forms.Panel panMain;
        private FarPoint.Win.Spread.FpSpread ssMain;
        private FarPoint.Win.Spread.SheetView ssMain_Sheet1;
        private DevComponents.DotNetBar.Controls.CircularProgress circProgress;
        private System.Windows.Forms.Button btnAdd;
    }
}