﻿namespace ComPmpaLibB 
{
    partial class ComPmPaGwaSakPrintSTS
    {
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose ( bool disposing )
	{
	    if ( disposing && ( components != null ) )
	    {
		components . Dispose ( );
	    }
	    base . Dispose ( disposing );
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent ( )
	{
            FarPoint.Win.Spread.NamedStyle namedStyle1 = new FarPoint.Win.Spread.NamedStyle("Color354636408136152815061", "DataAreaDefault");
            FarPoint.Win.Spread.NamedStyle namedStyle2 = new FarPoint.Win.Spread.NamedStyle("Text456636408136152855094", "DataAreaDefault");
            FarPoint.Win.Spread.CellType.TextCellType textCellType1 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.NamedStyle namedStyle3 = new FarPoint.Win.Spread.NamedStyle("Static560636408136152895114");
            FarPoint.Win.Spread.CellType.TextCellType textCellType2 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.NamedStyle namedStyle4 = new FarPoint.Win.Spread.NamedStyle("Static596636408136152905108");
            FarPoint.Win.Spread.CellType.TextCellType textCellType3 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.TipAppearance tipAppearance1 = new FarPoint.Win.Spread.TipAppearance();
            this.panmain = new System.Windows.Forms.Panel();
            this.lblTitleSub0 = new System.Windows.Forms.Label();
            this.panTitle = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblyyyy = new System.Windows.Forms.Panel();
            this.panSub = new System.Windows.Forms.Panel();
            this.cboTdate = new System.Windows.Forms.ComboBox();
            this.cboFdate = new System.Windows.Forms.ComboBox();
            this.lblyydd = new System.Windows.Forms.Label();
            this.CboGel = new System.Windows.Forms.ComboBox();
            this.lbldoc = new System.Windows.Forms.Label();
            this.lbljewon = new System.Windows.Forms.Label();
            this.panTitleSub1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ssView = new FarPoint.Win.Spread.FpSpread();
            this.ssView_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panSSmain = new System.Windows.Forms.Panel();
            this.panmain.SuspendLayout();
            this.panTitle.SuspendLayout();
            this.lblyyyy.SuspendLayout();
            this.panSub.SuspendLayout();
            this.panTitleSub1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssView_Sheet1)).BeginInit();
            this.panSSmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panmain
            // 
            this.panmain.BackColor = System.Drawing.Color.RoyalBlue;
            this.panmain.Controls.Add(this.lblTitleSub0);
            this.panmain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panmain.Location = new System.Drawing.Point(0, 34);
            this.panmain.Name = "panmain";
            this.panmain.Size = new System.Drawing.Size(674, 28);
            this.panmain.TabIndex = 181;
            // 
            // lblTitleSub0
            // 
            this.lblTitleSub0.AutoSize = true;
            this.lblTitleSub0.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleSub0.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleSub0.ForeColor = System.Drawing.Color.White;
            this.lblTitleSub0.Location = new System.Drawing.Point(4, 6);
            this.lblTitleSub0.Name = "lblTitleSub0";
            this.lblTitleSub0.Size = new System.Drawing.Size(34, 17);
            this.lblTitleSub0.TabIndex = 22;
            this.lblTitleSub0.Text = "조건";
            this.lblTitleSub0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.Color.White;
            this.panTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panTitle.Controls.Add(this.label15);
            this.panTitle.Controls.Add(this.btnExit);
            this.panTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitle.ForeColor = System.Drawing.Color.White;
            this.panTitle.Location = new System.Drawing.Point(0, 0);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(674, 34);
            this.panTitle.TabIndex = 180;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(3, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 21);
            this.label15.TabIndex = 83;
            this.label15.Text = "진료과별 삭감율";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(598, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 30);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "닫기";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btncansel_Click);
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnView.Location = new System.Drawing.Point(530, 0);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(72, 32);
            this.btnView.TabIndex = 77;
            this.btnView.Text = "조회";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = true;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrint.Location = new System.Drawing.Point(602, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(72, 32);
            this.btnPrint.TabIndex = 80;
            this.btnPrint.Text = "인쇄";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblyyyy
            // 
            this.lblyyyy.BackColor = System.Drawing.SystemColors.Window;
            this.lblyyyy.Controls.Add(this.panSub);
            this.lblyyyy.Controls.Add(this.btnView);
            this.lblyyyy.Controls.Add(this.btnPrint);
            this.lblyyyy.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblyyyy.Location = new System.Drawing.Point(0, 62);
            this.lblyyyy.Name = "lblyyyy";
            this.lblyyyy.Size = new System.Drawing.Size(674, 32);
            this.lblyyyy.TabIndex = 182;
            // 
            // panSub
            // 
            this.panSub.Controls.Add(this.cboTdate);
            this.panSub.Controls.Add(this.cboFdate);
            this.panSub.Controls.Add(this.lblyydd);
            this.panSub.Controls.Add(this.CboGel);
            this.panSub.Controls.Add(this.lbldoc);
            this.panSub.Controls.Add(this.lbljewon);
            this.panSub.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSub.Location = new System.Drawing.Point(0, 0);
            this.panSub.Name = "panSub";
            this.panSub.Size = new System.Drawing.Size(439, 32);
            this.panSub.TabIndex = 90;
            // 
            // cboTdate
            // 
            this.cboTdate.FormattingEnabled = true;
            this.cboTdate.Location = new System.Drawing.Point(158, 7);
            this.cboTdate.Name = "cboTdate";
            this.cboTdate.Size = new System.Drawing.Size(75, 20);
            this.cboTdate.TabIndex = 108;
            // 
            // cboFdate
            // 
            this.cboFdate.FormattingEnabled = true;
            this.cboFdate.Location = new System.Drawing.Point(69, 6);
            this.cboFdate.Name = "cboFdate";
            this.cboFdate.Size = new System.Drawing.Size(75, 20);
            this.cboFdate.TabIndex = 107;
            // 
            // lblyydd
            // 
            this.lblyydd.AutoSize = true;
            this.lblyydd.Location = new System.Drawing.Point(145, 12);
            this.lblyydd.Name = "lblyydd";
            this.lblyydd.Size = new System.Drawing.Size(14, 12);
            this.lblyydd.TabIndex = 106;
            this.lblyydd.Text = "~";
            // 
            // CboGel
            // 
            this.CboGel.FormattingEnabled = true;
            this.CboGel.Location = new System.Drawing.Point(322, 6);
            this.CboGel.Name = "CboGel";
            this.CboGel.Size = new System.Drawing.Size(85, 20);
            this.CboGel.TabIndex = 104;
            // 
            // lbldoc
            // 
            this.lbldoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldoc.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbldoc.ForeColor = System.Drawing.Color.Black;
            this.lbldoc.Location = new System.Drawing.Point(265, 4);
            this.lbldoc.Name = "lbldoc";
            this.lbldoc.Size = new System.Drawing.Size(56, 23);
            this.lbldoc.TabIndex = 96;
            this.lbldoc.Text = "계 약 처";
            this.lbldoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbljewon
            // 
            this.lbljewon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbljewon.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbljewon.ForeColor = System.Drawing.Color.Black;
            this.lbljewon.Location = new System.Drawing.Point(6, 5);
            this.lbljewon.Name = "lbljewon";
            this.lbljewon.Size = new System.Drawing.Size(62, 23);
            this.lbljewon.TabIndex = 90;
            this.lbljewon.Text = "작업년월";
            this.lbljewon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panTitleSub1
            // 
            this.panTitleSub1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panTitleSub1.Controls.Add(this.label1);
            this.panTitleSub1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitleSub1.Location = new System.Drawing.Point(0, 94);
            this.panTitleSub1.Name = "panTitleSub1";
            this.panTitleSub1.Size = new System.Drawing.Size(674, 28);
            this.panTitleSub1.TabIndex = 183;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "결과";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ssView
            // 
            this.ssView.AccessibleDescription = "ssView, Sheet1, Row 0, Column 0, ";
            this.ssView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssView.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ssView.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never;
            this.ssView.Location = new System.Drawing.Point(0, 0);
            this.ssView.Name = "ssView";
            namedStyle1.Font = new System.Drawing.Font("굴림체", 9F);
            namedStyle1.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            namedStyle1.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle1.Parent = "DataAreaDefault";
            namedStyle1.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            textCellType1.MaxLength = 60;
            namedStyle2.CellType = textCellType1;
            namedStyle2.Font = new System.Drawing.Font("굴림체", 9F);
            namedStyle2.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            namedStyle2.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle2.Parent = "DataAreaDefault";
            namedStyle2.Renderer = textCellType1;
            namedStyle2.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            textCellType2.Static = true;
            namedStyle3.CellType = textCellType2;
            namedStyle3.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            namedStyle3.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle3.Renderer = textCellType2;
            namedStyle3.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            textCellType3.Static = true;
            namedStyle4.CellType = textCellType3;
            namedStyle4.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
            namedStyle4.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle4.Renderer = textCellType3;
            namedStyle4.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssView.NamedStyles.AddRange(new FarPoint.Win.Spread.NamedStyle[] {
            namedStyle1,
            namedStyle2,
            namedStyle3,
            namedStyle4});
            this.ssView.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ssView_Sheet1});
            this.ssView.Size = new System.Drawing.Size(674, 313);
            this.ssView.TabIndex = 166;
            this.ssView.TabStripRatio = 0.6D;
            tipAppearance1.BackColor = System.Drawing.SystemColors.Info;
            tipAppearance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            tipAppearance1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ssView.TextTipAppearance = tipAppearance1;
            this.ssView.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            // 
            // ssView_Sheet1
            // 
            this.ssView_Sheet1.Reset();
            this.ssView_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.ssView_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.ssView_Sheet1.ColumnCount = 6;
            this.ssView_Sheet1.RowCount = 20;
            this.ssView_Sheet1.ColumnFooter.Columns.Default.SortIndicator = FarPoint.Win.Spread.Model.SortIndicator.None;
            this.ssView_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "진 료 과";
            this.ssView_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "청 구 액";
            this.ssView_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "입 금 액";
            this.ssView_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "삭 감 액";
            this.ssView_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "삭감율";
            this.ssView_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "비고";
            this.ssView_Sheet1.ColumnHeader.Columns.Default.SortIndicator = FarPoint.Win.Spread.Model.SortIndicator.None;
            this.ssView_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ssView_Sheet1.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssView_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssView_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced";
            this.ssView_Sheet1.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssView_Sheet1.ColumnHeader.Rows.Get(0).Height = 26F;
            this.ssView_Sheet1.Columns.Default.SortIndicator = FarPoint.Win.Spread.Model.SortIndicator.None;
            this.ssView_Sheet1.Columns.Get(0).Label = "진 료 과";
            this.ssView_Sheet1.Columns.Get(0).StyleName = "Static560636408136152895114";
            this.ssView_Sheet1.Columns.Get(0).Width = 118F;
            this.ssView_Sheet1.Columns.Get(1).Label = "청 구 액";
            this.ssView_Sheet1.Columns.Get(1).StyleName = "Static596636408136152905108";
            this.ssView_Sheet1.Columns.Get(1).Width = 117F;
            this.ssView_Sheet1.Columns.Get(2).Label = "입 금 액";
            this.ssView_Sheet1.Columns.Get(2).StyleName = "Static596636408136152905108";
            this.ssView_Sheet1.Columns.Get(2).Width = 118F;
            this.ssView_Sheet1.Columns.Get(3).Label = "삭 감 액";
            this.ssView_Sheet1.Columns.Get(3).StyleName = "Static596636408136152905108";
            this.ssView_Sheet1.Columns.Get(3).Width = 113F;
            this.ssView_Sheet1.Columns.Get(4).Label = "삭감율";
            this.ssView_Sheet1.Columns.Get(4).StyleName = "Static596636408136152905108";
            this.ssView_Sheet1.Columns.Get(4).Width = 80F;
            this.ssView_Sheet1.Columns.Get(5).Label = "비고";
            this.ssView_Sheet1.Columns.Get(5).StyleName = "Static560636408136152895114";
            this.ssView_Sheet1.Columns.Get(5).Width = 69F;
            this.ssView_Sheet1.DefaultStyleName = "Text456636408136152855094";
            this.ssView_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.ssView_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ssView_Sheet1.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssView_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssView_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefaultEnhanced";
            this.ssView_Sheet1.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssView_Sheet1.Rows.Default.Height = 24F;
            this.ssView_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ssView_Sheet1.SheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssView_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssView_Sheet1.SheetCornerStyle.Parent = "CornerDefaultEnhanced";
            this.ssView_Sheet1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssView_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panSSmain
            // 
            this.panSSmain.Controls.Add(this.ssView);
            this.panSSmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panSSmain.Location = new System.Drawing.Point(0, 122);
            this.panSSmain.Name = "panSSmain";
            this.panSSmain.Size = new System.Drawing.Size(674, 313);
            this.panSSmain.TabIndex = 184;
            // 
            // ComPmPaGwaSakPrintSTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 435);
            this.Controls.Add(this.panSSmain);
            this.Controls.Add(this.panTitleSub1);
            this.Controls.Add(this.lblyyyy);
            this.Controls.Add(this.panmain);
            this.Controls.Add(this.panTitle);
            this.Name = "ComPmPaGwaSakPrintSTS";
            this.Text = "진료과별 삭감율";
            this.Load += new System.EventHandler(this.ComPmPaGwaSakPrintSTS_Load);
            this.panmain.ResumeLayout(false);
            this.panmain.PerformLayout();
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.lblyyyy.ResumeLayout(false);
            this.lblyyyy.PerformLayout();
            this.panSub.ResumeLayout(false);
            this.panSub.PerformLayout();
            this.panTitleSub1.ResumeLayout(false);
            this.panTitleSub1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssView_Sheet1)).EndInit();
            this.panSSmain.ResumeLayout(false);
            this.ResumeLayout(false);

	}

	#endregion

	private System . Windows . Forms . Panel panmain;
	private System . Windows . Forms . Label lblTitleSub0;
	private System . Windows . Forms . Panel panTitle;
	private System . Windows . Forms . Label label15;
	public System . Windows . Forms . Button btnExit;
	private System . Windows . Forms . Button btnView;
	private System . Windows . Forms . Button btnPrint;
	private System . Windows . Forms . Panel lblyyyy;
	private System . Windows . Forms . Panel panSub;
	private System . Windows . Forms . ComboBox CboGel;
	private System . Windows . Forms . Label lbldoc;
	private System . Windows . Forms . Label lbljewon;
	private System . Windows . Forms . Panel panTitleSub1;
	private System . Windows . Forms . Label label1;
	private FarPoint . Win . Spread . FpSpread ssView;
	private FarPoint . Win . Spread . SheetView ssView_Sheet1;
	private System . Windows . Forms . Panel panSSmain;
	private System . Windows . Forms . Label lblyydd;
	private System . Windows . Forms . ComboBox cboTdate;
	private System . Windows . Forms . ComboBox cboFdate;
    }
}