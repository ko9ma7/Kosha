﻿namespace ComPmpaLibB
{
    partial class frmPmpaEntryJunior
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
            FarPoint.Win.Spread.InputMap ssFind_InputMapWhenFocusedNormal;
            FarPoint.Win.Spread.CellType.TextCellType textCellType1 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer enhancedFocusIndicatorRenderer2 = new FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer();
            FarPoint.Win.Spread.EnhancedScrollBarRenderer enhancedScrollBarRenderer3 = new FarPoint.Win.Spread.EnhancedScrollBarRenderer();
            FarPoint.Win.Spread.EnhancedScrollBarRenderer enhancedScrollBarRenderer4 = new FarPoint.Win.Spread.EnhancedScrollBarRenderer();
            FarPoint.Win.Spread.InputMap ssList_InputMapWhenFocusedNormal;
            FarPoint.Win.Spread.CellType.TextCellType textCellType2 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType3 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType4 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType5 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType6 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType7 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType8 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType9 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType10 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.ButtonCellType buttonCellType1 = new FarPoint.Win.Spread.CellType.ButtonCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType11 = new FarPoint.Win.Spread.CellType.TextCellType();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpTDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.grpFind = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.ssFind = new FarPoint.Win.Spread.FpSpread();
            this.ssFind_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.ssList = new FarPoint.Win.Spread.FpSpread();
            this.ssList_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ssFind_InputMapWhenFocusedNormal = new FarPoint.Win.Spread.InputMap();
            ssList_InputMapWhenFocusedNormal = new FarPoint.Win.Spread.InputMap();
            this.pnlTop.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.grpFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssFind_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssList_Sheet1)).BeginInit();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Window;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.btnSave);
            this.pnlTop.Controls.Add(this.dtpTDate);
            this.pnlTop.Controls.Add(this.dtpFDate);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.cboYear);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.btnCancel);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 30);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(4);
            this.pnlTop.Size = new System.Drawing.Size(1195, 40);
            this.pnlTop.TabIndex = 196;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(857, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 30);
            this.btnSearch.TabIndex = 213;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(940, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 30);
            this.btnSave.TabIndex = 212;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpTDate
            // 
            this.dtpTDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTDate.Location = new System.Drawing.Point(361, 9);
            this.dtpTDate.Name = "dtpTDate";
            this.dtpTDate.Size = new System.Drawing.Size(100, 21);
            this.dtpTDate.TabIndex = 210;
            // 
            // dtpFDate
            // 
            this.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFDate.Location = new System.Drawing.Point(255, 9);
            this.dtpFDate.Name = "dtpFDate";
            this.dtpFDate.Size = new System.Drawing.Size(100, 21);
            this.dtpFDate.TabIndex = 209;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 208;
            this.label1.Text = "수납일자";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(71, 9);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(97, 20);
            this.cboYear.TabIndex = 207;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 206;
            this.label3.Text = "작업년도";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(1023, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 30);
            this.btnCancel.TabIndex = 198;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Window;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(1106, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 30);
            this.btnExit.TabIndex = 197;
            this.btnExit.Text = "닫기";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.SystemColors.Window;
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBody.Controls.Add(this.grpFind);
            this.pnlBody.Controls.Add(this.ssList);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 70);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1195, 421);
            this.pnlBody.TabIndex = 197;
            // 
            // grpFind
            // 
            this.grpFind.Controls.Add(this.btnApply);
            this.grpFind.Controls.Add(this.ssFind);
            this.grpFind.Location = new System.Drawing.Point(865, 12);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(327, 424);
            this.grpFind.TabIndex = 201;
            this.grpFind.TabStop = false;
            this.grpFind.Text = "찾기내용";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.Window;
            this.btnApply.Location = new System.Drawing.Point(234, 20);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(83, 30);
            this.btnApply.TabIndex = 203;
            this.btnApply.Text = "적용";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // ssFind
            // 
            this.ssFind.AccessibleDescription = "ssFind, Sheet1, Row 0, Column 0, ";
            this.ssFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ssFind.FocusRenderer = enhancedFocusIndicatorRenderer1;
            this.ssFind.HorizontalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.ssFind.HorizontalScrollBar.Name = "";
            this.ssFind.HorizontalScrollBar.Renderer = enhancedScrollBarRenderer1;
            this.ssFind.HorizontalScrollBar.TabIndex = 78;
            this.ssFind.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.ssFind.Location = new System.Drawing.Point(10, 63);
            this.ssFind.Name = "ssFind";
            this.ssFind.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ssFind_Sheet1});
            this.ssFind.Size = new System.Drawing.Size(308, 333);
            this.ssFind.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Office2007;
            this.ssFind.TabIndex = 202;
            this.ssFind.VerticalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.ssFind.VerticalScrollBar.Name = "";
            this.ssFind.VerticalScrollBar.Renderer = enhancedScrollBarRenderer2;
            this.ssFind.VerticalScrollBar.TabIndex = 79;
            this.ssFind.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            ssFind_InputMapWhenFocusedNormal.Put(new FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Return, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumn);
            this.ssFind.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, ssFind_InputMapWhenFocusedNormal);
            this.ssFind.SetViewportLeftColumn(0, 0, 1);
            this.ssFind.SetActiveViewport(0, 0, -1);
            // 
            // ssFind_Sheet1
            // 
            this.ssFind_Sheet1.Reset();
            this.ssFind_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.ssFind_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.ssFind_Sheet1.ColumnCount = 1;
            this.ssFind_Sheet1.RowCount = 5;
            this.ssFind_Sheet1.ColumnFooter.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssFind_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssFind_Sheet1.ColumnFooter.DefaultStyle.Parent = "ColumnFooterEnhanced";
            this.ssFind_Sheet1.ColumnFooter.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssFind_Sheet1.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssFind_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssFind_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerEnhanced";
            this.ssFind_Sheet1.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssFind_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "정보";
            this.ssFind_Sheet1.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssFind_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssFind_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.ssFind_Sheet1.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssFind_Sheet1.Columns.Get(0).CellType = textCellType1;
            this.ssFind_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            this.ssFind_Sheet1.Columns.Get(0).Label = "정보";
            this.ssFind_Sheet1.Columns.Get(0).Locked = true;
            this.ssFind_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssFind_Sheet1.Columns.Get(0).Width = 177F;
            this.ssFind_Sheet1.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssFind_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssFind_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarEnhanced";
            this.ssFind_Sheet1.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssFind_Sheet1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssFind_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssFind_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderEnhanced";
            this.ssFind_Sheet1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssFind_Sheet1.FrozenColumnCount = 4;
            this.ssFind_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.ReadOnly;
            this.ssFind_Sheet1.RowHeader.Cells.Get(0, 0).Value = "참고사항";
            this.ssFind_Sheet1.RowHeader.Cells.Get(1, 0).Value = "신생아 이름";
            this.ssFind_Sheet1.RowHeader.Cells.Get(2, 0).Value = "엄마 등록번호";
            this.ssFind_Sheet1.RowHeader.Cells.Get(3, 0).Value = "엄마 주민번호(앞)";
            this.ssFind_Sheet1.RowHeader.Cells.Get(4, 0).Value = "엄마 주민번호(뒤)";
            this.ssFind_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.ssFind_Sheet1.RowHeader.Columns.Get(0).Width = 122F;
            this.ssFind_Sheet1.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssFind_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssFind_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.ssFind_Sheet1.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssFind_Sheet1.Rows.Get(0).Height = 26F;
            this.ssFind_Sheet1.Rows.Get(0).Label = "참고사항";
            this.ssFind_Sheet1.Rows.Get(1).Height = 26F;
            this.ssFind_Sheet1.Rows.Get(1).Label = "신생아 이름";
            this.ssFind_Sheet1.Rows.Get(2).Height = 26F;
            this.ssFind_Sheet1.Rows.Get(2).Label = "엄마 등록번호";
            this.ssFind_Sheet1.Rows.Get(3).Height = 26F;
            this.ssFind_Sheet1.Rows.Get(3).Label = "엄마 주민번호(앞)";
            this.ssFind_Sheet1.Rows.Get(4).Height = 26F;
            this.ssFind_Sheet1.Rows.Get(4).Label = "엄마 주민번호(뒤)";
            this.ssFind_Sheet1.SheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssFind_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssFind_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.ssFind_Sheet1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssFind_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // ssList
            // 
            this.ssList.AccessibleDescription = "ssList, Sheet1, Row 0, Column 0, ";
            this.ssList.FocusRenderer = enhancedFocusIndicatorRenderer2;
            this.ssList.HorizontalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.ssList.HorizontalScrollBar.Name = "";
            this.ssList.HorizontalScrollBar.Renderer = enhancedScrollBarRenderer3;
            this.ssList.HorizontalScrollBar.TabIndex = 75;
            this.ssList.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.ssList.Location = new System.Drawing.Point(14, 12);
            this.ssList.Name = "ssList";
            this.ssList.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ssList_Sheet1});
            this.ssList.Size = new System.Drawing.Size(845, 396);
            this.ssList.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Office2007;
            this.ssList.TabIndex = 200;
            this.ssList.VerticalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.ssList.VerticalScrollBar.Name = "";
            this.ssList.VerticalScrollBar.Renderer = enhancedScrollBarRenderer4;
            this.ssList.VerticalScrollBar.TabIndex = 76;
            this.ssList.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.ssList.EditModeOff += new System.EventHandler(this.ssList_EditModeOff);
            this.ssList.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.ssList_ButtonClicked);
            ssList_InputMapWhenFocusedNormal.Put(new FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Return, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumn);
            this.ssList.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, ssList_InputMapWhenFocusedNormal);
            this.ssList.SetViewportLeftColumn(0, 0, 4);
            this.ssList.SetActiveViewport(0, 0, -1);
            // 
            // ssList_Sheet1
            // 
            this.ssList_Sheet1.Reset();
            this.ssList_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.ssList_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.ssList_Sheet1.ColumnCount = 11;
            this.ssList_Sheet1.ColumnFooter.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssList_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssList_Sheet1.ColumnFooter.DefaultStyle.Parent = "ColumnFooterEnhanced";
            this.ssList_Sheet1.ColumnFooter.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssList_Sheet1.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssList_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssList_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerEnhanced";
            this.ssList_Sheet1.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "등록번호";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "환자성명";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "주민번호(앞)";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "주민번호(뒤)";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "증번호";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "매칭 등록번호";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "환자성명";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "주민번호(앞)";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "주민번호(뒤)";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "엄마";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 10).Value = "rowid";
            this.ssList_Sheet1.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssList_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssList_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.ssList_Sheet1.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssList_Sheet1.Columns.Get(0).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ssList_Sheet1.Columns.Get(0).CellType = textCellType2;
            this.ssList_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(0).Label = "등록번호";
            this.ssList_Sheet1.Columns.Get(0).Locked = false;
            this.ssList_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(0).Width = 71F;
            this.ssList_Sheet1.Columns.Get(1).CellType = textCellType3;
            this.ssList_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            this.ssList_Sheet1.Columns.Get(1).Label = "환자성명";
            this.ssList_Sheet1.Columns.Get(1).Locked = true;
            this.ssList_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(1).Width = 81F;
            this.ssList_Sheet1.Columns.Get(2).CellType = textCellType4;
            this.ssList_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(2).Label = "주민번호(앞)";
            this.ssList_Sheet1.Columns.Get(2).Locked = true;
            this.ssList_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(2).Width = 84F;
            this.ssList_Sheet1.Columns.Get(3).CellType = textCellType5;
            this.ssList_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(3).Label = "주민번호(뒤)";
            this.ssList_Sheet1.Columns.Get(3).Locked = true;
            this.ssList_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(3).Width = 83F;
            this.ssList_Sheet1.Columns.Get(4).CellType = textCellType6;
            this.ssList_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            this.ssList_Sheet1.Columns.Get(4).Label = "증번호";
            this.ssList_Sheet1.Columns.Get(4).Locked = true;
            this.ssList_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(4).Width = 97F;
            this.ssList_Sheet1.Columns.Get(5).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ssList_Sheet1.Columns.Get(5).CellType = textCellType7;
            this.ssList_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(5).Label = "매칭 등록번호";
            this.ssList_Sheet1.Columns.Get(5).Locked = false;
            this.ssList_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(5).Width = 84F;
            this.ssList_Sheet1.Columns.Get(6).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ssList_Sheet1.Columns.Get(6).CellType = textCellType8;
            this.ssList_Sheet1.Columns.Get(6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            this.ssList_Sheet1.Columns.Get(6).Label = "환자성명";
            this.ssList_Sheet1.Columns.Get(6).Locked = false;
            this.ssList_Sheet1.Columns.Get(6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(6).Width = 77F;
            this.ssList_Sheet1.Columns.Get(7).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ssList_Sheet1.Columns.Get(7).CellType = textCellType9;
            this.ssList_Sheet1.Columns.Get(7).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(7).Label = "주민번호(앞)";
            this.ssList_Sheet1.Columns.Get(7).Locked = false;
            this.ssList_Sheet1.Columns.Get(7).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(7).Width = 76F;
            this.ssList_Sheet1.Columns.Get(8).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ssList_Sheet1.Columns.Get(8).CellType = textCellType10;
            this.ssList_Sheet1.Columns.Get(8).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(8).Label = "주민번호(뒤)";
            this.ssList_Sheet1.Columns.Get(8).Locked = false;
            this.ssList_Sheet1.Columns.Get(8).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(8).Width = 85F;
            buttonCellType1.ButtonColor2 = System.Drawing.SystemColors.ButtonFace;
            buttonCellType1.Text = "찾기";
            this.ssList_Sheet1.Columns.Get(9).CellType = buttonCellType1;
            this.ssList_Sheet1.Columns.Get(9).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(9).Label = "엄마";
            this.ssList_Sheet1.Columns.Get(9).Locked = true;
            this.ssList_Sheet1.Columns.Get(9).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(9).Width = 47F;
            this.ssList_Sheet1.Columns.Get(10).CellType = textCellType11;
            this.ssList_Sheet1.Columns.Get(10).Label = "rowid";
            this.ssList_Sheet1.Columns.Get(10).Locked = true;
            this.ssList_Sheet1.Columns.Get(10).Visible = false;
            this.ssList_Sheet1.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssList_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssList_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarEnhanced";
            this.ssList_Sheet1.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssList_Sheet1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssList_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssList_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderEnhanced";
            this.ssList_Sheet1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssList_Sheet1.FrozenColumnCount = 4;
            this.ssList_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.ssList_Sheet1.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssList_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssList_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.ssList_Sheet1.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssList_Sheet1.SheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.ssList_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssList_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.ssList_Sheet1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.ssList_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlHead.Controls.Add(this.label7);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.ForeColor = System.Drawing.Color.White;
            this.pnlHead.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1195, 30);
            this.pnlHead.TabIndex = 198;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "신생아 등록번호 매칭";
            // 
            // frmPmpaEntryJunior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 491);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHead);
            this.Name = "frmPmpaEntryJunior";
            this.Text = " ";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.grpFind.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ssFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssFind_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssList_Sheet1)).EndInit();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DateTimePicker dtpTDate;
        private System.Windows.Forms.DateTimePicker dtpFDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlBody;
        private FarPoint.Win.Spread.FpSpread ssList;
        private FarPoint.Win.Spread.SheetView ssList_Sheet1;
        private System.Windows.Forms.GroupBox grpFind;
        private System.Windows.Forms.Button btnApply;
        private FarPoint.Win.Spread.FpSpread ssFind;
        private FarPoint.Win.Spread.SheetView ssFind_Sheet1;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label label7;
    }
}