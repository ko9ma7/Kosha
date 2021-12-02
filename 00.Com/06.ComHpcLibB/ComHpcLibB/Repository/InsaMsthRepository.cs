namespace ComHpcLibB.Repository
{
    using System;
    using System.Collections.Generic;
    using ComBase.Mvc;
    using ComHpcLibB.Dto;


    /// <summary>
    /// 
    /// </summary>
    public class InsaMsthRepository : BaseRepository
    {
        
        /// <summary>
        /// 
        /// </summary>
        public InsaMsthRepository()
        {
        }

        public string GetGunTaebySabunYear(string strSabun, string strYear)
        {
            MParameter parameter = CreateParameter();
            parameter.AppendSql("SELECT GUNTAE                  ");
            parameter.AppendSql("  FROM KOSMOS_ADM.INSA_MSTH    ");
            parameter.AppendSql(" WHERE SABUN = :SABUN          ");
            parameter.AppendSql("   AND YEAR  = :YEAR           ");

            parameter.Add("SABUN", strSabun, Oracle.DataAccess.Client.OracleDbType.Char);
            parameter.Add("YEAR", strYear, Oracle.DataAccess.Client.OracleDbType.Char);

            return ExecuteScalar<string>(parameter);
        }
    }
}
