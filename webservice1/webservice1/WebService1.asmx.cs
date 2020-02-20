using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webservice1
{
    [WebService(Namespace = "http://tempuri.org/")]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService1 : System.Web.Services.WebService
    {


        [WebMethod]
        public String DateNow()
        {
            return DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongTimeString();
        }
    }
}
