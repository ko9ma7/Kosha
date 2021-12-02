﻿using ComBase.Controls;
using ComBase.Mvc.Enums;
using ComBase.Mvc.Spread;
using ComBase.Mvc.Utils;
using ComHpcLibB.Model;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using HC.Core.Common.Interface;
using HC.Core.Common.Util;
using HC.Core.Model;
using HC.OSHA.Model;
using HC.OSHA.Service;
using HC_Core;
using System;
using System.Collections.Generic;

namespace HC_OSHA
{
    /// <summary>
    /// 화확물질 현황
    /// </summary>
    public partial class SiteMSDSListForm : CommonForm, ISelectSite, ISelectEstimate
    {
        private HcSiteMsdsModelService hcSiteMsdsModelService;
        private List<HC_SITE_MSDS_MODEL> msdsList = null;
        public SiteMSDSListForm()
        {
            InitializeComponent();
            hcSiteMsdsModelService = new HcSiteMsdsModelService();

            SSMSDSList.Initialize(new SpreadOption() { IsRowSelectColor = false });
            SSMSDSList.AddColumnCheckBox("", "", 30, new CheckBoxBooleanCellType { IsHeaderCheckBox = false});
            SSMSDSList.AddColumnText("취급공정", nameof(HC_SITE_MSDS_MODEL.PROCESS), 63, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false, mergePolicy = MergePolicy.Always });
            SSMSDSList.AddColumnText("제품명", nameof(HC_SITE_MSDS_MODEL.PRODUCTNAME), 100, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false, mergePolicy = MergePolicy.Always });
            SSMSDSList.AddColumnText("권고용도", nameof(HC_SITE_MSDS_MODEL.USAGE), 80, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false, mergePolicy = MergePolicy.Always });
            SSMSDSList.AddColumnText("제조사", nameof(HC_SITE_MSDS_MODEL.MANUFACTURER), 100, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false, mergePolicy = MergePolicy.Always });
            SSMSDSList.AddColumnText("월취급량", nameof(HC_SITE_MSDS_MODEL.MONTHLYAMOUNT), 67, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false, mergePolicy = MergePolicy.Always });
            SSMSDSList.AddColumnText("단위", nameof(HC_SITE_MSDS_MODEL.UNIT), 34, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false, mergePolicy = MergePolicy.Always });
            SSMSDSList.AddColumnText("개정일자", nameof(HC_SITE_MSDS_MODEL.REVISIONDATE), 80, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false, mergePolicy = MergePolicy.Always });
            SSMSDSList.AddColumnImage("그림문자", nameof(HC_SITE_MSDS_MODEL.GHS_IMAGE), 100,  new SpreadCellTypeOption { IsSort = false });
            

            SSMSDSList.AddColumnText("물질명", nameof(HC_SITE_MSDS_MODEL.NAME), 100, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false });
            SSMSDSList.AddColumnText("CasNo", nameof(HC_SITE_MSDS_MODEL.CASNO), 90, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false });
            SSMSDSList.AddColumnText("함유량", nameof(HC_SITE_MSDS_MODEL.QTY), 50, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false });
            SSMSDSList.AddColumnText("노출기준설정", nameof(HC_SITE_MSDS_MODEL.EXPOSURE_MATERIAL), 34, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false });
            SSMSDSList.AddColumnText("작업환경측정", nameof(HC_SITE_MSDS_MODEL.WEM_MATERIAL), 34, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false });
            SSMSDSList.AddColumnText("특수건강진단", nameof(HC_SITE_MSDS_MODEL.SPECIALHEALTH_MATERIAL), 34, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false });
            SSMSDSList.AddColumnText("관리대상유해", nameof(HC_SITE_MSDS_MODEL.MANAGETARGET_MATERIAL), 34, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false });
            SSMSDSList.AddColumnText("특별관리", nameof(HC_SITE_MSDS_MODEL.SPECIALMANAGE_MATERIAL), 34, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false });
            SSMSDSList.AddColumnText("허용기준설정", nameof(HC_SITE_MSDS_MODEL.STANDARD_MATERIAL), 34, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false });
            SSMSDSList.AddColumnText("허가대상유해", nameof(HC_SITE_MSDS_MODEL.PERMISSION_MATERIAL), 34, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false });
            SSMSDSList.AddColumnText("PSM제출대상", nameof(HC_SITE_MSDS_MODEL.PSM_MATERIAL), 34, IsReadOnly.Y, new SpreadCellTypeOption { IsSort = false });

            SSMSDSList.Column(0).Visible = false;
        }
    
        public void ShowSiteCardButton() {
            BtnMange.Visible = false;
            BtnPrint.Visible = false;
            BtnApply.Visible = true;
            SSMSDSList.Column(0).Visible = true;
        }
        public void Search()
        {
            //aaa
            //bbbb
            SSMSDSList.ActiveSheet.RowCount = 0;
            if (base.SelectedSite == null)
            {
                //MessageUtil.Info("견적 및 계약 정보가 없습니다");
                SSMSDSList.SetDataSource(null);
            }
            else
            {
                List<HC_SITE_MSDS_MODEL> list = hcSiteMsdsModelService.FindAll(base.SelectedSite.ID);
                SSMSDSList.SetDataSource(list);


                //imagecelltype은 자동머지가 안됨(MergePolicy) 수동으로 머지함.
                List<GHSRowSpan> rowSpanList = new List<GHSRowSpan>();
                for (int i = 0; i < SSMSDSList.ActiveSheet.RowCount; i++)
                {
                    if (i == 0)
                    {
                        GHSRowSpan rowSpan = new GHSRowSpan()
                        {
                            ProductName = SSMSDSList.ActiveSheet.Cells[i, 1].Value.ToString(),
                            RowIndex = i,
                            RowSpan = 1
                        };

                        rowSpanList.Add(rowSpan);
                    }
                    else
                    {
                        bool isNewRow = true;
                        string productName = SSMSDSList.ActiveSheet.Cells[i, 1].Value.ToString();
                        foreach (GHSRowSpan rowSpan in rowSpanList)
                        {
                            if (rowSpan.ProductName.Equals(productName))
                            {
                                rowSpan.RowSpan += 1;
                                isNewRow = false;
                            }
                        }
                        if (isNewRow)
                        {
                            GHSRowSpan rowSpan = new GHSRowSpan()
                            {
                                ProductName = SSMSDSList.ActiveSheet.Cells[i, 1].Value.ToString(),
                                RowIndex = i,
                                RowSpan = 1
                            };

                            rowSpanList.Add(rowSpan);
                        }
                    }

                    foreach (GHSRowSpan rowSpan in rowSpanList)
                    {
                        SSMSDSList.ActiveSheet.Cells[rowSpan.RowIndex, 0].RowSpan = rowSpan.RowSpan;
                       
                    }

                    SSMSDSList.ActiveSheet.Rows[i].Height = SSMSDSList.ActiveSheet.Rows[i].GetPreferredHeight();
                }
                
                for (int i = 0; i < SSMSDSList.ActiveSheet.RowCount; i++)
                {
                    SSMSDSList.ActiveSheet.Rows[i].Height = SSMSDSList.ActiveSheet.Rows[i].GetPreferredHeight();
                }
            }
         
        }
        private void BtnMange_Click(object sender, EventArgs e)
        {
            if(base.SelectedSite.ID<=0)
            {
                MessageUtil.Alert("사업장을 선택하세요");
                return;
            }
            SiteMSDSForm form = new SiteMSDSForm();
            form.SelectedSite = base.SelectedSite;
            form.SelectedEstimate = base.SelectedEstimate;
            form.SiteMSDSListForm = this;
            form.Show();
            
            Search();

        }

        void ISelectEstimate.Select(IEstimateModel estimateModel)
        {
            base.SelectedEstimate = estimateModel;
            Search();
          
        }

        void ISelectSite.Select(ISiteModel siteModel)
        {
            base.SelectedSite = siteModel;
            LblSite.Text = base.SelectedSite.NAME;

            Search();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            SpreadPrint print = new SpreadPrint(SSMSDSList, PrintStyle.FORM, false);
            print.Title = base.SelectedSite.NAME + " 화학물질 MSDS 목록 현황";
            print.orientation = PrintOrientation.Landscape;
            print.Execute();
        }

        public List<HC_SITE_MSDS_MODEL> GetSelectedMsds()
        {
            return msdsList;
        }
        private void BtnApply_Click(object sender, EventArgs e)
        {
            msdsList = new List<HC_SITE_MSDS_MODEL>();

            for (int i = 0; i < SSMSDSList.ActiveSheet.RowCount; i++)
            {
                if (Convert.ToBoolean(SSMSDSList.ActiveSheet.Cells[i, 0].Value))
                {
                    HC_SITE_MSDS_MODEL model = SSMSDSList.GetRowData(i) as HC_SITE_MSDS_MODEL;
                    msdsList.Add(model);
                }
            }
            this.Close();
         
        }
    }

    public class GHSRowSpan
    {
        public string ProductName { get; set; }
        public int RowIndex { get; set; }
        public int RowSpan { get; set; }

    }
}
