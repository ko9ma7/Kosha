﻿using ComBase.Controls;
using ComBase.Mvc;
using ComBase.Mvc.Utils;
using HC.Core.Service;
using HC.OSHA.Dto;
using HC.OSHA.Dto.StatusReport;
using HC.OSHA.Model;
using HC_Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.OSHA.Repository.StatusReport
{
    public class StatusReportMemoRepository : BaseRepository
    {
        public HIC_OSHA_MEMO FindOne(long siteId)
        {
            MParameter parameter = CreateParameter();
            parameter.AppendSql("SELECT * FROM HIC_OSHA_MEMO    ");
            parameter.AppendSql("WHERE SITEID = :ID");
            parameter.Add("ID", siteId);
            
            return ExecuteReaderSingle<HIC_OSHA_MEMO>(parameter);
        }

        public HIC_OSHA_MEMO Insert(HIC_OSHA_MEMO dto)
        {
            MParameter parameter = CreateParameter();
            parameter.AppendSql("INSERT INTO HIC_OSHA_MEMO    ");
            parameter.AppendSql("(SITEID, MEMO) ");
            parameter.AppendSql("VALUES( :SITEID , :MEMO ) ");

            parameter.Add("SITEID", dto.SITEID);
            parameter.Add("MEMO", dto.MEMO);

            ExecuteNonQuery(parameter);

            DataSyncService.Instance.Insert("HIC_OSHA_MEMO", dto.SITEID);
            return FindOne(dto.SITEID);

        }
        public void Update(HIC_OSHA_MEMO dto)
        {
            MParameter parameter = CreateParameter();
            parameter.AppendSql("UPDATE HIC_OSHA_MEMO    ");
            parameter.AppendSql("  SET    MEMO = :MEMO     ");
            parameter.AppendSql("  WHERE SITEID = :SITEID     ");

            parameter.Add("SITEID", dto.SITEID);
            parameter.Add("MEMO", dto.MEMO);

            ExecuteNonQuery(parameter);

            DataSyncService.Instance.Update("HIC_OSHA_MEMO", dto.SITEID);

        }
    }
}
