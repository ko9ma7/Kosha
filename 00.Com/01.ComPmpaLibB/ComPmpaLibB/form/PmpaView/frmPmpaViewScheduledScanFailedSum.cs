﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FarPoint.Win.Spread;
using ComBase; //기본 클래스

namespace ComPmpaLibB
{
    /// <summary>
    /// Class Name      : ComPmpaLibB
    /// File Name       : frmPmpaViewScheduledScanFailedSum.cs
    /// Description     : 예약검사 부도자 마감 집계표
    /// Author          : 안정수
    /// Create Date     : 2017-10-13
    /// Update History  : 
    /// <history>       
    /// d:\psmh\OPD\jepres\Frm예약부도자마감.frm(Frm예약부도자마감) => frmPmpaViewScheduledScanFailedSum.cs 으로 변경함
    /// </history>
    /// <seealso>
    /// d:\psmh\OPD\jepres\Frm예약부도자마감.frm(Frm예약부도자마감)
    /// </seealso>
    /// </summary>
    public partial class frmPmpaViewScheduledScanFailedSum : Form, MainFormMessage
    {
        ComFunc CF = new ComFunc();
        clsSpread CS = new clsSpread();

        string mstrPassId = "";

        #region MainFormMessage InterFace

        public MainFormMessage mCallForm = null;

        public void MsgActivedForm(Form frm)
        {

        }

        public void MsgUnloadForm(Form frm)
        {

        }

        public void MsgFormClear()
        {

        }

        public void MsgSendPara(string strPara)
        {

        }

        #endregion

        public frmPmpaViewScheduledScanFailedSum(MainFormMessage pform)
        {
            InitializeComponent();
            this.mCallForm = pform;
            setEvent();
        }

        public frmPmpaViewScheduledScanFailedSum()
        {
            InitializeComponent();
            setEvent();
        }

        public frmPmpaViewScheduledScanFailedSum(string FstrPassId)
        {
            InitializeComponent();
            setEvent();
            mstrPassId = FstrPassId;
        }

        void setEvent()
        {
            this.Load += new System.EventHandler(eFormLoad);

            this.btnExit.Click += new EventHandler(eBtnEvent);
            this.btnView.Click += new EventHandler(eBtnEvent);
            this.btnPrint.Click += new EventHandler(eBtnEvent);
        }

        void eFormLoad(object sender, EventArgs e)
        {
            if (ComQuery.isFormAuth(clsDB.DbCon, this) == false)
            {
                this.Close(); //폼 권한 조회
                return;
            }
            ComFunc.SetFormInit(clsDB.DbCon, this, "Y", "Y", "Y"); //폼 기본값 세팅 등                    

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        void eBtnEvent(object sender, EventArgs e)
        {
            if (sender == this.btnExit)
            {
                this.Close();
                return;
            }

            else if (sender == this.btnView)
            {
                if (ComQuery.IsJobAuth(this, "R", clsDB.DbCon) == false)
                {
                    return; //권한 확인
                }
                eGetData();
            }

            else if (sender == this.btnPrint)
            {
                if (ComQuery.IsJobAuth(this, "P", clsDB.DbCon) == false)
                {
                    return; //권한 확인
                }
                ePrint();
            }
        }

        void ePrint()
        {
            clsSpread SPR = new clsSpread();
            clsSpread.SpdPrint_Margin setMargin;
            clsSpread.SpdPrint_Option setOption;

            string strTitle = "(" + dtpDate.Text + ") 예약검사 부도자 마감 집계표";
            string strHeader = SPR.setSpdPrint_String(strTitle, new Font("굴림체", 15, FontStyle.Bold), clsSpread.enmSpdHAlign.Center, false, true);
            string strFooter = "";
            bool PrePrint = true;


            #region //시트 히든

            //ssList.ActiveSheet.Columns[(int)clsSupFnExSpd.enmSupFnExMain.Infect].Visible = false;



            #endregion

            setMargin = new clsSpread.SpdPrint_Margin(100, 10, 60, 10, 30, 15);
            setOption = new clsSpread.SpdPrint_Option(PrintOrientation.Portrait, PrintType.All, 0, 0, true, false, true, true, false, false, false);

            SPR.setSpdPrint(ssList, PrePrint, setMargin, setOption, strHeader, strFooter);

            #region //시트 히든 복원

            //ssList.ActiveSheet.Columns[(int)clsSupFnExSpd.enmSupFnExMain.Infect].Visible = true;
            #endregion
        }

        void eGetData()
        {
            int i = 0;

            string strSDate = "";

            long nRamt = 0;
            long nTRamt = 0;
            long nCAmt = 0;
            long nTCamt = 0;

            string strPart = "";
            string strSabun = "";

            int nRow = 0;

            DataTable dt = null;
            string SQL = "";
            string SqlErr = "";

            ssList_Sheet1.Rows.Count = 0;

            CS.Spread_All_Clear(ssList);

            strSDate = dtpDate.Text;

            SQL = "";
            SQL += ComNum.VBLF + "SELECT";
            SQL += ComNum.VBLF + "  CPART PART, CSABUN SABUN,  SUM(CAMT) CSamt, 0 RSAmt ";
            SQL += ComNum.VBLF + "FROM " + ComNum.DB_PMPA + "OPD_REFUND_EXAM";
            SQL += ComNum.VBLF + "WHERE 1=1";
            SQL += ComNum.VBLF + "      AND ACTDATE = TO_DATE('" + strSDate + "','YYYY-MM-DD')";
            SQL += ComNum.VBLF + "GROUP BY CPART, CSABUN";
            SQL += ComNum.VBLF + "UNION ALL";
            SQL += ComNum.VBLF + "SELECT";
            SQL += ComNum.VBLF + "  RPART PART, RSABUN SABUN, 0  CSamt, SUM(RAMT) RSAmt";
            SQL += ComNum.VBLF + "FROM " + ComNum.DB_PMPA + "OPD_REFUND_EXAM";
            SQL += ComNum.VBLF + "WHERE 1=1";
            SQL += ComNum.VBLF + "      AND RDATE >= TO_DATE('" + strSDate + "','YYYY-MM-DD') ";
            SQL += ComNum.VBLF + "      AND RDATE < TO_DATE('" + Convert.ToDateTime(strSDate).AddDays(1).ToShortDateString() + "', 'YYYY-MM-DD') ";
            SQL += ComNum.VBLF + "GROUP BY RPART, RSABUN";
            SQL += ComNum.VBLF + "ORDER BY 1 DESC";

            try
            {
                SqlErr = clsDB.GetDataTable(ref dt, SQL, clsDB.DbCon);

                if (SqlErr != "")
                {
                    ComFunc.MsgBox("조회중 문제가 발생했습니다");
                    clsDB.SaveSqlErrLog(SqlErr, SQL, clsDB.DbCon); //에러로그 저장
                    return;
                }

                if (dt.Rows.Count == 0)
                {
                    dt.Dispose();
                    dt = null;
                    ComFunc.MsgBox("해당 DATA가 없습니다.");
                    return;
                }

                if (dt.Rows.Count > 0)
                {
                    ssList_Sheet1.Rows.Count = dt.Rows.Count;

                    strPart = dt.Rows[0]["PART"].ToString().Trim();
                    strSabun = dt.Rows[0]["SABUN"].ToString().Trim();
                    nTRamt = 0;
                    nTCamt = 0;
                    nRow = 0;
                    nRamt = 0;
                    nCAmt = 0;

                    for (i = 0; i < dt.Rows.Count; i++)
                    {
//                        if (strPart != dt.Rows[i]["PART"].ToString().Trim() && strSabun != dt.Rows[i]["SABUN"].ToString().Trim())
                        if (strPart != dt.Rows[i]["PART"].ToString().Trim())
                        {
                                nRow += 1;

                            ssList_Sheet1.Rows.Count = nRow;

                            ssList_Sheet1.Cells[nRow - 1, 0].Text = strPart;
                            ssList_Sheet1.Cells[nRow - 1, 1].Text = CF.READ_PassName(clsDB.DbCon, strSabun);
                            ssList_Sheet1.Cells[nRow - 1, 2].Text = string.Format("{0:##,###,##0}", nCAmt);
                            ssList_Sheet1.Cells[nRow - 1, 3].Text = string.Format("{0:##,###,##0}", nRamt);
                            ssList_Sheet1.Cells[nRow - 1, 4].Text = string.Format("{0:##,###,##0}", nCAmt - nRamt);
                            ssList_Sheet1.Cells[nRow - 1, 5].Text = " ";
                            nRamt = 0;
                            nCAmt = 0;

                            strPart = dt.Rows[i]["PART"].ToString().Trim();
                            strSabun = dt.Rows[i]["SABUN"].ToString().Trim();
                        }

                        nCAmt += Convert.ToInt64(VB.Val(dt.Rows[i]["CSAMT"].ToString().Trim()));
                        nTCamt += Convert.ToInt64(VB.Val(dt.Rows[i]["CSAMT"].ToString().Trim()));
                        nRamt += Convert.ToInt64(VB.Val(dt.Rows[i]["RSAMT"].ToString().Trim()));
                        nTRamt += Convert.ToInt64(VB.Val(dt.Rows[i]["RSAMT"].ToString().Trim()));
                    }

                }
            }
            catch (Exception ex)
            {
                ComFunc.MsgBox(ex.Message);
                clsDB.SaveSqlErrLog(ex.Message, SQL, clsDB.DbCon); //에러로그 저장
            }
            dt.Dispose();
            dt = null;

            nRow += 1;

            ssList_Sheet1.Rows.Count = nRow;

            ssList_Sheet1.Cells[nRow - 1, 0].Text = strPart;
            ssList_Sheet1.Cells[nRow - 1, 1].Text = CF.READ_PassName(clsDB.DbCon, strSabun);
            ssList_Sheet1.Cells[nRow - 1, 2].Text = string.Format("{0:##,###,##0}", nCAmt);
            ssList_Sheet1.Cells[nRow - 1, 3].Text = string.Format("{0:##,###,##0}", nRamt);
            ssList_Sheet1.Cells[nRow - 1, 4].Text = string.Format("{0:##,###,##0}", nCAmt - nRamt);
            ssList_Sheet1.Cells[nRow - 1, 5].Text = " ";

            nRow += 1;

            ssList_Sheet1.Rows.Count = nRow;
            ssList_Sheet1.Cells[nRow - 1, 1].Text = "합  계";
            ssList_Sheet1.Cells[nRow - 1, 2].Text = string.Format("{0:##,###,##0}", nTCamt);
            ssList_Sheet1.Cells[nRow - 1, 3].Text = string.Format("{0:##,###,##0}", nTRamt);
            ssList_Sheet1.Cells[nRow - 1, 4].Text = string.Format("{0:##,###,##0}", nTCamt - nTRamt);
            ssList_Sheet1.Cells[nRow - 1, 5].Text = " ";
        }

        private void ssList_PrintHeaderFooterArea(object sender, PrintHeaderFooterAreaEventArgs e)
        {
            Pen cPen = new Pen(Color.Black);
            cPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            cPen.Width = 3;
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Far;

            if (e.IsHeader == true)
            {
                #region 칸 그리기
                e.Graphics.DrawRectangle(new Pen(Brushes.Black, 1), 550, 90, 220, 70);
                e.Graphics.DrawRectangle(new Pen(Brushes.Black, 1), 550, 90, 30, 70);
                e.Graphics.DrawRectangle(new Pen(Brushes.Black, 1), 580, 115, 190, 45);
                e.Graphics.DrawRectangle(new Pen(Brushes.Black, 1), 640, 90, 65, 70);



                #endregion

                #region 칸안에 글
                e.Graphics.DrawString("결", new Font("맑은 고딕", 11, FontStyle.Regular), Brushes.Black, 575, 93, drawFormat);
                e.Graphics.DrawString("재", new Font("맑은 고딕", 11, FontStyle.Regular), Brushes.Black, 575, 135, drawFormat);
                e.Graphics.DrawString("담  당", new Font("맑은 고딕", 11, FontStyle.Regular), Brushes.Black, 637, 93, drawFormat);
                e.Graphics.DrawString("계  장", new Font("맑은 고딕", 11, FontStyle.Regular), Brushes.Black, 700, 93, drawFormat);
                e.Graphics.DrawString("팀  장", new Font("맑은 고딕", 11, FontStyle.Regular), Brushes.Black, 760, 93, drawFormat);
                #endregion


             
                #region 작성자 
                drawFormat.Alignment = StringAlignment.Far;
                e.Graphics.DrawString("작성자 : " + clsType.User.UserName, new Font("맑은 고딕", 11, FontStyle.Regular), Brushes.Black, 185, 103, drawFormat);
                e.Graphics.DrawString("출력시간 : " + DateTime.Now.ToString("yyyy-MM-dd HH:mm"), new Font("맑은 고딕", 11, FontStyle.Regular), Brushes.Black, 275, 123, drawFormat);
                e.Graphics.DrawString("Page : " + e.PageNumber, new Font("맑은 고딕", 11, FontStyle.Regular), Brushes.Black, 135, 143, drawFormat);
                #endregion
            }
        }
    }
}
