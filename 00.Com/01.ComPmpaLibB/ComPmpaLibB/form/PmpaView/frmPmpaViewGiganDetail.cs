﻿using System;
using System.Data;
using System.Windows.Forms;
using ComDbB; //DB연결
using ComBase; //기본 클래스

namespace ComPmpaLibB
{
    /// <summary>
    /// Class Name      : ComPmpaLibB
    /// File Name       : frmPmpaViewGiganDetail.cs
    /// Description     : 미수금상세내역
    /// Author          : 박창욱
    /// Create Date     : 2017-11-06
    /// Update History  : 
    /// </summary>
    /// <history>  
    /// 2017-11-06 박창욱 : FrmIpgemGiganDetail, FrmIpgemGiganDetail2, FrmIpgemGiganDetail3 통합
    /// </history>
    /// <seealso cref= "\misu\misubs\misubs88.frm(FrmIpgemGiganDetail3.frm) >> frmPmpaViewGiganDetail.cs 폼이름 재정의" />
    /// <seealso cref= "\misu\misubs\misubs87.frm(FrmIpgemGiganDetail2.frm) >> frmPmpaViewGiganDetail.cs 폼이름 재정의" />
    /// <seealso cref= "\misu\misubs\misubs86.frm(FrmIpgemGiganDetail.frm) >> frmPmpaViewGiganDetail.cs 폼이름 재정의" />
    public partial class frmPmpaViewGiganDetail : Form
    {
        ComFunc cf = new ComFunc();

        string GstrSQL = "";
        string GstrRet = "";

        public frmPmpaViewGiganDetail()
        {
            InitializeComponent();
        }

        public frmPmpaViewGiganDetail(string strSQL, string strRet)
        {
            InitializeComponent();

            GstrSQL = strSQL;
            GstrRet = strRet;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPmpaViewGiganDetail_Load(object sender, EventArgs e)
        {
            //if (ComQuery.isFormAuth(clsDB.DbCon, this) == false)
            //{
            //    this.Close(); //폼 권한 조회
            //    return;
            //}
            //ComFunc.SetFormInit(clsDB.DbCon, this, "Y", "Y", "Y"); //폼 기본값 세팅 등


            //테스트용
            //GstrSQL = GstrSQL + ComNum.VBLF + "SELECT  B.WRTNO, B.MISUID,a.Class,a.ipdopd,a.GelCode,TO_CHAR(b.Bdate,'YYYY-MM-DD') Bdate,";
            //GstrSQL = GstrSQL + ComNum.VBLF + "       b.deptcode,a.ipgumamt,b.amt3,a.yymm,a.iwolamt,a.misuamt,a.sakamt,a.etcamt,  ";
            //GstrSQL = GstrSQL + ComNum.VBLF + "       a.janamt,a.banamt,b.remark ";
            //GstrSQL = GstrSQL + ComNum.VBLF + " FROM MISU_MONTHLY a,MISU_IDMST b  ";
            //GstrSQL = GstrSQL + ComNum.VBLF + " WHERE a.YYMM >='" + "201704" + "' ";
            //GstrSQL = GstrSQL + ComNum.VBLF + "   and a.YYMM <='" + "201704" + "' ";
            //GstrSQL = GstrSQL + ComNum.VBLF + "   and a.IPGUMAMT <> 0 ";
            //GstrSQL = GstrSQL + ComNum.VBLF + "   AND a.WRTNO=b.WRTNO(+) ";
            //GstrSQL = GstrSQL + ComNum.VBLF + " AND a.Class = '07' ";   //자보
            //GstrSQL = GstrSQL + ComNum.VBLF + "ORDER BY a.wrtno,b.BDate ";
            //GstrRet = "3";


            int i = 0;
            DataTable dt = null;
            DataTable dt1 = null;
            string SQL = "";    //Query문
            string SqlErr = ""; //에러문 받는 변수

            int k = 0;
            int nRead = 0;
            int nRow = 0;
            double[] nTot = new double[9];
            string strFD = "";
            string strTD = "";

            for (i = 0; i < 9; i++)
            {
                nTot[i] = 0;
            }

            nRow = 1;

            try
            {
                if (GstrSQL != "")
                {
                    SqlErr = clsDB.GetDataTable(ref dt, GstrSQL, clsDB.DbCon);

                    if (SqlErr != "")
                    {
                        clsDB.SaveSqlErrLog(SqlErr, GstrSQL, clsDB.DbCon); //에러로그 저장
                        ComFunc.MsgBox("조회중 문제가 발생했습니다");
                        return;
                    }
                    if (dt.Rows.Count == 0)
                    {
                        dt.Dispose();
                        dt = null;
                        ComFunc.MsgBox("해당 DATA가 없습니다.");
                        return;
                    }

                    nRead = dt.Rows.Count;
                    ssView_Sheet1.RowCount = nRead + 10;

                    for (i = 0; i < nRead; i++)
                    {
                        strTD = cf.READ_LASTDAY(clsDB.DbCon, VB.Left(dt.Rows[i]["YYMM"].ToString().Trim(), 4) + "-" +
                                                             VB.Right(dt.Rows[i]["YYMM"].ToString().Trim(), 2) + "-" + "01");
                        nRow += 1;
                        ssView_Sheet1.Cells[nRow - 1, 0].Text = dt.Rows[i]["WRTNO"].ToString().Trim();
                        ssView_Sheet1.Cells[nRow - 1, 1].Text = dt.Rows[i]["MISUID"].ToString().Trim();
                        ssView_Sheet1.Cells[nRow - 1, 1 + 1].Text = dt.Rows[i]["CLASS"].ToString().Trim();
                        ssView_Sheet1.Cells[nRow - 1, 2 + 1].Text = dt.Rows[i]["BDATE"].ToString().Trim();

                        //미수종료일 조회
                        if (dt.Rows[i]["CLASS"].ToString().Trim() == "")
                        {
                            SQL = "";
                            SQL = SQL + ComNum.VBLF + "SELECT TO_CHAR(MAX(BDATE),'YYYY-MM-DD') bdate";
                            SQL = SQL + ComNum.VBLF + "  FROM " + ComNum.DB_PMPA + "HIC_MISU_SLIP ";
                            SQL = SQL + ComNum.VBLF + " WHERE 1 = 1";
                            SQL = SQL + ComNum.VBLF + "   AND WRTNO = " + dt.Rows[i]["WRTNO"].ToString().Trim();
                            if (dt.Rows[i]["BDATE"].ToString().Trim() != "")
                            {
                                SQL = SQL + ComNum.VBLF + "   AND to_char(bdate,'yyyy-mm-dd') >= '" + dt.Rows[i]["BDATE"].ToString().Trim() + "' ";
                            }
                            else
                            {
                                SQL = SQL + ComNum.VBLF + "   AND TO_CHAR(BDate,'YYYY-MM-DD') >= '" + strFD + "' ";
                                SQL = SQL + ComNum.VBLF + "   AND TO_CHAR(BDate,'YYYY-MM-DD') <= '" + strTD + "' ";
                            }
                            SQL = SQL + ComNum.VBLF + "    AND ( GEACODE LIKE '2%' or GEACODE ='55')    "; //카드입금추가

                            SqlErr = clsDB.GetDataTable(ref dt1, SQL, clsDB.DbCon);

                            if (SqlErr != "")
                            {
                                clsDB.SaveSqlErrLog(SqlErr, SQL, clsDB.DbCon); //에러로그 저장
                                ComFunc.MsgBox("조회중 문제가 발생했습니다");
                                return;
                            }
                            if (dt1.Rows.Count > 0)
                            {
                                strTD = dt1.Rows[0]["BDATE"].ToString().Trim();
                            }
                            dt1.Dispose();
                            dt1 = null;
                        }
                        else
                        {
                            SQL = "";
                            SQL = SQL + ComNum.VBLF + "SELECT TO_CHAR(MAX(BDATE),'YYYY-MM-DD') bdate";
                            SQL = SQL + ComNum.VBLF + "  FROM " + ComNum.DB_PMPA + "MISU_SLIP ";
                            SQL = SQL + ComNum.VBLF + " WHERE 1 = 1";
                            SQL = SQL + ComNum.VBLF + "   AND WRTNO = " + dt.Rows[i]["WRTNO"].ToString().Trim();
                            SQL = SQL + ComNum.VBLF + "   AND to_char(bdate,'yyyy-mm-dd') >= '" + dt.Rows[i]["BDATE"].ToString().Trim() + "' ";
                            SQL = SQL + ComNum.VBLF + "   AND to_char(bdate,'yyyy-mm-dd') <= '" + strTD + "' ";
                            SQL = SQL + ComNum.VBLF + "   AND GUBUN LIKE '2%'";
                            SqlErr = clsDB.GetDataTable(ref dt1, SQL, clsDB.DbCon);

                            if (SqlErr != "")
                            {
                                clsDB.SaveSqlErrLog(SqlErr, SQL, clsDB.DbCon); //에러로그 저장
                                ComFunc.MsgBox("조회중 문제가 발생했습니다");
                                return;
                            }
                            if (dt1.Rows.Count > 0)
                            {
                                strTD = dt1.Rows[0]["BDATE"].ToString().Trim();
                            }
                            dt1.Dispose();
                            dt1 = null;
                        }
                        ssView_Sheet1.Cells[nRow - 1, 3 + 1].Text = strTD;
                        ssView_Sheet1.Cells[nRow - 1, 4 + 1].Text = VB.DateDiff("D", Convert.ToDateTime(dt.Rows[i]["BDATE"].ToString().Trim()),
                                                                                 Convert.ToDateTime(strTD)).ToString();
                        nTot[8] += (VB.Val(ssView_Sheet1.Cells[nRow - 1, 4 + 1].Text) * VB.Val(dt.Rows[i]["Ipgumamt"].ToString().Trim()));
                        if (GstrRet != "6" && GstrRet != "7")
                        {
                            if (dt.Rows[i]["IpdOpd"].ToString().Trim() == "I")
                            {
                                ssView_Sheet1.Cells[nRow - 1, 5 + 1].Text = "입원";
                            }
                            if (dt.Rows[i]["IpdOpd"].ToString().Trim() == "O")
                            {
                                ssView_Sheet1.Cells[nRow - 1, 5 + 1].Text = "외래";
                            }
                        }
                        ssView_Sheet1.Cells[nRow - 1, 6 + 1].Text = VB.Val(dt.Rows[i]["IwolAmt"].ToString().Trim()).ToString("###,###,###,##0");
                        nTot[1] += VB.Val(dt.Rows[i]["IwolAmt"].ToString().Trim());
                        ssView_Sheet1.Cells[nRow - 1, 7 + 1].Text = VB.Val(dt.Rows[i]["misuamt"].ToString().Trim()).ToString("###,###,###,##0");
                        nTot[2] += VB.Val(dt.Rows[i]["misuamt"].ToString().Trim());
                        ssView_Sheet1.Cells[nRow - 1, 8 + 1].Text = VB.Val(dt.Rows[i]["ipgumamt"].ToString().Trim()).ToString("###,###,###,##0");
                        nTot[3] += VB.Val(dt.Rows[i]["ipgumamt"].ToString().Trim());
                        ssView_Sheet1.Cells[nRow - 1, 9 + 1].Text = VB.Val(dt.Rows[i]["sakamt"].ToString().Trim()).ToString("###,###,###,##0");
                        nTot[4] += VB.Val(dt.Rows[i]["sakamt"].ToString().Trim());
                        if (GstrRet != "6" && GstrRet != "7")
                        {
                            ssView_Sheet1.Cells[nRow - 1, 10 + 1].Text = VB.Val(dt.Rows[i]["EtcAmt"].ToString().Trim()).ToString("###,###,###,##0");
                            nTot[5] += VB.Val(dt.Rows[i]["EtcAmt"].ToString().Trim());
                        }
                        ssView_Sheet1.Cells[nRow - 1, 11 + 1].Text = VB.Val(dt.Rows[i]["janamt"].ToString().Trim()).ToString("###,###,###,##0");
                        nTot[6] += VB.Val(dt.Rows[i]["janamt"].ToString().Trim());
                        ssView_Sheet1.Cells[nRow - 1, 12 + 1].Text = VB.Val(dt.Rows[i]["banamt"].ToString().Trim()).ToString("###,###,###,##0");
                        nTot[7] += VB.Val(dt.Rows[i]["banamt"].ToString().Trim());
                        if (GstrRet != "6" && GstrRet != "7")
                        {
                            ssView_Sheet1.Cells[nRow - 1, 13 + 1].Text = dt.Rows[i]["Remark"].ToString().Trim();
                        }
                    }
                    dt.Dispose();
                    dt = null;
                }
                GstrSQL = "";
                //합계 표시
                ssView_Sheet1.Cells[0, 0].Text = "합계";
                ssView_Sheet1.Cells[0, 4 + 1].Text = ((int)(nTot[8] / nTot[3])).ToString("###,###,###,##0");
                ssView_Sheet1.Cells[0, 6 + 1].Text = nTot[1].ToString("###,###,###,##0");
                ssView_Sheet1.Cells[0, 7 + 1].Text = nTot[2].ToString("###,###,###,##0");
                ssView_Sheet1.Cells[0, 8 + 1].Text = nTot[3].ToString("###,###,###,##0");
                ssView_Sheet1.Cells[0, 9 + 1].Text = nTot[4].ToString("###,###,###,##0");
                ssView_Sheet1.Cells[0, 10 + 1].Text = nTot[5].ToString("###,###,###,##0");
                ssView_Sheet1.Cells[0, 11 + 1].Text = nTot[6].ToString("###,###,###,##0");
                ssView_Sheet1.Cells[0, 12 + 1].Text = nTot[7].ToString("###,###,###,##0");

                ssView_Sheet1.RowCount = nRow;
                ssView_Sheet1.SetRowHeight(-1, ComNum.SPDROWHT);

            }
            catch (Exception ex)
            {
                clsDB.SaveSqlErrLog(ex.Message, SQL, clsDB.DbCon); //에러로그 저장
                ComFunc.MsgBox(ex.Message);
            }
        }
    }
}
