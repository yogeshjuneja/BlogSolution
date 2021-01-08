using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
    public class BlogClass
    {

        public int BLOGID { get; set; }
        public string BLOGDATA { get; set; }


    }
}
public enum eBlogService
{
    Insert = 1,
    Update,
    Delete,
    Select
}