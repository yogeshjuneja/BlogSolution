using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public interface IBlogService
    {
        DynamicData InsertorUpdate(BlogClass BoatData, eBlogService boatid);
        DynamicData GETAllBolgs( eBlogService boatid);
    }
         
}
