namespace HC.Core.BaseCode.Management.Repository
{
    using System.Collections.Generic;
    using ComBase.Mvc;
    using HC.Core.BaseCode.Management.Dto;
    using PSMH.MVC.Sample.Dto;


    /// <summary>
    /// 
    /// </summary>
    public class HcViewUserRepository : BaseRepository
    {
        
        /// <summary>
        /// 
        /// </summary>
        public HcViewUserRepository()
        {
        }
        public List<HC_VIEW_USER> FindAll()
        {
            MParameter parameter = CreateParameter();
            parameter.AppendSql("SELECT * FROM HC_VIEW_USER ORDER BY NAME");
            
            return ExecuteReader<HC_VIEW_USER>(parameter);
        }
    }
}
