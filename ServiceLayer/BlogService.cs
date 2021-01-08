using Dapper;
using DataLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class BlogService : IBlogService
    {
        DynamicParameters objDynamicParameters = new DynamicParameters();
        ISqlDBHelper objSqlDBHelper;
        DynamicData objDynamicData = new DynamicData();

        public BlogService(ISqlDBHelper ISqlDBHelper)
        {
            objSqlDBHelper = ISqlDBHelper;
        }
        DynamicData IBlogService.GETAllBolgs(eBlogService boatid)
        {
            objDynamicParameters.Add("SpMode", (int)boatid);
            objDynamicData.data = objSqlDBHelper.GetList<BlogClass>("prcBlog", objDynamicParameters);
            return objDynamicData;
        }

        DynamicData IBlogService.InsertorUpdate(BlogClass BoatData, eBlogService boatid)
        {

            objDynamicParameters.Add("SpMode", (int)boatid);
            objDynamicParameters.Add("@BLOGDATA", BoatData.BLOGDATA);
            objDynamicData.data = objSqlDBHelper.Execute("prcBlog", objDynamicParameters);
            objDynamicData.info.Status = objDynamicParameters.Get<int>("@Outputvalue");
            return objDynamicData;

        }
    }
}
