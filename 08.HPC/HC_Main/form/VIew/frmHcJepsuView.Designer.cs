﻿namespace HC_Main
{
    partial class frmHcJepsuView
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
            FarPoint.Win.Spread.FlatFocusIndicatorRenderer flatFocusIndicatorRenderer2 = new FarPoint.Win.Spread.FlatFocusIndicatorRenderer();
            FarPoint.Win.Spread.FlatScrollBarRenderer flatScrollBarRenderer3 = new FarPoint.Win.Spread.FlatScrollBarRenderer();
            FarPoint.Win.Spread.FlatScrollBarRenderer flatScrollBarRenderer4 = new FarPoint.Win.Spread.FlatScrollBarRenderer();
            this.panTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panSub01 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.lblSub04 = new System.Windows.Forms.Label();
            this.panSub04 = new System.Windows.Forms.Panel();
            this.btnLtdHelp = new System.Windows.Forms.Button();
            this.txtLtdName = new System.Windows.Forms.TextBox();
            this.lblSub03 = new System.Windows.Forms.Label();
            this.panSub03 = new System.Windows.Forms.Panel();
            this.cboJong = new System.Windows.Forms.ComboBox();
            this.lblSub02 = new System.Windows.Forms.Label();
            this.panSub02 = new System.Windows.Forms.Panel();
            this.dtpTDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFDate = new System.Windows.Forms.DateTimePicker();
            this.lblSub01 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.Progress = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.SSList = new FarPoint.Win.Spread.FpSpread();
            this.SSList_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkHabit = new System.Windows.Forms.CheckBox();
            this.chkResv = new System.Windows.Forms.CheckBox();
            this.chkEndo = new System.Windows.Forms.CheckBox();
            this.chkDel = new System.Windows.Forms.CheckBox();
            this.chkKaTalk = new System.Windows.Forms.CheckBox();
            this.chkJongGum = new System.Windows.Forms.CheckBox();
            this.chkChul = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkJumin = new System.Windows.Forms.CheckBox();
            this.panTitle.SuspendLayout();
            this.panSub01.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panSub04.SuspendLayout();
            this.panSub03.SuspendLayout();
            this.panSub02.SuspendLayout();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SSList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSList_Sheet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitle.Location = new System.Drawing.Point(0, 0);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(1204, 40);
            this.panTitle.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(3, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 21);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "검진접수 내역 조회";
            // 
            // panSub01
            // 
            this.panSub01.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panSub01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSub01.Controls.Add(this.panel1);
            this.panSub01.Controls.Add(this.lblSub04);
            this.panSub01.Controls.Add(this.panSub04);
            this.panSub01.Controls.Add(this.lblSub03);
            this.panSub01.Controls.Add(this.panSub03);
            this.panSub01.Controls.Add(this.lblSub02);
            this.panSub01.Controls.Add(this.panSub02);
            this.panSub01.Controls.Add(this.lblSub01);
            this.panSub01.Controls.Add(this.btnSearch);
            this.panSub01.Controls.Add(this.btnExit);
            this.panSub01.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSub01.Location = new System.Drawing.Point(0, 40);
            this.panSub01.Name = "panSub01";
            this.panSub01.Padding = new System.Windows.Forms.Padding(1);
            this.panSub01.Size = new System.Drawing.Size(1204, 35);
            this.panSub01.TabIndex = 133;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.panel1.Location = new System.Drawing.Point(797, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 31);
            this.panel1.TabIndex = 50;
            // 
            // txtSName
            // 
            this.txtSName.BackColor = System.Drawing.Color.White;
            this.txtSName.Location = new System.Drawing.Point(3, 3);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(86, 25);
            this.txtSName.TabIndex = 0;
            this.txtSName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSub04
            // 
            this.lblSub04.BackColor = System.Drawing.Color.LightBlue;
            this.lblSub04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSub04.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSub04.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSub04.Location = new System.Drawing.Point(734, 1);
            this.lblSub04.Name = "lblSub04";
            this.lblSub04.Size = new System.Drawing.Size(63, 31);
            this.lblSub04.TabIndex = 49;
            this.lblSub04.Text = "수검자명";
            this.lblSub04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panSub04
            // 
            this.panSub04.Controls.Add(this.btnLtdHelp);
            this.panSub04.Controls.Add(this.txtLtdName);
            this.panSub04.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSub04.Location = new System.Drawing.Point(533, 1);
            this.panSub04.Name = "panSub04";
            this.panSub04.Size = new System.Drawing.Size(201, 31);
            this.panSub04.TabIndex = 48;
            // 
            // btnLtdHelp
            // 
            this.btnLtdHelp.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLtdHelp.Location = new System.Drawing.Point(170, 3);
            this.btnLtdHelp.Name = "btnLtdHelp";
            this.btnLtdHelp.Size = new System.Drawing.Size(26, 25);
            this.btnLtdHelp.TabIndex = 92;
            this.btnLtdHelp.Text = "&H";
            this.btnLtdHelp.UseVisualStyleBackColor = true;
            // 
            // txtLtdName
            // 
            this.txtLtdName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtLtdName.Location = new System.Drawing.Point(3, 3);
            this.txtLtdName.Name = "txtLtdName";
            this.txtLtdName.Size = new System.Drawing.Size(165, 25);
            this.txtLtdName.TabIndex = 91;
            this.txtLtdName.Tag = "";
            this.txtLtdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSub03
            // 
            this.lblSub03.BackColor = System.Drawing.Color.LightBlue;
            this.lblSub03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSub03.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSub03.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSub03.Location = new System.Drawing.Point(470, 1);
            this.lblSub03.Name = "lblSub03";
            this.lblSub03.Size = new System.Drawing.Size(63, 31);
            this.lblSub03.TabIndex = 47;
            this.lblSub03.Text = "회사코드";
            this.lblSub03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panSub03
            // 
            this.panSub03.Controls.Add(this.cboJong);
            this.panSub03.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSub03.Location = new System.Drawing.Point(317, 1);
            this.panSub03.Name = "panSub03";
            this.panSub03.Size = new System.Drawing.Size(153, 31);
            this.panSub03.TabIndex = 46;
            // 
            // cboJong
            // 
            this.cboJong.FormattingEnabled = true;
            this.cboJong.Location = new System.Drawing.Point(3, 3);
            this.cboJong.Name = "cboJong";
            this.cboJong.Size = new System.Drawing.Size(147, 25);
            this.cboJong.TabIndex = 0;
            // 
            // lblSub02
            // 
            this.lblSub02.BackColor = System.Drawing.Color.LightBlue;
            this.lblSub02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSub02.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSub02.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSub02.Location = new System.Drawing.Point(254, 1);
            this.lblSub02.Name = "lblSub02";
            this.lblSub02.Size = new System.Drawing.Size(63, 31);
            this.lblSub02.TabIndex = 45;
            this.lblSub02.Text = "검진종류";
            this.lblSub02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panSub02
            // 
            this.panSub02.Controls.Add(this.dtpTDate);
            this.panSub02.Controls.Add(this.dtpFDate);
            this.panSub02.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSub02.Location = new System.Drawing.Point(64, 1);
            this.panSub02.Name = "panSub02";
            this.panSub02.Size = new System.Drawing.Size(190, 31);
            this.panSub02.TabIndex = 44;
            // 
            // dtpTDate
            // 
            this.dtpTDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTDate.Location = new System.Drawing.Point(97, 3);
            this.dtpTDate.Name = "dtpTDate";
            this.dtpTDate.Size = new System.Drawing.Size(88, 25);
            this.dtpTDate.TabIndex = 1;
            // 
            // dtpFDate
            // 
            this.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFDate.Location = new System.Drawing.Point(3, 3);
            this.dtpFDate.Name = "dtpFDate";
            this.dtpFDate.Size = new System.Drawing.Size(88, 25);
            this.dtpFDate.TabIndex = 0;
            // 
            // lblSub01
            // 
            this.lblSub01.BackColor = System.Drawing.Color.LightBlue;
            this.lblSub01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSub01.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSub01.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSub01.Location = new System.Drawing.Point(1, 1);
            this.lblSub01.Name = "lblSub01";
            this.lblSub01.Size = new System.Drawing.Size(63, 31);
            this.lblSub01.TabIndex = 43;
            this.lblSub01.Text = "접수일자";
            this.lblSub01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(1037, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 31);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "조 회(&V)";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.Location = new System.Drawing.Point(1119, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 31);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "닫 기(&X)";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // panMain
            // 
            this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMain.Controls.Add(this.Progress);
            this.panMain.Controls.Add(this.SSList);
            this.panMain.Controls.Add(this.panel2);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 75);
            this.panMain.Name = "panMain";
            this.panMain.Padding = new System.Windows.Forms.Padding(1);
            this.panMain.Size = new System.Drawing.Size(1204, 718);
            this.panMain.TabIndex = 134;
            // 
            // Progress
            // 
            this.Progress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.Progress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Progress.Location = new System.Drawing.Point(501, 258);
            this.Progress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Progress.Name = "Progress";
            this.Progress.ProgressColor = System.Drawing.Color.DarkBlue;
            this.Progress.Size = new System.Drawing.Size(200, 200);
            this.Progress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.Progress.TabIndex = 145;
            this.Progress.Visible = false;
            // 
            // SSList
            // 
            this.SSList.AccessibleDescription = "SSList, Sheet1, Row 0, Column 0, ";
            this.SSList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SSList.FocusRenderer = flatFocusIndicatorRenderer2;
            this.SSList.HorizontalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.SSList.HorizontalScrollBar.Name = "";
            flatScrollBarRenderer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SSList.HorizontalScrollBar.Renderer = flatScrollBarRenderer3;
            this.SSList.HorizontalScrollBar.TabIndex = 87;
            this.SSList.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.SSList.Location = new System.Drawing.Point(1, 31);
            this.SSList.Name = "SSList";
            this.SSList.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.SSList_Sheet1});
            this.SSList.Size = new System.Drawing.Size(1200, 684);
            this.SSList.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Office2013;
            this.SSList.TabIndex = 144;
            this.SSList.VerticalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.SSList.VerticalScrollBar.Name = "";
            flatScrollBarRenderer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SSList.VerticalScrollBar.Renderer = flatScrollBarRenderer4;
            this.SSList.VerticalScrollBar.TabIndex = 88;
            this.SSList.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            // 
            // SSList_Sheet1
            // 
            this.SSList_Sheet1.Reset();
            this.SSList_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.SSList_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.SSList_Sheet1.ColumnCount = 5;
            this.SSList_Sheet1.RowCount = 1;
            this.SSList_Sheet1.ColumnFooter.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.SSList_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.SSList_Sheet1.ColumnFooter.DefaultStyle.Parent = "ColumnFooterFlat";
            this.SSList_Sheet1.ColumnFooter.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.SSList_Sheet1.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.SSList_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.SSList_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerFooterFlat";
            this.SSList_Sheet1.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.SSList_Sheet1.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.SSList_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.SSList_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderFlat";
            this.SSList_Sheet1.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.SSList_Sheet1.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.SSList_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.SSList_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarFlat";
            this.SSList_Sheet1.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.SSList_Sheet1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.SSList_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.SSList_Sheet1.FilterBarHeaderStyle.Parent = "FilterBarHeaderFlat";
            this.SSList_Sheet1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.SSList_Sheet1.HorizontalGridLine = new FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.Flat, System.Drawing.Color.Gray);
            this.SSList_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.SSList_Sheet1.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.SSList_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.SSList_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderFlat";
            this.SSList_Sheet1.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.SSList_Sheet1.Rows.Get(0).Height = 24F;
            this.SSList_Sheet1.SheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.SSList_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.SSList_Sheet1.SheetCornerStyle.Parent = "CornerHeaderFlat";
            this.SSList_Sheet1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.SSList_Sheet1.VerticalGridLine = new FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.Flat, System.Drawing.Color.Gray);
            this.SSList_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chkJumin);
            this.panel2.Controls.Add(this.chkHabit);
            this.panel2.Controls.Add(this.chkResv);
            this.panel2.Controls.Add(this.chkEndo);
            this.panel2.Controls.Add(this.chkDel);
            this.panel2.Controls.Add(this.chkKaTalk);
            this.panel2.Controls.Add(this.chkJongGum);
            this.panel2.Controls.Add(this.chkChul);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(1200, 30);
            this.panel2.TabIndex = 142;
            // 
            // chkHabit
            // 
            this.chkHabit.AutoSize = true;
            this.chkHabit.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkHabit.Location = new System.Drawing.Point(482, 1);
            this.chkHabit.Name = "chkHabit";
            this.chkHabit.Size = new System.Drawing.Size(79, 26);
            this.chkHabit.TabIndex = 70;
            this.chkHabit.Text = "생활습관";
            this.chkHabit.UseVisualStyleBackColor = true;
            // 
            // chkResv
            // 
            this.chkResv.AutoSize = true;
            this.chkResv.Checked = true;
            this.chkResv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkResv.Location = new System.Drawing.Point(795, 2);
            this.chkResv.Name = "chkResv";
            this.chkResv.Size = new System.Drawing.Size(79, 21);
            this.chkResv.TabIndex = 69;
            this.chkResv.Text = "화면갱신";
            this.chkResv.UseVisualStyleBackColor = true;
            // 
            // chkEndo
            // 
            this.chkEndo.AutoSize = true;
            this.chkEndo.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkEndo.ForeColor = System.Drawing.Color.Blue;
            this.chkEndo.Location = new System.Drawing.Point(390, 1);
            this.chkEndo.Name = "chkEndo";
            this.chkEndo.Size = new System.Drawing.Size(92, 26);
            this.chkEndo.TabIndex = 58;
            this.chkEndo.Text = "내시경대상";
            this.chkEndo.UseVisualStyleBackColor = true;
            // 
            // chkDel
            // 
            this.chkDel.AutoSize = true;
            this.chkDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkDel.Location = new System.Drawing.Point(311, 1);
            this.chkDel.Name = "chkDel";
            this.chkDel.Size = new System.Drawing.Size(79, 26);
            this.chkDel.TabIndex = 57;
            this.chkDel.Text = "접수취소";
            this.chkDel.UseVisualStyleBackColor = true;
            // 
            // chkKaTalk
            // 
            this.chkKaTalk.AutoSize = true;
            this.chkKaTalk.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkKaTalk.Location = new System.Drawing.Point(232, 1);
            this.chkKaTalk.Name = "chkKaTalk";
            this.chkKaTalk.Size = new System.Drawing.Size(79, 26);
            this.chkKaTalk.TabIndex = 56;
            this.chkKaTalk.Text = "카톡결과";
            this.chkKaTalk.UseVisualStyleBackColor = true;
            // 
            // chkJongGum
            // 
            this.chkJongGum.AutoSize = true;
            this.chkJongGum.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkJongGum.Location = new System.Drawing.Point(153, 1);
            this.chkJongGum.Name = "chkJongGum";
            this.chkJongGum.Size = new System.Drawing.Size(79, 26);
            this.chkJongGum.TabIndex = 55;
            this.chkJongGum.Text = "종검접수";
            this.chkJongGum.UseVisualStyleBackColor = true;
            // 
            // chkChul
            // 
            this.chkChul.AutoSize = true;
            this.chkChul.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkChul.Location = new System.Drawing.Point(74, 1);
            this.chkChul.Name = "chkChul";
            this.chkChul.Size = new System.Drawing.Size(79, 26);
            this.chkChul.TabIndex = 54;
            this.chkChul.Text = "출장검진";
            this.chkChul.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(64, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 26);
            this.panel3.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 52;
            this.label1.Text = "조회옵션";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkJumin
            // 
            this.chkJumin.AutoSize = true;
            this.chkJumin.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkJumin.Location = new System.Drawing.Point(561, 1);
            this.chkJumin.Name = "chkJumin";
            this.chkJumin.Size = new System.Drawing.Size(105, 26);
            this.chkJumin.TabIndex = 71;
            this.chkJumin.Text = "주민번호표시";
            this.chkJumin.UseVisualStyleBackColor = true;
            this.chkJumin.Visible = false;
            // 
            // frmHcJepsuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 793);
            this.ControlBox = false;
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panSub01);
            this.Controls.Add(this.panTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHcJepsuView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "접수명단 조회(일반)";
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.panSub01.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSub04.ResumeLayout(false);
            this.panSub04.PerformLayout();
            this.panSub03.ResumeLayout(false);
            this.panSub02.ResumeLayout(false);
            this.panMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SSList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSList_Sheet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panSub01;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panSub02;
        private System.Windows.Forms.DateTimePicker dtpTDate;
        private System.Windows.Forms.DateTimePicker dtpFDate;
        private System.Windows.Forms.Label lblSub01;
        private System.Windows.Forms.Panel panSub04;
        private System.Windows.Forms.Label lblSub03;
        private System.Windows.Forms.Panel panSub03;
        private System.Windows.Forms.ComboBox cboJong;
        private System.Windows.Forms.Label lblSub02;
        private System.Windows.Forms.Button btnLtdHelp;
        private System.Windows.Forms.TextBox txtLtdName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label lblSub04;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkKaTalk;
        private System.Windows.Forms.CheckBox chkJongGum;
        private System.Windows.Forms.CheckBox chkChul;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDel;
        private DevComponents.DotNetBar.Controls.CircularProgress Progress;
        private FarPoint.Win.Spread.FpSpread SSList;
        private FarPoint.Win.Spread.SheetView SSList_Sheet1;
        private System.Windows.Forms.CheckBox chkEndo;
        private System.Windows.Forms.CheckBox chkResv;
        private System.Windows.Forms.CheckBox chkHabit;
        private System.Windows.Forms.CheckBox chkJumin;
    }
}